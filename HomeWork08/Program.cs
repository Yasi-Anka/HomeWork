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
// ЕСЛИ ОДИНОКОВАЯ СУММА В НЕСКОЛЬКИХ СТРОКАХ?

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
*/



// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

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
                        
void Show2dArray(int[,,] array)// печать двумерного массива
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
Show2dArray(myarray);
}

else
Console.WriteLine("В заданном диапазоне недостаточно чисел для заполнения массива");

// Задача 62: Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int[,] Spiral(int rows, int columns)
{
 for(int i = 0; i < array.GetLength(0);  )
}
*/