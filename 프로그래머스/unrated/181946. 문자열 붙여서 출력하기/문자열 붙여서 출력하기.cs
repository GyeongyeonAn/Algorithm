using System;

public class Example
{
    public static void Main()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        String s1 = input[0];
        String s2 = input[1];
        
        string result = s1 + s2;
        result = result.Replace(" ", "");
        Console.WriteLine(result);

    }
}