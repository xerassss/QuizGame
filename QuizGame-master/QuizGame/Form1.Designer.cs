namespace QuizGame
{
    partial class diffWindow
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
            this.ezbtn = new System.Windows.Forms.Button();
            this.mdmbtn = new System.Windows.Forms.Button();
            this.hrdbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameOfPlayer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ezbtn
            // 
            this.ezbtn.BackColor = System.Drawing.Color.Silver;
            this.ezbtn.ForeColor = System.Drawing.Color.Black;
            this.ezbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ezbtn.Location = new System.Drawing.Point(165, 138);
            this.ezbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ezbtn.Name = "ezbtn";
            this.ezbtn.Size = new System.Drawing.Size(213, 68);
            this.ezbtn.TabIndex = 0;
            this.ezbtn.Text = "Easy";
            this.ezbtn.UseVisualStyleBackColor = false;
            this.ezbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // mdmbtn
            // 
            this.mdmbtn.BackColor = System.Drawing.Color.Silver;
            this.mdmbtn.ForeColor = System.Drawing.Color.Black;
            this.mdmbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mdmbtn.Location = new System.Drawing.Point(167, 245);
            this.mdmbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mdmbtn.Name = "mdmbtn";
            this.mdmbtn.Size = new System.Drawing.Size(213, 68);
            this.mdmbtn.TabIndex = 1;
            this.mdmbtn.Text = "Medium";
            this.mdmbtn.UseVisualStyleBackColor = false;
            this.mdmbtn.Click += new System.EventHandler(this.mdmbtn_Click);
            // 
            // hrdbtn
            // 
            this.hrdbtn.BackColor = System.Drawing.Color.Silver;
            this.hrdbtn.ForeColor = System.Drawing.Color.Black;
            this.hrdbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hrdbtn.Location = new System.Drawing.Point(167, 350);
            this.hrdbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hrdbtn.Name = "hrdbtn";
            this.hrdbtn.Size = new System.Drawing.Size(213, 68);
            this.hrdbtn.TabIndex = 2;
            this.hrdbtn.Text = "Hard";
            this.hrdbtn.UseVisualStyleBackColor = false;
            this.hrdbtn.Click += new System.EventHandler(this.hrdbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // txtNameOfPlayer
            // 
            this.txtNameOfPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameOfPlayer.Location = new System.Drawing.Point(151, 57);
            this.txtNameOfPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameOfPlayer.Name = "txtNameOfPlayer";
            this.txtNameOfPlayer.Size = new System.Drawing.Size(247, 38);
            this.txtNameOfPlayer.TabIndex = 4;
            this.txtNameOfPlayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameOfPlayer_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // diffWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNameOfPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hrdbtn);
            this.Controls.Add(this.mdmbtn);
            this.Controls.Add(this.ezbtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "diffWindow";
            this.Text = "Difficulty";
            this.Load += new System.EventHandler(this.diffWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ezbtn;
        private System.Windows.Forms.Button mdmbtn;
        private System.Windows.Forms.Button hrdbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameOfPlayer;
        private System.Windows.Forms.Button button1;
    }
}

