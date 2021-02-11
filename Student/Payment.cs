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
    public partial class Payment : Form
    {
                            //1           2            3             4           5           6              7               8                 9              10          11         12                     
        public Payment(string id, string namec, string price, string id1, string namec1, string price1, string charge1, string charge2, string num1, string num2, string op1, string op2)
        {
            InitializeComponent();
            clean();
            label1.Text = id;
            label2.Text = namec;
            label3.Text = price;
            label6.Text = id1;
            label5.Text = namec1;
            label4.Text = price1;
            label7.Text = charge1;
            label8.Text = charge2;
            label16.Text = num1;
            label20.Text = num2;
            label25.Text = op1;
            label26.Text = op2;
            calculate();
        }

        public void calculate()
        {
            if (label25.Text == "Onsite" && label26.Text == "Onsite")
            {
                
                int num1 = Convert.ToInt32(label3.Text);
                int num2 = Convert.ToInt32(label7.Text);
                int total = num1 + num2 * num1 / 100;
                textBox5.Text = Convert.ToString(total);

                int num3 = Convert.ToInt32(label4.Text);
                int num4 = Convert.ToInt32(label8.Text);
                int total1 = num3 + num4 * num3 / 100;
                textBox6.Text = Convert.ToString(total1);
                int totpay = total + total1;
                double fee = Convert.ToDouble(totpay) * 0.123;
                int tax = Convert.ToInt32(fee) + totpay;
                textBox7.Text = Convert.ToString(tax);
                textBox8.Text = Convert.ToString(tax);
               // string pay = null;
                //textBox7.Text = pay;
                //int tobepaid = tax;
                textBox8.Text = Convert.ToString(tax);


            }
            else
            {
                if(label25.Text == "Online" && label26.Text == "Online")
                {
                    int num1 = Convert.ToInt32(label3.Text);
                    int num2 = Convert.ToInt32(label7.Text);
                    int total = num1 - num2 * num1 / 100;
                    textBox5.Text = Convert.ToString(total);

                    int num3 = Convert.ToInt32(label4.Text);
                    int num4 = Convert.ToInt32(label8.Text);
                    int total1 = num3 - num4 * num3 / 100;
                    textBox6.Text = Convert.ToString(total1);
                    int totpay = total + total1;
                    textBox7.Text = Convert.ToString(totpay);
                    int tobepaid = totpay;
                    textBox8.Text = Convert.ToString(totpay);
                }
                else
                {
                    if(label25.Text == "Onsite" && label26.Text == "Online")
                    {
                        int num1 = Convert.ToInt32(label3.Text);
                        int num2 = Convert.ToInt32(label7.Text);
                        int total = num1 + num2 * num1 / 100;
                        textBox5.Text = Convert.ToString(total);

                        int num3 = Convert.ToInt32(label4.Text);
                        int num4 = Convert.ToInt32(label8.Text);
                        int total1 = num3 - num4 * num3 / 100;
                        textBox6.Text = Convert.ToString(total1);
                        int totpay = total + total1;
                        textBox7.Text = Convert.ToString(totpay);
                        int tobepaid = totpay;
                        textBox8.Text = Convert.ToString(totpay);
                    }
                    else
                    {
                        if(label25.Text == "Online" && label26.Text == "Onsite")
                        {
                            int num1 = Convert.ToInt32(label3.Text);
                            int num2 = Convert.ToInt32(label7.Text);
                            int total = num1 - num2 * num1 / 100;
                            textBox5.Text = Convert.ToString(total);

                            int num3 = Convert.ToInt32(label4.Text);
                            int num4 = Convert.ToInt32(label8.Text);
                            int total1 = num3 + num4 * num3 / 100;
                            textBox6.Text = Convert.ToString(total1);
                            int totpay = total + total1;
                            textBox7.Text = Convert.ToString(totpay);
                            int tobepaid = totpay;
                            textBox8.Text = Convert.ToString(totpay);
                        }
                    }
                }
            }


        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Courses c = new Courses(label2.Text);
            c.Show();
            this.Hide();
        }
        public void clean()
        {
            radioButton1.Checked = false;
          //  radioButton2.Checked = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button3.Visible = false;
            textBox9.Visible = false;
            label27.Visible = false;
           
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                button3.Visible = true;
                textBox1.Text = label3.Text;
                textBox2.Text = label7.Text;
                textBox9.Visible = true;
                label27.Visible = true;
                if (label16.Text == "Extra Charge %:")
                {
                    int a = Convert.ToInt32(textBox1.Text);
                    int b = Convert.ToInt32(textBox2.Text);
                    int c = a + b * a / 100;
                    textBox3.Text = Convert.ToString(c.ToString());
                }
               
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           /* if (radioButton2.Checked == true)
            {
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                button3.Visible = true;
            }*/
        }

        /*  else
               {
                   if (textBox8.Text == "")
                   {
                       radioButton1.Visible = false;
                       radioButton2.Visible = false;
                       label9.Visible = false;
                       label10.Visible = false;
                       label11.Visible = false;
                       label12.Visible = false;
                       textBox1.Visible = false;
                       textBox2.Visible = false;
                       textBox3.Visible = false;
                       textBox4.Visible = false;
                       button3.Visible = false;

                       MessageBox.Show("Pagesa u be totale");
                   }
               } */

        private void button3_Click(object sender, EventArgs e)
        {
            calculate();
            int shuma = Convert.ToInt32(textBox4.Text);
            int pag = Convert.ToInt32(textBox8.Text);
            if (shuma > pag || shuma < pag)
            {
                MessageBox.Show("Pagesa te behet fikse ose me pake");
                textBox4.Text = "";
            }
            else
            {
                if (shuma == pag)
                {
                    int total = pag - shuma;
                    textBox8.Text = Convert.ToString(total);
                    MessageBox.Show("Total u paguan " + shuma + " mbetja eshte " + total);
                    if (textBox8.Text == "0")
                    {
                        radioButton1.Visible = false;
                       // radioButton2.Visible = false;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;
                        textBox1.Visible = false;
                        textBox2.Visible = false;
                        textBox3.Visible = false;
                        textBox4.Visible = false;
                        button3.Visible = false;
                        textBox9.Visible = false;
                        label27.Visible = false;

                        MessageBox.Show("Pagesa u be totale");
                    }
                }

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //textBox5.Text = textBox3.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
