﻿//  1.Напишите программу которая принимаеt
// 2. на вход трёхзначное число и 
// 3. на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
int lastDigit = number % 10; // 456 % 10 = 6 456 / 10 = 45 / 10 = 4 / 10 = 0
Console.WriteLine($"Последняя цифра числа = {lastDigit}");
}
else Console.WriteLine("Введите трёхзначное число!");