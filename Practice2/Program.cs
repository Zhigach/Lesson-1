/*
Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет */

Console.WriteLine("Enter square");
string input1 = Console.ReadLine();
int a = Convert.ToInt32(input1);
Console.WriteLine("Enter root");
string input2 = Console.ReadLine();
int b = Convert.ToInt32(input2);

if (a == (b*b)){
    Console.WriteLine("Yes");
} else{
    Console.WriteLine("No");
}