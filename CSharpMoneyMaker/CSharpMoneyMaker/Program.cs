using System;

namespace CSharpMoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");

            Console.WriteLine("Type in the amount of money you'd like to convert.");
            double amountToConvert = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{amountToConvert} is equal to...");

            // coin worths
            double gold = 10;
            double silver = 5;

            // math :)
            double goldCoins = Math.Floor(amountToConvert / gold);
            double coinRemaining = amountToConvert % gold;
            double silverCoins = Math.Floor(coinRemaining / silver);
            coinRemaining = coinRemaining % silver;

            // print result
            Console.WriteLine($"Gold Coins: {goldCoins}");
            Console.WriteLine($"Silver Coins: {silverCoins}");
            Console.WriteLine($"Bronze Coins: {coinRemaining}");



        }
    }
}