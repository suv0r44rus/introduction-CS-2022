﻿// С клавиатуры вводятся два числа a и b. 
//Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.


System.Console.WriteLine("Введите число a:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
double b=Convert.ToDouble(Console.ReadLine());
if (a%b==0)
{
    System.Console.WriteLine($"Число {a} кратно числу {b}");
}
else 
{
    System.Console.WriteLine($"Остаток от деления = {a%b}");
}