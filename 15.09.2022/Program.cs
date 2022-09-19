//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b) 
{
    Console.WriteLine($"первое число {a} больше второго {b}");
}
else 
{
    Console.WriteLine($"первое число {a} меньше второго {b}");
}


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

int max = a;
{
    if (a > max)
    Console.WriteLine($"число {a} максимальное");
    
    if (b > max)
    Console.WriteLine($"число {b} максимальное");
    
    if (c > max);
    Console.WriteLine($"число {c} максимальное");
}

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите четное число: ");
int a = int.Parse(Console.ReadLine());
{
if (a%2 == 0)
    Console.WriteLine($"число {a} четное");
else
    Console.WriteLine($"число {a} не четное");
}


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введи целое число: ");
int n = int.Parse(Console.ReadLine());

int a = 2;
while (a <= n)
{
    Console.WriteLine(a+" ");
    a+=2;
}


