﻿// See https://aka.ms/new-console-template for more information

System.Console.WriteLine("Введите число а:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
double b=Convert.ToDouble(Console.ReadLine());

if(a*a==b) System.Console.WriteLine($"{b} является квадратом {a}");
if(b*b==a) System.Console.WriteLine($"{a} является квадратом {b}");
