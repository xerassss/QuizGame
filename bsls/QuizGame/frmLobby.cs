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
    public partial class frmLobby : Form
    {
        public frmLobby()
        {
            InitializeComponent();
        }

        private void btnLobbyPlay_Click(object sender, EventArgs e)
        {
            using (frmLogin login = new frmLogin())
            {
                var result = login.ShowDialog();
            }
        }

        private void btnLobbyStats_Click(object sender, EventArgs e)
        {

        }

        private void btnLobbyExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
