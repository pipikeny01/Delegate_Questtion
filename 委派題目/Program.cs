using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委派題目
{
    class Program
    {
        static void Main(string[] args)
        {

            var question = new Question1();
            question.Run();
        } 

    }
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

}
