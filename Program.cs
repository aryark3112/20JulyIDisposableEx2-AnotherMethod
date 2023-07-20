using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20JulyIDisposableEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileHandler filehandler = new FileHandler("Sam File One");

            filehandler.GetFileDetails();
            FileHandler filehandler2 = new FileHandler("Sam File Two");
            filehandler2.GetFileDetails();
            filehandler.Dispose();
            Console.ReadKey();
        }
    }
}
