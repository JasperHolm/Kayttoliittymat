using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int loop = 0;

            while (true)
            {
                DialogResult dialogResult = MessageBox.Show("Valitse Yes jatkaaksesi tai NO lopettaaksesi. Loop: " + loop, "Huom!" , MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    loop++;
                }
                else if (dialogResult == DialogResult.No)
                {
                    break;
                }
                
            }
        }
    }
}
