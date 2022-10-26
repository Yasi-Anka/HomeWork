// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrom(int n)
{
int a1 = n/10000;
int a5 = n%10;
int a4 = (n%100)/10;
int a2 = (n/1000)%10;

if(a1 == a5 || a2 == a4)
    Console.WriteLine("Да");

else
    Console.WriteLine("Нет");
}

Console.WriteLine("Введите пятизначное число ");
int N = Convert.ToInt32(Console.ReadLine());

if(N<0)
N = -N;

while(N > 99999 || N < 10000)
{
    Console.WriteLine("введите ПЯТИЗНАЧНОЕ число ");
    N = Convert.ToInt32(Console.ReadLine());

    if(N<0)
    N = -N;
}

Palindrom(N);


// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

