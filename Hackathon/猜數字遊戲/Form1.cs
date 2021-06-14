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
        GameHost gameHost;
        List<string> Process;
        public Form1()
        {
            InitializeComponent();
            ChangeFormState(false);
            textBox1.Text = "4";
        }
        public void ChangeFormState(bool Enable)
        {
            Reveal.Enabled = Enable;
            EnterAnswer.Enabled = Enable;
            Check.Enabled = Enable;
            GiveUp.Enabled = Enable;
        }
        private void Initialize()
        {
            Process = new List<string>();
            gameHost = new GameHost(int.Parse(textBox1.Text));
            gameHost.Finish += CheckPass;
            UpdataData();
            
        }
        private void UpdataData()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = Process;
        }
        private void CheckPass()
        {
            MessageBox.Show("恭喜過關");
        }
        private void Check_Click(object sender, EventArgs e)
        {
            Process.Add(gameHost.CheckAnswer(EnterAnswer.Text));
            UpdataData();
        }
        private void GiveUp_Click(object sender, EventArgs e)
        {
            Initialize();
            Start.Enabled = true;
            EnterAnswer.Text = string.Empty;
            ChangeFormState(false);
        }

        private void Reveal_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"答案：{gameHost.GetAnswer()}");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Initialize();
            Start.Enabled = false;
            ChangeFormState(true);
        }
    }
}
