// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Ведите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine($"{a} > {b}, max = {a}");
}
else
{
    if(a < b)
    {
        Console.WriteLine($"{a} < {b}, max = {b}");
    }
    else
    {
        Console.WriteLine($"{a} = {b}");
    }
}

*/

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье числом ");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    if(a > c)
    {
        Console.WriteLine("Максимальное число = " + a);
    }
    else
    {
        Console.WriteLine("Максимальное число = " + c);
    }
}
else
{
    if(b > c)
    {
        Console.WriteLine("Максимальное число = " + b);
    }
    else
    {
        Console.WriteLine("Максимальное число = " + c);
    }
}
*/

//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());

int b = a % 2;

if(b == 0)
{
    Console.WriteLine("Число " + a + " - чётное");
}
else
{
    Console.WriteLine("Число "+ a + " - не чётное");
}

*/

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

int n = 2;

while(n < N + 1)
{
Console.Write(n + " ");
n = n + 2;
}
