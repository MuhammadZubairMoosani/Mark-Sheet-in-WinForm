using System;
using System.Windows.Forms;

namespace Metric_Mark_Sheet_in_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void engSubBox_TextChanged(object sender, EventArgs e)
        {

        }

        double english, math, history, geography, subTotal, average;

        private void totalBtn_Click(object sender, EventArgs e)
        {
            english = Convert.ToDouble(engSubBox.Text);
            math = Convert.ToDouble(mathSubBox.Text);
            history = Convert.ToDouble(hisSubBox.Text);
            geography = Convert.ToDouble(geoSubBox.Text);
            subTotal = english + math + history + geography;
            string grandTotal = Convert.ToString(subTotal);
            totalBox.Text = grandTotal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            average = subTotal / 4;
            string avrgeInStr = Convert.ToString(average);
            averageBox.Text = avrgeInStr;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (average >= 95)
            {
                gradeBox.Text = "A+";
            }
            else if (average >= 90)
            {
                gradeBox.Text = "A";
            }
            else if (average >= 80)
            {
                gradeBox.Text = "B";
            }
            else if (average >= 70)
            {
                gradeBox.Text = "C";
            }
            else if (average >= 60)
            {
                gradeBox.Text = "D";
            }
            else
            {
                gradeBox.Text = "Fail";
            }
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            rollNoBox.Text = "";
            engSubBox.Text = "";
            mathSubBox.Text = "";
            hisSubBox.Text = "";
            geoSubBox.Text = "";
            totalBox.Text = "";
            averageBox.Text = "";
            gradeBox.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
