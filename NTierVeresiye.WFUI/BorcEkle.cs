﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierVeresiye.WFUI
{
    public partial class BorcEkle : Form
    {
        public BorcEkle()
        {
            InitializeComponent();
        }

        private void btnBorcEkleIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
