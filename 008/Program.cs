// Вывести на экран числа от -N до N

System.Console.WriteLine("Введите число:");
int N=Convert.ToInt32(Console.ReadLine());

for (int i=-1*N;i<=N;i=i+1)
{
System.Console.Write($"{i}| ");
}


