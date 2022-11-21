// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandom2dArray(int rows, int columns, double minValue, double maxValue)//генерация рандомного двумерного массива
{
    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
                array[i,j] = (new Random().NextDouble())*(maxValue - minValue) + minValue;
    }
    return array;
}


void Show2dArray(double[,] array)// печать двумерного массива
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        Console.Write(array[i,j] + " ");

    Console.WriteLine();
    }
}


Console.Write("Input a number of cows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
double min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
double max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

