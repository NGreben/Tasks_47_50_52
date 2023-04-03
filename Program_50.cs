/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] array = CreateArray(3, 4, 1, 10);
PrintArray(array);


int position;
Console.Write($"Введите позицию эелемента: ");
int.TryParse(Console.ReadLine()!, out position);
if (array.GetLength(0) >= position / 10 & array.GetLength(1) >= position % 10)
    Console.Write($"-> {array[position / 10, position % 10]}");
else
    Console.Write($"-> такого числа в массиве нет");

int[,] CreateArray(int row, int column, int min, int max)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(min, max);
    return array;
}

void PrintArray(int[,] array, string title = " ")
{
    if (title != " ")
        Console.Write($"{title}\n");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
