
int[] CreateRandomeArray(int size, int minValue, int maxValue) //создать рандомный массив величиной size, в диапазорне от ... до ..
{
    int[] array = new int[size]; // инициализация массива (выделить память для size элементов (заполняется нулями по умолчанию))

    for(int i = 0; i < size; i++)

        array[i] = new Random().Next(minValue, maxValue + 1);

        return array;
}   

void ShowArray(int[] array) // Вывести массив на консоль
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

/*

int VolumeEvenArray(int[] array)
{
    int Volume = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if( array[i]%2 == 0 )
        Volume = Volume + 1;
    }
    return Volume;
}

Console.WriteLine("Задайте кол-во элементов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());

int[] XArray = CreateRandomeArray(n, 100, 1000);

ShowArray(XArray);

Console.WriteLine("Чётных чисел " + VolumeEvenArray(XArray));

*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*

int SumOddArray(int[] array)
{
    int Sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
        Sum = Sum + array[i];

     return Sum;
}

Console.WriteLine("Введите величину массива ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное значение элемента массива ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное значение элемента массива ");
int max = Convert.ToInt32(Console.ReadLine());

int[] Xarray = CreateRandomeArray(n, min, max );
ShowArray(Xarray);
Console.WriteLine("Сумма элементов, стоящих на нечётных позитциях равна " + SumOddArray(Xarray));

*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomeArrayD(int size, double minValue, double maxValue) //создать рандомный массив величиной size, в диапазорне от ... до ..
{
    double[] array = new double[size]; // инициализация массива (выделить память для size элементов (заполняется нулями по умолчанию))
 
      for(int i = 0; i < array.Length; i++)
                        
            array[i] = (new Random().NextDouble())*(maxValue - minValue) + minValue;

return array;
}

void ShowArrayD(double[] array) // Вывести массив на консоль
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

double MaxArray(double[] array)
{
    double Max = array[0];
  
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > Max)
        Max = array[i];
    }
    return Max;
}

double MinArray(double[] array)
{
    double Min = array[0];
  
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < Min)
        Min = array[i];
    }
    return Min;
}

Console.WriteLine("Введите величину массива ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное значение массива ");
double min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное значение массива ");
double max = Convert.ToInt32(Console.ReadLine());

double[] array = CreateRandomeArrayD(n, min, max);
ShowArrayD(array);

Console.WriteLine("Разница между максимальным и минимальным элементами равна: " + (MaxArray(array) - MinArray(array)));

