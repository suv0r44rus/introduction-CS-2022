// С клавиатуры вводятся три числа. Найти максимальное из трех чисел

System.Console.WriteLine("Введите число a:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
double b=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число с:");
double c=Convert.ToDouble(Console.ReadLine());
double max=Math.Max(a,b);
double max_=Math.Max(max,c);
System.Console.WriteLine(max_);
