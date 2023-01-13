/*
Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
на само себя).
*/

Console.WriteLine("Enter number");
string input = Console.ReadLine();
int num = Convert.ToInt32(input);
int result = num * num;
Console.WriteLine($"Square of the {num} is {result}");