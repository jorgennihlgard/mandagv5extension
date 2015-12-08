using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mandagv5extension
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = MyStringExtension.Dotify("Hej");
            Console.WriteLine(name);
            Console.WriteLine("Kalle".Dotify());
            Console.WriteLine("Jorgen".Plusplussa());
            Console.ReadLine();
        }
    }
}
