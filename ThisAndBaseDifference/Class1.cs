using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisAndBaseDifference
{
    class Class1
    {
        string data = "World";
        public void Method(string data)               //假設 資料="Hello"
        {
            System.Console.WriteLine(data);       //顯示：Hello
            System.Console.WriteLine(this.data);  //顯示：World
        }
    }
}
