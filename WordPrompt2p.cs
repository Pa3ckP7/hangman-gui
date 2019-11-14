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
    public partial class WordPrompt2p : Form
    {
        public WordPrompt2p()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            if (WordToHide.Text.Trim().Length != 0)
            {
                Form2 form2 = new Form2(WordToHide.Text.Trim());
                form2.Show();
                this.Close();
            }
        }
    }
}
