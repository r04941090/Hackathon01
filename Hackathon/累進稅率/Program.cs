using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 累進稅率
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine($"請輸入年收入： ");
                Decimal YearSalary = Decimal.Parse(Console.ReadLine());
                Tax tax = new Tax(YearSalary);
                Console.WriteLine(tax.calculate());
                Console.WriteLine("------------------------------------");
            }
        }
    }
}
