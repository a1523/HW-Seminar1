// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int numb1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numb2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int numb3 = int.Parse(Console.ReadLine());

int max = numb1;

if (numb2 > max)
{
    max = numb2;
}

if (numb3 > max)
{
    max = numb3;
}

Console.WriteLine($"Максимальное число {max}");


