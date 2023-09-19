// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("歡迎使用密碼創造器！");
        Console.Write("請輸入你想要的密碼長度：");

        if (int.TryParse(Console.ReadLine(), out int passwordLength) && passwordLength > 0)
        {
            string password = GeneratePassword(passwordLength);
            Console.WriteLine($"創造成功!密碼為：{password}");
        }
        else
        {
            Console.WriteLine("無效輸入!請輸入正確的數字!");
        }
    }

    static string GeneratePassword(int length)
    {
        const string characters = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+-=";

        StringBuilder password = new StringBuilder();

        Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            int index = random.Next(characters.Length);
            password.Append(characters[index]);
        }

        return password.ToString();
    }
}
