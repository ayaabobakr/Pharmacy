
namespace Pharmacy.Forms
{
    partial class Customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.bunifuElipse7 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.Phone2 = new System.Windows.Forms.TextBox();
            this.insurance = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.c1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Phone1 = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.address = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuElipse8 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse7
            // 
            this.bunifuElipse7.ElipseRadius = 30;
            this.bunifuElipse7.TargetControl = this.panel6;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.AliceBlue;
            this.panel6.Controls.Add(this.Phone2);
            this.panel6.Controls.Add(this.insurance);
            this.panel6.Controls.Add(this.textBox8);
            this.panel6.Controls.Add(this.listView2);
            this.panel6.Controls.Add(this.bunifuThinButton23);
            this.panel6.Controls.Add(this.bunifuThinButton21);
            this.panel6.Controls.Add(this.Phone1);
            this.panel6.Controls.Add(this.gender);
            this.panel6.Controls.Add(this.address);
            this.panel6.Controls.Add(this.name);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(2, 49);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(975, 645);
            this.panel6.TabIndex = 25;
            // 
            // Phone2
            // 
            this.Phone2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone2.Location = new System.Drawing.Point(316, 159);
            this.Phone2.Name = "Phone2";
            this.Phone2.Size = new System.Drawing.Size(204, 28);
            this.Phone2.TabIndex = 29;
            // 
            // insurance
            // 
            this.insurance.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.insurance.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.insurance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insurance.FormattingEnabled = true;
            this.insurance.Location = new System.Drawing.Point(316, 76);
            this.insurance.Name = "insurance";
            this.insurance.Size = new System.Drawing.Size(161, 29);
            this.insurance.TabIndex = 28;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.Maroon;
            this.textBox8.Location = new System.Drawing.Point(21, 212);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(205, 28);
            this.textBox8.TabIndex = 25;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c1,
            this.c3,
            this.c4,
            this.c2,
            this.c5});
            this.listView2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.ForeColor = System.Drawing.Color.Black;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(10, 254);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(949, 373);
            this.listView2.TabIndex = 24;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // c1
            // 
            this.c1.Text = "Name";
            this.c1.Width = 193;
            // 
            // c2
            // 
            this.c2.Text = "Insurance";
            this.c2.Width = 191;
            // 
            // c3
            // 
            this.c3.Text = "Gender";
            this.c3.Width = 201;
            // 
            // c4
            // 
            this.c4.Text = "Address";
            this.c4.Width = 225;
            // 
            // c5
            // 
            this.c5.Text = "Phone";
            this.c5.Width = 138;
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.AliceBlue;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Delete";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.MintCream;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.MidnightBlue;
            this.bunifuThinButton23.Location = new System.Drawing.Point(806, 186);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(92, 54);
            this.bunifuThinButton23.TabIndex = 23;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.AliceBlue;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Add";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.MintCream;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.MidnightBlue;
            this.bunifuThinButton21.Location = new System.Drawing.Point(678, 186);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(92, 54);
            this.bunifuThinButton21.TabIndex = 21;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Phone1
            // 
            this.Phone1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone1.Location = new System.Drawing.Point(23, 159);
            this.Phone1.Name = "Phone1";
            this.Phone1.Size = new System.Drawing.Size(204, 28);
            this.Phone1.TabIndex = 18;
            // 
            // gender
            // 
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(550, 76);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(161, 29);
            this.gender.TabIndex = 17;
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(780, 77);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(118, 28);
            this.address.TabIndex = 15;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(22, 76);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(205, 28);
            this.name.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.SlateGray;
            this.label17.Location = new System.Drawing.Point(546, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 21);
            this.label17.TabIndex = 12;
            this.label17.Text = "Gender";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.SlateGray;
            this.label16.Location = new System.Drawing.Point(776, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 21);
            this.label16.TabIndex = 11;
            this.label16.Text = "Address";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.SlateGray;
            this.label15.Location = new System.Drawing.Point(312, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 21);
            this.label15.TabIndex = 10;
            this.label15.Text = "Insurance";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SlateGray;
            this.label13.Location = new System.Drawing.Point(18, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 21);
            this.label13.TabIndex = 8;
            this.label13.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SlateGray;
            this.label4.Location = new System.Drawing.Point(233, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "+";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateGray;
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(17, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Customers Details";
            // 
            // bunifuElipse8
            // 
            this.bunifuElipse8.ElipseRadius = 30;
            this.bunifuElipse8.TargetControl = this;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox10.Image = global::Pharmacy.Properties.Resources.Exit_button_Png_Transparent;
            this.pictureBox10.Location = new System.Drawing.Point(917, 6);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(60, 37);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 27;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click_1);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 30;
            this.bunifuElipse3.TargetControl = this;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 30;
            this.bunifuElipse6.TargetControl = this;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 30;
            this.bunifuElipse4.TargetControl = this;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 30;
            this.bunifuElipse5.TargetControl = this;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(430, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 28);
            this.label8.TabIndex = 26;
            this.label8.Text = "Customers";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(978, 700);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox Phone2;
        private System.Windows.Forms.ComboBox insurance;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader c1;
        private System.Windows.Forms.ColumnHeader c2;
        private System.Windows.Forms.ColumnHeader c3;
        private System.Windows.Forms.ColumnHeader c4;
        private System.Windows.Forms.ColumnHeader c5;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.TextBox Phone1;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse8;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
    }
}