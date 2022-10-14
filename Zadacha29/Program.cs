//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]
// 6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]

int[] array = new int[8];

void FillRandomArray (int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(1,100);
    }
}
FillRandomArray (array);
void Print (int [] array)
{
    for (int i = 0; i < 8; i++)
    {
        if (i < 7)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }   
    }
}
Print(array);
Console.Write(" -> ["); Print(array); Console.Write("]");