namespace Hangman_gui
{
    partial class SloSolo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WrongLettersText = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.SendGuessButton = new System.Windows.Forms.Button();
            this.GuessTextBox = new System.Windows.Forms.TextBox();
            this.LivesText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HiddenWord = new System.Windows.Forms.Label();
            this.hangedman = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hangedman)).BeginInit();
            this.SuspendLayout();
            // 
            // WrongLettersText
            // 
            this.WrongLettersText.AutoSize = true;
            this.WrongLettersText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WrongLettersText.Location = new System.Drawing.Point(150, 49);
            this.WrongLettersText.Name = "WrongLettersText";
            this.WrongLettersText.Size = new System.Drawing.Size(96, 25);
            this.WrongLettersText.TabIndex = 13;
            this.WrongLettersText.Text = "              ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.Location = new System.Drawing.Point(7, 49);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(146, 25);
            this.label.TabIndex = 12;
            this.label.Text = "Wrong letters:";
            // 
            // SendGuessButton
            // 
            this.SendGuessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SendGuessButton.Location = new System.Drawing.Point(438, 427);
            this.SendGuessButton.Name = "SendGuessButton";
            this.SendGuessButton.Size = new System.Drawing.Size(91, 26);
            this.SendGuessButton.TabIndex = 11;
            this.SendGuessButton.Text = "Send";
            this.SendGuessButton.UseVisualStyleBackColor = true;
            this.SendGuessButton.Click += new System.EventHandler(this.SendGuessButton_Click);
            // 
            // GuessTextBox
            // 
            this.GuessTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GuessTextBox.Location = new System.Drawing.Point(12, 427);
            this.GuessTextBox.Name = "GuessTextBox";
            this.GuessTextBox.Size = new System.Drawing.Size(405, 26);
            this.GuessTextBox.TabIndex = 10;
            // 
            // LivesText
            // 
            this.LivesText.AutoSize = true;
            this.LivesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LivesText.Location = new System.Drawing.Point(125, 388);
            this.LivesText.Name = "LivesText";
            this.LivesText.Size = new System.Drawing.Size(36, 25);
            this.LivesText.TabIndex = 9;
            this.LivesText.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lives Left:";
            // 
            // HiddenWord
            // 
            this.HiddenWord.AutoSize = true;
            this.HiddenWord.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HiddenWord.Location = new System.Drawing.Point(211, 9);
            this.HiddenWord.Name = "HiddenWord";
            this.HiddenWord.Size = new System.Drawing.Size(119, 40);
            this.HiddenWord.TabIndex = 7;
            this.HiddenWord.Text = "******";
            this.HiddenWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hangedman
            // 
            this.hangedman.Location = new System.Drawing.Point(130, 99);
            this.hangedman.Name = "hangedman";
            this.hangedman.Size = new System.Drawing.Size(275, 275);
            this.hangedman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hangedman.TabIndex = 14;
            this.hangedman.TabStop = false;
            // 
            // SloSolo
            // 
            this.AcceptButton = this.SendGuessButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 518);
            this.Controls.Add(this.hangedman);
            this.Controls.Add(this.WrongLettersText);
            this.Controls.Add(this.label);
            this.Controls.Add(this.SendGuessButton);
            this.Controls.Add(this.GuessTextBox);
            this.Controls.Add(this.LivesText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HiddenWord);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(557, 557);
            this.MinimumSize = new System.Drawing.Size(557, 557);
            this.Name = "SloSolo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solo Play Slovenian";
            this.Load += new System.EventHandler(this.SloSolo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangedman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WrongLettersText;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button SendGuessButton;
        private System.Windows.Forms.TextBox GuessTextBox;
        private System.Windows.Forms.Label LivesText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HiddenWord;
        private System.Windows.Forms.PictureBox hangedman;
    }
}