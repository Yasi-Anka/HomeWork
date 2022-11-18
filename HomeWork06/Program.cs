// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*

int Polozitelnie()
{
int x = 0;
int n = 1;
Console.WriteLine("Введите число №1, для остановки введите любую букву");
string s = Console.ReadLine();

while(int.TryParse(s, out int i))
    {
    if(i > 0) x++;
    n++;
    Console.WriteLine("Введите число №" + n + ", для остановки нажмите любую букву");
    s = Console.ReadLine();
    }

return x;
}

Console.WriteLine( Polozitelnie() + " чисел больше нуля");
*/
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Tochka(double b1, double k1, double b2, double k2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k1*x + b1;
    Console.WriteLine(x + " " + y);
}

Console.WriteLine("Введите значение b1 ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k1 ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b2 ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k2 ");
double k2 = Convert.ToInt32(Console.ReadLine());


Tochka(b1, k1, b2, k2);
