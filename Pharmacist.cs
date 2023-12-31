using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pharmacy
{
    public partial class Pharmacist : Form
    {
        private Button current;
        private Form activateForm;
        public Pharmacist()
        {
            InitializeComponent();
        }

        string connstring = "server=localhost;user id=root;Password = root;database=pharmacy";

        private void ActivateBtn(object btnSender)
        {
            if (btnSender != null)
            {
                if (current != (Button)btnSender)
                {
                    DisableBtn();
                    Color color = Color.Navy;
                    current = (Button)btnSender;
                    current.BackColor = color;
                    current.ForeColor = Color.White;
                    current.Font = new System.Drawing.Font(" Century Gothic", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableBtn()
        {
            foreach (Control previous in panel1.Controls)
            {
                if (previous.GetType() == typeof(Button))
                {
                    previous.BackColor = Color.FromArgb(185, 209, 234);
                    previous.ForeColor = Color.White;
                    previous.Font = new System.Drawing.Font(" Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        
        private void OpenChildPanel(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            ActivateBtn(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(childForm);
            this.panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Reset()
        {
            DisableBtn();
            current = null;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            query("select sum(stock_quantity) from medicine ;", med);
            query("select count(CID) from customer ;", cust);
            query("select count(OrderId) from orderr ;", ord);

            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "select medName, stock_quantity, expirydate from medicine where stock_quantity<10;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rd;
            rd = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (rd.Read())
            {
                ListViewItem lv = new ListViewItem(rd.GetString(0).ToString());
                lv.SubItems.Add(rd.GetInt32(1).ToString());
                lv.SubItems.Add(rd.GetDateTime(2).ToString("dd/MM/yyyy"));
                listView1.Items.Add(lv);
            }
            rd.Close();
            cmd.Dispose();
            conn.Close();

        }

        public void query(string s, Label label)
        {
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = s;
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label.Text = reader.GetValue(0).ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }

            query("select sum(stock_quantity) from medicine ;", med);
            query("select count(CID) from customer ;", cust);
            query("select count(OrderId) from orderr ;", ord);

            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "select medName, stock_quantity, expirydate from medicine where stock_quantity<10;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rd;
            rd = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (rd.Read())
            {
                ListViewItem lv = new ListViewItem(rd.GetString(0).ToString());
                lv.SubItems.Add(rd.GetInt32(1).ToString());
                lv.SubItems.Add(rd.GetDateTime(2).ToString("dd/MM/yyyy"));
                listView1.Items.Add(lv);
            }
            rd.Close();
            cmd.Dispose();
            conn.Close();
            Reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new Forms.Medicines(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new Forms.Insurance(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new Forms.Prescription(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new Forms.Customers(), sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new Forms.Order(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
