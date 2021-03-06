﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
         doubleX("axxbb") → true
         doubleX("axaxax") → false
         doubleX("xxxxx") → true
         */
        public bool DoubleX(string str)
        {
            int lastIndex = str.Length - 1;
            int indexOfX = 0;
            indexOfX = str.IndexOf('x');

            if (indexOfX >= 0  && indexOfX < lastIndex)
            {
                indexOfX += 1;
                if (indexOfX <= lastIndex)
                {
                    if (str[indexOfX] == 'x')
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
