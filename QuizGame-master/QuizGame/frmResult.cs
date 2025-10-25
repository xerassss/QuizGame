using System;
using System.Windows.Forms;
using static QuizGame.UserResult;

namespace QuizGame
{

    public partial class frmResult : Form
    {
        private DelegateNumber DelScore, DelPercentage, DelTime;
        public frmResult()          
        {
            InitializeComponent();
            DelScore = new DelegateNumber(UserResult.getScore);
            DelPercentage = new DelegateNumber(UserResult.getPercentage);
            DelTime = new DelegateNumber(UserResult.getTime);

        }

        private void frmResult_Load(object sender, EventArgs e)
        {   
            lblScore.Text = DelScore(UserResult.Score).ToString();
            lblPercentage.Text = DelPercentage(UserResult.Percentage).ToString() + "%";
            lblTotalTime.Text = DelTime(UserResult.Time).ToString();

        }


        private void btnFinish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
                 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
