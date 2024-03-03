

using System.Runtime.CompilerServices;

namespace Namespace_Dll_Static_Etesions__Homeworks
{
    internal static class Extasions_1
    {

        public static bool CheckOfEmail(this string email)
        {
           
            return email.Contains("@");

        }
        public static bool CheckOfPassword(this string password)
        {
            return password.Length > 8;
        }




    }
}
