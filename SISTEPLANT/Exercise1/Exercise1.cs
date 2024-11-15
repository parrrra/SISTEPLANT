using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEPLANT.Exercise1
{
    public class Exercise1
    {
        public static int Solution(int N)
        {
            string number = N.ToString();
            bool isNegative = N < 0;
            int start = isNegative ? 1 : 0;

            for (int i = start; i < number.Length; i++)
            {
                if ((isNegative && number[i] - '0' >= 5) || (!isNegative && number[i] - '0' <= 5))
                {
                    return int.Parse(number.Insert(i, "5"));
                }
            }

            return int.Parse(number + "5");
        }
    }
}
