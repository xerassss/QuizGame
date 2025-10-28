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
        int correctAnswer;
        int questionNumber = 1;
        int questionTaken = 1;
        int score;
        int percentage;
        int totalQuestions;
        int timerSec = 0;
        int max_Time = 60;

        public frmHard()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 4;
        }
        int M, S, TotalS = 0;

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
            S = 0;

            int buttonTag = Convert.ToInt32(senderObject.Tag);
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
                UserResultNum.Score = score;
                UserResultNum.Percentage = percentage;
                UserResultNum.Time = TotalS;
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
                    questionNumber = randomQuestion.Next(1, 5); // 1 to 10 inclusive
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            TotalS++;
            lbAllTime.Text = TotalS.ToString();
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

            }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            S++;
            lbSec.Text = S.ToString();
            if (S >= 15)
            {
                question();
                S = 0;
            }


            lbSec.Text = S.ToString();
            lbMin.Text = M.ToString();

        }
    }
}
