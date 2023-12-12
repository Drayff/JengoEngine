namespace JengoEngine;

public class Log
{
    public static void Info(String text)
    {
        Console.Write("[");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("INFO");
        Console.ResetColor();
        Console.WriteLine("] " + text);
    }
    
    public static void Warning(String text)
    {
        Console.Write("[");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("WARN");
        Console.ResetColor();
        Console.WriteLine("] " + text);
    }
    
    public static void Error(String text)
    {
        Console.Write("[");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("ERRO");
        Console.ResetColor();
        Console.WriteLine("] " + text);
    }
    
    public static void Debug(String text)
    {
        Console.Write("[");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("DEBG");
        Console.ResetColor();
        Console.WriteLine("] " + text);
    }
}