using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_Picture
{
    public partial class Form1 : Form
    {
        //private Bitmap HessuHopoBitmap;

        private Graphics a;



        public Form1()
        {
            InitializeComponent();         

            this.BackgroundImage = Properties.Resources.Viidakko;

            a = this.CreateGraphics();

            this.TransparencyKey = Color.Blue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnClick(e);

         int mouseX = e.X;
         int mouseY = e.Y;

            

            a.DrawImage(Properties.Resources.HessuHopo, new Point(mouseX, mouseY));          
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
