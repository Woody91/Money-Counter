using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int count = 0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;
        int count5 = 0;
        int count6 = 0;
        int count7 = 0;
        int count8 = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count += 1;
            label1pCounter.Text = count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count2 += 1;
            label2pCounter.Text = count2.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count3 += 1;
            label5pCounter.Text = count3.ToString();
        }

        private void button10p_Click(object sender, EventArgs e)
        {
            count4 += 1;
            label10pCounter.Text = count4.ToString();
        }

        private void button20p_Click(object sender, EventArgs e)
        {
            count5 += 1;
            label20pCounter.Text = count5.ToString();
        }

        private void button50p_Click(object sender, EventArgs e)
        {
            count6 += 1;
            label50pCounter.Text = count6.ToString();
        }

        private void button1Pound_Click(object sender, EventArgs e)
        {
            count7 += 1;
            label1POUNDCounter.Text = count7.ToString();
        }

        private void button2Pound_Click(object sender, EventArgs e)
        {
            count8 += 1;
            label2POUNDCounter.Text = count8.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumOfCred_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetBut_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };
            func(Controls);
        }
    }
}