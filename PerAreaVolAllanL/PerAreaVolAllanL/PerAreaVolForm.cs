/*
 * Created by: Allan Léveillé
 * Created on: 14 February 2019 
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - Perimeter, Area amd Volume
 * This program uses buttons to reveal answers to the questions presented.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerAreaVolAllanL
{
    public partial class frmPerAreaVol : Form
    {
        public frmPerAreaVol()
        {
            InitializeComponent();
        }

        private void frmPerAreaVol_Load(object sender, EventArgs e)
        {

        }

        private void lblQuestion1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuestion1_Click(object sender, EventArgs e)
        {
            lblAnswer1.Text = Convert.ToString(14 + 24);
        }

        private void btnQuestion2_Click(object sender, EventArgs e)
        {
            lblAnswer2.Text = Convert.ToString(3.14 * Math.Pow(7,2));
        }

        private void btnQuestion3_Click(object sender, EventArgs e)
        {
            lblAnswer3.Text = Convert.ToString(4.0/3.0 * Math.PI * Math.Pow(3,3));
        }
    }
}