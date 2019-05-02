using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委派題目
{
    //當希望CheckAge 能同時用在Male跟Female類別的時候要怎麼改?
    public class Question3_Ans
    {
        public void Run()
        {
            var male = new List<Male>
            {
                new Male { Age=61,Name = "阿三" },
                new Male { Age=55,Name = "李四" },
                new Male { Age=51,Name = "王八" },
                new Male { Age=65,Name = "烏龜" },
                new Male { Age=63,Name = "軟但" },
                new Male { Age=42,Name = "俗仔" },
            };

            var femail = new List<Female>
            {
                new Female { Age=61,Name = "阿花" },
                new Female { Age=55,Name = "三八" },
                new Female { Age=51,Name = "水姑娘" },
                new Female { Age=65,Name = "長舌婦" },
                new Female { Age=63,Name = "水蛇腰" },
                new Female { Age=42,Name = "如花" },
            };

            var result = CheckAge<Male>(male);
            var result2 = CheckAge<Female>(femail);

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name}:{person.Age}");
            }
            
            Console.ReadKey();
        }

        private IEnumerable<T1> CheckAge<T1>(List<T1> people, Func<int, bool> eachPerson = null) where T1 : Person
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