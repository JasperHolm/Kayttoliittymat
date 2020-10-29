using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void nappi (string button)
        {
            switch (button)
            {
                case "1":
                    MessageBox.Show("Valinta 1");
                    break;
                case "2":
                    MessageBox.Show("Valinta 2");
                    break;
                case "3":
                    MessageBox.Show("Valinta 3");
                    break;
                case "4":
                    MessageBox.Show("Valinta 4");
                    break;
                case "Default":
                    MessageBox.Show("Default");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nappi("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nappi("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nappi("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nappi("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nappi("Default");
        }
    }
}
