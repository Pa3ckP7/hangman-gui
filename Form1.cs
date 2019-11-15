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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Multyplayer_Click(object sender, EventArgs e)
        {
            WordPrompt2p wp2 =new WordPrompt2p();
            wp2.Show();
            
        }

        private void SoloSlovenian_Click(object sender, EventArgs e)
        {
            SloSolo ss = new SloSolo();
            ss.Show();
        }

        private void SoloEnglish_Click(object sender, EventArgs e)
        {
            EngSolo es = new EngSolo();
            es.Show();
        }
    }
}
