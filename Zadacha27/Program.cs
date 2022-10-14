// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int SumNumber(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10; //определение последней цифры числа
        number = number/10; //переход к следующей цифре (отсекание найденной последней цифры числа)
    }
    return sum;
}
Console.WriteLine($"{num} -> {SumNumber(num)}");