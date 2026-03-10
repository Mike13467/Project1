using System;


class Game
{
    public virtual void Run() 
    {
        Console.WriteLine("Запуск неопределенной игры...");
    }
}
class QuestGame : Game
{
    public override void Run() => Console.WriteLine("Игра 'Квест' запущена!");
}

class ActionGame : Game
{
    public override void Run() => Console.WriteLine("Игра 'Экшен' запущена!");
}

class Program6
{
    static void Main()
    {
        Console.WriteLine("Выберите игру: 1 - Квест, 2 - Экшен");
        string choice = Console.ReadLine();

        Game selectedGame; 

        if (choice == "1")
            selectedGame = new QuestGame();
        else
            selectedGame = new ActionGame();

        selectedGame.Run(); 
    }
}