namespace Hangman_gui
{
    partial class EngSolo
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
            this.HiddenWord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LivesText = new System.Windows.Forms.Label();
            this.GuessTextBox = new System.Windows.Forms.TextBox();
            this.SendGuessButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.WrongLettersText = new System.Windows.Forms.Label();
            this.hangedman = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hangedman)).BeginInit();
            this.SuspendLayout();
            // 
            // HiddenWord
            // 
            this.HiddenWord.AutoSize = true;
            this.HiddenWord.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HiddenWord.Location = new System.Drawing.Point(211, 9);
            this.HiddenWord.Name = "HiddenWord";
            this.HiddenWord.Size = new System.Drawing.Size(119, 40);
            this.HiddenWord.TabIndex = 14;
            this.HiddenWord.Text = "******";
            this.HiddenWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Lives Left:";
            // 
            // LivesText
            // 
            this.LivesText.AutoSize = true;
            this.LivesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LivesText.Location = new System.Drawing.Point(125, 388);
            this.LivesText.Name = "LivesText";
            this.LivesText.Size = new System.Drawing.Size(36, 25);
            this.LivesText.TabIndex = 16;
            this.LivesText.Text = "10";
            // 
            // GuessTextBox
            // 
            this.GuessTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GuessTextBox.Location = new System.Drawing.Point(12, 427);
            this.GuessTextBox.Name = "GuessTextBox";
            this.GuessTextBox.Size = new System.Drawing.Size(405, 26);
            this.GuessTextBox.TabIndex = 17;
            // 
            // SendGuessButton
            // 
            this.SendGuessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SendGuessButton.Location = new System.Drawing.Point(438, 427);
            this.SendGuessButton.Name = "SendGuessButton";
            this.SendGuessButton.Size = new System.Drawing.Size(91, 26);
            this.SendGuessButton.TabIndex = 18;
            this.SendGuessButton.Text = "Send";
            this.SendGuessButton.UseVisualStyleBackColor = true;
            this.SendGuessButton.Click += new System.EventHandler(this.SendGuessButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.Location = new System.Drawing.Point(7, 49);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(146, 25);
            this.label.TabIndex = 19;
            this.label.Text = "Wrong letters:";
            // 
            // WrongLettersText
            // 
            this.WrongLettersText.AutoSize = true;
            this.WrongLettersText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WrongLettersText.Location = new System.Drawing.Point(162, 52);
            this.WrongLettersText.Name = "WrongLettersText";
            this.WrongLettersText.Size = new System.Drawing.Size(96, 25);
            this.WrongLettersText.TabIndex = 20;
            this.WrongLettersText.Text = "              ";
            // 
            // hangedman
            // 
            this.hangedman.Location = new System.Drawing.Point(130, 97);
            this.hangedman.Name = "hangedman";
            this.hangedman.Size = new System.Drawing.Size(275, 275);
            this.hangedman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hangedman.TabIndex = 21;
            this.hangedman.TabStop = false;
            // 
            // EngSolo
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
            this.Name = "EngSolo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EngSolo";
            this.Load += new System.EventHandler(this.EngSolo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangedman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HiddenWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LivesText;
        private System.Windows.Forms.TextBox GuessTextBox;
        private System.Windows.Forms.Button SendGuessButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label WrongLettersText;
        private System.Windows.Forms.PictureBox hangedman;
    }
}