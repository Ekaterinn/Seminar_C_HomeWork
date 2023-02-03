// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int numA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int numB = int.Parse(Console.ReadLine()!);

if (numA > numB)
{
    Console.WriteLine($"Первое число больше второго. Результат: {numA} больше, чем {numB}");
}
else
{
    Console.WriteLine($"Второе число больше первого. Результат: {numB} больше, чем {numA}");
}