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
            //Example 1
            //FileHandler filehandler = new FileHandler("Sam File One");

            //filehandler.GetFileDetails();
            //FileHandler filehandler2 = new FileHandler("Sam File Two");
            //filehandler2.GetFileDetails();
            //filehandler.Dispose();

            //Example 2
            using (FileHandler obj1 = new FileHandler("Document-001") )
            {
                obj1.GetFileDetails();
            }
            using (FileHandler obj2 = new FileHandler("Document-002"))
            {
                obj2.GetFileDetails();
            }
            Console.ReadKey();
        }
    }
}
