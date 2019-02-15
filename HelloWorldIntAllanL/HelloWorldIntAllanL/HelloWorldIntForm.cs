/*
 * Created by: Allan Léveillé
 * Created on: 11 February, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #5 - HelloWorldInt
 * This program uses radio buttons to change the label to the language displayed. 
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

namespace HelloWorldIntAllanL
{
    public partial class frmHelloWorldInt : Form
    {
        public frmHelloWorldInt()
        {
            InitializeComponent();
        }

        private void frmHelloWorldInt_Load(object sender, EventArgs e)
        {

        }

        private void radArabic_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "مرحبا بالعالم";
        }

        private void radEnglish_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World";
        }

        private void radFrench_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Bonjour le monde";
        }

        private void radGreek_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Γειά σου Κόσμε";
        }

        private void radSwedish_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hej världen";
        }

        private void lblHelloWorld_Click(object sender, EventArgs e)
        {

        }
    }
}
