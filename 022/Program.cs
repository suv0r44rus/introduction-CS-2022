// Программа проверяет пятизначное число на палиндромом.

//System.Console.WriteLine("Введите пятизначное чило");
//int namber=Convert.ToInt32(Console.ReadLine());

Random rnd = new Random();
int number = rnd.Next(10000,99999);
System.Console.WriteLine(number);
int[] array_number = number.ToString().Select(o => int.Parse(o.ToString())).ToArray();
if (array_number[0]==array_number[4] && array_number[1]==array_number[3]) 
{
    System.Console.WriteLine($"Число {number} ПОЛИНОМ!");
}
else System.Console.WriteLine($"Число {number} не является полиномом");