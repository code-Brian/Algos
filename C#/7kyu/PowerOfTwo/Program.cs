// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, PowerOfTwo!");

// This is a troll method, but it is kinda a meme xD
bool PowerOfTwo(int n)
{
    bool IsPowerOfTwo = false;
    int Product = 2;
    do
    {
        Product = Product * 2;
    } while (Product < n);

    if(Product == n || n == 1 || n == 2)
    {
        Console.WriteLine($"Product: {Product} | n: {n}");
        return IsPowerOfTwo = true;
    }
    else
    {
        Console.WriteLine($"Product: {Product} | n: {n}");
        return IsPowerOfTwo;
    }
}

Console.WriteLine(PowerOfTwo(2));