using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR _Week10_3");
            string ans = "yes";
            while (ans == "yes")
            {
                Console.Write("請輸入身高值:");
                string cmStr = Console.ReadLine();
                int cm = int.Parse(cmStr);
                if (cm < 120)
                {
                    Console.WriteLine("身高值:{0}，免費", cm);
                }
                else if (cm >= 120 && cm <= 150)
                {
                    Console.WriteLine("身高值:{0}，半價", cm);
                }
                else if (cm > 150)
                {
                    Console.WriteLine("身高值:{0}，全票", cm);
                }
                Console.Write("請輸入\"yes\"繼續計算，其它任意鍵離開:");
                ans = Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
