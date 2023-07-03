using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            double bmi;
            bmi = Convert.ToDouble(txtweight.Text) / (Convert.ToDouble(txtheight.Text) * Convert.ToDouble(txtheight.Text));
            txtbmi.Text = bmi.ToString();
            if (bmi < 18.5)
            {
                txtstatus.Text = "under weight";
                txtindicat.BackColor = Color.Red;
            }
            else if (bmi<25)
            {
                txtstatus.Text = "Normal";
                txtindicat.BackColor= Color.Blue;
            }
            else if (bmi <30)
            {
                txtstatus.Text = "Over weight";
                txtindicat.BackColor = Color.Green;
            }
            else if (bmi < 35)
            {
                txtstatus.Text = "Obsity class 1";
                txtindicat.BackColor = Color.Orange;
            }
            else if (bmi < 40)
            {
                txtstatus.Text = "Obsity class 2";
                txtindicat.BackColor = Color.Pink;
            }
            else
            {
                txtstatus.Text = "Obsity class 3";
                txtindicat.BackColor = Color.Brown;

            }

        }
    }
}
