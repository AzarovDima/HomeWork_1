// Написать программу, которая на вход принимает два числа и выдает, какое число больше а какое меньше
// Например а = 5; b = 7 -> MAX = 7

Console.Write("Введите ПЕРВОЕ целое число: ");
string userInput1 = Console.ReadLine() ?? "";
int number1 = int.Parse(userInput1);

Console.Write("Введите ВТОРОЕ целое число: ");
string userInput2 = Console.ReadLine() ?? "";
int number2 = int.Parse(userInput2);

if (number1 > number2)
{
    Console.WriteLine($"Число {number1} ---> Максимальное!!!");
}
else
{
    Console.WriteLine($"Число {number2} ---> Максимальное!!!");
}
// КОНЕЦ!!!