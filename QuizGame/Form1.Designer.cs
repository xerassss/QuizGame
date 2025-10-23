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
            this.SuspendLayout();
            // 
            // ezbtn
            // 
            this.ezbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ezbtn.Location = new System.Drawing.Point(165, 75);
            this.ezbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ezbtn.Name = "ezbtn";
            this.ezbtn.Size = new System.Drawing.Size(213, 68);
            this.ezbtn.TabIndex = 0;
            this.ezbtn.Text = "Easy";
            this.ezbtn.UseVisualStyleBackColor = true;
            this.ezbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // mdmbtn
            // 
            this.mdmbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mdmbtn.Location = new System.Drawing.Point(167, 182);
            this.mdmbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mdmbtn.Name = "mdmbtn";
            this.mdmbtn.Size = new System.Drawing.Size(213, 68);
            this.mdmbtn.TabIndex = 1;
            this.mdmbtn.Text = "Medium";
            this.mdmbtn.UseVisualStyleBackColor = true;
            this.mdmbtn.Click += new System.EventHandler(this.mdmbtn_Click);
            // 
            // hrdbtn
            // 
            this.hrdbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hrdbtn.Location = new System.Drawing.Point(167, 285);
            this.hrdbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hrdbtn.Name = "hrdbtn";
            this.hrdbtn.Size = new System.Drawing.Size(213, 68);
            this.hrdbtn.TabIndex = 2;
            this.hrdbtn.Text = "Hard";
            this.hrdbtn.UseVisualStyleBackColor = true;
            this.hrdbtn.Click += new System.EventHandler(this.hrdbtn_Click);
            // 
            // diffWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.hrdbtn);
            this.Controls.Add(this.mdmbtn);
            this.Controls.Add(this.ezbtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "diffWindow";
            this.Text = "Difficulty";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ezbtn;
        private System.Windows.Forms.Button mdmbtn;
        private System.Windows.Forms.Button hrdbtn;
    }
}

