using System;
using System.Linq;
using System.Text;

class PasswordGenerator
{
    static void Main()
    {
        Console.WriteLine("Введите длину пароля:");
        int length = int.Parse(Console.ReadLine());

        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
        Random random = new Random();
        StringBuilder password = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            password.Append(chars[random.Next(chars.Length)]);
        }

        Console.WriteLine($"Сгенерированный пароль: {password}");

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadLine();
    }
}
