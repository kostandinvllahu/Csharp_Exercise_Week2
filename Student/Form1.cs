﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // isChecked = radioButton1.Checked;
            //radioButton2.Checked = false;
        }

        public void courses()
        {

        }

        public void totalFees()
        {

        }

        public void clear()
        {
            radioButton1.Checked = false;
           // radioButton2.Checked = false;
        }

        public void Print()
        {
            if (radioButton1.Checked == true)
            {
                label1.Text = "1";
                label2.Text = "Beni";
                label3.Text = "Courses: ";
                label4.Text = "Fees paid so far";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Print();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // string name = "test this point";
            if (radioButton1.Checked == true)
            {  
                Courses c = new Courses(label2.Text);
                c.ShowDialog();
                this.Hide();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
           
        }
    }
}
