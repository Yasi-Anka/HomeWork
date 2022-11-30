// Задача 64: Задайте значение N.
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.
/*
void ShowNumbers(int N)
{
    Console.Write(N + " ");
    if(N > 1) ShowNumbers(N - 1);
    if(N < 1 ) ShowNumbers(N +1);
    
}

Console.WriteLine("Введите число ");

ShowNumbers(Convert.ToInt32(Console.ReadLine()));

*/
// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N
/*

int Sum(int m, int n)
{
     
    if(m < n) return Sum (m + 1,n) + m;
    
    if(m > n) return Sum (m - 1,n) + m;
    
   
    return n;
}

Console.WriteLine("Введите первое число ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Sum(m, n));

*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if(m==0) return n+1;
    
    if((n==0)&&(m>0)) return Akkerman ( m-1,1);
        
    return Akkerman (m-1, Akkerman(m,n-1));


}
Console.WriteLine("Введите первое число ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Akkerman(m, n));
