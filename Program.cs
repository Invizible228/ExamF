using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1pr31s18
{
    public class Program
    {
        Programmer cc = new Programmer();   
        static void Main(string[] args)
        {
            Console.Write("Напишите фамилию:");
            string surname = Console.ReadLine();
            Console.Write("Напишите количество ЯП:");
            int PLcount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Напишите количество написанных программ:");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Напишите количество правильно написанных программ:");
            int p = Convert.ToInt32(Console.ReadLine());
            int q = 0;
            int qp = 0;
            Console.WriteLine("Качество обьекта:" + Programmer.Quality(q, PLcount, quantity));
            Console.WriteLine("Число всех программ:"+Ancestor.Calculating(qp, p, q, PLcount, quantity));
            Console.Write("Нажмите любую клавишу для закрытия программы...");
            Console.ReadKey();
        }
    }
}
