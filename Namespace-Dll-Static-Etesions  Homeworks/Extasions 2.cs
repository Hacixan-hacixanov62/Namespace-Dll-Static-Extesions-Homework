

using System.Security.Cryptography.X509Certificates;

namespace Namespace_Dll_Static_Etesions__Homeworks
{
    internal static  class Extasions_2
    {
        public static int ProductOfNumber(this int[] arr)
        {

            int result = 1;
            foreach (int i in arr)
            {
                result *= i;
            }
            return result;
        
        }
    }
}
