using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace QuizGame
{
    public partial class frmMedium : Form
    {
        Random randomQuestion = new Random();
        List<int> usedQuestions = new List<int>();
        int correctAnswer;
        int questionNumber = 1;
        int questionTaken = 1;
        int score;
        int percentage;
        int totalQuestions;
        int Minute, TotalTime;
        int QuizTimer = 30;


        public frmMedium()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 15;
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
                    questionNumber = randomQuestion.Next(1, 15); // 1 to 15 inclusive
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

                    lblQuestions.Text = "Is a function whose domain is a sample space and whose range is some set of real numbers.";

                    btnA.Text = "Random Variable";
                    btnB.Text = "Complex Variable";
                    btnC.Text = "Simple Variable";
                    btnD.Text = "Multiplex Variable";

                    correctAnswer = 1;


                    break;


                case 2:
                    lblQuestions.Text = "Ainsley Harriot was the person behind the Hehe Boi";

                    btnA.Text = "True";
                    btnB.Text = "False";
                    trueFalse();

                    correctAnswer = 1;

                    break;
                case 3:

                    lblQuestions.Text = "Is a random variable that may assume an uncountable number of values or possible outcomes, represented by the intervals on a number line.";

                    btnA.Text = "Sequential Random Variable";
                    btnB.Text = "Continuous Random Variable";
                    btnC.Text = "Discrete Random Variable";
                    btnD.Text = "Patterned Random Variable";

                    correctAnswer = 2;

                    correctAnswer = 1;

                    break;

                case 4:
                    lblQuestions.Text = "Rem and Emilia are the twin characters from the anime Re: Zero.";

                    btnA.Text = "True";
                    btnB.Text = "False";
                    trueFalse();

                    correctAnswer = 2;

                    break;

                case 5:
                    lblQuestions.Text = "J. Robert Oppenheimer is known as the Father of Atomic Bombs.";

                    btnA.Text = "True";
                    btnB.Text = "False";
                    trueFalse();

                    correctAnswer = 1;

                    break;

                case 6:
                    lblQuestions.Text = "Which Race Track was the hometown of the racing driver Sabine Schmitz ";

                    btnA.Text = "Nürburgring";
                    btnB.Text = "Zandvoort Circuit";
                    btnC.Text = "Silverstone Circuit";
                    btnD.Text = "Monza Circuit";

                    correctAnswer = 1;

                    break;

                case 7:
                    lblQuestions.Text = "The protagonist in the anime series One Punch Man is named Saitama.";

                    btnA.Text = "True";
                    btnB.Text = "False";
                    trueFalse();

                    correctAnswer = 1;

                    break;

                case 8:
                    lblQuestions.Text = "Tanjiro Kamado is the main antagonist in the anime series Demon Slayer.";

                    btnA.Text = "True";
                    btnB.Text = "False";
                    trueFalse();

                    correctAnswer = 2;

                    break;

                case 9:
                    lblQuestions.Text = "The Russian Revolution started in the year 1918.";

                    btnA.Text = "True";
                    btnB.Text = "False";
                    trueFalse();

                    correctAnswer = 2;

                    break;

                case 10:
                    lblQuestions.Text = "The Pythagorean Theorem is also known as Pythagoras Theorem.";

                    btnA.Text = "True";
                    btnB.Text = "False";
                    trueFalse();

                    correctAnswer = 1;

                    break;

                case 11:
                    lblQuestions.Text = "Plutonium is mostly man-made.";

                    btnA.Text = "True";
                    btnB.Text = "False";
                    trueFalse();

                    correctAnswer = 1;

                    break;

                case 12:
                    lblQuestions.Text = "If a wrecking ball has a weight of 100 Tonnes and a crane has a lifting capacity of 40 Tonnes how many 10kg counterweights should be added to the crane";

                    btnA.Text = "5,500";
                    btnB.Text = "6,000";
                    btnC.Text = "7,000";
                    btnD.Text = "5,995";

                    correctAnswer = 2;

                    break;

                case 13:
                    lblQuestions.Text = "What are the three most important things to start an engine?";

                    btnA.Text = "Air, Fuel, Alcohol";
                    btnB.Text = "Air, Ether, Spark";
                    btnC.Text = "Dust, Fuel, Spark";
                    btnD.Text = "Air, Fuel, Spark";

                    correctAnswer = 4;

                    break;

                case 14:
                    lblQuestions.Text = "Salinity refers to the measure of saltiness in a body of water.";

                    btnA.Text = "True";
                    btnB.Text = "False";
                    trueFalse();

                    correctAnswer = 1;

                    break;

                case 15:
                    lblQuestions.Text = "Constantine the Great is the founder of Byzantine Empire.";

                    btnA.Text = "True";
                    btnB.Text = "False";
                    trueFalse();

                    correctAnswer = 1;

                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
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
            if(TotalTime == 60)
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
        private void frmMedium_Load(object sender, EventArgs e)
        {   
            timer1.Enabled= true;  
            timer2.Enabled = true;
        }
        public void trueFalse()
        {
            btnA.Location = new System.Drawing.Point(26, 260);
            btnB.Location = new System.Drawing.Point(312, 260);
            btnC.Visible = false;
            btnD.Visible = false;
        }
    }
}