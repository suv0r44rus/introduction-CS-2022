// Удалить вторую цифру целого числа введенного с клавиатуры

System.Console.WriteLine("Введите число:");
int a= Convert.ToInt32(Console.ReadLine());
//125 => 1 + остаток от деления на 10 - 5
int b=a/100*10+a%10; 
System.Console.WriteLine(b);


