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
    public partial class MultyLose : Form
    {
        public MultyLose(String word)
        {
            InitializeComponent();
            CorrectWordText.Text = word;
        }

        private void QuitApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void QuitModeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RematchButton_Click(object sender, EventArgs e)
        {
            WordPrompt2p wp2 = new WordPrompt2p();
            wp2.Show();
            Close();
        }
    }
}
