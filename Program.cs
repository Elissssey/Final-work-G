using System;

class Program 
{
    static void Main(string[] args) 
    {
        // Ввод исходного массива строк с клавиатуры
        Console.Write("Введите строку элементов через запятую: ");
        string input = Console.ReadLine();
        string[] strings = input.Split(new char[] {','});

        // Создание нового массива с подходящими строками
        string[] output = new string[strings.Length];
        int count = 0;
        for (int i = 0; i < strings.Length; i++)
        {
            if (strings[i].Length <= 3)
            {
                output[count] = strings[i];
                count++;
            }
        }
        