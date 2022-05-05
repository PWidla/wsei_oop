using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

        dictionary["image"] = new List<string> { "png", "webp", "jpg", "gif", "tiff" };
        dictionary["audio"] = new List<string> { "ogg", "mp3" };
        dictionary["video"] = new List<string> { "mkv", "mp4", "webm" };
        dictionary["document"] = new List<string> { "txt", "doc", "docx", "xml", "xlmx" };

        string path = "C:\\Users\\Eryk\\Desktop\\przyklad";
        //var info = new DirectoryInfo(path);
        //var files = info.GetFiles();
        //FileInfo[] fiArr = info.GetFiles();
        //var dirs = info.GetDirectories();

        //string[] Scan = Directory.GetFileSystemEntries(path, "*.*", SearchOption.AllDirectories); //skan rekursywny
        //string[] a = Directory.GetFiles(path);
        string[] a = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
        string[] b = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);

        //double sizeInBytes = Directory.EnumerateFiles($"{path}", "*", SearchOption.AllDirectories).Sum(fileInfo => new FileInfo(fileInfo).Length);

        SortedList<string, double> Files = new SortedList<string, double>(); //możliwość stworzenia kolekcji typu para klucz/wartość, które są sortowane według kluczy i są dostępne przez klucz i według indeksu.
        SortedList<string, double> Folders = new SortedList<string, double>();

        double FilesSize = 0;
        double FoldersSize = 0;


        foreach (string item in a)
        {
            FileInfo fileinfo = new FileInfo(item);
            double size = (fileinfo.Length / 1000000);
            Files.Add(item, size);
            FilesSize += size;
        }

        foreach (string item in b)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(item);
            long sizeInBytes = dirInfo.
           // long sizeInBytes = Directory.EnumerateFiles($"{path}", "*", SearchOption.AllDirectories).Sum(fileInfo => new FileInfo(fileInfo).Length);
            double size = (sizeInBytes / 1000000);
            Folders.Add(item, size);
            FoldersSize += size;
        }

        


        Console.WriteLine("Nodes: ");
        Console.WriteLine("{0, 20} {1, 10} {2, 10}", "", "[count]", "[total size]");
        Console.WriteLine("{0, 20} {1, 10} {2, 10}", "Directiories:", $"{Folders.Count()}", $"{FoldersSize}MB");
        Console.WriteLine("{0, 20} {1, 10} {2, 10}", "Files:", $"{Files.Count()}", $"{FilesSize}MB");



    }
}