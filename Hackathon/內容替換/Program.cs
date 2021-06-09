using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 內容替換
{
    class Program
    {
        // 用IEnumerable試看看
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個整數max(至少大於90)： ");
            int data = int.Parse(Console.ReadLine());
            for (int i = 1; i < data + 1; i++)
            {
                string result;
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result = "Dann";
                }
                else if (i % 5 == 0)
                {
                    result = "School";
                }
                else if (i % 3 == 0)
                {
                    result = "Build";
                }
                else
                {
                    result = i.ToString();
                }
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }

        
    }

}
