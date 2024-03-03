
using System.Security.Cryptography.X509Certificates;

namespace Namespace_Dll_Static_Etesions__Homeworks.Services
{
    internal class CalculatorService
    {
       
        public  double Calculation(double num1, double num2, string Operation)
        {

            switch (Operation)
            {
                case "+":
                    return num1 + num2;

                case "-":
                    return num1 - num2;

                case "*":
                    return num1 * num2;

                case "/":
                    return num1 / num2;
            }
            return 0;


        }
    }
}