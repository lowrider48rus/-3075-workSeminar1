// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Type first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Type second number: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"first mumber {num1} larger than second number {num2}");
}
else{
    Console.WriteLine($"second mumber {num2} larger than first number {num1}");
}
