// Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.Write("Введите первое число: ");
int num_A = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num_B = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int num_C = int.Parse(Console.ReadLine()!);

if (num_A > num_B)
{
    if (num_A > num_C)
    {
        Console.WriteLine(num_A);
    }
    else
    {
        Console.WriteLine(num_C);
    }
}
else if (num_B > num_C)
{
    Console.WriteLine(num_B);
}
else 
{
    Console.WriteLine(num_C);
}