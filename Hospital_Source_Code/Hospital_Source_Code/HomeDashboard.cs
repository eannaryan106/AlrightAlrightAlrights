﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Source_Code
{
    public partial class HomeDashboard : Form
    {

        public HomeDashboard(UserRole role) {
            InitializeComponent();
            if (role == UserRole.SuperUser)
            {
                Console.WriteLine((int)role);
            }
            Console.WriteLine(role);
        }

        private void HomeDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
