using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Timers;

Random rand = new Random();
int targetNumber = rand.Next(1, 51);
int userGuess = 0;
int attempts = 0;

Console.WriteLine("Я загадал число от 1 до 50. Попробуй угодать");

while (userGuess != targetNumber)
{
    Console.Write("Введите ваше число: ");
    String input = Console.ReadLine();

    if (!int.TryParse(input, out userGuess))
    {
        Console.WriteLine("Пожалуйста введите конкретное число.");
        continue;
    }

    attempts++;

    if (userGuess < targetNumber)
    {
        Console.WriteLine("Загаданное число больше");
    }
    else if (userGuess > targetNumber)
    {
        Console.WriteLine("Загаданное число меньше");
    }
    else
    {
        Console.WriteLine($"Поздравляю! Ты угадал число за {attempts} попыток.");
    }
}
