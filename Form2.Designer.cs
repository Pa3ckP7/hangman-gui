namespace Hangman_gui
{
    partial class Form2
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
            this.SuspendLayout();
            // 
            // HiddenWord
            // 
            this.HiddenWord.AutoSize = true;
            this.HiddenWord.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HiddenWord.Location = new System.Drawing.Point(96, 89);
            this.HiddenWord.Name = "HiddenWord";
            this.HiddenWord.Size = new System.Drawing.Size(119, 40);
            this.HiddenWord.TabIndex = 0;
            this.HiddenWord.Text = "******";
            this.HiddenWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(101, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lives Left:";
            // 
            // LivesText
            // 
            this.LivesText.AutoSize = true;
            this.LivesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LivesText.Location = new System.Drawing.Point(211, 202);
            this.LivesText.Name = "LivesText";
            this.LivesText.Size = new System.Drawing.Size(36, 25);
            this.LivesText.TabIndex = 2;
            this.LivesText.Text = "10";
            // 
            // GuessTextBox
            // 
            this.GuessTextBox.Location = new System.Drawing.Point(12, 270);
            this.GuessTextBox.Name = "GuessTextBox";
            this.GuessTextBox.Size = new System.Drawing.Size(405, 20);
            this.GuessTextBox.TabIndex = 3;
            // 
            // SendGuessButton
            // 
            this.SendGuessButton.Location = new System.Drawing.Point(438, 270);
            this.SendGuessButton.Name = "SendGuessButton";
            this.SendGuessButton.Size = new System.Drawing.Size(75, 23);
            this.SendGuessButton.TabIndex = 4;
            this.SendGuessButton.Text = "Send";
            this.SendGuessButton.UseVisualStyleBackColor = true;
            this.SendGuessButton.Click += new System.EventHandler(this.SendGuessButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.Location = new System.Drawing.Point(101, 177);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(146, 25);
            this.label.TabIndex = 5;
            this.label.Text = "Wrong letters:";
            // 
            // WrongLettersText
            // 
            this.WrongLettersText.AutoSize = true;
            this.WrongLettersText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WrongLettersText.Location = new System.Drawing.Point(253, 177);
            this.WrongLettersText.Name = "WrongLettersText";
            this.WrongLettersText.Size = new System.Drawing.Size(0, 25);
            this.WrongLettersText.TabIndex = 6;
            // 
            // Form2
            // 
            this.AcceptButton = this.SendGuessButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 318);
            this.Controls.Add(this.WrongLettersText);
            this.Controls.Add(this.label);
            this.Controls.Add(this.SendGuessButton);
            this.Controls.Add(this.GuessTextBox);
            this.Controls.Add(this.LivesText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HiddenWord);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(557, 357);
            this.MinimumSize = new System.Drawing.Size(557, 357);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman 2 players";
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
    }
}