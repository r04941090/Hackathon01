using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace 猜數字遊戲
{
    delegate void EventHandler();
    class GameHost
    {
        public event EventHandler Finish;
        private List<int> Answer;
        public GameHost(int NumberCount)
        {
            Answer = new List<int>();
            Random rnd = new Random();
            List<int> Total = Enumerable.Range(0, 9).Select((x) => x).ToList();
            for (int i = 0; i < NumberCount; i++)
            {
                int index = rnd.Next(0, Total.Count);
                Answer.Add(Total[index]);
                Total.RemoveAt(index);
            }
        }
        public string CheckAnswer(string EnterAnswer)
        {
            int[] a = Array.ConvertAll(EnterAnswer.ToCharArray().Select((x) => x.ToString()).ToArray(), (x) => int.Parse(x));
            int A = 0;
            int B = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int FindIndex = Answer.FindIndex((x) => x == a[i]);
                if (FindIndex != -1)
                {
                    if (FindIndex == i)
                    {
                        A++;
                    }
                    else
                    {
                        B++;
                    }
                }
            }
            if (A == a.Length)
            {
                Finish?.Invoke();
            }
            return $"{EnterAnswer}：{A}A{B}B";
        }
        public string GetAnswer()
        {
            return string.Join("", Answer);
        }
    }
}
