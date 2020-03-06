using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class RomanToInteger
    {
        public static int Solution(string s)
        {
            var result = 0;

            var Roman = new Dictionary<string, int>(){
            {"I",1},{"V",5},{"X",10},{"L",50},{"C",100},{"D",500},{"M",1000}
        };

            for (var i = 0; i < s.Length; i++)
            {
                var current = Roman[s[i].ToString()];
                var next = i == s.Length - 1 ? 0 : Roman[(s[i + 1]).ToString()];
                var currentValue = 0;
                if (current >= next)
                {
                    currentValue = Convert.ToInt32(current);
                }
                else
                {
                    currentValue = next - current;
                    i++;
                }

                result += currentValue;

            }

            return result;

        }
    }
}
