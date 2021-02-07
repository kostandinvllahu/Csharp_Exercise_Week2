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
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
            else
            {
                if(checkBox3.Checked == true && checkBox4.Checked == true)
                {
                    MessageBox.Show("Nuk lejohet te marresh me shume se nje klase te se njejtes lende!");
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if(checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
                    {
                        MessageBox.Show("Zgjidh dy klasa");
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        checkBox4.Checked = false;
                    }
                    else
                    {
                        if(checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false || checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false && checkBox4.Checked == false || checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true && checkBox4.Checked == false || checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == true)
                        {
                            MessageBox.Show("Zgjidh dy klasa");
                            checkBox1.Checked = false;
                            checkBox2.Checked = false;
                            checkBox3.Checked = false;
                            checkBox4.Checked = false;
                        }
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //security();
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //security();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //security();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //security();
        }

        private void label17_Click(object sender, EventArgs e)
        {
           
        }

        private void Courses_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            security();
            if (checkBox1.Checked == true && checkBox3.Checked == true)
            {
                Payment p = new Payment(label26.Text, label1.Text, label18.Text, label28.Text, label12.Text, label24.Text, label19.Text, label21.Text, label38.Text, label39.Text, label4.Text, label9.Text);
                p.Show();
                this.Hide();
            }
            else
            {
                if (checkBox1.Checked == true && checkBox4.Checked == true)
                {
                    Payment p = new Payment(label26.Text, label1.Text, label18.Text, label29.Text, label16.Text, label22.Text, label19.Text, label21.Text, label38.Text, label39.Text, label4.Text, label13.Text);
                    p.Show();
                    this.Hide();
                }
                else
                {
                    if(checkBox2.Checked == true && checkBox3.Checked)
                    {
                        Payment p = new Payment(label27.Text, label8.Text, label20.Text, label28.Text, label12.Text, label24.Text, label19.Text, label21.Text, label38.Text, label39.Text, label5.Text, label9.Text);
                        p.Show();
                        this.Hide();
                    }
                    else
                    {
                        if (checkBox2.Checked == true && checkBox4.Checked)
                        {//                            1               2             3          4             5            6             7               8               9           10              11            12                          
                            Payment p = new Payment(label27.Text, label8.Text, label20.Text, label29.Text, label16.Text, label22.Text, label19.Text, label21.Text, label38.Text, label39.Text, label5.Text, label13.Text);
                            p.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
