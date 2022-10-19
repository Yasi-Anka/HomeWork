// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondNumber(int N)
{
   int x = N/10 % 10;
   return x;
}

Console.WriteLine("Введите трёхзначное число ");
int N = Convert.ToInt32(Console.ReadLine());

while((N<100)||(N>999))
{
    Console.WriteLine("Мама роди меня обратно! Введите ТРЁХЗНАЧНОЕ число!!! ");
    int a = Convert.ToInt32(Console.ReadLine());
    N = a;
}

int n = SecondNumber(N);

Console.WriteLine(n);