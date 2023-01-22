// Дано число. Проверить кратно ли оно 7 и 23

System.Console.WriteLine("Введите число n:");
int n=Convert.ToInt32(Console.ReadLine());
if (n%7==0 && n%23==0)
{
    System.Console.WriteLine($"Число {n} кратно числу 7 и 23");
}
else 
{
    System.Console.WriteLine($"Число {n} не кратно  = 7 и 23");
}