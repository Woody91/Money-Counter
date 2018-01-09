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
        int count4 = 0;  // Sets Value For Each Coin
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
            count += 1; //Adds one on each click
            label1pCounter.Text = count.ToString(); // Changes Coins Selected Amount
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count2 += 1; //Adds one on each click
            label2pCounter.Text = count2.ToString(); // Changes Coins Selected Amount
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count3 += 1; //Adds one on each click
            label5pCounter.Text = count3.ToString(); // Changes Coins Selected Amount
        }

        private void button10p_Click(object sender, EventArgs e)
        {
            count4 += 1; //Adds one on each click
            label10pCounter.Text = count4.ToString(); // Changes Coins Selected Amount
        }

        private void button20p_Click(object sender, EventArgs e)
        {
            count5 += 1; //Adds one on each click
            label20pCounter.Text = count5.ToString(); // Changes Coins Selected Amount
        }

        private void button50p_Click(object sender, EventArgs e)
        {
            count6 += 1; //Adds one on each click
            label50pCounter.Text = count6.ToString(); // Changes Coins Selected Amount
        }

        private void button1Pound_Click(object sender, EventArgs e)
        {
            count7 += 1; //Adds one on each click
            label1POUNDCounter.Text = count7.ToString(); // Changes Coins Selected Amount
        }

        private void button2Pound_Click(object sender, EventArgs e)
        {
            count8 += 1; //Adds one on each click
            label2POUNDCounter.Text = count8.ToString(); // Changes Coins Selected Amount
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Uneccessary Label
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Displays Total Spent in Pence
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Displays Total Spent In Pounds And Pence
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Displays Cost Per Credit
        }

        private void NumOfCred_TextChanged(object sender, EventArgs e)
        {
            // Displays Number Of Credits
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
                        (control as TextBox).Clear(); // Resets All TextBoxes
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