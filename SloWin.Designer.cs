namespace Hangman_gui
{
    partial class SloWin
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
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(72, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "Warning: Button quits the entire application including the still open menu";
            // 
            // QuitModeButton
            // 
            this.QuitModeButton.Location = new System.Drawing.Point(75, 282);
            this.QuitModeButton.Name = "QuitModeButton";
            this.QuitModeButton.Size = new System.Drawing.Size(155, 53);
            this.QuitModeButton.TabIndex = 8;
            this.QuitModeButton.Text = "Quit Game";
            this.QuitModeButton.UseVisualStyleBackColor = true;
            this.QuitModeButton.Click += new System.EventHandler(this.QuitModeButton_Click);
            // 
            // QuitApplicationButton
            // 
            this.QuitApplicationButton.Location = new System.Drawing.Point(75, 341);
            this.QuitApplicationButton.Name = "QuitApplicationButton";
            this.QuitApplicationButton.Size = new System.Drawing.Size(155, 53);
            this.QuitApplicationButton.TabIndex = 7;
            this.QuitApplicationButton.Text = "Quit Application";
            this.QuitApplicationButton.UseVisualStyleBackColor = true;
            this.QuitApplicationButton.Click += new System.EventHandler(this.QuitApplicationButton_Click);
            // 
            // RematchButton
            // 
            this.RematchButton.Location = new System.Drawing.Point(75, 223);
            this.RematchButton.Name = "RematchButton";
            this.RematchButton.Size = new System.Drawing.Size(155, 53);
            this.RematchButton.TabIndex = 6;
            this.RematchButton.Text = "Rematch";
            this.RematchButton.UseVisualStyleBackColor = true;
            this.RematchButton.Click += new System.EventHandler(this.RematchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(68, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "You Win";
            // 
            // SloWin
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
            this.Name = "SloWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SloWin";
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