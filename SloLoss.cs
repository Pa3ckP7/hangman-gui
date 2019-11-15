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
    public partial class SloLoss : Form
    {
        public SloLoss(String str)
        {
            InitializeComponent();
            WordText.Text = str;
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
            SloSolo ss = new SloSolo();
            ss.Show();
            Close();
        }
    }
}
