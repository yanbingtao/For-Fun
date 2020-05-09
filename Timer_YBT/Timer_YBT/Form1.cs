using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_YBT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Start_Click(object sender, EventArgs e)
        {

            timer1.Start();

        }
            int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            lblDisplay.Text = i.ToString()+"s";

            if (lblDisplay.Text == "10s")
            {
                var player = new System.Media.SoundPlayer();
                player.SoundLocation = @"d:\1.wav";
                player.Play();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
           
        
    }
}
