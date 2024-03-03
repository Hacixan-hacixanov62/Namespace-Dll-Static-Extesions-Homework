
namespace Namespace_Dll_Static__Extation.Helpers.Extensions
{
    internal static class MathExtasions
    {
        public static int SumOfNums(this int num1 , int num2)
        {
            return num1 + num2;
        }

        public static double  SquareOfNums(this int a)
        {
            return Math.Pow(a, 2);
        }

        public static double PowerOfNums (this int a , int pow)
        {
            return Math.Pow(a, pow);
        }

    }
}

