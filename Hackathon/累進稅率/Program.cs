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
        



        //static decimal calculate2(Decimal YearSalary)
        //{
        //    decimal result = 0;
        //    decimal[] range = new decimal[]
        //    {
        //        0m, 540000m, 1210000m, 2420000m, 4530000m, 10310000m
        //    };
        //    decimal[] percentage = new decimal[]
        //    {
        //        0.05m, 0.12m, 0.2m, 0.3m, 0.4m, 0.5m
        //    };

        //    if (YearSalary >= 0 && YearSalary <= range[0])
        //    {
        //        result = (YearSalary - range[0]) * percentage[0];
        //    }
        //    else if(YearSalary >= range[0] + 1 && YearSalary <= range[1])
        //    {
        //        result = (YearSalary - range[1]) * percentage[1] + (range[1] - range[0]) * percentage[0];
        //    }
        //    else if(YearSalary >= range[1] + 1 && YearSalary <= range[2])
        //    {
        //        result = (YearSalary - range[2]) * percentage[2] + (range[2] - range[1]) * percentage[1] + range[0] * percentage[0];
        //    }
        //    else if (YearSalary >= range[2] + 1 && YearSalary <= range[3])
        //    {
        //        result = (YearSalary - range[3]) * percentage[3] + (range[3] - range[2]) * percentage[2] + (range[1] - range[0]) * percentage[1] + range[0] * percentage[0];
        //    }
        //    else if (YearSalary >= range[3] + 1 && YearSalary <= range[4])
        //    {
        //        result = (YearSalary - range[4]) * percentage[4] + (range[4] - range[3]) * percentage[3] + (range[2] - range[1]) * percentage[2] + (range[1] - range[0]) * percentage[1] + range[0] * percentage[0];
        //    }
        //    else
        //    {
        //        result = (YearSalary - range[5]) * percentage[5] + (range[5] - range[4]) * percentage[4] + (range[3] - range[2]) * percentage[3] + (range[2] - range[1]) * percentage[2] + (range[1] - range[0]) * percentage[1] + range[0] * percentage[0];
        //    }
        //    return result;
        //}
        
    }
}
