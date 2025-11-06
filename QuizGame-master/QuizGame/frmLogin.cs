using QuizGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilikemen
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {



        }        
 
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();
            bool isAuthenticated = false;

            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\admin\source\QuizGame-master\QuizGame\credentials.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            string fileUsername = parts[0].Trim();
                            string filePassword = parts[1].Trim();

                            if (username == fileUsername && password == filePassword)
                            {
                                using (frmLobby confirm = new frmLobby())
                                {
                                    var result = confirm.ShowDialog();
                                }
                            }
                      
                        }
                    }
                }

                if (isAuthenticated)
                {
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading credentials file: " + ex.Message);
            }
        }
    }
}