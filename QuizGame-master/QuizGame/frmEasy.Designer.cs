namespace QuizGame
{
    partial class frmEasy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEasy));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnA = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.lblTimerTitle = new System.Windows.Forms.Label();
            this.lblTotalTimeTitle = new System.Windows.Forms.Label();
            this.lblAllTime = new System.Windows.Forms.Label();
            this.lbSec = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnA
            // 
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(26, 239);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(249, 51);
            this.btnA.TabIndex = 1;
            this.btnA.Tag = "1";
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.ClickAnswerEvent);
            // 
            // btnC
            // 
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(26, 316);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(249, 51);
            this.btnC.TabIndex = 3;
            this.btnC.Tag = "3";
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.ClickAnswerEvent);
            // 
            // btnB
            // 
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(315, 239);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(249, 51);
            this.btnB.TabIndex = 2;
            this.btnB.Tag = "2";
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.UseWaitCursor = true;
            this.btnB.Click += new System.EventHandler(this.ClickAnswerEvent);
            // 
            // btnD
            // 
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(315, 316);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(249, 51);
            this.btnD.TabIndex = 4;
            this.btnD.Tag = "4";
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.ClickAnswerEvent);
            // 
            // lblQuestions
            // 
            this.lblQuestions.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestions.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQuestions.Location = new System.Drawing.Point(26, 71);
            this.lblQuestions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(528, 144);
            this.lblQuestions.TabIndex = 5;
            this.lblQuestions.Text = "(Sample)";
            this.lblQuestions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTimerTitle
            // 
            this.lblTimerTitle.AutoSize = true;
            this.lblTimerTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTimerTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerTitle.Location = new System.Drawing.Point(440, 7);
            this.lblTimerTitle.Name = "lblTimerTitle";
            this.lblTimerTitle.Size = new System.Drawing.Size(104, 26);
            this.lblTimerTitle.TabIndex = 21;
            this.lblTimerTitle.Text = "Time left:";
            this.lblTimerTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalTimeTitle
            // 
            this.lblTotalTimeTitle.AutoSize = true;
            this.lblTotalTimeTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalTimeTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTimeTitle.Location = new System.Drawing.Point(424, 33);
            this.lblTotalTimeTitle.Name = "lblTotalTimeTitle";
            this.lblTotalTimeTitle.Size = new System.Drawing.Size(120, 26);
            this.lblTotalTimeTitle.TabIndex = 20;
            this.lblTotalTimeTitle.Text = "Total Time:";
            this.lblTotalTimeTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAllTime
            // 
            this.lblAllTime.BackColor = System.Drawing.Color.Transparent;
            this.lblAllTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTime.Location = new System.Drawing.Point(540, 32);
            this.lblAllTime.Name = "lblAllTime";
            this.lblAllTime.Size = new System.Drawing.Size(60, 26);
            this.lblAllTime.TabIndex = 19;
            this.lblAllTime.Text = "0";
            this.lblAllTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbSec
            // 
            this.lbSec.BackColor = System.Drawing.Color.Transparent;
            this.lbSec.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSec.Location = new System.Drawing.Point(548, 7);
            this.lbSec.Name = "lbSec";
            this.lbSec.Size = new System.Drawing.Size(52, 26);
            this.lbSec.TabIndex = 17;
            this.lbSec.Text = "0";
            this.lbSec.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmEasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(604, 427);
            this.Controls.Add(this.lblTimerTitle);
            this.Controls.Add(this.lblTotalTimeTitle);
            this.Controls.Add(this.lblAllTime);
            this.Controls.Add(this.lbSec);
            this.Controls.Add(this.lblQuestions);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEasy";
            this.Text = "frmEasy";
            this.Load += new System.EventHandler(this.frmEasy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.Label lblTimerTitle;
        private System.Windows.Forms.Label lblTotalTimeTitle;
        private System.Windows.Forms.Label lblAllTime;
        private System.Windows.Forms.Label lbSec;
        private System.Windows.Forms.Timer timer2;
    }
}