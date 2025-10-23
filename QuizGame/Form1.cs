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
    }
}
                
       
    

