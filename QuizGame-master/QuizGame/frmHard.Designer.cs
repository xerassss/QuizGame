namespace QuizGame
{
    partial class frmHard
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
            this.lblQuestions = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAllTime = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbSec = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblQuestions
            // 
            this.lblQuestions.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQuestions.Location = new System.Drawing.Point(35, 23);
            this.lblQuestions.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(733, 241);
            this.lblQuestions.TabIndex = 6;
            this.lblQuestions.Text = "(Sample)";
            // 
            // btnA
            // 
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnA.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(35, 294);
            this.btnA.Margin = new System.Windows.Forms.Padding(4);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(332, 63);
            this.btnA.TabIndex = 7;
            this.btnA.Tag = "1";
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.ClickAnswerEvent);
            // 
            // btnB
            // 
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnB.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(420, 294);
            this.btnB.Margin = new System.Windows.Forms.Padding(4);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(332, 63);
            this.btnB.TabIndex = 8;
            this.btnB.Tag = "2";
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.UseWaitCursor = true;
            this.btnB.Click += new System.EventHandler(this.ClickAnswerEvent);
            // 
            // btnC
            // 
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnC.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(35, 389);
            this.btnC.Margin = new System.Windows.Forms.Padding(4);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(332, 63);
            this.btnC.TabIndex = 9;
            this.btnC.Tag = "3";
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.ClickAnswerEvent);
            // 
            // btnD
            // 
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnD.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(420, 389);
            this.btnD.Margin = new System.Windows.Forms.Padding(4);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(332, 63);
            this.btnD.TabIndex = 10;
            this.btnD.Tag = "4";
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.ClickAnswerEvent);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(628, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "Time left:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(608, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Total Time:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbAllTime
            // 
            this.lbAllTime.AutoSize = true;
            this.lbAllTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllTime.Location = new System.Drawing.Point(758, 40);
            this.lbAllTime.Name = "lbAllTime";
            this.lbAllTime.Size = new System.Drawing.Size(28, 31);
            this.lbAllTime.TabIndex = 19;
            this.lbAllTime.Text = "0";
            this.lbAllTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMin.Location = new System.Drawing.Point(758, 118);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(28, 31);
            this.lbMin.TabIndex = 18;
            this.lbMin.Text = "0";
            this.lbMin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbSec
            // 
            this.lbSec.AutoSize = true;
            this.lbSec.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSec.Location = new System.Drawing.Point(758, 9);
            this.lbSec.Name = "lbSec";
            this.lbSec.Size = new System.Drawing.Size(28, 31);
            this.lbSec.TabIndex = 17;
            this.lbSec.Text = "0";
            this.lbSec.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmHard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 526);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAllTime);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.lbSec);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.lblQuestions);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHard";
            this.Text = "frmHard";
            this.Load += new System.EventHandler(this.frmHard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAllTime;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbSec;
        private System.Windows.Forms.Timer timer2;
    }
}