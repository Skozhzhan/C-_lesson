Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
int nextn = 2;

if (n > 1)
{
    while (nextn <= n)
    {
        Console.WriteLine(nextn + " ");
        nextn = nextn + 2;
    }
}