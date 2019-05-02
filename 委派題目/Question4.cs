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
    public class Question4
    {
        private List<string> _data = new List<string>();

        public List<string> MyAdd(string value)
        {
            _data.Add($"myAdd_{value}");
            return _data;
        }
    }
}