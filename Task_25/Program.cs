/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int getNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
int numberA = getNumber("Введите число A: ");
int numberB = getNumber("Введите число B: ");
int result = numberA;

for (int i = 1; i < numberB; i++)
{
result = result * numberA;
}
Console.WriteLine("A в степени B равно: " + result);