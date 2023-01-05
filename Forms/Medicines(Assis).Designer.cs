
namespace Pharmacy.Forms
{
    partial class Medicines_Assis_
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
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.c1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 30;
            this.bunifuElipse4.TargetControl = this;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox10.Image = global::Pharmacy.Properties.Resources.Exit_button_Png_Transparent;
            this.pictureBox10.Location = new System.Drawing.Point(917, 4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(60, 37);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 18;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click_1);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(426, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 28);
            this.label8.TabIndex = 17;
            this.label8.Text = "Medicines";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.listView2);
            this.panel1.Location = new System.Drawing.Point(2, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 645);
            this.panel1.TabIndex = 13;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.Maroon;
            this.textBox8.Location = new System.Drawing.Point(13, 32);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(205, 30);
            this.textBox8.TabIndex = 27;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c1,
            this.c2,
            this.c3,
            this.c6,
            this.c5,
            this.c7,
            this.c8,
            this.c4});
            this.listView2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.ForeColor = System.Drawing.Color.Black;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(13, 81);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(949, 549);
            this.listView2.TabIndex = 26;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // c1
            // 
            this.c1.Text = "Batch No.";
            this.c1.Width = 108;
            // 
            // c2
            // 
            this.c2.Text = "Name";
            this.c2.Width = 155;
            // 
            // c3
            // 
            this.c3.Text = "Type";
            this.c3.Width = 130;
            // 
            // c4
            // 
            this.c4.Text = "Price";
            this.c4.Width = 119;
            // 
            // c5
            // 
            this.c5.Text = "Quantity";
            this.c5.Width = 113;
            // 
            // c6
            // 
            this.c6.Text = "Manufacturer";
            this.c6.Width = 126;
            // 
            // c7
            // 
            this.c7.Text = "Mfg.Date";
            this.c7.Width = 108;
            // 
            // c8
            // 
            this.c8.Text = "Exp.Date";
            this.c8.Width = 118;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this.panel1;
            // 
            // Medicines_Assis_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(978, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Medicines_Assis_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicines";
            this.Load += new System.EventHandler(this.Medicines_Assis__Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader c1;
        private System.Windows.Forms.ColumnHeader c2;
        private System.Windows.Forms.ColumnHeader c3;
        private System.Windows.Forms.ColumnHeader c4;
        private System.Windows.Forms.ColumnHeader c5;
        private System.Windows.Forms.ColumnHeader c6;
        private System.Windows.Forms.ColumnHeader c7;
        private System.Windows.Forms.ColumnHeader c8;
    }
}