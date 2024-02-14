// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.



System.Console.WriteLine("Введите двухзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9 && number < 100) {
int num1 = number / 10;
int num2 = number % 10;
if ( num1 > num2) {
System.Console.WriteLine(num1);   
} else {
System.Console.WriteLine(num2);
}

} else {
    System.Console.WriteLine("Введено некорректное число");
}