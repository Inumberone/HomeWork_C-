//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);

int exp = a;

for (int i = 1; i < b; i++)
{
exp = exp * a;
}
Console.WriteLine(exp);


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введи число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {A} равна {GetSum(A)}");
int GetSum(int limit){
    int sum = 0;
    for(int i = 1; i<= limit; i++){
        sum=sum+i;
    }
    return sum;
}

//Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.

int[] array = FillArray(8);
Console.WriteLine($"[{String.Join(',', array)}]");

int[] FillArray(int size)
{
    int[] result= new int[size];
    for (int i=0; i< size; i++)
    {
    result[i] = new Random(). Next(9);
    }

    return result;

}
