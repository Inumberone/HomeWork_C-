
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введи число : ");
int a = int.Parse(Console.ReadLine());
int num1 = (a/10000);
int num5 = (a%10);
int num2 = ((a/1000)%10);
int num4 = ((a/10)%10);

if ((num1/num5==1) || (num2/num4==1)) 
{
Console.WriteLine("Число палиндром");
}
else 
{
Console.WriteLine("Числа не палиндром");
}

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введи число x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введи число y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введи число z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введи число x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введи число y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введи число z2: ");
int z2 = int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z2, 2));
Console.WriteLine($"Расстояние между двумя точками равно {d}");


//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введи число n: ");
int n = int.Parse(Console.ReadLine());

for(int i =1; i<=n; i++){
double a = Math.Pow (i,3);
Console.WriteLine($"Таблица кубов чисел {a}");
}
