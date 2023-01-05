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

namespace Pharmacy.Forms
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        string connstring = "server=localhost;user id=root;Password = root;database=pharmacy ";



        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();
            string strCmd = "select medname from medicine";
            MySqlCommand cd = new MySqlCommand(strCmd, con);
            MySqlDataAdapter da = new MySqlDataAdapter(strCmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            medname.DataSource = ds.Tables[0];
            medname.ValueMember = "medname";
            medname.Enabled = true;
            this.medname.SelectedIndex = -1;
            cd.ExecuteNonQuery();
            con.Close();


            MySqlConnection con1 = new MySqlConnection(connstring);
            con1.Open();
            string strCmd1 = "select batch_number from medicine";
            MySqlCommand cd1 = new MySqlCommand(strCmd1, con1);
            MySqlDataAdapter da1 = new MySqlDataAdapter(strCmd1, con1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            batch.DataSource = ds1.Tables[0];
            batch.ValueMember = "batch_number";
            batch.Enabled = true;
            this.batch.SelectedIndex = -1;
            cd1.ExecuteNonQuery();
            con1.Close();


            MySqlConnection con2 = new MySqlConnection(connstring);
            con2.Open();
            string strCmd2 = "select cname from customer";
            MySqlCommand cd2 = new MySqlCommand(strCmd2, con2);
            MySqlDataAdapter da2 = new MySqlDataAdapter(strCmd2, con2);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            customer.DataSource = ds2.Tables[0];
            customer.ValueMember = "cname";
            customer.Enabled = true;
            this.customer.SelectedIndex = -1;
            cd2.ExecuteNonQuery();
            con2.Close();

            MySqlConnection con3 = new MySqlConnection(connstring);
            con3.Open();
            string strCmd3 = "select emp_name from employee";
            MySqlCommand cd3 = new MySqlCommand(strCmd3, con3);
            MySqlDataAdapter da3 = new MySqlDataAdapter(strCmd3, con3);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);
            employee.DataSource = ds3.Tables[0];
            employee.ValueMember = "emp_name";
            employee.Enabled = true;
            this.employee.SelectedIndex = -1;
            cd3.ExecuteNonQuery();
            con3.Close();





            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "select  orderid, (select cname from customer where cid = (select cid from prescription where presid = orderr.PresID))" +
                "as customer, (select emp_name from employee where EmployeeID = orderr.EmployeeID) as Name, orderdate,batch_number," +
                "ordered_quantity, medname, price from orderr natural join orderedmed; ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rd;
            rd = cmd.ExecuteReader();
            listView2.Items.Clear();
            while (rd.Read())
            {
                ListViewItem lv = new ListViewItem(rd.GetInt32(0).ToString());
                lv.SubItems.Add(rd.GetString(1).ToString());
                lv.SubItems.Add(rd.GetString(2).ToString());
                lv.SubItems.Add(rd.GetDateTime(3).ToString("dd/MM/yyyy"));
                lv.SubItems.Add(rd.GetInt32(4).ToString());
                lv.SubItems.Add(rd.GetInt32(5).ToString());
                lv.SubItems.Add(rd.GetString(6).ToString());
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
                string str = "select  orderid, (select cname from customer where cid = (select cid from prescription where presid = orderr.PresID))" +
                "as customer, (select emp_name from employee where EmployeeID = orderr.EmployeeID) as Name, orderdate,batch_number," +
                "ordered_quantity, medname, price from orderr natural join orderedmed Where medname Like'%" + textBox8.Text + "%' or orderr.presid Like'%" + textBox8.Text + "%' or ordered_quantity Like'%" + textBox8.Text + "%'" +
                    "or (select emp_name from employee where EmployeeID = orderr.EmployeeID) Like'%" + textBox8.Text + "%' or orderdate Like'%" + textBox8.Text + "%' or (select cname from customer where cid = (select cid from prescription where presid = orderr.PresID))" +
                    " Like'%" + textBox8.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(str, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ListViewItem lv = new ListViewItem(rd.GetInt32(0).ToString());
                    lv.SubItems.Add(rd.GetString(1).ToString());
                    lv.SubItems.Add(rd.GetString(2).ToString());
                    lv.SubItems.Add(rd.GetDateTime(3).ToString("dd/MM/yyyy"));
                    lv.SubItems.Add(rd.GetInt32(4).ToString());
                    lv.SubItems.Add(rd.GetInt32(5).ToString());
                    lv.SubItems.Add(rd.GetString(6).ToString());
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
                string sql = "select  orderid, (select cname from customer where cid = (select cid from prescription where presid = orderr.PresID))" +
                "as customer, (select emp_name from employee where EmployeeID = orderr.EmployeeID) as Name, orderdate,batch_number," +
                "ordered_quantity, medname, price from orderr natural join orderedmed; ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rd;
                rd = cmd.ExecuteReader();
                listView2.Items.Clear();
                while (rd.Read())
                {
                    ListViewItem lv = new ListViewItem(rd.GetInt32(0).ToString());
                    lv.SubItems.Add(rd.GetString(1).ToString());
                    lv.SubItems.Add(rd.GetString(2).ToString());
                    lv.SubItems.Add(rd.GetDateTime(3).ToString("dd/MM/yyyy"));
                    lv.SubItems.Add(rd.GetInt32(4).ToString());
                    lv.SubItems.Add(rd.GetInt32(5).ToString());
                    lv.SubItems.Add(rd.GetString(6).ToString());
                    lv.SubItems.Add(rd.GetFloat(7).ToString());
                    listView2.Items.Add(lv);
                }
                rd.Close();
                cmd.Dispose();
                conn.Close();
            }
        }
        public static string mednamee;
        public static string p;
        public static string q;

        private void add_Click(object sender, EventArgs e)
        {
            
            
            
            using (MySqlConnection sqlcon = new MySqlConnection(connstring))
            {
                string insert = "insert into orderr(PresID,OrderDate,EmployeeID) values((select PresID from Prescription where cid = (select cid from customer where cname = '" + customer.Text + "')), CURDATE()," +
                    "(select employeeid from employee where emp_name ='" + employee.Text + "')); " +
                    "insert into OrderedMed (OrderID,batch_number,ordered_quantity,MedName,Price) values" +
                    " ((select OrderID  from orderr  where PresID = (select PresID from Prescription where cid = (select cid from customer where cname = '" + customer.Text + "' and orderdate = curdate())))," +
                    "@batchnumber,@quantity, @medname, @price);" +
                    "update medicine set stock_quantity = stock_quantity - " + quantity.Text + " where MedName = '" + medname.Text + "';";
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(insert, sqlcon);
                mednamee = medname.Text;
                q = quantity.Text;
                p = price.Text;
                cmd.Parameters.Add("@medname", MySqlDbType.VarChar);
                cmd.Parameters["@medname"].Value = medname.Text;

                cmd.Parameters.Add("@quantity", MySqlDbType.Int32);
                cmd.Parameters["@quantity"].Value = quantity.Text;

                cmd.Parameters.Add("@price", MySqlDbType.Float);
                cmd.Parameters["@price"].Value = price.Text;

                cmd.Parameters.Add("@batchnumber", MySqlDbType.Int32);
                cmd.Parameters["@batchnumber"].Value = batch.Text;

                cmd.ExecuteNonQuery();
                sqlcon.Close();


            }
            MessageBox.Show("Ordered!");
        }


        private void label4_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "select  price from medicine where medname = '" + medname.Text + "' and batch_number = '" + batch.Text + "';";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rd;
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                price.Text = rd.GetFloat(0).ToString();
            }
            rd.Close();
            cmd.Dispose();
            conn.Close();
        }

        private void print_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlcon = new MySqlConnection(connstring))
            {

                string insert = "insert into payment(OrderID,CID,TotalAmount,customerpayment,insurancepayment) values(" +
                    "(select OrderID  from orderr  where PresID = (select PresID from Prescription where cid = (select cid from customer where cname = '" + customer.Text + "' and orderdate = curdate())))," +
                    "(select cid from customer where cname = '" + customer.Text + "'),@price,@price*(select percent from insurance where insurance_id= (select insurance_id from customer where cname = '" + customer.Text + "'))/100,(select percent from insurance where insurance_id= (select insurance_id from customer where cname = '" + customer.Text + "')))";
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(insert, sqlcon);
                mednamee = medname.Text;
                q = quantity.Text;
                p = price.Text;
                cmd.Parameters.Add("@medname", MySqlDbType.VarChar);
                cmd.Parameters["@medname"].Value = medname.Text;

                cmd.Parameters.Add("@quantity", MySqlDbType.Int32);
                cmd.Parameters["@quantity"].Value = quantity.Text;

                cmd.Parameters.Add("@price", MySqlDbType.Float);
                cmd.Parameters["@price"].Value = price.Text;

                cmd.Parameters.Add("@batchnumber", MySqlDbType.Int32);
                cmd.Parameters["@batchnumber"].Value = batch.Text;

                cmd.ExecuteNonQuery();
                sqlcon.Close();




                Receipt r = new Receipt();
                r.Show();
            }
        }
    }
}
