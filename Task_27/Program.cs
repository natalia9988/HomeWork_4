/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int getNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
int num = getNumber("Введите число: ");
int sum =0;

while (num > 0)
{
int result = num % 10;
num = num / 10;
sum = sum + result;
}
Console.WriteLine($"Cумма всех цифр в числе равна: {sum} ");