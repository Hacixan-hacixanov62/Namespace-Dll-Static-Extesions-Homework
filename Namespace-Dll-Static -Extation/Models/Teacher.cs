

namespace Namespace_Dll_Static__Extation.Models
{
    internal class Teacher
    {
        public static int Count { get; set; } = 0;

        //static Teacher()
        //{
              
        //}

        public Teacher()
        {
            Count++;
        }

    }
}
