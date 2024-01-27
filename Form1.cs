using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_loop_Table
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "")
            MessageBox.Show("Please Enter 1st Number");



                else if(textBox2.Text == "" )
                MessageBox.Show("Please Enter 2nd Number");


            else
            {
            int tabl_num = Convert.ToInt16(textBox1.Text);
            int desired_num = Convert.ToInt16(textBox2.Text);
            int a = 1;

            

                listBox1.Items.Clear();

                while (a <= desired_num)
                {
                    listBox1.Items.Add(tabl_num + "x" + a + "=" + tabl_num * a);

                    a++;

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();  
        }
    }
}