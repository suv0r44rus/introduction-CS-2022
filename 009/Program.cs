﻿// Вывести на экран четные числа от 1 до N

System.Console.WriteLine("Введите чило N:");
int N=Convert.ToInt32(Console.ReadLine());

for (int j=2;j<=N;j=j+2)
{
    System.Console.Write($"{j} ");
}