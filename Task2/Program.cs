// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

System.Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > 0 && number2 > 0) {
    System.Console.WriteLine("Четверть: 1");
} else if (number1 < 0 && number2 > 0) {
    System.Console.WriteLine("Четверть: 2");
} else if (number1 < 0 && number2 < 0) {
    System.Console.WriteLine("Четверть: 3");
} else if (number1 > 0 && number2 < 0) {
    System.Console.WriteLine("Четверть: 4");
} else {
    System.Console.WriteLine("Введены некорректные коодинаты");
}