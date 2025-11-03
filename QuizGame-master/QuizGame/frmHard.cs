using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class frmHard : Form
    {
        Random randomQuestion = new Random();
        List<int> usedQuestions = new List<int>();
        int buttonTag, restore;
        int correctAnswer;
        int questionNumber = 1;
        int questionTaken = 1;
        double score;
        int percentage;
        int totalQuestions;
        int Minute, TotalTime;
        int QuizTimer = 30;

        TextBox trueAnswer = new TextBox();
        string modifiedAnswer;
        string Answer;


        public frmHard()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 5;
        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {
            if (btnC.Visible == false)
            {
                btnC.Visible = true;
                btnD.Visible = true;
                btnA.Location = new System.Drawing.Point(26, 239);
                btnB.Location = new System.Drawing.Point(315, 239);

            }
            var senderObject = (Button)sender;
            QuizTimer = 30;

            buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;
            }
            question();
        }
        private void question()
        {
            if (questionTaken == totalQuestions)
            {
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);
                UserResult.Score = score;
                UserResult.Percentage = percentage;
                UserResult.Time = lblAllTime.Text;
                StopQuizTimer();
                StopTotalTimer();
                frmResult frm = new frmResult();
                DialogResult result = frm.ShowDialog();
                this.Close();
            }

            if (questionTaken != totalQuestions)
            {

                do
                {
                    questionNumber = randomQuestion.Next(1, 6); // 1 to 10 inclusive
                }
                while (usedQuestions.Contains(questionNumber));

                usedQuestions.Add(questionNumber);
                questionTaken++;

                askQuestion(questionNumber);
            }
        }

        private void StopQuizTimer()
        {
            timer1.Stop();
        }


        private void StopTotalTimer()
        {
            timer2.Stop();
        }

        private void frmHard_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    lblQuestions.Text = "Which countries were at war during Operation Barbarossa?";

                    btnA.Text = "Japan and Germany";
                    btnB.Text = "United Kingdom and Germany";
                    btnC.Text = "France and USSR";
                    btnD.Text = "Germany and USSR";

                    correctAnswer = 4;

                    break;
                case 2:
                    lblQuestions.Text = "What empire built the Colosseum?";

                    btnA.Text = "Greek Empire";
                    btnB.Text = "Roman Empire";
                    btnC.Text = "Ottoman Empire";
                    btnD.Text = "Persian Empire";

                    correctAnswer = 2;

                    break;
                case 3:
                    lblQuestions.Text = "The first Shrek movie came out in the year 1999";

                    btnA.Text = "True";
                    btnB.Text = "False";
                    Answer = "2000";
                    modifiedTrueFalse();

                    break;
                case 4:
                    lblQuestions.Text = "From which anime series does Ichigo Kurosaki being featured?";

                    btnA.Text = "Bleach";
                    btnB.Text = "Tokyo Ghoul";
                    btnC.Text = "One Piece";
                    btnD.Text = "Naruto";

                    correctAnswer = 1;

                    break;
                case 5:
                    lblQuestions.Text = "30 Degrees Celsius is equal to 86 Fahrenheit";

                    btnA.Text = "True";
                    btnB.Text = "False";
                    trueFalse();

                    correctAnswer = 1;

                    break;


            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            QuizTimer--;
            lbSec.Text = QuizTimer.ToString();
            if (QuizTimer < 0)
            {
                question();
                QuizTimer = 30;
            }


            lbSec.Text = QuizTimer.ToString();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            TotalTime++;
            if (TotalTime == 60)
            {
                Minute++;
                TotalTime = 0;
            }

            if (TotalTime > 0 && Minute == 0)
            {
                lblAllTime.Text = TotalTime.ToString();
            }
            else if (TotalTime < 10 && Minute > 0)
            {
                lblAllTime.Text = Minute + ":0" + TotalTime.ToString();
            }
            else
            {
                lblAllTime.Text = Minute + ":" + TotalTime.ToString();
            }
        }
        public void trueFalse()
        {
            btnA.Location = new System.Drawing.Point(26, 260);
            btnB.Location = new System.Drawing.Point(312, 260);
            btnC.Visible = false;
            btnD.Visible = false;
        }
        private void modifiedTrueFalse()
        {
            btnA.Location = new System.Drawing.Point(26, 260);
            btnB.Location = new System.Drawing.Point(312, 260);
            btnC.Visible = false;
            btnD.Visible = false;
            btnA.Click -= new System.EventHandler(ClickAnswerEvent);
            btnB.Click -= new System.EventHandler(ClickAnswerEvent);
            btnA.Click += new System.EventHandler(FalseButtonAnswer);
            btnB.Click += new System.EventHandler(FalseButtonAnswer);

        }

        private void FalseButtonAnswer(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            restore = Convert.ToInt32(senderObject.Tag);
            if (restore == 1)
            {
                btnA.Click -= new System.EventHandler(FalseButtonAnswer);
                btnB.Click -= new System.EventHandler(FalseButtonAnswer);
                btnA.Click += new System.EventHandler(ClickAnswerEvent);
                btnB.Click += new System.EventHandler(ClickAnswerEvent);
                btnC.Visible = true;
                btnD.Visible = true;
                question();
            }
            else
            {
                addTextbox();
                score += .5;
            }
        }

            private void trueAnswer_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    modifiedAnswer = trueAnswer.Text;
                    RemoveTextBox();
                    if (modifiedAnswer.Equals(Answer))
                    {
                        score += .5;
                    }
                    else
                    {
                        correctAnswer = 0;
                    }
                    QuizTimer = 30;
                    question();
                }
            }

        private void addTextbox()
        {
            btnC.Visible = false;
            btnD.Visible = false;
            this.Controls.Add(trueAnswer);
            trueAnswer.Visible = true;
            trueAnswer.Location = new System.Drawing.Point(26, 327);
            trueAnswer.Size = new System.Drawing.Size(186, 32);
            trueAnswer.TabIndex = 0;
            trueAnswer.Margin = new System.Windows.Forms.Padding(2);
            trueAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(trueAnswer_KeyDown);
        }

        public void RemoveTextBox()
        {
            this.Controls.Remove(trueAnswer);
            trueAnswer.KeyDown -= new System.Windows.Forms.KeyEventHandler(trueAnswer_KeyDown);
            btnB.Click -= new System.EventHandler(FalseButtonAnswer);
            btnB.Click += new System.EventHandler(ClickAnswerEvent);

            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;
        }
    }
}
