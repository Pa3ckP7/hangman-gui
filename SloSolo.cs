using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_gui
{
    public partial class SloSolo : Form
    {
        SloGameMasterSolo solo = new SloGameMasterSolo();
        string SecretWord;
        int Lives = 10;
        bool P2Wins = false;
        
        public SloSolo()
        {
            InitializeComponent();
        }

        private void SloSolo_Load(object sender, EventArgs e)
        {
            SecretWord = solo.RandomWord();
            HiddenWord.Text = solo.Encrypt(SecretWord);
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
