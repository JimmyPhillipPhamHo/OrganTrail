﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganTrail
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void btnContinue3_Click(object sender, EventArgs e)
        {
            gbToBuy.Visible = true;
        }
    }
}
