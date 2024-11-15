using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SISTEPLANT.Exercise2
{
    public class Exercise2
    {
        public static int Solution(int[] A)
        {
            int n = A.Length;
            int i = n - 1;
            int result = -1;
            int current = 0, maximal = 0;
            while (i >= 0)
            {
                if (A[i] == 1)
                {
                    current = current + 1;
                    if (current >= maximal)
                    {
                        maximal = current;
                        result = i;
                    }
                }
                else
                    current = 0;
                i = i - 1;
            }

            return result;
        }
    }
}
