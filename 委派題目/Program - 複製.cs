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
            var people = new List<Person>
            {
                new Person { Age=61,Name = "阿三" },
                new Person { Age=55,Name = "李四" },
                new Person { Age=51,Name = "王八" },
                new Person { Age=65,Name = "烏龜" },
                new Person { Age=63,Name = "軟但" },
                new Person { Age=42,Name = "俗仔" },
            };

            var result = CheckAge(people);

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name}:{person.Age}");
            }

            Console.ReadKey();
        }

        static IEnumerable<Person> CheckAge(List<Person> people)
        {
            foreach (var person in people)
            {
                if(person.Age >60)
                  yield return person;
            }
        }
    }


    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
