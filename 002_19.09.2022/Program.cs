
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введи трехзначное число: ");
int a = int.Parse(Console.ReadLine());
int b = ((a%100)/10); 
Console.WriteLine($" ответ {b}, от целого число {a}");


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введи номер дня недели: ");
int a = int.Parse(Console.ReadLine());

if ((a%7==0)||(a%6==0)) 
{
Console.WriteLine($"День {a} является выходным");
}
else
{
Console.WriteLine($"День {a} не является выходным");    
}


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введи многозначное число: ");
int a = int.Parse(Console.ReadLine());
int b=(a%10);
int c=((a/10)%10);
int d=((a/100)%10);
int e=((a/1000)%10);
int f=((a/10000)%10);
int g=((a/100000)%10);
int h=((a/1000000)%10);
int i=((a/10000000)%10);

int count = 0;
while (count<1)
{
    if ((a<=999)&&(a>=99)) 
    {
    Console.WriteLine($"Третья цифра -> {b} от целого числа {a}");
    }

    if (a<99)
    {
    Console.WriteLine("Третей цифры нет");
    }

    if ((a<=9999)&&(a>=999))
    {
    Console.WriteLine($"Третья цифра -> {c} от целого числа {a}");
    }

    if ((a<=99999)&&(a>=9999))
    {
    Console.WriteLine($"Третья цифра -> {d} от целого числа {a}");
    }

    if ((a<=999999)&&(a>=99999))
    {
    Console.WriteLine($"Третья цифра -> {e} от целого числа {a}");
    }

    if ((a<=9999999)&&(a>=999999))
    {
    Console.WriteLine($"Третья цифра -> {f} от целого числа {a}");
    }

    if ((a<=99999999)&&(a>=9999999))
    {
    Console.WriteLine($"Третья цифра -> {g} от целого числа {a}");
    }

    if ((a<=999999999)&&(a>=99999999))
    {
    Console.WriteLine($"Третья цифра -> {h} от целого числа {a}");
    }

    if ((a<=9999999999)&&(a>=999999999))
    {
    Console.WriteLine($"Третья цифра -> {i} от целого числа {a}");
    }
    
    count++;
}
