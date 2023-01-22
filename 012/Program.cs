// С Клавиатуры вводится целое число из диапазона {10,99}, показать наибольшую цифру числа

System.Console.WriteLine("Введите число от 10 до 99:");
int N= Convert.ToInt32(Console.ReadLine());
int a=N/10;
int b=N%10;
int max=Math.Max(a,b);
System.Console.WriteLine(max);
