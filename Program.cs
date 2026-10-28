using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var menu = new Stack<string>();
            int i = 1;
            while (i <= 5)
            { 
                Console.WriteLine("===กรุณาเลือกเมนู :===");
                menu.Push(Console.ReadLine());
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("===ชื่อเมนูทั้งหมด===");
            while (i >= 1)
            {
                Console.WriteLine(menu.Pop());
                i--;
            }

        }
    }
}
