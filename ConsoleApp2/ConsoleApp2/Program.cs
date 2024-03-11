using System.Runtime.InteropServices;

public class Project
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, Earth!");
        Console.WriteLine("Hello, Mars!");
        Console.WriteLine("Hello, Sun!");
    }

    public static int avg(int[] arr)
    {
        int res = 0;
        int sum = 0;
        foreach (var i in arr)
        {
            sum += i;
        }
        res = sum / arr.Length;
        return res;
    }
}

