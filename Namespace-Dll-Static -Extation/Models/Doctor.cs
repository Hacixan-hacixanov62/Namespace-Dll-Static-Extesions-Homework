

namespace Namespace_Dll_Static__Extation.Models
{
    internal  class Doctor
    {
        public static int Id { get; set; } = 100;
        public static  string name { get; set; }
        public int MyProperty { get; set; }

        static Doctor()
        {
            Console.WriteLine(" static constructor");

        }


        public Doctor()
        {
            Console.WriteLine(" non static constructor");
        }


    }
}
