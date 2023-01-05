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
    public partial class Medicines_Assis_ : Form
    {
        public Medicines_Assis_()
        {
            InitializeComponent();
        }

        string connstring = "server=localhost;user id=root;Password = root;database=pharmacy";

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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

        private void Medicines_Assis__Load(object sender, EventArgs e)
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
}
