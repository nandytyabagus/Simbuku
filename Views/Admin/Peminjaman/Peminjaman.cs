﻿using Projek_SimBuku.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_SimBuku.Views.Peminjaman
{
    public partial class Peminjaman : UserControl
    {
        C_Homepage Controller;
        C_Peminjaman peminjaman;
        public Peminjaman(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
            peminjaman = new C_Peminjaman(controller, this);
        }

        private void Peminjaman_Load(object sender, EventArgs e)
        {
            peminjaman.LoadData();
        }

        private void dataPeminjaman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataPeminjaman.Columns["Ubah Status"].Index)
            {

            }
        }
    }
}
