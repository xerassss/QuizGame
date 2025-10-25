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
            this.ezbtn.BackColor = System.Drawing.Color.Silver;
            this.ezbtn.ForeColor = System.Drawing.Color.Black;
            this.ezbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ezbtn.Location = new System.Drawing.Point(124, 61);
            this.ezbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ezbtn.Name = "ezbtn";
            this.ezbtn.Size = new System.Drawing.Size(160, 55);
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
            this.mdmbtn.Location = new System.Drawing.Point(125, 148);
            this.mdmbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mdmbtn.Name = "mdmbtn";
            this.mdmbtn.Size = new System.Drawing.Size(160, 55);
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
            this.hrdbtn.Location = new System.Drawing.Point(125, 232);
            this.hrdbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hrdbtn.Name = "hrdbtn";
            this.hrdbtn.Size = new System.Drawing.Size(160, 55);
            this.hrdbtn.TabIndex = 2;
            this.hrdbtn.Text = "Hard";
            this.hrdbtn.UseVisualStyleBackColor = false;
            this.hrdbtn.Click += new System.EventHandler(this.hrdbtn_Click);
            // 
            // diffWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(412, 366);
            this.Controls.Add(this.hrdbtn);
            this.Controls.Add(this.mdmbtn);
            this.Controls.Add(this.ezbtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

