// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).

System.Console.WriteLine("Введите число: ");
int N= Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);
string N_ = Convert.ToString(N);
if (N%100==N)
{
    System.Console.WriteLine("-=NO=-");
}
else
{
    Console.WriteLine("Третья цифра в числе = " + N_[2]);
}