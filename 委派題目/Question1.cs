using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委派題目
{
    //當年齡的判斷要加入其他使用委派要怎麼改?
    public class Question1
    {
        public void Run()
        {
            var people = new List<Male>
            {
                new Male { Age=61,Name = "阿三" },
                new Male { Age=55,Name = "李四" },
                new Male { Age=51,Name = "王八" },
                new Male { Age=65,Name = "烏龜" },
                new Male { Age=63,Name = "軟但" },
                new Male { Age=42,Name = "俗仔" },
            };

            var result = CheckAge(people);

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name}:{person.Age}");
            }

            Console.ReadKey();
        }

        private IEnumerable<Male> CheckAge(List<Male> people)
        {
            foreach (var person in people)
            {
                if (person.Age > 60)
                    yield return person;
            }
        }
    }

    public class Male : Person
    {
    }
}