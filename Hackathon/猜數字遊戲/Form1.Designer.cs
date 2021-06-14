
namespace 猜數字遊戲
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.Reveal = new System.Windows.Forms.Button();
            this.EnterAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.Button();
            this.GiveUp = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(22, 54);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(112, 34);
            this.Start.TabIndex = 0;
            this.Start.Text = "開始遊戲";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Reveal
            // 
            this.Reveal.Location = new System.Drawing.Point(22, 122);
            this.Reveal.Name = "Reveal";
            this.Reveal.Size = new System.Drawing.Size(112, 34);
            this.Reveal.TabIndex = 1;
            this.Reveal.Text = "看答案";
            this.Reveal.UseVisualStyleBackColor = true;
            this.Reveal.Click += new System.EventHandler(this.Reveal_Click);
            // 
            // EnterAnswer
            // 
            this.EnterAnswer.Location = new System.Drawing.Point(22, 271);
            this.EnterAnswer.Name = "EnterAnswer";
            this.EnterAnswer.Size = new System.Drawing.Size(240, 30);
            this.EnterAnswer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "輸入";
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(22, 320);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(112, 34);
            this.Check.TabIndex = 4;
            this.Check.Text = "檢查答案";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // GiveUp
            // 
            this.GiveUp.Location = new System.Drawing.Point(150, 320);
            this.GiveUp.Name = "GiveUp";
            this.GiveUp.Size = new System.Drawing.Size(112, 34);
            this.GiveUp.TabIndex = 5;
            this.GiveUp.Text = "放棄重來";
            this.GiveUp.UseVisualStyleBackColor = true;
            this.GiveUp.Click += new System.EventHandler(this.GiveUp_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(290, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(336, 372);
            this.listBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "遊戲歷程";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 30);
            this.textBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "數字位數";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.GiveUp);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterAnswer);
            this.Controls.Add(this.Reveal);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "猜數字";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Reveal;
        private System.Windows.Forms.TextBox EnterAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button GiveUp;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}

