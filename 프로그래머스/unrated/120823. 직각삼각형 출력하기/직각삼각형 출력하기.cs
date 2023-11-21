using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int n = Int32.Parse(s[0]);
        
        for(int i=n-1; i>=0; i--)
        {
            for(int j=i; j<n; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
        
    }
}