using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hangman_gui
{
    public partial class SloSolo : Form
    {
        SloGameMasterSolo solo = new SloGameMasterSolo();
        string SecretWord;
        int Lives = 10;
        bool P2Wins = false;
        Image[] states = new Image[10];

        public SloSolo()
        {
            InitializeComponent();
        }

        private void SloSolo_Load(object sender, EventArgs e)
        {
            SecretWord = solo.RandomWord();
            HiddenWord.Text = solo.Encrypt(SecretWord);
            hangedman.Image = Image.FromFile(@"assets/stage/default.png");
            Load_states();
        }

        private void Load_states()
        {
            for (int i = 0; i < 10; i++)
            {
                string stateLocation = $@"assets/stage/Stage{i}.png";
                Image state = Image.FromFile(stateLocation);
                states[i] = (Image)state;
            }
        }

        private void SendGuessButton_Click(object sender, EventArgs e)
        {
            GuessTextBox.Text.Trim().ToLower();
            if (GuessTextBox.Text.Length != 0)
            {
                if (GuessTextBox.Text.Length > 1)
                {
                    if (SecretWord.Equals(GuessTextBox.Text))
                    {
                        SloWin sv = new SloWin();
                        sv.Show();
                        Close();
                    }
                    else
                    {
                        SloLoss sl = new SloLoss(SecretWord);
                        sl.Show();
                        Close();

                    }
                }
                else
                {
                    if (solo.TestIfUsed(Convert.ToChar(GuessTextBox.Text)))
                    {
                        MessageBox.Show("You already tried that", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (solo.TestFor(SecretWord, HiddenWord.Text, Convert.ToChar(GuessTextBox.Text)))
                        {
                            HiddenWord.Text = solo.Unscramble(SecretWord, HiddenWord.Text, Convert.ToChar(GuessTextBox.Text));
                        }
                        else
                        {
                            Lives--;
                            LivesText.Text = Lives.ToString();
                            hangedman.Image = states[Lives];
                        }
                    }
                }

            }
            if (HiddenWord.Text.Equals(SecretWord))
            {
                P2Wins = true;
            }
            GuessTextBox.Text = "";
            string wrongletters = "";
            foreach (char c in solo.wrong_letters)
            {
                wrongletters += c;
            }
            WrongLettersText.Text = wrongletters;
            if (Lives == 0)
            {
                SloLoss sl = new SloLoss(SecretWord);
                sl.Show();
                Close();
            }
            else if (P2Wins == true)
            {
                SloWin sv = new SloWin();
                sv.Show();
                P2Wins = false;
                Close();
            }
        }
    }
}
