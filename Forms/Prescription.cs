using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
        }
        string connstring = "server=localhost;user id=root;Password = root;database=pharmacy";

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void LoadDataAndUpdateUI()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "SELECT presid, (select cname from customer where cid = prescription.cid)" +
                         "as Name, presdate, medname, quantity FROM prescription natural join prescribedmed where prescription.presid = prescribedmed.presid;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rd;
            rd = cmd.ExecuteReader();
            listView2.Items.Clear();
            while (rd.Read())
            {
                ListViewItem lv = new ListViewItem(rd.GetInt32(0).ToString());
                lv.SubItems.Add(rd.GetString(1).ToString());
                lv.SubItems.Add(rd.GetDateTime(2).ToString("dd/MM/yyyy"));
                lv.SubItems.Add(rd.GetString(3).ToString());
                lv.SubItems.Add(rd.GetInt32(4).ToString());
                listView2.Items.Add(lv);
            }
            rd.Close();
            cmd.Dispose();
            conn.Close();
        }


        private void Prescription_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();
            string strCmd = "select cname from customer";
            MySqlCommand cd = new MySqlCommand(strCmd, con);
            MySqlDataAdapter da = new MySqlDataAdapter(strCmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            customer.DataSource = ds.Tables[0];
            customer.ValueMember = "cname";
            customer.Enabled = true;
            this.customer.SelectedIndex = -1;
            cd.ExecuteNonQuery();
            con.Close();



            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "SELECT presid, (select cname from customer where cid = prescription.cid)" +
                "as Name,presdate, medname, quantity FROM prescription natural join prescribedmed where prescription.presid = prescribedmed.presid;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rd;
            rd = cmd.ExecuteReader();
            listView2.Items.Clear();
            while (rd.Read())
            {
                ListViewItem lv = new ListViewItem(rd.GetInt32(0).ToString());
                lv.SubItems.Add(rd.GetString(1).ToString());
                lv.SubItems.Add(rd.GetDateTime(2).ToString("dd/MM/yyyy"));
                lv.SubItems.Add(rd.GetString(3).ToString());
                lv.SubItems.Add(rd.GetInt32(4).ToString());
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
                string str = "Select presid, (select cname from customer where cid = prescription.cid)as Name,presdate, medname, quantity from " +
                    "prescription natural join prescribedmed Where medname Like'%" + textBox8.Text + "%' or prescription.presid Like'%" + textBox8.Text + "%' or quantity Like'%" + textBox8.Text + "%'" +
                    "or (select cname from customer where cid = prescription.cid) Like'%" + textBox8.Text + "%' or presdate Like'%" + textBox8.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(str, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ListViewItem lv = new ListViewItem(rd.GetInt32(0).ToString());
                    lv.SubItems.Add(rd.GetString(1).ToString());
                    lv.SubItems.Add(rd.GetDateTime(2).ToString("dd/MM/yyyy"));
                    lv.SubItems.Add(rd.GetString(3).ToString());
                    lv.SubItems.Add(rd.GetInt32(4).ToString());
                    listView2.Items.Add(lv);
                }
                rd.Close();
                con.Close();
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(connstring);
                conn.Open();
                string sql = "SELECT presid, (select cname from customer where cid = prescription.cid)" +
                    "as Name,presdate, medname, quantity FROM prescription natural join prescribedmed where prescription.presid = prescribedmed.presid;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rd;
                rd = cmd.ExecuteReader();
                listView2.Items.Clear();
                while (rd.Read())
                {
                    ListViewItem lv = new ListViewItem(rd.GetInt32(0).ToString());
                    lv.SubItems.Add(rd.GetString(1).ToString());
                    lv.SubItems.Add(rd.GetDateTime(2).ToString("dd/MM/yyyy"));
                    lv.SubItems.Add(rd.GetString(3).ToString());
                    lv.SubItems.Add(rd.GetInt32(4).ToString());
                    listView2.Items.Add(lv);
                }
                rd.Close();
                cmd.Dispose();
                conn.Close();
            }
        }



        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customer.Text) || string.IsNullOrEmpty(medname.Text) || string.IsNullOrEmpty(quantity.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            using (MySqlConnection sqlcon = new MySqlConnection(connstring))
            {
                string insert = "insert into Prescription (CID, PresDate) values ((select cid from customer where cname = '" + customer.Text + "'), CURDATE()); " +
                    "insert into PrescribedMed(PresID, MedName , Quantity) values ((select presid from Prescription where cid = (select cid from customer where cname = '" + customer.Text + "')and presdate = CURDATE()), @medname, @quantity);";
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(insert, sqlcon);

                cmd.Parameters.Add("@medname", MySqlDbType.VarChar);
                cmd.Parameters["@medname"].Value = medname.Text;

                cmd.Parameters.Add("@quantity", MySqlDbType.Int32);
                cmd.Parameters["@quantity"].Value = quantity.Text;

                cmd.ExecuteNonQuery();
                sqlcon.Close();


            }
            MessageBox.Show("Prescription Added!");

            LoadDataAndUpdateUI();

            // Clear fields
            customer.SelectedIndex = -1;
            medname.Text = string.Empty;
            quantity.Text = string.Empty;
        }
    }
}
