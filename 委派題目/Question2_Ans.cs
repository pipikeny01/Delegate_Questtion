using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委派題目
{
    //我希望在開始和結束時候可以自訂顯示訊息 , 
    //1.在結束時顯示在此物件結束時間 
    //2.替集合中的名字加上括號
    //以上使用委派該怎麼改
    public class Question2_Ans
    {
        public void Run(Action whenBegin = null, Action<Male> whenEach = null, Action<DateTime> whenEnd = null)
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

            if (whenBegin != null)
                whenBegin();
            else            
                Console.WriteLine($"開始嘍!");

            foreach (var person in result)
            {
                whenEach?.Invoke(person);
                Console.WriteLine($"{person.Name}:{person.Age}");
            }

            if (whenEnd != null)
                whenEnd(DateTime.Now);
            else
                Console.WriteLine($"結束嘍!");


            Console.ReadKey();

        }

        IEnumerable<Male> CheckAge(List<Male> people)
        {

            foreach (var person in people)
            {
                if (person.Age > 60)
                    yield return person;
            }
        }

    }



}
