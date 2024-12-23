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

namespace Projek_SimBuku.Views.Dashboard
{
    public partial class Dashboard : UserControl
    {
        C_Homepage Controller;
        C_Dashboard c_Dashboard;
        public Dashboard(C_Homepage controller)
        {
            InitializeComponent();
            this.Controller = controller;
            c_Dashboard = new C_Dashboard(controller, this);
            c_Dashboard.LoadAndShowInfo();
        }

    }
}
