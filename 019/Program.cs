// Проверить истинность утверждения 
//¬(X ⋁ Y) = ¬X ⋀ ¬Y 
//!(X || Y)==!X && !Y

System.Console.WriteLine("Введите число x:");
int x=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число y:");
int y=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("X Y ¬(X | Y) ¬X & ¬Y");
System.Console.WriteLine($"0 0 {Convert.ToInt32(!(false || false)),5} {Convert.ToInt32((!false && !false)),8}");
System.Console.WriteLine($"0 1 {Convert.ToInt32(!(false || true)),5} {Convert.ToInt32((!false && !true)),8}");
System.Console.WriteLine($"1 0 {Convert.ToInt32(!(true || false)),5} {Convert.ToInt32((!true && !false)),8}");
System.Console.WriteLine($"1 1 {Convert.ToInt32(!(true || true)),5} {Convert.ToInt32((!true && !true)),8}");

