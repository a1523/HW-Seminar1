// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
int numb1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numb2 = int.Parse(Console.ReadLine());

if (numb1 > numb2)
{
    Console.WriteLine($"Первое число {numb1} больше второго числа {numb2}");
}
else
{
    Console.WriteLine($"Второе число {numb2} больше первого числа {numb1}");
}
