﻿namespace Projek_SimBuku.Views.Admin.Transaksi
{
    partial class Transaksi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            panel1 = new Panel();
            Search = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1378, 710);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources._38ad706e_f194_40e2_8a7e_48a4a97401b1;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(50, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(1418, 750);
            panel2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Frame_23;
            panel1.Controls.Add(Search);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(50, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 80);
            panel1.TabIndex = 7;
            // 
            // Search
            // 
            Search.BackColor = Color.White;
            Search.BorderStyle = BorderStyle.None;
            Search.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Search.ForeColor = Color.Black;
            Search.Location = new Point(105, 22);
            Search.Name = "Search";
            Search.PlaceholderText = "Search";
            Search.Size = new Size(272, 39);
            Search.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources._7d72fdb8_53c5_4b02_8afc_59e6a8f86106;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources._02de674a_a51c_4cd4_bad8_25a1c70748c4;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(80, 80);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // Transaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Frame_16;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Transaksi";
            Size = new Size(1518, 1040);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel1;
        private TextBox Search;
        private Button button1;
    }
}