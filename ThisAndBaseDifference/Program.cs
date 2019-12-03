using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisAndBaseDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            //子類別繼承父類別後，當存取同名的成員時，可以使用base和this來區分是存取父類別或子類別的成員，this：代表目前類別，可以用來識別類別成員或區域變數
            Class1 class1 = new Class1();
            class1.Method("Hello");

            DerivedClass md = new DerivedClass();
            DerivedClass md1 = new DerivedClass(1);
            Console.ReadKey();

            Console.ReadLine();
        }
    }
}
