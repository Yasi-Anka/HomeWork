// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)//генерация рандомного двумерного массива
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
                array[i,j] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void Show2dArray(int[,] array)// печать двумерного массива
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");

    Console.WriteLine();
    }
}

void Sortirovka(int[,] array)
{
    int temp = 0;
      for(int i = 0; i < array.GetLength(0); i++)
    {
        
        for(int j = 0; j < array.GetLength(1); j++)
            {   
                
            for(int n = 0; n < array.GetLength(1)-1; n++)
            {
            if (array[i,n] <array[i,n+1])
            {
                temp = array[i,n];
                array[i,n] = array[i,n +1];
                array[i,n+1] = temp;

            }                   
            } 
            

            }
    }
}

Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент массива ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимакльный элемент массива ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myarray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myarray);
Console.WriteLine();
Sortirovka(myarray);
Show2dArray(myarray);

// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.



// Задача 58: Задайте две матрицы.\
// Напишите программу, которая будет находить произведение двух матриц.



// Напишите программу, которая заполнит спирально массив 4 на 4.