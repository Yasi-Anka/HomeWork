// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*
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

*/

// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// НЕДОРАБОТАНО: ЕСЛИ ОДИНОКОВАЯ СУММА В НЕСКОЛЬКИХ СТРОКАХ?

/*
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

int[] SumRows (int[,] array, int rows)
{
    int sum = 0;
    int [] TempArray = new int[rows];

    for(int i = 0; i < array.GetLength(0); i++ )
    {
        sum = 0;
       for(int j = 0; j < array.GetLength(1); j++)
       {
            sum = array[i,j] + sum;
        }
        TempArray[i] = sum;
    }
return TempArray;
}

int Min(int[] array)
{
    
    int min = array[0];
    int N = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]<min)
        {
            min = array[i];
            N = i;
        }
    }
    
    return N;
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

int[] SumArray = SumRows(myarray, m);

Console.WriteLine("Наименьшая сумма элементов в " + Min(SumArray) + " строке (нумерация строк с 0)");
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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

int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    int[,] array = new int[array1.GetLength(0), array2.GetLength(1)];
   
    int sum = 0;

    for(int j = 0; j < array2.GetLength(1); j++)
    {
        for(int i = 0; i < array1.GetLength(0); i++)
        {
            sum = 0;
            for(int i2 = 0, j1 = 0; i2 < array2.GetLength(0) && j1 < array1.GetLength(1); i2++, j1++)
            {
                sum = sum + array1[i,j1]*array2[i2, j];
            }

            array[i,j] = sum;

        }
    }
return array;
}

Console.Write("Введите количество строк матрицы 1: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент массива матрицы 1: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимакльный элемент массива матрицы 1: ");
int max1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.Write("Введите количество строк матрицы 2: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент массива матрицы 2: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимакльный элемент массива матрицы 2: ");
int max2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();


if(n1 != m2)
Console.Write("Матрицу 1 невозможно умножить на матрицу 2, так как число столбцов матрицы 1 не равно числу строк матрицы 2.");
else
{
    Console.WriteLine("Матрица 1");
    int[,] array1 = CreateRandom2dArray(m1, n1, min1, max1);
    Show2dArray(array1);

    Console.WriteLine();

    Console.WriteLine("Матрица 2");
    int[,] array2 = CreateRandom2dArray(m2, n2, min2, max2);
    Show2dArray(array2);

    Console.WriteLine();

    Console.WriteLine("Результат умножения:");
    int[,] array = MatrixMultiplication(array1, array2);
    Show2dArray(array);

}




// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*

int[,,] CreateRandom2dArray(int layer1, int layer2, int layer3, int minValue, int maxValue)//генерация рандомного двумерного массива
{
    int[,,] array = new int[layer1, layer2, layer3];
    int x = 0;
    bool n = false;

    for(int i = 0; i < layer1; i++)
    {
        for(int j = 0; j < layer2; j++)
            {
                for(int k = 0; k < layer3; k++)
                {
                x = new Random().Next(minValue, maxValue + 1);
                n = false;
                
                while (n == false)
                {
                    int ix = 0;
                    int jx = 0;
                    int kx = 0;
                    for(ix = 0; ix < layer1; ix++)
                        {
                        for(jx = 0; jx < layer2; jx++)
                            {
                            for(kx = 0; kx < layer3; kx++)
                            {
                                if(x == array[ix,jx,kx])
                                {
                                    x = new Random().Next(minValue, maxValue + 1);
                                    
                                }
                                else
                                {
                                n = true;
                                
                                }                           
                            }
                                
                            }
                        }
                }
                
                array[i,j,k] = x;
                           
               }
            }
    }
    return array;
}
                        
void Show3dArray(int[,,] array)// печать трёхмерного массива
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            Console.Write(array[i,j,k] + "(" + i + "," + j + "," + k + ") ");

        Console.WriteLine();
        }

     Console.WriteLine();
    
    }

}

bool Test(int layer1, int layer2, int layer3, int minValue, int maxValue)
{
    int N = maxValue - minValue + 2;
    if ((layer1*layer2*layer3)>=N)
    return false;
    else return true;
}


Console.Write("Введите количество элементов первого уровня массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов второго уровня массива ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов третьего уровня массива ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент массива ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимакльный элемент массива ");
int max = Convert.ToInt32(Console.ReadLine());

bool x = Test(m, n, k, min, max);

if(x == true)
{
int[,,] myarray = CreateRandom2dArray(m, n, k, min, max);
Show3dArray(myarray);
}

else
Console.WriteLine("В заданном диапазоне недостаточно чисел для заполнения массива");

*/

// Задача 62: Напишите программу, которая заполнит спирально массив 4 на 4.
// НЕДОРАБОТАНО:
// 1 исправить вывод результата из 1, 2, 3... в 01, 02, 03 Что бы матрица красиво выводилась на экране
// 2 работает только с прямоугольными матрицами((

/*
int[,] Spiral(int rows, int columns)

{
    int[,] array = new int[rows, columns];
    int N = 0;
    int i = 0;
    int j = 0;
    

for(int k = 0; k < rows - 2; k++)
{
    for(j = 0 + k , i = 0 + k; j < columns - 2*k; j++)
    {
        array[i,j] = N;
        N = N + 1;
    }
    for(j = columns -1 - k; i < columns -k; i++)
    {
            array[i,j] = N;
            N = N + 1;
    }
    for(i = rows - 1 - k, j = columns - 2 - k; j > 0 + k; j--)
    {
         array[i,j] = N;
         N = N + 1;
    }
    for(i = rows -1 - k, j = 0 + k; i> 0 + k; i--)
    {
        array[i,j] = N;
        N = N + 1;
    }
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

Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


int[,] myarray = Spiral(m, n);
Show2dArray(myarray);
*/