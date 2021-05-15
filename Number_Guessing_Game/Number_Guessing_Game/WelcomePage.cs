using System;
using System.Windows.Forms;

namespace Number_Guessing_Game
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Play button method. Go to Game Information Page. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButton_Click(object sender, EventArgs e)
        {
            GamePage gamePage = new GamePage();
            gamePage.Show();
            this.Hide();
        }

        /// <summary>
        /// High scores button method. Go to High Scores Page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void highScoresButton_Click(object sender, EventArgs e)
        {
            HighScoresPage highScoresPage = new HighScoresPage();
            highScoresPage.Show();
            this.Hide();
        }

        /// <summary>
        /// Quit button method. Application exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitButton_Click(object sender, EventArgs e)
        {
            // The user wants to exit the application. Close everything down.
            Application.Exit();
        }
    }
}
