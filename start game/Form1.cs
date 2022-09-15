using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

using System.Threading;

using System.Media;


namespace start_game
{
    public partial class startGameBackground : Form
    {
        public startGameBackground()
        {
            InitializeComponent();
            startGameGO.Visible = false;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.FlatAppearance.MouseOverBackColor = Color.Green;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            SoundPlayer player = new SoundPlayer(Properties.Resources.countdown);
            player.Play();
            countdownTimer.Text = "time till launch 3 seconds";
           
            Refresh();
            Thread.Sleep(1000);

            countdownTimer.Text = "time till launch 2 seconds";

            Refresh();
            Thread.Sleep(1000);

            countdownTimer.Text = "time till launch 1 seconds";

            Refresh();
            Thread.Sleep(1000);
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.go);
            player2.Play();
            countdownTimer.Visible = false;
            startButton.BackColor = Color.Green;

            countdownTimer.BackColor = Color.Green;
         startGameGO.Visible = true;

        }

        private void countdownTimer_Click(object sender, EventArgs e)
        {

        }
    }
}
