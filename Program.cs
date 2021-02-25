//Name:         Roger Silva Santos Aguiar
//Initial date: February 25, 2021

using System;

namespace LottetyGamesProject
{
    class TestLotteryGamesByFrequency
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the quantity of available numbers in the game: ");
            int quantityOfAvailableNumbers = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the quantity of numbers by game: ");
            int quantityOfNumbersByGame = Int32.Parse(Console.ReadLine());       
            Console.Write("Copy and past the path of the file with the past results here: ");     
            string file = Console.ReadLine();
            
            LotteryGamesByFrequency game = new LotteryGamesByFrequency(file, quantityOfAvailableNumbers, quantityOfNumbersByGame);
            game.GenerateGames();
            Console.WriteLine(game.GetLayoutGame());
        }
    }
}
