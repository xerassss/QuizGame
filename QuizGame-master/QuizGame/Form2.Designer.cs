namespace QuizGame
{
    partial class frmLobby
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
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.btnLobbyPlay = new System.Windows.Forms.Button();
            this.btnLobbyStats = new System.Windows.Forms.Button();
            this.btnLobbyExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGameTitle.Location = new System.Drawing.Point(58, 25);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(380, 67);
            this.lblGameTitle.TabIndex = 0;
            this.lblGameTitle.Text = "Untitled Quiz Game";
            this.lblGameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLobbyPlay
            // 
            this.btnLobbyPlay.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLobbyPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLobbyPlay.Location = new System.Drawing.Point(164, 165);
            this.btnLobbyPlay.Name = "btnLobbyPlay";
            this.btnLobbyPlay.Size = new System.Drawing.Size(155, 66);
            this.btnLobbyPlay.TabIndex = 1;
            this.btnLobbyPlay.Text = "Play";
            this.btnLobbyPlay.UseVisualStyleBackColor = false;
            this.btnLobbyPlay.Click += new System.EventHandler(this.btnLobbyPlay_Click);
            // 
            // btnLobbyStats
            // 
            this.btnLobbyStats.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLobbyStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLobbyStats.Location = new System.Drawing.Point(164, 256);
            this.btnLobbyStats.Name = "btnLobbyStats";
            this.btnLobbyStats.Size = new System.Drawing.Size(155, 66);
            this.btnLobbyStats.TabIndex = 2;
            this.btnLobbyStats.Text = "Stats";
            this.btnLobbyStats.UseVisualStyleBackColor = false;
            this.btnLobbyStats.Click += new System.EventHandler(this.btnLobbyStats_Click);
            // 
            // btnLobbyExit
            // 
            this.btnLobbyExit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLobbyExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLobbyExit.Location = new System.Drawing.Point(164, 343);
            this.btnLobbyExit.Name = "btnLobbyExit";
            this.btnLobbyExit.Size = new System.Drawing.Size(155, 66);
            this.btnLobbyExit.TabIndex = 3;
            this.btnLobbyExit.Text = "Quit";
            this.btnLobbyExit.UseVisualStyleBackColor = false;
            this.btnLobbyExit.Click += new System.EventHandler(this.btnLobbyExit_Click);
            // 
            // frmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuizGame.Properties.Resources.test_bgpic;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.btnLobbyExit);
            this.Controls.Add(this.btnLobbyStats);
            this.Controls.Add(this.btnLobbyPlay);
            this.Controls.Add(this.lblGameTitle);
            this.Name = "frmLobby";
            this.Text = "frmLobby";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Button btnLobbyPlay;
        private System.Windows.Forms.Button btnLobbyStats;
        private System.Windows.Forms.Button btnLobbyExit;
    }
}