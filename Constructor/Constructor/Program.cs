using System;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----demo on constructor----");
            
            Date mydate=new Date();               //non parametric 
            Console.WriteLine(mydate.GetData());

            Date date2=new Date(10,"may",2020);  //using parameters
            Console.WriteLine(date2.GetData());
        }
    }
}
