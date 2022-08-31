// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int startNumber = 1;

Console.WriteLine($"Четные числа до {number}: ");

while (startNumber <= number) {
    if (startNumber % 2 == 0)
    {
        Console.WriteLine(startNumber);
    }
        startNumber = startNumber + 1;
}


