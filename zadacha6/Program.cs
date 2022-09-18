// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Type number: ");
int num = int.Parse(Console.ReadLine());
int resid = num % 2;

if (resid == 1){
    Console.WriteLine($"Number {num} IS NOT even number");
}
else {
    Console.WriteLine($"Number {num} IS even number");
}