using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Number_Guessing_Game
{
    public partial class GamePage : Form
    {
        // This string contains player name and player score database path.
        string scoreBoardTxtPath = @"..\..\scoreBoard.txt";
        // This integer array contains searched number.
        private int[] _searchedNumber;
        // This integer array contains guessed number.
        private int[] _guessNumber;
        // This integer checks whether the correct number has been entered.
        private int _control;
        // This integer contains remaining time.
        private int _counter;

        public GamePage()
        {
            InitializeComponent();
        }

        #region Public Methods.

        /// <summary>
        /// This method is reset game area.
        /// </summary>
        public void ResetGameArea()
        {
            enterGameInformationGroupBox.Enabled = true;
            startButton.Enabled = true;
            playerNameLabel.Text = "";
            scoreLabel.Text = "";
            timeLabel.Text = "";
            livesLabel.Text = "";
        }

        /// <summary>
        /// This method is compare to searched number and guessed number. 
        /// New labels write to screen. 
        /// if correct number has been entered return true. else return false.   
        /// </summary>
        /// <returns></returns>
        public bool CompareSearchedAndGuessed()
        {
            // Clears labels on the screen
            flowLayoutPanel.Controls.Clear();
            // Has the new tag been written to the screen?
            bool labelControl;


            for (int i = 0; i < _guessNumber.Length; i++)
            {
                labelControl = false;

                for (int j = 0; j < _searchedNumber.Length; j++)
                {

                    if (_guessNumber[i] == _searchedNumber[j])
                    {
                        if (i == j && labelControl == false)
                        {
                            Label newLabel1 = new Label();
                            newLabel1.Text = "-";
                            newLabel1.Font = new Font(newLabel1.Font.Name, 35);
                            newLabel1.AutoSize = true;
                            newLabel1.BackColor = Color.Green;
                            flowLayoutPanel.Controls.Add(newLabel1);
                            labelControl = true;
                            scoreLabel.Text = (Convert.ToInt32(scoreLabel.Text) + 10).ToString();
                            _control++;
                        }
                        else if (labelControl == false)
                        {
                            Label newLabel1 = new Label();
                            newLabel1.Text = "-";
                            newLabel1.Font = new Font(newLabel1.Font.Name, 35);
                            newLabel1.AutoSize = true;
                            newLabel1.BackColor = Color.Red;
                            flowLayoutPanel.Controls.Add(newLabel1);
                            labelControl = true;
                            scoreLabel.Text = (Convert.ToInt32(scoreLabel.Text) + 5).ToString();
                        }
                    }

                }

                if (labelControl == false)
                {
                    Label newLabel = new Label();
                    newLabel.Text = "-";
                    newLabel.Font = new Font(newLabel.Font.Name, 35);
                    newLabel.AutoSize = true;
                    newLabel.BackColor = Color.White;
                    flowLayoutPanel.Controls.Add(newLabel);
                }

            }

            // if correct number has been entered return true. else return false.
            if (_control == _searchedNumber.Length)
            {
                return true;
            }
            else
            {
                _control = 0;
                return false;
            }
        }

        /// <summary>
        /// This method is divides the guessed number by guess number array.
        /// </summary>
        public void WriteToString()
        {
            _guessNumber = new int[Convert.ToInt32(numberOfDigitsNumericUpDown.Value)];

            int a = Convert.ToInt32(guessNumericUpDown.Value);

            for (int i = Convert.ToInt32(numberOfDigitsNumericUpDown.Value) - 1; i >= 0; i--)
            {
                _guessNumber[i] = a % 10;
                a = a / 10;
            }

        }

        /// <summary>
        /// This method is takes the digit and prints the required number of labels to the screen.
        /// </summary>
        /// <param name="digit"></param>
        public void CreateLabels(int digit)
        {
            // Clears labels on the screen.
            flowLayoutPanel.Controls.Clear();

            for (int i = 1; i <= digit; i++)
            {
                Label newLabel = new Label();
                newLabel.Text = "-";
                newLabel.Font = new Font(newLabel.Font.Name, 35);
                newLabel.AutoSize = true;
                newLabel.BackColor = Color.White;
                flowLayoutPanel.Controls.Add(newLabel);
            }

        }

        /// <summary>
        /// This method checks the accuracy of player information.
        /// if entered correctly return true. else return false. 
        /// </summary>
        /// <returns></returns>
        public bool CheckedPlayerInformation()
        {
            if (playerNameTextBox.Text == "")
            {
                MessageBox.Show("Lütfen adınızı giriniz.");
                return false;
            }
            else if (numberOfLivesNumericUpDown.Value == 0)
            {
                MessageBox.Show("Lütfen hak sayısı belirtiniz.");
                return false;
            }
            else if (numberOfDigitsNumericUpDown.Value == 0)
            {
                MessageBox.Show("Lütfen basamak sayısı belirtiniz.");
                return false;
            }
            else if (repeatingNumberNoRadioButton.Checked == false && repeatingNumberYesRadioButton.Checked == false)
            {
                MessageBox.Show("Lütfen tekrar eden rakam olacak mı bilgisini işaretleyin.");
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// This method is takes the digit and create random repeatable number. 
        /// </summary>
        /// <param name="digit"></param>
        public void RepeatingRandomNumberCreate(int digit)
        {

            Random random = new Random();

            _searchedNumber = new int[digit];

            for (int i = 0; i < digit; i++)
            {
                if (i == 0)
                {

                    _searchedNumber[i] = random.Next(1, 10);
                }
                else
                {
                    _searchedNumber[i] = random.Next(0, 10);
                }
            }
        }

        /// <summary>
        /// This method is takes the digit and create random not repeatable number.
        /// </summary>
        /// <param name="digit"></param>
        public void NotRepeatingRandomNumberCreate(int digit)
        {
            Random random = new Random();
            _searchedNumber = new int[digit];

            for (int i = 0; i < digit; i++)
            {
                if (i == 0)
                {
                    _searchedNumber[i] = random.Next(1, 10);
                }
                else
                {
                    _searchedNumber[i] = random.Next(0, 10);

                    for (int k = i - 1; k >= 0; k--)
                    {
                        if (_searchedNumber[i] == _searchedNumber[k])
                        {
                            _searchedNumber[i] = random.Next(0, 10);
                            k = i - 1;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }

        }

        #endregion

        #region Button methods.

        /// <summary>
        /// This method is Checked player information.
        /// Game information write to screen.
        /// prints the required number of labels to the screen.
        /// Create random number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startButton_Click(object sender, EventArgs e)
        {
            if (CheckedPlayerInformation() == true)
            {
                #region Game Information write to screen.

                playerNameLabel.Text = playerNameTextBox.Text;

                _counter = (Convert.ToInt32(numberOfLivesNumericUpDown.Value) * 10);
                timeLabel.Text = _counter.ToString();
                timer.Start();

                livesLabel.Text = numberOfLivesNumericUpDown.Value.ToString();

                guessNumericUpDown.Minimum = Convert.ToInt32(Math.Pow(10, Convert.ToDouble(Convert.ToInt32(numberOfDigitsNumericUpDown.Value) - 1)));
                guessNumericUpDown.Maximum = Convert.ToInt32(Math.Pow(10, Convert.ToDouble(numberOfDigitsNumericUpDown.Value)) - 1);

                enterGameInformationGroupBox.Enabled = false;
                startButton.Enabled = false;

                #endregion

                CreateLabels(Convert.ToInt32(numberOfDigitsNumericUpDown.Value));
                guessButton.Enabled = true;

                if (repeatingNumberYesRadioButton.Checked == true)
                {
                    RepeatingRandomNumberCreate(Convert.ToInt32(numberOfDigitsNumericUpDown.Value));
                }
                else if (repeatingNumberNoRadioButton.Checked == true)
                {
                    NotRepeatingRandomNumberCreate(Convert.ToInt32(numberOfDigitsNumericUpDown.Value));
                }


                /*
                // searched number print to screen.
                for(int i=0; i<_searchedNumber.Length; i++)
                {
                    MessageBox.Show(_searchedNumber[i].ToString());
                }
                */

            }

        }

        /// <summary>
        /// This method is divides the guessed number by guess number array.
        /// Compare searceh number and guessed number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guessButton_Click(object sender, EventArgs e)
        {
            WriteToString();

            // if the number guessed by the player is correct
            if (CompareSearchedAndGuessed() == true)
            {
                guessButton.Enabled = false;

                scoreLabel.Text = (Convert.ToInt32(scoreLabel.Text) + (Convert.ToInt32(livesLabel.Text) * 20)).ToString();

                // Write to databese. 
                File.AppendAllText(scoreBoardTxtPath, "\n" + playerNameLabel.Text + "#" + scoreLabel.Text, Encoding.UTF8);
                MessageBox.Show("Tebrikler bildiniz!!!\nPuanınız kaydedildi.");
            }
            else
            {
                livesLabel.Text = (Convert.ToInt32(livesLabel.Text) - 1).ToString();

                if (livesLabel.Text == "0")
                {
                    timer.Stop();
                    MessageBox.Show("Hakkınız bitti\nMaalesef bilemediniz!\nYeni oyuna başla");
                    guessButton.Enabled = false;
                    ResetGameArea();
                }
            }
        }

        /// <summary>
        /// Back button method. Go to Welcome Page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            welcomePage.Show();
            this.Hide();
        }

        #endregion

        private void timer_Tick(object sender, EventArgs e)
        {
            _counter--;

            if (_counter == 0)
            {
                timeLabel.Text = _counter.ToString();
                timer.Stop();
                guessButton.Enabled = false;
                MessageBox.Show("Süre bitti\nKaybettin.\nYeni oyuna başla");
                ResetGameArea();
            }
            else
            {
                timeLabel.Text = _counter.ToString();
            }
        }

    }
}
