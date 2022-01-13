using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursivitate2
{
    class Recursiv
    {
        public static int Maxim(int[] vector, int n, int max)
        {
            if(n == 0)
            {
                if (max >= vector[n])
                    return max;
                else
                    return vector[n];
            }
            else
            {
                if (max >= vector[n])
                    return Maxim(vector, n - 1, max);
                else
                    return Maxim(vector, n - 1, vector[n]);
            }
        }
    }
}
