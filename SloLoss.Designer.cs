namespace Hangman_gui
{
    partial class SloLoss
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuitModeButton = new System.Windows.Forms.Button();
            this.QuitApplicationButton = new System.Windows.Forms.Button();
            this.RematchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WordText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Word was:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(75, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 42);
            this.label2.TabIndex = 15;
            this.label2.Text = "Warning: Button quits the entire application including the still open menu";
            // 
            // QuitModeButton
            // 
            this.QuitModeButton.Location = new System.Drawing.Point(78, 283);
            this.QuitModeButton.Name = "QuitModeButton";
            this.QuitModeButton.Size = new System.Drawing.Size(155, 53);
            this.QuitModeButton.TabIndex = 14;
            this.QuitModeButton.Text = "Quit Game";
            this.QuitModeButton.UseVisualStyleBackColor = true;
            this.QuitModeButton.Click += new System.EventHandler(this.QuitModeButton_Click);
            // 
            // QuitApplicationButton
            // 
            this.QuitApplicationButton.Location = new System.Drawing.Point(78, 342);
            this.QuitApplicationButton.Name = "QuitApplicationButton";
            this.QuitApplicationButton.Size = new System.Drawing.Size(155, 53);
            this.QuitApplicationButton.TabIndex = 13;
            this.QuitApplicationButton.Text = "Quit Application";
            this.QuitApplicationButton.UseVisualStyleBackColor = true;
            this.QuitApplicationButton.Click += new System.EventHandler(this.QuitApplicationButton_Click);
            // 
            // RematchButton
            // 
            this.RematchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RematchButton.Location = new System.Drawing.Point(78, 224);
            this.RematchButton.Name = "RematchButton";
            this.RematchButton.Size = new System.Drawing.Size(155, 53);
            this.RematchButton.TabIndex = 12;
            this.RematchButton.Text = "Rematch";
            this.RematchButton.UseVisualStyleBackColor = true;
            this.RematchButton.Click += new System.EventHandler(this.RematchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(71, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "You Lose";
            // 
            // WordText
            // 
            this.WordText.AutoSize = true;
            this.WordText.BackColor = System.Drawing.Color.Transparent;
            this.WordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WordText.Location = new System.Drawing.Point(126, 77);
            this.WordText.Name = "WordText";
            this.WordText.Size = new System.Drawing.Size(55, 24);
            this.WordText.TabIndex = 17;
            this.WordText.Text = "         ";
            // 
            // SloLoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 450);
            this.Controls.Add(this.WordText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuitModeButton);
            this.Controls.Add(this.QuitApplicationButton);
            this.Controls.Add(this.RematchButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(323, 489);
            this.MinimumSize = new System.Drawing.Size(323, 489);
            this.Name = "SloLoss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SloLoss";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button QuitModeButton;
        private System.Windows.Forms.Button QuitApplicationButton;
        private System.Windows.Forms.Button RematchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WordText;
    }
}