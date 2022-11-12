// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomeArray(int size, int minValue, int maxValue) //создать рандомный массив величиной size, в диапазорне от ... до ..
{
    int[] array = new int[size]; // инициализация массива (выделить память для size элементов (заполняется нулями по умолчанию))

    for(int i = 0; i < size; i++)

        array[i] = new Random().Next(minValue, maxValue + 1);

        return array;
}   

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

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

