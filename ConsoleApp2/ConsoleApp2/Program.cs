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

    public static int Average(int[] arr)
    {
        int result = 0;
        int sum = 0;
        foreach (var i in arr)
        {
            sum += i;
        }
        result = sum / arr.Length;
        return result;
    }

    public static int max(int[] arr)
    {
        int max = 0;
        foreach (var i in arr)
        {
            if (i > max)
                max = i;
        }

        return max;
    }
}

