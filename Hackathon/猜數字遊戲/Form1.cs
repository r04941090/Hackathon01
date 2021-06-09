using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 猜數字遊戲
{
    public partial class Form1 : Form
    {
        List<int> Answer;
        List<string> Process;
        int A;
        int B;
        int NumberCount;
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }
        private void GenerateAnswer()
        {
            Random rnd = new Random();
            //int number;
            //while(Answer.Count < 4)
            //{
            //    number = rnd.Next(0, 9);
            //    if(!Answer.Contains(number))
            //    {
            //        Answer.Add(number);
            //    }
            //}

            List<int> Total = Enumerable.Range(0, 9).Select((x) => x).ToList();
            for (int i = 0; i < NumberCount; i++)
            {
                int index = rnd.Next(0, Total.Count);
                Answer.Add(Total[index]);
                Total.RemoveAt(index);
            }
            //MessageBox.Show(string.Join("", Answer));
        }
        private void Initialize()
        {
            A = 0;
            B = 0;
            NumberCount = 4;
            Answer = new List<int>();
            Process = new List<string>();
            UpdataData();
            
        }
        private void UpdataData()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = Process;
        }
        private void CheckAnswer()
        {
            char[] a = EnterAnswer.Text.ToCharArray();
            A = 0;
            B = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int FindIndex = Answer.FindIndex((x) => x == int.Parse(a[i].ToString()));
                if(FindIndex != -1)
                {
                    if(FindIndex == i)
                    {
                        A++;
                    }
                    else
                    {
                        B++;
                    }
                }
            }
            Process.Add($"{EnterAnswer.Text}：{A}A{B}B");
        }
        private void CheckPass()
        {
            if(A == 4)
            {
                MessageBox.Show("恭喜過關");
            }
        }
        private void Check_Click(object sender, EventArgs e)
        {
            CheckAnswer();
            UpdataData();
            CheckPass();
        }
        private void GiveUp_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        private void Reveal_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join("", Answer));
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Initialize();
            GenerateAnswer();
        }
    }
}
