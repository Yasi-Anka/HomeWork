// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*

int Stepen( int a, int b)
{
int st = 1;

for (int i=1; i <= b; i++)
{
st = st*a;
}
return st;
}

Console.WriteLine("Введите число А ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число В ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("A в степени В равно " + Stepen(A,B));

*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int FindSum(int N)
{
    int Sum = 0;
    int Ost = 0;
    while (N >= 10)
    {
        Ost = N % 10;
        Sum = Sum + Ost;
        N = N/10;
    }
    Sum = Sum + N;
    return Sum;
}

Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма цифр равна " + FindSum(N));
