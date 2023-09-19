// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("歡迎來和我比猜拳!");
        Console.WriteLine("1. 剪刀");
        Console.WriteLine("2. 石頭");
        Console.WriteLine("3. 布");
        Console.WriteLine("請輸入1、2、3猜拳:");

        int playerChoice = GetPlayerChoice();
        int computerChoice = GetComputerChoice();
        int result = DetermineWinner(playerChoice, computerChoice);

        Console.WriteLine($"你出的是 {GetGestureName(playerChoice)}");
        Console.WriteLine($"我出的是 {GetGestureName(computerChoice)}");

        

        if (result == 0)
        {
            Console.WriteLine("平手!");
        }
        else if (result == 1)
        {
            Console.WriteLine("你竟然赢了!");
        }
        else
        {
            Console.WriteLine("哇哈哈你输了!再去練練吧");
        }
    }

    static int GetPlayerChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.WriteLine("無效的输入，請重新輸入:");
        }
        return choice;
    }

    static int GetComputerChoice()
    {
        Random random = new Random();
        return random.Next(1, 4);
    }

    static string GetGestureName(int gesture)
    {
        switch (gesture)
        {
            case 1:
                return "剪刀";
            case 2:
                return "石頭";
            case 3:
                return "布";
            default:
                return "無效的输入，請重新輸入:";
        }
    }

    static int DetermineWinner(int playerGesture, int computerGesture)
    {
        if (playerGesture == computerGesture)
        {
            return 0; // 平局
        }
        else if ((playerGesture == 1 && computerGesture == 3) || (playerGesture == 2 && computerGesture == 1) || (playerGesture == 3 && computerGesture == 2))
        {
            return 1; // 玩家赢
        }
        else
        {
            return -1; // 我赢
        }
    }
}
