using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public static class Extension
    {
        public static int ReverseString(this int nums)
        {
            var str = nums.ToString();
            var charArr = str.ToCharArray();
            Array.Reverse(charArr);
            str = new string(charArr);
            return Convert.ToInt32(str);
        }

        public static string ReverseString(this string str)
        {
            var charArr = str.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }

        public static double ReverseString(this double doStr)
        {
            var str = doStr.ToString();
            var separatedString = str.Split(',', '.');
            var charArr1 = separatedString[0].ToCharArray();
            var charArr2 = separatedString[1].ToCharArray();
            Array.Reverse(charArr1);
            Array.Reverse(charArr2);
            str = string.Join(",", new string(charArr1), new string(charArr2));
            return Convert.ToDouble(str);
        }

        public static void ReverseArray(this int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                var tmp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = tmp;
            }
        }

        public static void Mean(this int[] arr)
        {
            int ArithmeticMean, GeometricMean;
            int Sum = 0;
            int Product = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                Sum = Sum + arr[i];
                Product = Product * arr[i];
            }
            ArithmeticMean = Sum / arr.Length;
            GeometricMean = Product^(1 / arr.Length);
            Console.Write("Arithmetic mean - ");
            Console.WriteLine(ArithmeticMean);
            Console.Write("Geometric mean - ");
            Console.WriteLine(GeometricMean);

        }
    }
}