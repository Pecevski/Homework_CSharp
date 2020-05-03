using Calculator.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Models
{
    public static class Calc
    {
        public static decimal Avg(List<int> numbers)
        {
            return HelperMethods.CalculateAverage(numbers);
        }

        public static int Max(List<int> numbers)
        {
            return HelperMethods.FindMaxNumber(numbers);
        }

        public static int Min(List<int> numbers)
        {
            return HelperMethods.FindMinNumber(numbers);
        }

        public static int Multiply(List<int> numbers)
        {
            return HelperMethods.MultiplyAllNumbers(numbers);
        }

        public static int SumAll(List<int> numbers)
        {
            return HelperMethods.SumAllNumbers(numbers);
        }

    }
}
