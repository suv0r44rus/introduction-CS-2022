﻿// С клавиатуры вводятся два числа a и b. Найти максимальное из них.

System.Console.WriteLine("Введите число a:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
double b=Convert.ToDouble(Console.ReadLine());
double max=Math.Max(a,b);
System.Console.WriteLine(max);
