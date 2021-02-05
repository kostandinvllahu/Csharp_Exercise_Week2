using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class Courses : Form
    {


        public Courses(string name)
        {
            InitializeComponent();
            label17.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        public void security()
        {
            if(checkBox1.Checked == true && checkBox2.Checked == true)
            {
                MessageBox.Show("Nuk lejohet te marresh me shume se nje klase te se njejtes lende!");
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
            else
            {
                if(checkBox3.Checked == true && checkBox4.Checked == true)
                {
                    MessageBox.Show("Nuk lejohet te marresh me shume se nje klase te se njejtes lende!");
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            security();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            security();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            security();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            security();
        }

        private void label17_Click(object sender, EventArgs e)
        {
           
        }

        private void Courses_Load(object sender, EventArgs e)
        {

        }
    }
}
