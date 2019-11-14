namespace Hangman_gui
{
    partial class WordPrompt2p
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
            this.PromptTextLabel = new System.Windows.Forms.Label();
            this.WordToHide = new System.Windows.Forms.TextBox();
            this.HintLabel = new System.Windows.Forms.Label();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PromptTextLabel
            // 
            this.PromptTextLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PromptTextLabel.AutoSize = true;
            this.PromptTextLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PromptTextLabel.Location = new System.Drawing.Point(105, 29);
            this.PromptTextLabel.Name = "PromptTextLabel";
            this.PromptTextLabel.Size = new System.Drawing.Size(330, 36);
            this.PromptTextLabel.TabIndex = 0;
            this.PromptTextLabel.Text = "Player 1 enter your word";
            // 
            // WordToHide
            // 
            this.WordToHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WordToHide.Location = new System.Drawing.Point(111, 97);
            this.WordToHide.Name = "WordToHide";
            this.WordToHide.Size = new System.Drawing.Size(324, 26);
            this.WordToHide.TabIndex = 1;
            // 
            // HintLabel
            // 
            this.HintLabel.AutoSize = true;
            this.HintLabel.Location = new System.Drawing.Point(108, 126);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(309, 13);
            this.HintLabel.TabIndex = 2;
            this.HintLabel.Text = "Hint: You can add multiple words by leaving a space in between";
            // 
            // ButtonOk
            // 
            this.ButtonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonOk.Location = new System.Drawing.Point(111, 157);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(96, 32);
            this.ButtonOk.TabIndex = 3;
            this.ButtonOk.Text = "Ok";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonCancel.Location = new System.Drawing.Point(300, 157);
            this.ButtonCancel.MaximumSize = new System.Drawing.Size(96, 32);
            this.ButtonCancel.MinimumSize = new System.Drawing.Size(96, 32);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(96, 32);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // WordPrompt2p
            // 
            this.AcceptButton = this.ButtonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 215);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.HintLabel);
            this.Controls.Add(this.WordToHide);
            this.Controls.Add(this.PromptTextLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(555, 254);
            this.MinimumSize = new System.Drawing.Size(555, 254);
            this.Name = "WordPrompt2p";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordPrompt2p";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PromptTextLabel;
        private System.Windows.Forms.TextBox WordToHide;
        private System.Windows.Forms.Label HintLabel;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonCancel;
    }
}