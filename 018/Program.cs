// По двум заданным числам проверять является ли одно квадратом другого.

System.Console.WriteLine("Введите число a:");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
int b=Convert.ToInt32(Console.ReadLine());
if (a*a==b) System.Console.WriteLine($"{a} является квадратом {b}");
else 
if (b*b==a) System.Console.WriteLine($"{b} является квадратом {a}");
else System.Console.WriteLine("Не является");
