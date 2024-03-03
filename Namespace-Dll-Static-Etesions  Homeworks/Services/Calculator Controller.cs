

using System.Threading.Channels;

namespace Namespace_Dll_Static_Etesions__Homeworks.Services
{
    internal class CalculatorController
    {
        CalculatorService _calculatorService;
        public CalculatorController()
        {
            _calculatorService = new();
        }

        public void Calculation()
        {
            Console.WriteLine("please, enter number");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("please, enter number");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("please, enter Operation");
            string Operation = Console.ReadLine();

            var result = _calculatorService.Calculation(num1, num2, Operation);
            Console.WriteLine(result);


        }
    
      }
}
