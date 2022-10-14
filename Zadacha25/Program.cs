//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine());

int Exp(int num1, int num2)
{
    int C = 1;
    for (int i = 1; i <= num2; i++)
    {
        C = C*num1;
    }
    return C;
}
Console.WriteLine($"{A}, {B} -> {Exp(A, B)}");