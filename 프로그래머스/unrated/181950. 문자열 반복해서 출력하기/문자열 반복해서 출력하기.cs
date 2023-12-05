using System;

public class Example
{
    public static void Main()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        String s1 = input[0];
        int a = Int32.Parse(input[1]);
        
        String repeat = s1;
        for(int i=1; i<a; i++)
        {
            s1 += repeat;
        }
        
        Console.Write(s1);
    }
}