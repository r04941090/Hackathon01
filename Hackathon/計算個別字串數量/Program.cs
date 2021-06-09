using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 計算個別字串數量
{
    class Program
    {
        static void Main(string[] args)
        {
            // 用groupby
            Console.WriteLine("請輸入有意義的英文敘述字串： ");
            string data = Console.ReadLine().ToLower();
            List<string> data2 = data.Split().ToList();
            //while(data2.Count() > 0)
            //{
            //    string item = data2[0];
            //    int count = data2.FindAll((x) => x.ToLower() == data2[0].ToLower()).Count;
            //    data2.RemoveAll((x) => x.ToLower() == item.ToLower());

            //    Console.WriteLine($"{item}：{count}");
            //}

            var data3 = data2.GroupBy((x) => x).Select((x) => new {item = x.Key, count = x.Count() });
            foreach(var item in data3)
            {
                Console.WriteLine($"{item.item}：{item.count}");
            }

            string a = "1234";
            string[] input = a.Split();
            int[] array = Array.ConvertAll(a.ToCharArray().Select((x)=> x.ToString()).ToArray(), (x) => int.Parse(x));

            Console.ReadLine();
        }
    }
}
