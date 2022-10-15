// Напишите программу, 
//1. которая на вход принимавет число
//2.  и выдаёт его квадрат(число умноженное на само себя)
// Например;
// 4 -> 16
// -3 -> 9
// -7 -> 49

 Console.Write("Введите целое число: ");
 int number = Convert.ToInt32 (Console.ReadLine( ));

 // string str = Console.Readline();
 //int num = Convert.ToInt32(str)

 int square = number * number;

Console.WriteLine($"Квадрвт числа {number} = {square}");
