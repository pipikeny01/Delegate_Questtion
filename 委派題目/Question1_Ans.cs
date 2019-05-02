using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委派題目
{
    public class Question1_Ans
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

            var result = CheckAge(people, (age) =>
            {
                return age > 50;
            });

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name}:{person.Age}");
            }

            Console.ReadKey();


        }



        IEnumerable<Male> CheckAge(List<Male> people ,Func<int,bool> eachPerson = null)
        {
            foreach (var person in people)
            {
                if (eachPerson != null)
                {
                    if (eachPerson(person.Age))
                        yield return person;
                }
                else
                {
                    if (person.Age > 60)
                        yield return person;
                }
            }
        }

    }



}
