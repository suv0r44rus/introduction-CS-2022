// Задать номер четверти, показать диапазоны для возможных координат

int quarter = new Random().Next(1, 5);
string range = "";
if (quarter == 1) range = "x > 0, y > 0";
else if (quarter == 2) range = "x < 0, y > ";
else if (quarter == 3) range = "x < 0, y < 0";
else range = "x > 0, y < 0";

System.Console.WriteLine($"Диапазон координат для {quarter}-й четверти должны быть в диапазоне ( {range} )");
