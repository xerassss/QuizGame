using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static QuizGame.DifficultyChooser;

namespace QuizGame
{
    public partial class frmQuiz : Form
    {
        //NEEDED TO ELIMINATE REPEAT QUESTIONS
        Random randomQuestion = new Random();
        List<int> usedQuestions = new List<int>();

        int buttonTag, restore, correctAnswer, questionNumber;
        int questionTaken = 1;
        double score;
        int percentage, totalQuestions, Minute, TotalTime;
        int QuizTimer = 30;

        TextBox txtBoxType = new TextBox();
        string txtBoxAnswer, txtBoxCorrectAnswer;
        //
        //
        //NEEDED TO HAVE THE QUESTIONS LOAD AND DIFFERENTIATE WHAT TYPE OF QUIZ
        private DelegateText DelEasy, DelMedium, DelHard;
        bool easy = false;
        bool medium = false;
        bool hard = false;

        public frmQuiz()
        {
            InitializeComponent();
            DelEasy = new DelegateText(DifficultyChooser.getEasy);
            DelMedium = new DelegateText(DifficultyChooser.getMedium);
            DelHard = new DelegateText(DifficultyChooser.getHard);
        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {
            // To remove the true and false type
            if (btnC.Visible == false)
            {
                btnC.Visible = true;
                btnD.Visible = true;
                btnA.Location = new System.Drawing.Point(26, 239);
                btnB.Location = new System.Drawing.Point(315, 239);
                lblTip.Text = " ";
                lblTip.Location = new System.Drawing.Point(12, 388);

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
            //To end the Quiz
            if (questionTaken == totalQuestions)
            {
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);
                UserResult.Score = score;
                UserResult.Percentage = percentage;
                UserResult.Time = lblAllTime.Text;
                StopTimers();
                frmResult frm = new frmResult();
                this.Hide();
                DialogResult result = frm.ShowDialog();
            }

            //To keep the quiz going as well as randomize the quizzes
            else if (questionTaken != totalQuestions)
            {
                if (easy == true)
                {
                    do
                    {
                        questionNumber = randomQuestion.Next(1, 11); // 1 to 10 inclusive
                    }
                    while (usedQuestions.Contains(questionNumber));

                    usedQuestions.Add(questionNumber);
                    questionTaken++;

                    askQuestionEasy(questionNumber);
                } 
                else if (medium == true)
                {
                    do
                    {
                        questionNumber = randomQuestion.Next(1, 16); // 1 to 10 inclusive
                    }
                    while (usedQuestions.Contains(questionNumber));

                    usedQuestions.Add(questionNumber);
                    questionTaken++;

                    askQuestionMedium(questionNumber);
                }
                else if (hard == true)
                {
                    do
                    {
                        questionNumber = randomQuestion.Next(1, 14); // 1 to 10 inclusive
                    }
                    while (usedQuestions.Contains(questionNumber));

                    usedQuestions.Add(questionNumber);
                    questionTaken++;

                    askQuestionHard(questionNumber);
                }
            }
        }
        //
        //
        // Timer and question loader
        private void frmQuiz_Load(object sender, EventArgs e)
        {
            DelegateLoader();
            QuestionDecider();
            ChoosingDiff();
            timer1.Enabled = true;
            timer2.Enabled = true;
        }
        //
        // Timer Config
        /*Note: timer1 = Quiz Timer
                timer2 = Total time
        */
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            QuizTimer--;
            lbSec.Text = QuizTimer.ToString();
            if (QuizTimer < 0)
            {
                if (txtBoxType.Visible == true && easy == true)
                {
                    RemoveEasyTxtBox();
                    lblTip.Text = " ";
                    lblTip.Location = new System.Drawing.Point(12, 388);
                } 
                else if (txtBoxType.Visible == true && hard == true)
                {
                    RemoveHardTxtbox();
                    btnA.Click -= new System.EventHandler(FalseButtonAnswer);
                    btnA.Click += new System.EventHandler(ClickAnswerEvent);
                    lblTip.Text = " ";
                    lblTip.Location = new System.Drawing.Point(12, 388);
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

        private void StopTimers()
        {
            timer1.Stop();
            timer2.Stop();
        }
        //
        //
        //Quiz Questions
        private void askQuestionEasy(int qnum)
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

                    btnA.Text = "51";
                    btnB.Text = "21";
                    btnC.Text = "31";
                    btnD.Text = "None of the above";

                    correctAnswer = 3;

                    break;

                case 6:
                    lblQuestions.Text = "Whats the product of 23 * 25?";

                    AddEasyTxtBox();
                    txtBoxCorrectAnswer = "575";
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

                    btnA.Text = "4015";
                    btnB.Text = "3579";
                    btnC.Text = "3619";
                    btnD.Text = "3609";

                    correctAnswer = 4;

                    break;

                case 9:
                    lblQuestions.Text = "The difference of 3490 - 2667 is?";

                    AddEasyTxtBox();
                    txtBoxCorrectAnswer = "823";

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

        private void askQuestionMedium(int qnum)
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

        private void askQuestionHard(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    lblQuestions.Text = "How many countries joined NATO?";

                    btnA.Text = "22";
                    btnB.Text = "39";
                    btnC.Text = "32";
                    btnD.Text = "33";

                    correctAnswer = 3;

                    break;
                case 2:
                    lblQuestions.Text = "1677 * 13 = 24,521?";

                    btnA.Text = "True";
                    btnB.Text = "False";

                    txtBoxAnswer = "21801";
                    modifiedTrueFalse();

                    break;
                case 3:
                    lblQuestions.Text = "The first Shrek movie came out in the year 1999";

                    btnA.Text = "True";
                    btnB.Text = "False";

                    txtBoxAnswer = "2000";
                    modifiedTrueFalse();

                    break;
                case 4:
                    lblQuestions.Text = "The Byzantine Empire ended in the year 1455.";

                    btnA.Text = "True";
                    btnB.Text = "False";

                    txtBoxAnswer = "1453";
                    modifiedTrueFalse();

                    break;
                case 5:
                    lblQuestions.Text = "30 Degrees Celsius is equal to 86 Fahrenheit";

                    btnA.Text = "True";
                    btnB.Text = "False";
                    trueFalse();

                    correctAnswer = 1;

                    break;
                case 6:
                    lblQuestions.Text = "SLBM, in military terms is also known as submarine-launched ballistic missile.";

                    btnA.Text = "True";
                    btnB.Text = "False";
                    trueFalse();

                    correctAnswer = 1;

                    break;
                case 7:
                    lblQuestions.Text = "When did the Cavite Mutiny occur?";

                    btnA.Text = "February 20, 1872";
                    btnB.Text = "January 20, 1872";
                    btnC.Text = "April 10, 1872";
                    btnD.Text = "February 30, 1872";

                    correctAnswer = 2;

                    break;
                case 8:
                    lblQuestions.Text = "155 * 24 = 3565?";

                    btnA.Text = "True";
                    btnB.Text = "False";

                    txtBoxAnswer = "3720";
                    modifiedTrueFalse();

                    break;
                case 9:
                    lblQuestions.Text = "The Romanji term Kaminari no kokyū is also known as what breathing technique from Demon Slayer?";

                    btnA.Text = "Mist Breathing";
                    btnB.Text = "Water Breathing";
                    btnC.Text = "Thunder Breathing";
                    btnD.Text = "Sun Breathing";

                    correctAnswer = 3;

                    break;
                case 10:
                    lblQuestions.Text = "string x = 1 + 2 + 3 + 4 + 5; \n What is the output?";

                    btnA.Text = "True";
                    btnB.Text = "Syntax Error";
                    btnC.Text = "12345";
                    btnD.Text = "15";

                    correctAnswer = 2;

                    break;
                case 11:
                    lblQuestions.Text = "Magellan arrived in the Philippines on  May 16, 1521";

                    btnA.Text = "True";
                    btnB.Text = "False";

                    txtBoxAnswer = "march";
                    modifiedTrueFalse();

                    break;
                case 12:
                    lblQuestions.Text = "The word Encapsulasion is spelled correctly.";

                    btnA.Text = "True";
                    btnB.Text = "False";

                    txtBoxAnswer = "encapsulation";
                    modifiedTrueFalse();

                    break;
                case 13:
                    lblQuestions.Text = "x = 9 + 8 - 7 * 6 / 5 \n What is the output?";

                    btnA.Text = "8.6";
                    btnB.Text = "-45.875";
                    btnC.Text = "63.8";
                    btnD.Text = "9.3";

                    correctAnswer = 1;

                    break;
            }
        }
        //
        //
        // Difficulty chooser config
        private void ChoosingDiff()
        {
            if (easy == true && medium == false && hard == false)
            {
                askQuestionEasy(questionNumber);
                totalQuestions = 10;
            }
            if (easy == false && medium == true && hard == false)
            {
                askQuestionMedium(questionNumber);
                totalQuestions = 15;
            }
            if (easy == false && medium == false && hard == true)
            {
                askQuestionHard(questionNumber);
                totalQuestions = 13;
            }
        }
        private void DelegateLoader()
        {
            easy = DelEasy(DifficultyChooser.Easy);
            medium = DelMedium(DifficultyChooser.Medium);
            hard = DelHard(DifficultyChooser.Hard);
        }
        private void QuestionDecider()
        {
            if (easy == true)
            {
                questionNumber = randomQuestion.Next(1, 10);
                usedQuestions.Add(questionNumber);
            }
            else if (medium == true) 
            {
                questionNumber = randomQuestion.Next(1, 16);
                usedQuestions.Add(questionNumber);
            }
            else if (hard == true)
            {
                questionNumber = randomQuestion.Next(1, 14);
                usedQuestions.Add(questionNumber);
            }
        }
        //
        //
        // Difficulty Easy TextBox Config
        private void txtBoxEasy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBoxAnswer = txtBoxType.Text;
                RemoveEasyTxtBox();
                if (txtBoxAnswer.Equals(txtBoxCorrectAnswer))
                {
                    score++;
                }
                else
                {
                    //To make sure the user doesnt really get a point
                    correctAnswer = 0;
                }
                lblTip.Text = " ";
                lblTip.Location = new System.Drawing.Point(12, 388);
                QuizTimer = 30;
                question();
            }
        }
        public void AddEasyTxtBox()
        {
            btnA.Visible = false;
            btnB.Visible = false;
            btnC.Visible = false;
            btnD.Visible = false;
            this.Controls.Add(txtBoxType);
            txtBoxType.Visible = true;
            txtBoxType.Location = new System.Drawing.Point(26, 239);
            txtBoxType.Multiline = true;
            txtBoxType.Size = new System.Drawing.Size(249, 38);
            txtBoxType.TabIndex = 0;
            txtBoxType.Margin = new System.Windows.Forms.Padding(2);
            txtBoxType.KeyDown += new System.Windows.Forms.KeyEventHandler(txtBoxEasy_KeyDown);

            lblTip.Location = new System.Drawing.Point(26, 280);
            lblTip.Text = "*Tip: Hit Enter on the textbox to proceed to the next question!";
        }
        public void RemoveEasyTxtBox()
        {
            this.Controls.Remove(txtBoxType);
            txtBoxType.KeyDown -= new System.Windows.Forms.KeyEventHandler(txtBoxEasy_KeyDown);
            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;
        }
        //
        //
        // Difficulty Medium True and false Config
        public void trueFalse()
        {
            btnA.Location = new System.Drawing.Point(26, 260);
            btnB.Location = new System.Drawing.Point(312, 260);
            btnC.Visible = false;
            btnD.Visible = false;
        }
        //
        //
        // Hard Difficulty Quiz type Config
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
                addHardTxtbox();
                score += .5;
            }
        }

        private void txtBoxHard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBoxAnswer = txtBoxType.Text;
                RemoveHardTxtbox();
                if (txtBoxAnswer.Equals(txtBoxCorrectAnswer))
                {
                    score += .5;
                }
                else
                {
                    correctAnswer = 0;
                }
                lblTip.Text = " ";
                lblTip.Location = new System.Drawing.Point(12, 388);
                QuizTimer = 30;
                question();
            }
        }

        private void addHardTxtbox()
        {
            btnC.Visible = false;
            btnD.Visible = false;
            this.Controls.Add(txtBoxType);
            txtBoxType.Visible = true;
            txtBoxType.Location = new System.Drawing.Point(26, 327);
            txtBoxType.Multiline = true;
            txtBoxType.Size = new System.Drawing.Size(249, 38);
            txtBoxType.TabIndex = 0;
            txtBoxType.Margin = new System.Windows.Forms.Padding(2);
            txtBoxType.KeyDown += new System.Windows.Forms.KeyEventHandler(txtBoxHard_KeyDown);

            lblTip.Location = new System.Drawing.Point(312, 327);
            lblTip.Text = "*Tip: Hit Enter on the textbox to proceed to the next question!";
        }

        public void RemoveHardTxtbox()
        {
            this.Controls.Remove(txtBoxType);
            txtBoxType.KeyDown -= new System.Windows.Forms.KeyEventHandler(txtBoxHard_KeyDown);
            btnB.Click -= new System.EventHandler(FalseButtonAnswer);
            btnB.Click += new System.EventHandler(ClickAnswerEvent);

            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;
        }
    }
}


