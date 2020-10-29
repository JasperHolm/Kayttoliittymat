using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08ArrayLotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static bool Sama(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value) return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int koko = 9;
            int[] lottonumerot = new int[koko];            

            Random rand = new Random();

            for (int i = 0; i < lottonumerot.Length; i++)
            {
                var seur = 0;
                while (true)
                {
                    seur = rand.Next(10);
                    if (!Sama(lottonumerot, seur)) break;
                }
                lottonumerot[i] = seur;

                label1.Text = lottonumerot[0].ToString() + ", " + lottonumerot[1].ToString() + ", " + lottonumerot[2].ToString() + ", " + lottonumerot[3].ToString() + ", " + lottonumerot[4].ToString() + ", " + lottonumerot[5].ToString() + ", " + lottonumerot[6].ToString() + ", " + lottonumerot[7].ToString() + ", " + lottonumerot[8].ToString();

                if (maskedTextBox1.Text == lottonumerot[0].ToString())
                {
                    MessageBox.Show("Veikkaus 1: Oikein");
                }
                else if (maskedTextBox2.Text == lottonumerot[1].ToString())
                {
                    MessageBox.Show("Veikkaus 2: Oikein");
                }
                else if (maskedTextBox3.Text == lottonumerot[2].ToString())
                {
                    MessageBox.Show("Veikkaus 3: Oikein");
                }
                else if (maskedTextBox4.Text == lottonumerot[3].ToString())
                {
                    MessageBox.Show("Veikkaus 4: Oikein");
                }
                else if (maskedTextBox5.Text == lottonumerot[4].ToString())
                {
                    MessageBox.Show("Veikkaus 5: Oikein");
                }
                else if (maskedTextBox6.Text == lottonumerot[5].ToString())
                {
                    MessageBox.Show("Veikkaus 6: Oikein");
                }
                else if (maskedTextBox7.Text == lottonumerot[6].ToString())
                {
                    MessageBox.Show("Veikkaus 7: Oikein");
                }
                else if (maskedTextBox8.Text == lottonumerot[7].ToString())
                {
                    MessageBox.Show("Veikkaus 8: Oikein");
                }
                else if (maskedTextBox9.Text == lottonumerot[8].ToString())
                {
                    MessageBox.Show("Veikkaus 9: Oikein");
                }
                else
                {
                    MessageBox.Show("Väärin");
                }
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
