﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP_2020
{
    public partial class DetailsForm : Form
    {
        public DetailsForm(string label)
        {
            InitializeComponent();
            lblTitle.Text = label;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}