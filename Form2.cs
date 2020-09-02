using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hangman_gui
{
    public partial class Form2 : Form
    {
        GameMaster gm = new GameMaster();
        static string SecretWord;
        static int Lives;
        static bool P2Wins = false;
        Image[] states = new Image[10];
        public Form2(String str)
        {
            InitializeComponent();
            HiddenWord.Text=gm.EncryptWord(str);
            SecretWord = str.Trim().ToLower();
            Lives = 10;
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
                        MultyWin mv = new MultyWin();
                        mv.Show();
                        Close();
                    }
                    else 
                    {
                        MultyLose ml = new MultyLose(SecretWord);
                        ml.Show();
                        Close();
                        
                    }
                }
                else 
                {
                    if (gm.TestIfUsed(Convert.ToChar(GuessTextBox.Text)))
                    {
                        MessageBox.Show("You already tried that", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else 
                    {
                        if (gm.TestFor(SecretWord, HiddenWord.Text, Convert.ToChar(GuessTextBox.Text)))
                        {
                           HiddenWord.Text=gm.Unscramble(SecretWord, HiddenWord.Text, Convert.ToChar(GuessTextBox.Text));
                        }
                        else 
                        {
                            Lives--;
                            LivesText.Text=Lives.ToString();
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
            string wrongletters="";
            foreach (char c in gm.wrong_letters) 
            {
                wrongletters += c;
            }
            WrongLettersText.Text = wrongletters;
            if (Lives == 0)
            {
                MultyLose ml = new MultyLose(SecretWord);
                ml.Show();
                Close();
            }
            else if (P2Wins == true) 
            {
                MultyWin mv = new MultyWin();
                mv.Show();
                P2Wins = false;
                Close();
            }
            
        }
    }
}
