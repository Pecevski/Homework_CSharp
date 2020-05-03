using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Helpers
{
    internal class HelperMethods
    {
        internal static decimal CalculateAverage(List<int> numbers)
        {

            int sum = 0;
            numbers.ForEach(number => sum += number);
            return Convert.ToDecimal(sum) / Convert.ToDecimal(numbers.Count);
        }

        internal static int FindMaxNumber(List<int> numbers)
        {
            int  max = 0;
            foreach (var number in numbers)
            {
                if(number > max)
                {
                    max = number;
                }              
            }
            return max;
        }

        internal static int FindMinNumber(List<int> numbers)
        {
            int min = FindMaxNumber(numbers);
            foreach (var number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }

        internal static int MultiplyAllNumbers(List<int> numbers)
        {
            int multiplyAll = 1;
            foreach (var number in numbers)
            {
                multiplyAll *= number;
            }
            return multiplyAll;
        }

        internal static int SumAllNumbers(List<int> numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

    }
}
