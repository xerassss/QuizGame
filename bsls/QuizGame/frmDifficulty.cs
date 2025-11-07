using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class diffWindow : Form
    {
        public diffWindow()
        {
            InitializeComponent();

            this.ezbtn.MouseHover += new EventHandler(this.ezbtn_MouseHover);
            this.ezbtn.MouseLeave += new EventHandler(this.ezbtn_MouseLeave);
            this.mdmbtn.MouseHover += new EventHandler(this.mdmbtn_MouseHover);
            this.mdmbtn.MouseLeave += new EventHandler(this.mdmbtn_MouseLeave);
            this.hrdbtn.MouseHover += new EventHandler(this.hrdbtn_MouseHover);
            this.hrdbtn.MouseLeave += new EventHandler(this.hrdbtn_MouseLeave);
        }
        //For buttons
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UserResult.Name = txtNameOfPlayer.Text;
                if (UserResult.Name == "")
                {
                    throw new ArgumentNullException("Please Enter your name!");
                }
                using (frmQuiz confirm = new frmQuiz())
                {

                    DifficultyChooser.Easy = true;
                    DifficultyChooser.Medium = false;
                    DifficultyChooser.Hard = false;
                    var result = confirm.ShowDialog();
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Null Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void mdmbtn_Click(object sender, EventArgs e)
        {
            try
            {
                UserResult.Name = txtNameOfPlayer.Text;
                if (UserResult.Name == "")
                {
                    throw new ArgumentNullException("Please Enter your name!");
                }
                
                using (frmQuiz confirm = new frmQuiz())
                {
                    DifficultyChooser.Easy = false;
                    DifficultyChooser.Medium = true;
                    DifficultyChooser.Hard = false;
                    var result = confirm.ShowDialog();
                }

            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Null Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void hrdbtn_Click(object sender, EventArgs e)
        {
            try
            {
                UserResult.Name = txtNameOfPlayer.Text;
                if (UserResult.Name == "")
                {
                    throw new ArgumentNullException("Please Enter your name!");
                }
                
                using (frmQuiz confirm = new frmQuiz())
                {
                    DifficultyChooser.Easy = false;
                    DifficultyChooser.Medium = false;
                    DifficultyChooser.Hard = true;
                    var result = confirm.ShowDialog();
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Null Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
     
        
        }

        //For button design
        private void ezbtn_MouseHover(object sender, EventArgs e)
        {
            Button hoveredButton = (Button)sender;
            
            hoveredButton.BackColor = Color.Lime;
            hoveredButton.ForeColor = Color.White;
        }

        private void ezbtn_MouseLeave(object sender, EventArgs e)
        {
            Button leavedButton = (Button)sender;

            leavedButton.BackColor = Color.Silver;
            leavedButton.ForeColor = Color.Black;
        }


        private void mdmbtn_MouseHover(object sender, EventArgs e)
        {
            Button hoveredButton = (Button)sender;

            hoveredButton.BackColor = Color.Yellow;
        }

        private void mdmbtn_MouseLeave(object sender, EventArgs e)
        {
            Button leavedButton = (Button)sender;

            leavedButton.BackColor = Color.Silver;
        }

        private void hrdbtn_MouseHover(object sender, EventArgs e)
        {
            Button hoveredButton = (Button)sender;

            hoveredButton.BackColor = Color.Red;
            hoveredButton.ForeColor = Color.White;
        }

        private void hrdbtn_MouseLeave(object sender, EventArgs e)
        {
            Button leavedButton = (Button)sender;

            leavedButton.BackColor = Color.Silver;
            leavedButton.ForeColor = Color.Black;
        }

        //txtbox number exception
        private void txtNameOfPlayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            UserResult.Name = txtNameOfPlayer.Text;

            try
            {
                // Check if the character is a digit
                if (char.IsDigit(e.KeyChar))
                {
                    // Prevent the number from being entered
                    e.Handled = true;
                    throw new Exception("Numbers are not allowed in this field.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    public class DifficultyChooser
    {
        public delegate bool DelegateText(bool text);

        public static bool Easy = false;
        public static bool Medium = false;
        public static bool Hard = false;

        public static bool getEasy(bool Easy) { return Easy; }
        public static bool getMedium(bool Medium) { return Medium; }
        public static bool getHard(bool Hard) { return Hard; }
    }
}
                
       
    

