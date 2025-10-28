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
using System.Xml.Linq;

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (frmEasy confirm = new frmEasy())
            {
                var result = confirm.ShowDialog();
            }
        }

        private void mdmbtn_Click(object sender, EventArgs e)
        {
            using (frmMedium confirm = new frmMedium())
            {
                var result = confirm.ShowDialog();
            }
        }

        private void hrdbtn_Click(object sender, EventArgs e)
        {
            using (frmHard confirm = new frmHard())
            {
                var result = confirm.ShowDialog();
            }
     
        
        }


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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNameOfPlayer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNameOfPlayer_TextChanged_1(object sender, EventArgs e)
        {
           

        }

        private void txtNameOfPlayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            StringUserResult.Name = txtNameOfPlayer.Text;

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
                // Show message box or handle it your own way
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }


}
                
       
    

