
//Tasks:

//1) Sinifde yazdiqlarimizin praktikasi.

//2) 2 eded extension method yazirsiz. Biri emailin icinde @ isaresinin olub olmamasini yoxlamalidir. Digeri passwordun uzunluqunun 8den boyuk olub olmadigini yoxlamalidir.

//3)int arrayi ucun extention method yazirsiz. Hemin extention method arrayin elementlerinin hasilini tapsin.

//4)CalculatorService adinda class yaradirsiz, hemin classin icinde Calculation metodunuz olur. Method 2 parametr qebul edir. 4 emeliyyati (+,-,*,/)hesablayan
//calculator olacaq. Reqemler ve operatorlar console-dan daxil edilmelidir. Uygun controller de olsun.




//2) 2 eded extension method yazirsiz. Biriemailin icinde @ isaresinin olub olmamasini yoxlamalidir. Digeri passwordun uzunluqunun 8den boyuk olub olmadigini yoxlamalidir.


using Namespace_Dll_Static_Etesions__Homeworks;
using Namespace_Dll_Static_Etesions__Homeworks.Services;

string word = "hacixan@gmail.com";

//Console.WriteLine(word.CheckOfEmail());

string password = "772311132";

//Console.WriteLine(password.CheckOfPassword());


//3)int arrayi ucun extention method yazirsiz. Hemin extention method arrayin elementlerinin hasilini tapsin.

int[] number = { 1, 2, 3, 4 };

//Console.WriteLine(number.ProductOfNumber());


//4)CalculatorService adinda class yaradirsiz, hemin classin icinde Calculation metodunuz olur. Method 2 parametr qebul edir. 4 emeliyyati (+,-,*,/)hesablayan
             //calculator olacaq. Reqemler ve operatorlar console-dan daxil edilmelidir. Uygun controller de olsun.


CalculatorController controller = new CalculatorController();

controller.Calculation();




