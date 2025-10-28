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
        int correctAnswer;
        int questionNumber = 1;
        int questionTaken = 1;
        int score;
        int percentage;
        int totalQuestions;
        int timerSec = 0;
        int max_Time = 59;

        public frmEasy()
        {
            InitializeComponent();

            askQuestion(questionNumber);
            totalQuestions = 10;



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

                    btnA.Text = "41";
                    btnB.Text = "20";
                    btnC.Text = "31";
                    btnD.Text = "23";

                    correctAnswer = 3;

                    break;

                case 6:
                    lblQuestions.Text = "Whats the product of 23 * 25?";

                    btnA.Text = "575";
                    btnB.Text = "650";
                    btnC.Text = "890";
                    btnD.Text = "234";

                    correctAnswer = 1;

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

                    btnA.Text = "3034";
                    btnB.Text = "3609";
                    btnC.Text = "3669";
                    btnD.Text = "3690";

                    correctAnswer = 2;

                    break;

                case 9:
                    lblQuestions.Text = "The difference of 3490 - 2667 is?";

                    btnA.Text = "1098";
                    btnB.Text = "823";
                    btnC.Text = "849";
                    btnD.Text = "871";

                    correctAnswer = 2;

                    break;

                case 10:
                    lblQuestions.Text = "Whats the total average of 55, 67, 59 and 62?";

                    btnA.Text = "57.50";
                    btnB.Text = "65.70";
                    btnC.Text = "64.34";
                    btnD.Text = "60.75";
                        
                    correctAnswer = 4;

                    break;


            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerSec <= max_Time)
            {
                timerSec++;
            }
            else
            {
                timerSec = 0;
                question();
            }
        }

        private void lblQuestions_Click(object sender, EventArgs e)
        {

        }

        private void frmEasy_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
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
            if (TotalS == 59    )
            {
                TotalS = 0;
                M++;
            }


            lbSec.Text = S.ToString();
            lbMin.Text = M.ToString();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TotalS++;
            lbAllTime.Text = TotalS.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbSec_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    public class UserResultNum
    {
        public delegate long DelegateNumber(long number);

        public static long Score = 0;
        public static long Percentage = 0;
        public static long Time = 0;

        public static long getScore(long Score) { return Score; }
        public static long getTime(long Time) { return Time; }
        public static long getPercentage(long Percentage) { return Percentage; }
    }
}

public class StringUserResult 
{
    public delegate string DelegateText(string text);
    
        public static string Name;
    public static string getName(string Name) { return Name; }
}


