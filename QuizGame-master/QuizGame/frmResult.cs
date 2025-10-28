using System;
using System.Windows.Forms;
using static QuizGame.UserResultNum;
using static StringUserResult;


namespace QuizGame
{

    public partial class frmResult : Form
    {
        private DelegateNumber DelScore, DelPercentage, DelTime;
        private DelegateText DelName;

        public frmResult()          
        {
            InitializeComponent();
            DelName = new DelegateText(StringUserResult.getName);
            DelScore = new DelegateNumber(UserResultNum.getScore);
            DelPercentage = new DelegateNumber(UserResultNum.getPercentage);
            DelTime = new DelegateNumber(UserResultNum.getTime);

        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            //lblName.Text = DelName(StringUserResult.Name).ToString();   
            lblScore.Text = DelScore(UserResultNum.Score).ToString();
            lblPercentage.Text = DelPercentage(UserResultNum.Percentage).ToString() + "%";
            lblTotalTime.Text = DelTime(UserResultNum.Time).ToString();

        }


        private void btnFinish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
                 
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click_1(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
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
