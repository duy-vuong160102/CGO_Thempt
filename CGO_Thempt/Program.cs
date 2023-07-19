using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Thempt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap slpt: ");
            int n = int.Parse(Console.ReadLine());

            List<int> lstInpt = new List<int>();    //ko cần khai báo slpt
            for (int i = 0; i < n; i++)
            {
                Console.Write("Gia tri thu {0}= ", i);
                lstInpt.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Du lieu dau: " + string.Join(" ", lstInpt));         //6 2 8 9 0
            lstInpt.Insert(0, 1);//10 6 2 8 9 0
            lstInpt.Insert(2, 20);//10 6 100 2 8 9 0
            Console.WriteLine("Du lieu sau: " + string.Join(" ", lstInpt));

            Console.ReadKey();
        }
    }
}
