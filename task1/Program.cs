using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input number 1");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input number 2");
        int n2 = Convert.ToInt32(Console.ReadLine());
        if (n1 > n2)
            Console.WriteLine(n1);
        else
            Console.WriteLine(n2);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}