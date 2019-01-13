using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDialogs;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1p_Click(object sender, EventArgs e)
        {
  
            int costOfCredit = Convert.ToInt32(creditCost.Text);

            if (costOfCredit <= 0) // The following IF statement (for all coins), will not allow the user to click on the coins as normal, if their new input is 0 or below.
            {
                MessageBox.Show("You must set a credit cost higher than 0!");
            }
            else // The rest of the code executes if all is valid.
            {

                int onePenceCount= int.Parse(label1pCounter.Text);
                onePenceCount ++;
                label1pCounter.Text = onePenceCount.ToString(); //This sequence of code simply increments the coin counter by one with each click, to represent how many the user has selected. The code, with the exception of variable names and output targets, is uniform for each coin.

                int onePenceValue = int.Parse(totalPenceVal.Text);
                onePenceValue ++;
                totalPenceVal.Text = onePenceValue.ToString(); //This adds up the value of the coin, in this case, 1 pence, and adds it to the total pence value selected so far. The code works in the same way for the rest of the coins.

                double onePenceValueInPounds = double.Parse(totalPoundVal.Text);
                onePenceValueInPounds = onePenceValueInPounds + 0.01;
                totalPoundVal.Text = onePenceValueInPounds.ToString(); //This adds the value of the coin too, but this time in pounds and pence, a decimal figure. It is then displayed in an appropriate textbox.

                int creditCount = Convert.ToInt32(creditCost.Text);
                int credits = onePenceValue / creditCount;
                creditNum.Text = credits.ToString(); // This creates a new integer out of the user specified credit cost, and divides that by the total in pence to give an amount of current credits.
            }

        }

        private void button2p_Click(object sender, EventArgs e)
        {
            int costOfCredit = Convert.ToInt32(creditCost.Text);

            if (costOfCredit <= 0) // The following IF statement (for all coins), will not allow the user to click on the coins as normal, if their new input is 0 or below.
            {
                MessageBox.Show("You must set a credit cost higher than 0!");
            }
            else // The rest of the code executes if all is valid.
            {

                int twoPenceCount = int.Parse(label2pCounter.Text);
                twoPenceCount++;
                label2pCounter.Text = twoPenceCount.ToString(); //This sequence of code simply increments the coin counter by one with each click, to represent how many the user has selected. The code, with the exception of variable names and output targets, is uniform for each coin.

                int twoPenceValue = int.Parse(totalPenceVal.Text);
                twoPenceValue = twoPenceValue +2;
                totalPenceVal.Text = twoPenceValue.ToString(); //This adds up the value of the coin, in this case, 1 pence, and adds it to the total pence value selected so far. The code works in the same way for the rest of the coins.

                double twoPenceValueInPounds = double.Parse(totalPoundVal.Text);
                twoPenceValueInPounds = twoPenceValueInPounds + 0.02;
                totalPoundVal.Text = twoPenceValueInPounds.ToString(); //This adds the value of the coin too, but this time in pounds and pence, a decimal figure. It is then displayed in an appropriate textbox.

                int creditCount = Convert.ToInt32(creditCost.Text);
                int credits = twoPenceValue / creditCount;
                creditNum.Text = credits.ToString(); // This creates a new integer out of the user specified credit cost, and divides that by the total in pence to give an amount of current credits.
            }
        }

        private void button5p_Click(object sender, EventArgs e)
        {
            int costOfCredit = Convert.ToInt32(creditCost.Text);

            if (costOfCredit <= 0) // The following IF statement (for all coins), will not allow the user to click on the coins as normal, if their new input is 0 or below.
            {
                MessageBox.Show("You must set a credit cost higher than 0!");
            }
            else // The rest of the code executes if all is valid.
            {

                int fivePenceCount = int.Parse(label5pCounter.Text);
                fivePenceCount++;
                label5pCounter.Text = fivePenceCount.ToString(); //This sequence of code simply increments the coin counter by one with each click, to represent how many the user has selected. The code, with the exception of variable names and output targets, is uniform for each coin.

                int fivePenceValue = int.Parse(totalPenceVal.Text);
                fivePenceValue = fivePenceValue +5;
                totalPenceVal.Text = fivePenceValue.ToString(); //This adds up the value of the coin, in this case, 1 pence, and adds it to the total pence value selected so far. The code works in the same way for the rest of the coins.

                double fivePenceValueInPounds = double.Parse(totalPoundVal.Text);
                fivePenceValueInPounds = fivePenceValueInPounds + 0.05;
                totalPoundVal.Text = fivePenceValueInPounds.ToString(); //This adds the value of the coin too, but this time in pounds and pence, a decimal figure. It is then displayed in an appropriate textbox.

                int creditCount = Convert.ToInt32(creditCost.Text);
                int credits = fivePenceValue / creditCount;
                creditNum.Text = credits.ToString(); // This creates a new integer out of the user specified credit cost, and divides that by the total in pence to give an amount of current credits.
            }
        }

        private void button10p_Click(object sender, EventArgs e)
        {
            int costOfCredit = Convert.ToInt32(creditCost.Text);

            if (costOfCredit <= 0) // The following IF statement (for all coins), will not allow the user to click on the coins as normal, if their new input is 0 or below.
            {
                MessageBox.Show("You must set a credit cost higher than 0!");
            }
            else // The rest of the code executes if all is valid.
            {

                int tenPenceCount = int.Parse(label10pCounter.Text);
                tenPenceCount++;
                label10pCounter.Text = tenPenceCount.ToString(); //This sequence of code simply increments the coin counter by one with each click, to represent how many the user has selected. The code, with the exception of variable names and output targets, is uniform for each coin.

                int tenPenceValue = int.Parse(totalPenceVal.Text);
                tenPenceValue = tenPenceValue + 10;
                totalPenceVal.Text = tenPenceValue.ToString(); //This adds up the value of the coin, in this case, 1 pence, and adds it to the total pence value selected so far. The code works in the same way for the rest of the coins.

                double tenPenceValueInPounds = double.Parse(totalPoundVal.Text);
                tenPenceValueInPounds = tenPenceValueInPounds + 0.1;
                totalPoundVal.Text = tenPenceValueInPounds.ToString(); //This adds the value of the coin too, but this time in pounds and pence, a decimal figure. It is then displayed in an appropriate textbox.

                int creditCount = Convert.ToInt32(creditCost.Text);
                int credits = tenPenceValue / creditCount;
                creditNum.Text = credits.ToString(); // This creates a new integer out of the user specified credit cost, and divides that by the total in pence to give an amount of current credits.
            }
        }

        private void button20p_Click(object sender, EventArgs e)
        {
            int costOfCredit = Convert.ToInt32(creditCost.Text);

            if (costOfCredit <= 0) // The following IF statement (for all coins), will not allow the user to click on the coins as normal, if their new input is 0 or below.
            {
                MessageBox.Show("You must set a credit cost higher than 0!");
            }
            else // The rest of the code executes if all is valid.
            {

                int twentyPenceCount = int.Parse(label20pCounter.Text);
                twentyPenceCount++;
                label20pCounter.Text = twentyPenceCount.ToString(); //This sequence of code simply increments the coin counter by one with each click, to represent how many the user has selected. The code, with the exception of variable names and output targets, is uniform for each coin.

                int twentyPenceValue = int.Parse(totalPenceVal.Text);
                twentyPenceValue = twentyPenceValue +20;
                totalPenceVal.Text = twentyPenceValue.ToString(); //This adds up the value of the coin, in this case, 1 pence, and adds it to the total pence value selected so far. The code works in the same way for the rest of the coins.

                double twentyPenceValueInPounds = double.Parse(totalPoundVal.Text);
                twentyPenceValueInPounds = twentyPenceValueInPounds + 0.2;
                totalPoundVal.Text = twentyPenceValueInPounds.ToString(); //This adds the value of the coin too, but this time in pounds and pence, a decimal figure. It is then displayed in an appropriate textbox.

                int creditCount = Convert.ToInt32(creditCost.Text);
                int credits = twentyPenceValue / creditCount;
                creditNum.Text = credits.ToString(); // This creates a new integer out of the user specified credit cost, and divides that by the total in pence to give an amount of current credits.
            }
        }

        private void button50p_Click(object sender, EventArgs e)
        {
            int costOfCredit = Convert.ToInt32(creditCost.Text);

            if (costOfCredit <= 0) // The following IF statement (for all coins), will not allow the user to click on the coins as normal, if their new input is 0 or below.
            {
                MessageBox.Show("You must set a credit cost higher than 0!");
            }
            else // The rest of the code executes if all is valid.
            {

                int fiftyPenceCount = int.Parse(label50pCounter.Text);
                fiftyPenceCount++;
                label50pCounter.Text = fiftyPenceCount.ToString(); //This sequence of code simply increments the coin counter by one with each click, to represent how many the user has selected. The code, with the exception of variable names and output targets, is uniform for each coin.

                int fiftyPenceValue = int.Parse(totalPenceVal.Text);
                fiftyPenceValue = fiftyPenceValue + 50;
                totalPenceVal.Text = fiftyPenceValue.ToString(); //This adds up the value of the coin, in this case, 1 pence, and adds it to the total pence value selected so far. The code works in the same way for the rest of the coins.

                double fiftyPenceValueInPounds = double.Parse(totalPoundVal.Text);
                fiftyPenceValueInPounds = fiftyPenceValueInPounds + 0.5;
                totalPoundVal.Text = fiftyPenceValueInPounds.ToString(); //This adds the value of the coin too, but this time in pounds and pence, a decimal figure. It is then displayed in an appropriate textbox.

                int creditCount = Convert.ToInt32(creditCost.Text);
                int credits = fiftyPenceValue / creditCount;
                creditNum.Text = credits.ToString(); // This creates a new integer out of the user specified credit cost, and divides that by the total in pence to give an amount of current credits.
            }
        }

        private void button1Pound_Click(object sender, EventArgs e)
        {
            int costOfCredit = Convert.ToInt32(creditCost.Text);

            if (costOfCredit <= 0) // The following IF statement (for all coins), will not allow the user to click on the coins as normal, if their new input is 0 or below.
            {
                MessageBox.Show("You must set a credit cost higher than 0!");
            }
            else // The rest of the code executes if all is valid.
            {

                int onePoundCount = int.Parse(label1PoundCounter.Text);
                onePoundCount++;
                label1PoundCounter.Text = onePoundCount.ToString(); //This sequence of code simply increments the coin counter by one with each click, to represent how many the user has selected. The code, with the exception of variable names and output targets, is uniform for each coin.

                int onePoundValue = int.Parse(totalPenceVal.Text);
                onePoundValue = onePoundValue + 100;
                totalPenceVal.Text = onePoundValue.ToString(); //This adds up the value of the coin, in this case, 1 pence, and adds it to the total pence value selected so far. The code works in the same way for the rest of the coins.

                double onePoundValueInPounds = double.Parse(totalPoundVal.Text);
                onePoundValueInPounds = onePoundValueInPounds + 1;
                totalPoundVal.Text = onePoundValueInPounds.ToString(); //This adds the value of the coin too, but this time in pounds and pence, a decimal figure. It is then displayed in an appropriate textbox.

                int creditCount = Convert.ToInt32(creditCost.Text);
                int credits = onePoundValue / creditCount;
                creditNum.Text = credits.ToString(); // This creates a new integer out of the user specified credit cost, and divides that by the total in pence to give an amount of current credits.
            }
        }

        private void button2Pound_Click(object sender, EventArgs e)
        {
            int costOfCredit = Convert.ToInt32(creditCost.Text);

            if (costOfCredit <= 0) // The following IF statement (for all coins), will not allow the user to click on the coins as normal, if their new input is 0 or below.
            {
                MessageBox.Show("You must set a credit cost higher than 0!");
            }
            else // The rest of the code executes if all is valid.
            {

                int twoPoundCount = int.Parse(label2PoundCounter.Text);
                twoPoundCount++;
                label2PoundCounter.Text = twoPoundCount.ToString(); //This sequence of code simply increments the coin counter by one with each click, to represent how many the user has selected. The code, with the exception of variable names and output targets, is uniform for each coin.

                int twoPoundValue = int.Parse(totalPenceVal.Text);
                twoPoundValue = twoPoundValue +200;
                totalPenceVal.Text = twoPoundValue.ToString(); //This adds up the value of the coin, in this case, 1 pence, and adds it to the total pence value selected so far. The code works in the same way for the rest of the coins.

                double twoPoundValueInPounds = double.Parse(totalPoundVal.Text);
                twoPoundValueInPounds = twoPoundValueInPounds + 2;
                totalPoundVal.Text = twoPoundValueInPounds.ToString(); //This adds the value of the coin too, but this time in pounds and pence, a decimal figure. It is then displayed in an appropriate textbox.

                int creditCount = Convert.ToInt32(creditCost.Text);
                int credits = twoPoundValue / creditCount;
                creditNum.Text = credits.ToString(); // This creates a new integer out of the user specified credit cost, and divides that by the total in pence to give an amount of current credits.
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            int zero = 0;
            int creditCounter = Convert.ToInt32(creditCost.Text);
            creditCounter = 0;

            int totalPence = 0;

            double totalPounds = 0.00;
            creditCost.Text = zero.ToString();
            creditNum.Text = creditCounter.ToString();
            totalPenceVal.Text = totalPence.ToString();
            totalPoundVal.Text = totalPounds.ToString(); // The above resets previously used variables to default values of 0 and inputs the into their respective boxes, to reset program progress.
            label1pCounter.Text = "0";
            label2pCounter.Text = "0";
            label5pCounter.Text = "0";
            label10pCounter.Text = "0";
            label20pCounter.Text = "0";
            label50pCounter.Text = "0";
            label1PoundCounter.Text = "0";
            label2PoundCounter.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //These are the default values as soon as the form loads. - (0)
            int zero = 0;
            int creditCounter = 0;

            int totalPence = 0;

            double totalPounds = 0.00;
            creditCost.Text = zero.ToString();
            creditNum.Text = creditCounter.ToString();
            totalPenceVal.Text = totalPence.ToString();
            totalPoundVal.Text = totalPounds.ToString(); // The above resets previously used variables to default values of 0 and inputs the into their respective boxes, to reset program progress.
            label1pCounter.Text = "0";
            label2pCounter.Text = "0";
            label5pCounter.Text = "0";
            label10pCounter.Text = "0";
            label20pCounter.Text = "0";
            label50pCounter.Text = "0";
            label1PoundCounter.Text = "0";
            label2PoundCounter.Text = "0";
        }
    }
}
