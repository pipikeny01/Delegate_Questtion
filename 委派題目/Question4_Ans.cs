using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委派題目
{
    /// <summary>
    /// 使用泛型讓MyAdd方法可以用在任何型別
    /// </summary>
    public class Question4_Ans<T>
    {
        private List<T> _data = new List<T>();

        public List<T> MyAdd(T value)
        {
            var v = value.ToString();
            _data.Add(value);

            return _data;
        }
    }
}