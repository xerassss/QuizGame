namespace QuizGame
{
    partial class frmResult
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
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lbElapsedTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.Location = new System.Drawing.Point(13, 13);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(65, 24);
            this.lblNameTitle.TabIndex = 0;
            this.lblNameTitle.Text = "Name: ";
            // 
            // lblScoreTitle
            // 
            this.lblScoreTitle.AutoSize = true;
            this.lblScoreTitle.Location = new System.Drawing.Point(13, 52);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Size = new System.Drawing.Size(57, 24);
            this.lblScoreTitle.TabIndex = 1;
            this.lblScoreTitle.Text = "Score:";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(13, 89);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(98, 24);
            this.lblPercent.TabIndex = 2;
            this.lblPercent.Text = "Percentage:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(63, 52);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(86, 24);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "( Sample )";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(110, 89);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(86, 24);
            this.lblPercentage.TabIndex = 4;
            this.lblPercentage.Text = "( Sample )";
            // 
            // btnRetry
            // 
            this.btnRetry.Location = new System.Drawing.Point(20, 213);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(106, 41);
            this.btnRetry.TabIndex = 5;
            this.btnRetry.Text = "Play Again?";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(185, 213);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(106, 41);
            this.btnFinish.TabIndex = 6;
            this.btnFinish.Text = "Exit";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(137, 125);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(86, 24);
            this.lblTotalTime.TabIndex = 9;
            this.lblTotalTime.Text = "( Sample )";
            this.lblTotalTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbElapsedTime
            // 
            this.lbElapsedTime.AutoSize = true;
            this.lbElapsedTime.Location = new System.Drawing.Point(16, 125);
            this.lbElapsedTime.Name = "lbElapsedTime";
            this.lbElapsedTime.Size = new System.Drawing.Size(115, 24);
            this.lbElapsedTime.TabIndex = 8;
            this.lbElapsedTime.Text = "Elapsed Time:";
            this.lbElapsedTime.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(63, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(262, 24);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "\'";
            this.lblName.Click += new System.EventHandler(this.lblName_Click_1);
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 325);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.lbElapsedTime);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblScoreTitle);
            this.Controls.Add(this.lblNameTitle);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmResult";
            this.Text = "frmResult";
            this.Load += new System.EventHandler(this.frmResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Label lblScoreTitle;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lbElapsedTime;
        internal System.Windows.Forms.Label lblName;
    }
}