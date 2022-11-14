int max = 0;

Console.WriteLine("Input number 1");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 3");
int n3 = Convert.ToInt32(Console.ReadLine());
if (n1 > max)
{
    max = n1;
}
if (n2 > max)
{
    max = n2;
}
if (n3 > max)
{
    max = n3;
}
Console.WriteLine("max = " + max);
