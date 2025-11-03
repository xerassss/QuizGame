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
            String username = txtUser.Text;
            String password = txtPass.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                // Define where to store the file
                string filePath = Path.Combine(Application.StartupPath, "UserLogins.txt");

                // ✅ Use Microsoft Streams
                using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine($"{DateTime.Now:G} | Username: {username}, Password: {password}");
                }   

                MessageBox.Show("Login information saved successfully!");

                // Optionally open the quiz form next:
                // MainForm quizForm = new MainForm();
                // quizForm.Show();
                // this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to file: " + ex.Message);
            }

            using (diffWindow confirm = new diffWindow())
            {
                var result = confirm.ShowDialog();
            }
        }
    }
}
