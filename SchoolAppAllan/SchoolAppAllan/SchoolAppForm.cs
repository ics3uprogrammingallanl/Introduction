/*
 * Created by: Allan Léveillé
 * Created on: Feb. 7, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #4 - Hello World with Menu
 * This program displays Hello World but with an exit menu
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

namespace SchoolAppAllan
{
    public partial class frmSchoolApp : Form
    {
        public frmSchoolApp()
        {
            InitializeComponent();
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
