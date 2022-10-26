// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
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

while(N > 99999 || N < 100000)
{
    Console.WriteLine("введите ПЯТИЗНАЧНОЕ число ");
    N = Convert.ToInt32(Console.ReadLine());

    if(N<0)
    N = -N;
}

Palindrom(N);
*/

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double Length(double x1, double x2, double y1, double y2, double z1, double z2)
{
double L = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
return L;
}

Console.WriteLine("Введите координаты Х первой точки");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y первой точки");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Z первой точки");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Х второй точки");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y второй точки");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Z второй точки");
double z2 = Convert.ToInt32(Console.ReadLine());

double L = Length(x1, x2, y1, y2, z1, z2);
Console.WriteLine("Растояние между точками равно " + L);
*/
//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cub(int N)
{
int n = 1;
int x = 0;
while(n < N+1)
{
    x = n*n*n;
    Console.Write(x + " ");
    n++;
}
}

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
Cub(N);
