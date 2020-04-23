using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnClose.Enabled = false;
            btnClose.Text = "Wpisz coś tam wyżej";
        }


        private void txtButtonChange_TextChanged(object sender, EventArgs e)
        {
            if (txtButtonChange.TextLength > 0)
            {
                btnClose.Text = txtButtonChange.Text;
            }
            else btnClose.Text = "wyłącz to po prostu";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnClose.Enabled = chkButtonEnabled.Checked;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            DetailsForm detailsForm = new DetailsForm(txtButtonChange.Text);

            detailsForm.Show();
        }
    }
}
