// Задача 1.
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
   Console.WriteLine("max = a, min = b ");
}
else
{
    Console.WriteLine("max = b, min = a ");
}

// Задача 2.
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("max = a ");
    }
    else
    {
        Console.WriteLine("max = c ");
    }
}
else
{
    if (b > c)
    {
        Console.WriteLine("max = b ");
    }
    else
    {
        Console.WriteLine("max = c ");
    }
}

// Задача 3. 
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("Even ");
}
else
{
    Console.WriteLine("Odd ");
}

// Задача 4. 
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = 1;

while (current <= n)
{
    if (current % 2 == 0)
    {
    Console.Write(current + " ");
    current++;
    }
    else
    {
         current++;
    }
}