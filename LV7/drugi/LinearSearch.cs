using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7
{
    class LinearSearch : SearchStrategy
    {
        public int Search(double item, double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (item == array[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}