// Найти расстояние между точками в пространстве 2D

double x1,y1, x2, y2, distance;
System.Console.WriteLine("Введите координату x1:");
x1=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координату y1:");
y1=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координату x2:");
x2=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координату y2:");
y2=Convert.ToDouble(Console.ReadLine());

distance=Math.Sqrt((x2-x1)*(x2-x1)+Math.Pow(y2-y1,2));
System.Console.WriteLine(distance);