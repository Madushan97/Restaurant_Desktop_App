using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;
            firstCustomeControl1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;
            firstCustomeControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button2.Height;
            sidePanel.Top = button2.Top;
            mySecondCustomeControl1.BringToFront();
        }
    }
}
