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
        int score;
        int percentage;
        int totalQuestions;
        int timerSec = 0;
        int max_Time = 60;

        public frmEasy()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 4;
        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            timerSec = 0;

            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;
            }
            question();
        }
        private void question()
        {
            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);
                MessageBox.Show("Quiz Ended" + Environment.NewLine + "Your total percentage is " + percentage + "%" 
                + Environment.NewLine + "Click Ok to play again");

                score = 0;
                questionNumber = 0;
                return;
            }

            do
            {
                questionNumber = randomQuestion.Next(1, 5); // 1 to 10 inclusive
                if (questionNumber.Contains(usedQuestions)){
                    questionNumber = randomQuestion.Next(1, 5);
                }
            }
            while (usedQuestions.Contains(questionNumber));

            usedQuestions.Add(questionNumber);

            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
            {
                switch(qnum)
                {
                    case 1:
                        lblQuestion.Text = "Whats your name?";

                        btnA.Text = "Chino";
                        btnB.Text = "Cocoa";
                        btnC.Text = "Shamiko";
                        btnD.Text = "Misha";

                        correctAnswer = 3;

                        break;
                    case 2:
                        lblQuestion.Text = "Whats her name?";

                        btnA.Text = "Chino";
                        btnB.Text = "Shamiko";  
                        btnC.Text = "Cocoa";
                        btnD.Text = "Misha";

                        correctAnswer = 2;

                        break;
                    case 3:
                        lblQuestion.Text = "Question 3";

                        btnA.Text = "True";
                        btnB.Text = "False";  
                        btnC.Text = "Cocoa";
                    btnD.Text = "Misha";

                    correctAnswer = 2;

                    break;
                case 4:
                    lblQuestion.Text = "Question 4";

                    btnA.Text = "True";
                    btnB.Text = "False";  
                    btnC.Text = "Huh";
                    btnD.Text = "LOL";

                    correctAnswer = 2;

                    break;
                
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timerSec <= max_Time)
            {
                timerSec++;
            }
            else
            {
                timerSec = 0;
                question();
            }
        }
    }
}
