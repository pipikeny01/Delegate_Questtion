using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委派題目
{
    /// <summary>
    /// fun1~ fun3 都有一段判斷條件 , 如何把判斷的部分共用 ?  必須使用委派的概念
    /// </summary>
    public class Question5
    {
        int _param1 = 0;
        int _param2 = 0;
        string _param3 = "";
        public Question5(int param1 , int param2 ,string param3)
        {
            _param1 = param1;
            _param2 = param2;
            _param3 = param3;
        }

        string fun1()
        {
            if (_param1 == 0 || _param2 == 0 || _param3 == "")
            {
                throw new Exception("參數錯誤");
            }
            else
            {
                return ("fun1");
            }
        }

        string fun2()
        {
            if (_param1 == 0 || _param2 == 0 || _param3 == "")
            {
                throw new Exception("參數錯誤");
            }
            else
            {
                return ("fun2");
            }
        }

        string fun3()
        {
            if (_param1 == 0 || _param2 == 0 || _param3 == "")
            {
                throw new Exception("參數錯誤");
            }
            else
            {
                return ("fun3");
            }
        }

    }
}
