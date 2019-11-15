namespace Hangman_gui
{
    partial class Form1
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
            this.MainName = new System.Windows.Forms.Label();
            this.Creator = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.QuitButton = new System.Windows.Forms.Button();
            this.Multyplayer = new System.Windows.Forms.Button();
            this.SoloEnglish = new System.Windows.Forms.Button();
            this.SoloSlovenian = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainName
            // 
            this.MainName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainName.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainName.Location = new System.Drawing.Point(53, 74);
            this.MainName.Name = "MainName";
            this.MainName.Size = new System.Drawing.Size(305, 85);
            this.MainName.TabIndex = 0;
            this.MainName.Text = "Hangman";
            this.MainName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Creator
            // 
            this.Creator.AutoSize = true;
            this.Creator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Creator.Location = new System.Drawing.Point(325, 523);
            this.Creator.Name = "Creator";
            this.Creator.Size = new System.Drawing.Size(92, 20);
            this.Creator.TabIndex = 1;
            this.Creator.Text = "by Pa3ckP7";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.QuitButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Multyplayer, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SoloEnglish, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SoloSlovenian, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(113, 201);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 255);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // QuitButton
            // 
            this.QuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuitButton.Location = new System.Drawing.Point(3, 192);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(194, 60);
            this.QuitButton.TabIndex = 3;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // Multyplayer
            // 
            this.Multyplayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Multyplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Multyplayer.Location = new System.Drawing.Point(3, 129);
            this.Multyplayer.Name = "Multyplayer";
            this.Multyplayer.Size = new System.Drawing.Size(194, 57);
            this.Multyplayer.TabIndex = 2;
            this.Multyplayer.Text = "2 Players";
            this.Multyplayer.UseVisualStyleBackColor = true;
            this.Multyplayer.Click += new System.EventHandler(this.Multyplayer_Click);
            // 
            // SoloEnglish
            // 
            this.SoloEnglish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoloEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SoloEnglish.Location = new System.Drawing.Point(3, 66);
            this.SoloEnglish.Name = "SoloEnglish";
            this.SoloEnglish.Size = new System.Drawing.Size(194, 57);
            this.SoloEnglish.TabIndex = 1;
            this.SoloEnglish.Text = "Solo Play English";
            this.SoloEnglish.UseVisualStyleBackColor = true;
            this.SoloEnglish.Click += new System.EventHandler(this.SoloEnglish_Click);
            // 
            // SoloSlovenian
            // 
            this.SoloSlovenian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoloSlovenian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SoloSlovenian.Location = new System.Drawing.Point(3, 3);
            this.SoloSlovenian.Name = "SoloSlovenian";
            this.SoloSlovenian.Size = new System.Drawing.Size(194, 57);
            this.SoloSlovenian.TabIndex = 0;
            this.SoloSlovenian.Text = "Solo Play Slovenian";
            this.SoloSlovenian.UseVisualStyleBackColor = true;
            this.SoloSlovenian.Click += new System.EventHandler(this.SoloSlovenian_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Creator);
            this.Controls.Add(this.MainName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(445, 600);
            this.MinimumSize = new System.Drawing.Size(445, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainName;
        private System.Windows.Forms.Label Creator;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button Multyplayer;
        private System.Windows.Forms.Button SoloEnglish;
        private System.Windows.Forms.Button SoloSlovenian;
    }
}

