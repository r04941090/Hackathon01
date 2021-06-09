using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 溫度轉換
{
    public partial class Form1 : Form
    {
        StringBuilder data;
        public Form1()
        {
            InitializeComponent();
            ResetData();
        }
        private double Calculate(string rawData, bool CToF)
        {
            double data = Convert.ToDouble(rawData);
            double result;
            if (CToF)
            {
                result = ((double)9 / 5) * data + 32; 
            }
            else
            {
                result = (data - 32) * (double)5 / 9;
            }
            return Math.Round(result, 1, MidpointRounding.AwayFromZero);
            // https://neilw.tw/2017/08/18/c-%E5%B0%8F%E6%95%B8%E9%BB%9E%E4%BD%8D%E6%95%B8/
        }
        private void ResetData()
        {
            data = new StringBuilder();
            textBox1.Text = data.ToString();
        }
        private void Display(double result, bool choose)
        {
            if (choose)
            {
                label1.Text = $"{data.ToString()}°C = {result.ToString()}°F";
            }
            else
            {
                label1.Text = $"{data.ToString()}°F = {result.ToString()}°C";
            }
        }
        private void AppendData(string enter)
        {
            textBox1.Text = data.Append(enter).ToString();
        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            Display(Calculate(data.ToString(),radioButton1.Checked), radioButton1.Checked);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResetData();
        }

        private void Number1_Click(object sender, EventArgs e)
        {

            AppendData(Number1.Text);
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            AppendData(Number2.Text);
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            AppendData(Number3.Text);
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            AppendData(Number4.Text);
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            AppendData(Number5.Text);
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            AppendData(Number6.Text);
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            AppendData(Number7.Text);
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            AppendData(Number8.Text);
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            AppendData(Number9.Text);
        }

        private void Number0_Click(object sender, EventArgs e)
        {
            AppendData(Number0.Text);
        }

        private void dot_Click(object sender, EventArgs e)
        {
            AppendData(dot.Text);
        }
    }
}
