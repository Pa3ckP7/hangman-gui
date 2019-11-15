namespace Hangman_gui
{
    partial class EngWin
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
            this.label2 = new System.Windows.Forms.Label();
            this.QuitModeButton = new System.Windows.Forms.Button();
            this.QuitApplicationButton = new System.Windows.Forms.Button();
            this.RematchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(76, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 42);
            this.label2.TabIndex = 14;
            this.label2.Text = "Warning: Button quits the entire application including the still open menu";
            // 
            // QuitModeButton
            // 
            this.QuitModeButton.Location = new System.Drawing.Point(79, 239);
            this.QuitModeButton.Name = "QuitModeButton";
            this.QuitModeButton.Size = new System.Drawing.Size(155, 53);
            this.QuitModeButton.TabIndex = 13;
            this.QuitModeButton.Text = "Quit Game";
            this.QuitModeButton.UseVisualStyleBackColor = true;
            this.QuitModeButton.Click += new System.EventHandler(this.QuitModeButton_Click);
            // 
            // QuitApplicationButton
            // 
            this.QuitApplicationButton.Location = new System.Drawing.Point(79, 298);
            this.QuitApplicationButton.Name = "QuitApplicationButton";
            this.QuitApplicationButton.Size = new System.Drawing.Size(155, 53);
            this.QuitApplicationButton.TabIndex = 12;
            this.QuitApplicationButton.Text = "Quit Application";
            this.QuitApplicationButton.UseVisualStyleBackColor = true;
            this.QuitApplicationButton.Click += new System.EventHandler(this.QuitApplicationButton_Click);
            // 
            // RematchButton
            // 
            this.RematchButton.Location = new System.Drawing.Point(79, 180);
            this.RematchButton.Name = "RematchButton";
            this.RematchButton.Size = new System.Drawing.Size(155, 53);
            this.RematchButton.TabIndex = 11;
            this.RematchButton.Text = "Rematch";
            this.RematchButton.UseVisualStyleBackColor = true;
            this.RematchButton.Click += new System.EventHandler(this.RematchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(72, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "You Win";
            // 
            // EngWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuitModeButton);
            this.Controls.Add(this.QuitApplicationButton);
            this.Controls.Add(this.RematchButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(323, 489);
            this.MinimumSize = new System.Drawing.Size(323, 489);
            this.Name = "EngWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EngWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button QuitModeButton;
        private System.Windows.Forms.Button QuitApplicationButton;
        private System.Windows.Forms.Button RematchButton;
        private System.Windows.Forms.Label label1;
    }
}