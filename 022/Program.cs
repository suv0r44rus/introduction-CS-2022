// Программа проверяет пятизначное число на палиндромом.

System.Console.WriteLine("Введите пятизначное чило");
int number=Convert.ToInt32(Console.ReadLine());
//Random rnd = new Random();
//int number = rnd.Next(10000,99999);
int number_= Math.Abs(number);
System.Console.WriteLine(number_);
int[] array_number = number_.ToString().Select(o => int.Parse(o.ToString())).ToArray();
if (array_number[0]==array_number[4] && array_number[1]==array_number[3]) 
{
    System.Console.WriteLine($"Число {number} ПОЛИНОМ!");
}
else System.Console.WriteLine($"Число {number} не является полиномом");