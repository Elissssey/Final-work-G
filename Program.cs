using System;

class Program 
{
    static void Main(string[] args) 
    {
        // Ввод исходного массива строк с клавиатуры
        Console.Write("Введите строку элементов через запятую: ");
        string input = Console.ReadLine();
        string[] strings = input.Split(new char[] {','});
