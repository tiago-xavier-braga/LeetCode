using System;
using System.Diagnostics;

namespace LeetCode.RomanToInteger
{
    public class Solution
    {
        private int GetInteger(string Caracter)
        {
            switch (Caracter)
            {
                case "I":
                    return 1;
                case "V":
                    return 5;
                case "X":
                    return 10;
                case "L":
                    return 50;
                case "C":
                    return 100;
                case "D":
                    return 500;
                case "M":
                    return 1000;
                default:
                    return 0;
            }
        }
        public int RomanToInt(string stringParameter)
        {
            GC.Collect();
            int result = 0;

            for (int index = 0; index < stringParameter.Count(); index++)
            {
                // if (index == stringParameter.Count() - 1) return result + GetInteger(stringParameter[index].ToString());
                if (index == stringParameter.Count() - 1) return result;
                
                bool isLarger =  GetInteger(stringParameter[index].ToString()) 
                > GetInteger(stringParameter[index + 1].ToString()); 

                if (isLarger)
                {
                    result += GetInteger(stringParameter[index].ToString());
                }
                else
                {
                    result += GetInteger(stringParameter[index + 1].ToString()) 
                    - GetInteger(stringParameter[index].ToString());
                }
            }

            return result;
        }
    }

}