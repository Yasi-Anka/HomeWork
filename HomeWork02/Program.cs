// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit(int N)
{
   int x = N/10 % 10;
   return x;
}

Console.WriteLine("Введите трёхзначное число ");
int N = Convert.ToInt32(Console.ReadLine());

if(N < 0)
N = -1 * N;
else
while((N<100)||(N>999))
{
    Console.WriteLine("Мама роди меня обратно! Введите ТРЁХЗНАЧНОЕ число!!! ");
    int a = Convert.ToInt32(Console.ReadLine());
    
    if(a < 0)
    N = -1 * a;
}

int n = SecondDigit(N);

Console.WriteLine(n);

*/
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
int ThirdDigit(int N)
{
    while(N > 999)
    N = N/10;
int x = N % 10;

return x;
}

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if( N < 0 )
    N = -N;
    
if( N < 100)
Console.WriteLine("Третьей цифры нет");

else
{
    int n = ThirdDigit(N);
    Console.WriteLine(n);
}
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void YesNo(int N)
{
if((N == 1)||(N == 2)||(N == 3)|| N == 4 || N == 5)
Console.WriteLine("No( - Будний");
else
Console.WriteLine("Yes! - Выходной");
}

Console.WriteLine("Введите день недели от 1 до 7-ми. Где 1 - понедельник, 2 - вторник, 3 - среда, 4 - четверг, 5 - пятница, 6 суббота, 7 - воскресенье.");
int N = Convert.ToInt32(Console.ReadLine());
while(N<1||N>7)
{
    Console.WriteLine("Введите день недели от 1 до 7-ми!");
    N = Convert.ToInt32(Console.ReadLine());
}
YesNo(N);












