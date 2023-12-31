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
    public partial class Medicines : Form
    {
        public Medicines()
        {
            InitializeComponent();
        }

        string connstring = "server=localhost;user id=root;Password = root;database=pharmacy";
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void RefreshMedicineList()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "SELECT * FROM medicine;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rd;
            rd = cmd.ExecuteReader();
            listView2.Items.Clear();
            while (rd.Read())
            {
                ListViewItem lv = new ListViewItem(rd.GetInt32(0).ToString());
                lv.SubItems.Add(rd.GetString(1).ToString());
                lv.SubItems.Add(rd.GetString(2).ToString());
                lv.SubItems.Add(rd.GetString(3).ToString());
                lv.SubItems.Add(rd.GetInt32(4).ToString());
                lv.SubItems.Add(rd.GetDateTime(5).ToString("yyyy/MM/dd"));
                lv.SubItems.Add(rd.GetDateTime(6).ToString("yyyy/MM/dd"));
                lv.SubItems.Add(rd.GetFloat(7).ToString());
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
                string str = "Select* from medicine Where medname Like'%" + textBox8.Text + "%' or batch_number Like'%" + textBox8.Text + "%' or medicineType Like'%" + textBox8.Text + "%'" +
                    "or manufacturer Like'%" + textBox8.Text + "%' or stock_quantity Like'%" + textBox8.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(str, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ListViewItem lv = new ListViewItem(rd.GetInt32(0).ToString());
                    lv.SubItems.Add(rd.GetString(1).ToString());
                    lv.SubItems.Add(rd.GetString(2).ToString());
                    lv.SubItems.Add(rd.GetString(3).ToString());
                    lv.SubItems.Add(rd.GetInt32(4).ToString());
                    lv.SubItems.Add(rd.GetDateTime(5).ToString("dd/MM/yyyy"));
                    lv.SubItems.Add(rd.GetDateTime(6).ToString("dd/MM/yyyy"));
                    lv.SubItems.Add(rd.GetFloat(7).ToString());
                    listView2.Items.Add(lv);
                }
                rd.Close();
                con.Close();
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(connstring);
                conn.Open();
                string sql = "SELECT * FROM medicine;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rd;
                rd = cmd.ExecuteReader();
                listView2.Items.Clear();
                while (rd.Read())
                {
                    ListViewItem lv = new ListViewItem(rd.GetInt32(0).ToString());
                    lv.SubItems.Add(rd.GetString(1).ToString());
                    lv.SubItems.Add(rd.GetString(2).ToString());
                    lv.SubItems.Add(rd.GetString(3).ToString());
                    lv.SubItems.Add(rd.GetInt32(4).ToString());
                    lv.SubItems.Add(rd.GetDateTime(5).ToString("dd/MM/yyyy"));
                    lv.SubItems.Add(rd.GetDateTime(6).ToString("dd/MM/yyyy"));
                    lv.SubItems.Add(rd.GetFloat(7).ToString());
                    listView2.Items.Add(lv);
                }
                rd.Close();
                cmd.Dispose();
                conn.Close();
            }
        }

        private void Medicines_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "SELECT * FROM medicine;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rd;
            rd = cmd.ExecuteReader();
            listView2.Items.Clear();
            while (rd.Read())
            {
                ListViewItem lv = new ListViewItem(rd.GetInt32(0).ToString());
                lv.SubItems.Add(rd.GetString(1).ToString());
                lv.SubItems.Add(rd.GetString(2).ToString());
                lv.SubItems.Add(rd.GetString(3).ToString());
                lv.SubItems.Add(rd.GetInt32(4).ToString());
                lv.SubItems.Add(rd.GetDateTime(5).ToString("yyyy/MM/dd"));
                lv.SubItems.Add(rd.GetDateTime(6).ToString("yyyy/MM/dd"));
                lv.SubItems.Add(rd.GetFloat(7).ToString());
                listView2.Items.Add(lv);
            }
            rd.Close();
            cmd.Dispose();
            conn.Close();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            var cashierId = listView2.FocusedItem.Text;
            var itemm = listView2.SelectedItems[0];
            var firstColumn = itemm.SubItems[0].Text;
            var secondColumn = itemm.SubItems[1].Text;
            string query = "delete from medicine WHERE batch_number = @batch and medname = @name;";
            using (MySqlConnection sqlcon = new MySqlConnection(connstring))
            {
                try
                {
                    sqlcon.Open();
                    using (MySqlTransaction trans = sqlcon.BeginTransaction())
                    {

                        using (MySqlCommand com = new MySqlCommand(query, sqlcon, trans))
                        {

                            com.Parameters.AddWithValue("@batch", firstColumn);
                            com.Parameters.AddWithValue("@name", secondColumn);

                            var should_be_one = com.ExecuteNonQuery();

                            if (should_be_one == 1)
                            {

                                trans.Commit();
                                foreach (ListViewItem item in listView2.Items)
                                    if (item.Selected)
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

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem item = listView2.SelectedItems[0];

                name.Text = item.SubItems[1].Text;
                batch.Text = item.SubItems[0].Text;
                manufacture.Text = item.SubItems[3].Text;
                type.Text = item.SubItems[2].Text;
                quantity.Text = item.SubItems[4].Text;
                mfgdate.Text = item.SubItems[5].Text;
                expdate.Text = item.SubItems[6].Text;
                price.Text = item.SubItems[7].Text;
            }
            else
            {
                name.Text = string.Empty;
                batch.Text = string.Empty;
                manufacture.Text = string.Empty;
                type.Text = string.Empty;
                quantity.Text = string.Empty;
                mfgdate.Text = string.Empty;
                expdate.Text = string.Empty;
                price.Text = string.Empty;
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlcon = new MySqlConnection(connstring))
            {
                string insert = "update medicine set medicinetype = @type" +
                    ", manufacturer = @manuf, manufdate = @mfgdate, expirydate = @expdate, price = @price, stock_quantity=@stock where medname='"+name.Text+ "' and batch_number ="+ batch.Text +";";
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(insert, sqlcon);
                cmd.Parameters.Add("@type", MySqlDbType.VarChar);
                cmd.Parameters["@type"].Value = type.Text;

                cmd.Parameters.Add("@manuf", MySqlDbType.VarChar);
                cmd.Parameters["@manuf"].Value = manufacture.Text;

                cmd.Parameters.Add("@mfgdate", MySqlDbType.Date);
                cmd.Parameters["@mfgdate"].Value = mfgdate.Text;

                cmd.Parameters.Add("@expdate", MySqlDbType.Date);
                cmd.Parameters["@expdate"].Value = expdate.Text;

                cmd.Parameters.Add("@price", MySqlDbType.Float);
                cmd.Parameters["@price"].Value = price.Text;

                cmd.Parameters.Add("@stock", MySqlDbType.Int32);
                cmd.Parameters["@stock"].Value = quantity.Text;

                cmd.ExecuteNonQuery();
                sqlcon.Close();


            }
            MessageBox.Show("Medicine Updated!");

            RefreshMedicineList();

            // Clear textboxes
            name.Text = string.Empty;
            batch.Text = string.Empty;
            manufacture.Text = string.Empty;
            type.SelectedIndex = -1;
            quantity.Text = string.Empty;
            mfgdate.Text = string.Empty;
            expdate.Text = string.Empty;
            price.Text = string.Empty;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlcon = new MySqlConnection(connstring))
            {
                try
                {
                    // Validate input fields
                    if (string.IsNullOrEmpty(batch.Text) || string.IsNullOrEmpty(name.Text) ||
                        string.IsNullOrEmpty(type.Text) || string.IsNullOrEmpty(manufacture.Text) ||
                        string.IsNullOrEmpty(mfgdate.Text) || string.IsNullOrEmpty(expdate.Text) ||
                        string.IsNullOrEmpty(price.Text) || string.IsNullOrEmpty(quantity.Text))
                    {
                        MessageBox.Show("Please fill in all fields.");
                        return; // Stop execution if any field is missing
                    }

                    // If all fields are present, proceed with the insertion
                    string insert = "INSERT INTO medicine (batch_number, medname, medicinetype, manufacturer, stock_quantity," +
                        "manufdate, expirydate, price) VALUES (@batch_number, @medname, @medicinetype, @manufacturer, @stock," +
                        "@mfgdate, @expdate, @price);";

                    sqlcon.Open();
                    MySqlCommand cmd = new MySqlCommand(insert, sqlcon);

                    cmd.Parameters.AddWithValue("@batch_number", Convert.ToInt32(batch.Text));
                    cmd.Parameters.AddWithValue("@medname", name.Text);
                    cmd.Parameters.AddWithValue("@medicinetype", type.Text);
                    cmd.Parameters.AddWithValue("@manufacturer", manufacture.Text);
                    cmd.Parameters.AddWithValue("@mfgdate", DateTime.Parse(mfgdate.Text));
                    cmd.Parameters.AddWithValue("@expdate", DateTime.Parse(expdate.Text));
                    cmd.Parameters.AddWithValue("@price", Convert.ToDouble(price.Text));
                    cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(quantity.Text));

                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    MessageBox.Show("Medicine Added!");
                    RefreshMedicineList();

                    // Clear textboxes
                    name.Text = string.Empty;
                    batch.Text = string.Empty;
                    manufacture.Text = string.Empty;
                    type.SelectedIndex = -1;
                    quantity.Text = string.Empty;
                    mfgdate.Text = string.Empty;
                    expdate.Text = string.Empty;
                    price.Text = string.Empty;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
}

        }
    }
}
