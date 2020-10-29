using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_Muistipeli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button2.Enabled = false;
        }

        bool salliClick = false;
        PictureBox arvaus;
        Random rnd = new Random();
        Timer clickAjastin = new Timer();

        int aika = 80;
        int kierros = 1;

        //1000 = 1sec
        Timer ajastin = new Timer { Interval = 1000 };

        private PictureBox[] PictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }
        //nappi aloittaa pelin
        private void button1_Click(object sender, EventArgs e)
        {
            salliClick = true;
            SetRandomImages();
            HideImages();
            StartGameTimer();
            clickAjastin.Interval = 1000;
            clickAjastin.Tick += ClickAjastinTick;
            button1.Enabled = false;
            button2.Enabled = true;
        }
        //nappi aloittaa kierroksen alusta
        private void button2_Click(object sender, EventArgs e)
        {
            StopGameTimer();
            ResetImages();
            label2.Text = "0";
        }
        //käytetään resources kuvia
        private static IEnumerable<Image> Images
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources._1,
                    Properties.Resources._2,
                    Properties.Resources._3,
                    Properties.Resources._4,
                    Properties.Resources._5,
                    Properties.Resources._6,
                    Properties.Resources._7,
                    Properties.Resources._8,
                    Properties.Resources._9,
                    Properties.Resources._10
                };
            }
        }
        //Aloittaa ajastimen ja näyttää jäljellä olevan ajan label1, sekä ilmoittaa kun aika on kulunut
        private void StartGameTimer()
        {
            ajastin.Start();
            ajastin.Tick += delegate
            {
                aika--;
                if (aika < 0)
                {
                    ajastin.Stop();

                    int loop = 0;

                    DialogResult dialogResult = MessageBox.Show("Aika loppui! Yritätkö uudelleen?", "Aika!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        loop++;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        System.Windows.Forms.Application.ExitThread();
                    }
                    ResetImages();
                }
                label1.Text = aika.ToString();
                
            };
        }
        //Pysäyttää ajastimen
        private void StopGameTimer()
        {
            ajastin.Stop();
        }
        //Resetoi picture boxit jolloin peliä voi pelata uudelleen
        private void ResetImages()
        {
            foreach (var pic in PictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }
            HideImages();
            SetRandomImages();
            aika = 80;
            ajastin.Start();
        }
        //foreach looppi joka laittaa picture boxien päälle kysymysmerkki kuvan
        private void HideImages()
        {
            foreach (var pic in PictureBoxes)
            {
                pic.Image = Properties.Resources.QuestionMark;
            }
        }
        //
        private PictureBox FreeSlot()
        {
            int num;

            do
            {
                num = rnd.Next(0, PictureBoxes.Count());
            }
            while (PictureBoxes[num].Tag != null);
            return PictureBoxes[num];
        }
        //
        private void SetRandomImages()
        {
            foreach (var image in Images)
            {
                FreeSlot().Tag = image;
                FreeSlot().Tag = image;
            }
        }
        //
        private void ClickAjastinTick(object sender, EventArgs e)
        {
            HideImages();
            salliClick = true;
            clickAjastin.Stop();
        }
        //
        private void ClickImage(object sender, EventArgs e)
        {
            if (!salliClick) return;
            var pic = (PictureBox)sender;
            if (arvaus == null)
            {
                arvaus = pic;
                pic.Image = (Image)pic.Tag;               
                return;
            }
            label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - 5);
            pic.Image = (Image)pic.Tag;
            
            if (pic.Image == arvaus.Image && pic != arvaus)
            {
                pic.Visible = arvaus.Visible = false;
                {
                    arvaus = pic;
                }
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 15);
                HideImages();
            }
            else
            {
                salliClick = false;
                clickAjastin.Start();
            }
            arvaus = null;

            if (PictureBoxes.Any(p => p.Visible)) return;
            {
                StopGameTimer();

                int loop = 0;
                
                    DialogResult dialogResult = MessageBox.Show("Voitit! Haluatko jatkaa pelaamista?", "Voitit!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        loop++;
                        kierros++;                      
                }
                    else if (dialogResult == DialogResult.No)
                    {
                        System.Windows.Forms.Application.ExitThread();
                    }
                    label5.Text = kierros.ToString();
                    ResetImages();
                    label2.Text = "0";
            }          
        }
    }
}
