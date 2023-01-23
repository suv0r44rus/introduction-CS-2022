// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int dayNumber = new Random().Next(1, 8);
string[] weekday = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string conclusion = "";

if (dayNumber > 5) conclusion = $" ВЫХОДНОЙ ДЕНЬ!";
else conclusion = $", рабочий день.";

System.Console.WriteLine($"{dayNumber} день недели - {weekday[dayNumber - 1]}{conclusion}");

