// Обмен значения двух переменных
/* int a=5;
int b=7;
temp=a;
a=b;
b=temp;
*/

//Без использования 3й переменной
/* int a=5;
int b=7;
a=a+b;
b=a-b;
a=a-b;
*/

//Третий способ логический
/*int a=5;
int b=7;
a=a^b;
b=a^b;
a=a^b;
*/

      //счетчик и флаг
/*
        int n = int.Parse(Console.ReadLine());
        int k = 0;//Счетчик
        bool flag = false;//флаг

        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            if (a < 5) k++;
            if (a == 10) flag = true;
        }
        Console.WriteLine(k);
        if (flag) Console.WriteLine("YES"); else Console.WriteLine("NO");
*/

//Нахождение минимального числа

int n=Convert.ToInt32(Console.ReadLine());
int min=30000;
for (int i=0;i<n;i++)
{
    int a=Convert.ToInt32(Console.ReadLine());
    if (a<min && a%10==4) min = a;
}
System.Console.WriteLine(min);