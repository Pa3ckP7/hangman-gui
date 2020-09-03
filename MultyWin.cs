﻿using System;
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
    public partial class MultyWin : Form
    {
        public MultyWin()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("assets/bgs/solowin.png");
        }

        private void RematchButton_Click(object sender, EventArgs e)
        {
            WordPrompt2p wp2 = new WordPrompt2p();
            wp2.Show();
            Close();
        }

        private void QuitModeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuitApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
