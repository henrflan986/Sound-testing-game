using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace Sound_testing_game
{
    public partial class backGroundColor : Form
    {
        public backGroundColor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void number3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            

           
        }

        private void buttonToStart_Click(object sender, EventArgs e)
        {

            //play a sound
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.aaa);
            alertPlayer.Play();

            buttonToStart.Text = "3";

            Refresh();
            Thread.Sleep(1000);

            // change state label colours
            buttonToStart.BackColor = Color.Red;

            buttonToStart.Text = "2";

            Refresh();
            Thread.Sleep(1000);

            buttonToStart.BackColor = Color.Blue;

            buttonToStart.Text = "1";

            Refresh();
            Thread.Sleep(1000);

            buttonToStart.BackColor = Color.Green;

            buttonToStart.Text = "GO";

            alertPlayer = new SoundPlayer(Properties.Resources.bbb);
            alertPlayer.Play();
        }
    }
}
