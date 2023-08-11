using System;
using System.IO;


namespace HW_8_6_2;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите путь к каталогу");
        string path = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Размер вложенный файлов и папок {DirectorySize.Size(path)} байт");

    }
}