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

            //var question = new Question2_Ans();
            //question.Run(
            //    ()=> { Console.WriteLine("start"); },
            //    (m)=> { Console.WriteLine($"{m.Name}"); },
            //    (d)=> { Console.WriteLine($"end:{d.ToString()}"); });

            var question = new Question3_Ans();

            question.Run();
        }
    }
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

}
