using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;



namespace CreatingDll
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---demo dll file---");
            Class1 class1= new Class1();
            Console.WriteLine(class1.Add(10,5));
            Console.WriteLine(class1.ASquare(4));
            
        }
    }
}
