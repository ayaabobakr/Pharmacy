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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            DateTime thisday = DateTime.Today;
            date.Text = thisday.ToString();
            Medicine.Text = Order.mednamee;
            quantity.Text = Order.q;
            price.Text = Order.p;
            total.Text = Order.p;

                
        }
    }
}
