// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

// Я знаю, что исполнение кривое

System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10) {
    System.Console.WriteLine(number);
} if (number > 9 && number < 100) {
    int num1 = number / 10;
    int num2 = number % 10;
    System.Console.WriteLine(num1 + "," + num2);
} else if (number > 99 && number < 1000) {
    int num3 = number / 100;
    int num4 = (number / 10) % 10;
    int num5 = number % 10;
    System.Console.WriteLine(num3 + "," + num4 + "," + num5);
} else if (number > 999 && number < 10000) {
    int num6 = number / 1000;
    int num7 = (number / 100) % 10;
    int num8 = (number / 10) % 10;
    int num9 = number % 10;
    System.Console.WriteLine(num6 + "," + num7 + "," + num8 + "," + num9);
} else if (number > 9999 && number < 100000) {
    int num10 = number / 10000;
    int num11 = (number / 1000) % 10;
    int num12 = (number / 100) % 10;
    int num13 = (number / 10) % 10;
    int num14 = number % 10;
    System.Console.WriteLine(num10 + "," + num11 + "," + num12 + "," + num13 + "," + num14);

} else {
    System.Console.WriteLine("Введено некорректное число");
}