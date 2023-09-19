// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> todoList = new List<string>();

        while (true)
        {
            Console.WriteLine("________________________");
            Console.WriteLine("|歡迎使用待辦事項管理器|");
            Console.WriteLine("|    1.新增待辦事項    |");
            Console.WriteLine("|    2.檢視待辦事項    |");
            Console.WriteLine("|    3.移除待辦事項    |");
            Console.WriteLine("|      4.離開          |");
            Console.WriteLine("________________________");
            Console.Write("請輸入你的選擇: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("請輸入待辦事項: ");
                        string newTodo = Console.ReadLine();
                        todoList.Add(newTodo);
                        Console.WriteLine("待辦事項新增成功");
                        break;
                    case 2:
                        Console.WriteLine("待辦事項:");
                        for (int i = 0; i < todoList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {todoList[i]}");
                        }
                        break;
                    case 3:
                        Console.Write("待辦事項: ");
                        if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= todoList.Count)
                        {
                            string removedTodo = todoList[index - 1];
                            todoList.RemoveAt(index - 1);
                            Console.WriteLine($"待辦事項 '{removedTodo}' 移除成功");
                        }
                        else
                        {
                            Console.WriteLine("無效輸入!");
                        }
                        break;
                    case 4:
                        Console.WriteLine("即將離開管理器，再會!");
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.WriteLine("無效輸入!請輸入數字1~4其中一個數字!");
            }

            Console.WriteLine();
        }
    }
}
