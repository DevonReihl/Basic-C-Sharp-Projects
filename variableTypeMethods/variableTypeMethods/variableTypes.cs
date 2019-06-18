using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variableTypeMethods
{
    class variableTypes
    {
        public int mathOp(int num)
        {
            int answer = num * 10;
            return answer;
        }
        public decimal mathOp (decimal num2)
        {
            decimal answer2 = num2 / 2;
            return answer2;
        }
        public int mathOp(string num3)
        {
            int answer3 = Convert.ToInt32(num3) + 100;
            return answer3;
        }

    }
}
