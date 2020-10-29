using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Syötä tulostettava luku!");
            }

                int a = Convert.ToInt32(maskedTextBox1.Text);
                       
            for (int i = 0;  i < a; i++)
            {
                label1.Text = i.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
