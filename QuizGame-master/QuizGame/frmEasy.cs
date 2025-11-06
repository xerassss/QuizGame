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
    public partial class frmEasy : Form
    {
        Random randomQuestion = new Random();
        List<int> usedQuestions = new List<int>();
        int buttonTag;
        int correctAnswer;
        int questionNumber = 1;
        int questionTaken = 1;
        int score;
        int percentage;
        int totalQuestions;
        int Minute, TotalTime;
        int QuizTimer = 30;

        TextBox txtEnumeration = new TextBox();
        string enumerationAnswer;
        string enumerationCorrectAnswer;
        

        public frmEasy()
        {
            InitializeComponent();

            askQuestion(questionNumber);
            totalQuestions = 10;
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
                    questionNumber = randomQuestion.Next(1, 10); // 1 to 10 inclusive
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
                    lblQuestions.Text = "What phrase is often associated with the meme of Kermit the Frog sipping tea?";

                    btnA.Text = "Its none of your business.";
                    btnB.Text = "But thats none of my business.";
                    btnC.Text = "I told you so.";
                    btnD.Text = "None of the above.";

                    correctAnswer = 2;

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
                    
                    lblQuestions.Text = "Whats the quotient of 155 / 5?";

                    AddEnumeration();
                    enumerationCorrectAnswer = "31";

                    break;

                case 6:
                    lblQuestions.Text = "Whats the product of 23 * 25?";

                    AddEnumeration();
                    enumerationCorrectAnswer = "575";
                    break;

                case 7:
                    lblQuestions.Text = "It's also called as Heavy Water.";

                    btnA.Text = "Carbon Monoxide";
                    btnB.Text = "Mercury";
                    btnC.Text = "Deuterium";
                    btnD.Text = "Oxygen";

                    correctAnswer = 3;

                    break;

                case 8:

                    lblQuestions.Text = "Find the sum of 1564 + 2045.";

                    AddEnumeration();
                    enumerationCorrectAnswer = "3609";

                    break;

                case 9:
                    lblQuestions.Text = "The difference of 3490 - 2667 is?";
                    
                    AddEnumeration();
                    enumerationCorrectAnswer = "823";

                    break;

                case 10: //do not change    
                    lblQuestions.Text = "Whats the total average of 55, 67, 59 and 62?";

                    btnA.Text = "57.50";
                    btnB.Text = "65.70";
                    btnC.Text = "64.34";
                    btnD.Text = "60.75";

                    correctAnswer = 4;

                    break;


            }
        }

        private void frmEasy_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            QuizTimer--;
            lbSec.Text = QuizTimer.ToString();
            if (QuizTimer < 0)
            {
                if (txtEnumeration.Visible == true){
                    RemoveEnumeration();
                }
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

        private void txtEnumeration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enumerationAnswer = txtEnumeration.Text;
                RemoveEnumeration();
                if (enumerationAnswer.Equals(enumerationCorrectAnswer))
                {
                    score++;
                }
                else
                {
                    correctAnswer = 0;
                }
                QuizTimer = 30;
                question();
            }
        }
        public void AddEnumeration()
        {
            btnA.Visible = false;
            btnB.Visible = false;
            btnC.Visible = false;
            btnD.Visible = false;
            this.Controls.Add(txtEnumeration);
            txtEnumeration.Visible = true;
            txtEnumeration.Location = new System.Drawing.Point(26, 239);
            txtEnumeration.Size = new System.Drawing.Size(186, 32);
            txtEnumeration.TabIndex = 0;
            txtEnumeration.Margin = new System.Windows.Forms.Padding(2);
            txtEnumeration.KeyDown += new System.Windows.Forms.KeyEventHandler(txtEnumeration_KeyDown);
        }
        public void RemoveEnumeration()
        {
            this.Controls.Remove(txtEnumeration);
            txtEnumeration.KeyDown -= new System.Windows.Forms.KeyEventHandler(txtEnumeration_KeyDown);
            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;
        } 
    }
}


