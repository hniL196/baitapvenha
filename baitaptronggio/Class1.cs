using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitaptronggio
{
    public class Class1
    {
        public string name;
        public int age;

        public string Name { get; set; }

        public int Age { get; set; }

        public void Display (string name, int age)
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
        }       
    }
}
