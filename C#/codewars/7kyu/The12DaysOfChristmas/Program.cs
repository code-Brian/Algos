// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello! Let's save Christmas!");

public class Dinglemous
{
    public class HelpSaveChristmas : IComparer<string>
    {
        
    }
}
int CompareIntegers(string x, string y)
{
    if(x == null || y == null)
    {
        return 0;
    }
    if(x.Length == y.Length)
    {
        return 0;
    }
    else if (x.Length < y.Length)
    {
        return -1;
    }
    else
    {
        return 1;
    }
}

string[] strangs = {"ass","cock","balls","a"};

for(int i=0; i<strangs.Length; i++)
{
    if(i+1 < strangs.Length)
    {
        Console.WriteLine($"Comparing:{strangs[i]} | {strangs[i+1]} ");
        Console.WriteLine(CompareIntegers(strangs[i], strangs[i+1]));
    }
    else
    {
        Console.WriteLine($"Comparing:{strangs[i-1]} | {strangs[i]} ");
        Console.WriteLine(CompareIntegers(strangs[i-1], strangs[i]));
    }
}

