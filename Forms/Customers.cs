﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pharmacy.Forms
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        string connstring = "server=localhost;user id=root;Password = root;database=pharmacy";


        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            Phone2.Visible = false;

            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();
            string strCmd = "select Insurance_ID from Insurance";
            MySqlCommand cd = new MySqlCommand(strCmd, con);
            MySqlDataAdapter da = new MySqlDataAdapter(strCmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            insurance.DataSource = ds.Tables[0];
            insurance.ValueMember = "Insurance_ID";
            insurance.Enabled = true;
            this.insurance.SelectedIndex = -1;
            cd.ExecuteNonQuery();
            con.Close();






            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "select cname, gender, address, Insurance_ID, group_concat(phone SEPARATOR '-') " +
                "phone from customer left join phone on customer.cid = phone.cid group by customer.cid; ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rd;
            rd = cmd.ExecuteReader();
            listView2.Items.Clear();
            while (rd.Read())
            {
                ListViewItem lv = new ListViewItem(rd.GetString(0).ToString());
                lv.SubItems.Add(rd.GetString(1).ToString());
                lv.SubItems.Add(rd.GetString(2).ToString());
                lv.SubItems.Add(rd.GetInt32(3).ToString());
                lv.SubItems.Add(rd.GetString(4).ToString());
                listView2.Items.Add(lv);
            }
            rd.Close();
            cmd.Dispose();
            conn.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connstring);
            if (textBox8.Text != "")
            {
                listView2.Items.Clear();
                con.Open();
                string str = "select cname, gender, address, Insurance_ID, group_concat(phone SEPARATOR '-') " +
                    "phone from customer left join phone on customer.cid = phone.cid group by customer.cid having cname Like'%" + textBox8.Text + "%' or gender Like'%" + textBox8.Text + "%' or address Like'%" + textBox8.Text + "%'" +
                    "or Insurance_ID Like'%" + textBox8.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(str, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ListViewItem lv = new ListViewItem(rd.GetString(0).ToString());
                    lv.SubItems.Add(rd.GetString(1).ToString());
                    lv.SubItems.Add(rd.GetString(2).ToString());
                    lv.SubItems.Add(rd.GetInt32(3).ToString());
                    lv.SubItems.Add(rd.GetString(4).ToString());
                    listView2.Items.Add(lv);
                }
                rd.Close();
                con.Close();
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(connstring);
                conn.Open();
                string sql = "select cname, gender, address, Insurance_ID, group_concat(phone SEPARATOR '-') " +
                    "phone from customer left join phone on customer.cid = phone.cid group by customer.cid; ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rd;
                rd = cmd.ExecuteReader();
                listView2.Items.Clear();
                while (rd.Read())
                {
                    ListViewItem lv = new ListViewItem(rd.GetString(0).ToString());
                    lv.SubItems.Add(rd.GetString(1).ToString());
                    lv.SubItems.Add(rd.GetString(2).ToString());
                    lv.SubItems.Add(rd.GetInt32(3).ToString());
                    lv.SubItems.Add(rd.GetString(4).ToString());
                    listView2.Items.Add(lv);
                }
                rd.Close();
                cmd.Dispose();
                conn.Close();
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            var cashierId = listView2.FocusedItem.Text;
            var item = listView2.SelectedItems[0];
            string query = "delete from customer where CID = (select cid where cname = @name);";
            using (MySqlConnection sqlcon = new MySqlConnection(connstring))
            {
                try
                {
                    sqlcon.Open();
                    using (MySqlTransaction trans = sqlcon.BeginTransaction())
                    {

                        using (MySqlCommand com = new MySqlCommand(query, sqlcon, trans))
                        {

                            com.Parameters.AddWithValue("@name", cashierId);

                            var should_be_one = com.ExecuteNonQuery();

                            if (should_be_one ==1)
                            {

                                trans.Commit();
                                foreach (ListViewItem itemm in listView2.Items)
                                    if (itemm.Selected)
                                        listView2.Items.Remove(item);
                            }
                            else
                            {

                                trans.Rollback();

                                throw new Exception("An attempt to delete multiple rows was detected");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlcon.Close();
                }
            }


        }

        private void LoadCustomerData()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "SELECT cname, gender, address, Insurance_ID, GROUP_CONCAT(phone SEPARATOR '-') AS phone " +
                         "FROM customer LEFT JOIN phone ON customer.cid = phone.cid GROUP BY customer.cid; ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rd;
            rd = cmd.ExecuteReader();
            listView2.Items.Clear();
            while (rd.Read())
            {
                ListViewItem lv = new ListViewItem(rd.GetString(0).ToString());
                lv.SubItems.Add(rd.GetString(1).ToString());
                lv.SubItems.Add(rd.GetString(2).ToString());
                lv.SubItems.Add(rd.GetInt32(3).ToString());
                lv.SubItems.Add(rd.GetString(4).ToString());
                listView2.Items.Add(lv);
            }
            rd.Close();
            cmd.Dispose();
            conn.Close();
        }

        private bool CustomerExists(string customerName)
        {
            using (MySqlConnection conn = new MySqlConnection(connstring))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM customer WHERE CName = @cname";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cname", customerName);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(gender.Text) ||
                string.IsNullOrEmpty(address.Text) || insurance.SelectedValue == null ||
                string.IsNullOrEmpty(Phone1.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return; // Stop execution if any field is missing
            }

            // Check if the customer already exists
            if (CustomerExists(name.Text))
            {
                MessageBox.Show("Customer already exists!");
                return;
            }

            using (MySqlConnection sqlcon = new MySqlConnection(connstring))
            {
                string insert = "insert into customer (CName, Gender, Address, Insurance_ID) values (@cname, @gender," +
                    "@address, @insurance); Insert into Phone Values(@phone, (select cid from customer where cname = @cname)); ";
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(insert, sqlcon);
                cmd.Parameters.Add("@cname", MySqlDbType.VarChar);
                cmd.Parameters["@cname"].Value = name.Text;

                cmd.Parameters.Add("@gender", MySqlDbType.VarChar);
                cmd.Parameters["@gender"].Value = gender.Text;

                cmd.Parameters.Add("@address", MySqlDbType.VarChar);
                cmd.Parameters["@address"].Value = address.Text;

                cmd.Parameters.Add("@insurance", MySqlDbType.Int32);
                cmd.Parameters["@insurance"].Value = insurance.SelectedValue.ToString();

                cmd.Parameters.Add("@phone", MySqlDbType.Int32);
                cmd.Parameters["@phone"].Value = Phone1.Text;

                cmd.ExecuteNonQuery();
                sqlcon.Close();


            }

            if (!string.IsNullOrEmpty(Phone2.Text))
            {
                using (MySqlConnection sqlcon = new MySqlConnection(connstring))
                {
                    string insert2 = "Insert into Phone Values(@phone, (select cid from customer where cname = '"+ name.Text + "')); ";
                    sqlcon.Open();
                    MySqlCommand cmd = new MySqlCommand(insert2, sqlcon);
                    cmd.Parameters.Add("@phone", MySqlDbType.Int32);
                    cmd.Parameters["@phone"].Value = Phone2.Text;

                    cmd.ExecuteNonQuery();
                    sqlcon.Close();


                }
            }
            MessageBox.Show("Customer Added!");
            LoadCustomerData();

            // Clear textboxes
            name.Text = string.Empty;
            gender.SelectedIndex = -1;
            address.Text = string.Empty;
            insurance.SelectedIndex = -1; // Reset the ComboBox selection
            Phone1.Text = string.Empty;
            Phone2.Text = string.Empty;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem item = listView2.SelectedItems[0];

                string stringToSplit = item.SubItems[4].Text.ToString();
                var splitString = stringToSplit.Split('-');
                name.Text = item.SubItems[0].Text;
                insurance.Text = item.SubItems[3].Text;
                gender.Text = item.SubItems[1].Text;
                address.Text = item.SubItems[2].Text;
                Phone1.Text = splitString[0];
                Phone2.Text = splitString.Length > 1 ? splitString[1] : string.Empty;
            }
            else
            {
                name.Text = string.Empty;
                insurance.Text = string.Empty;
                gender.Text = string.Empty;
                address.Text = string.Empty;
                Phone1.Text = string.Empty;
                Phone2.Text = string.Empty;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Phone2.Visible = true;
        }

    }
}