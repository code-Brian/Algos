bool IsSquare(int n)
{
    bool PerfectSquare = false;
    if(n % Math.Sqrt(n) == 0 && n > 0 || n == 0)
    {
        Console.WriteLine($"{n} is a perfect square.");
        return PerfectSquare = true;
    }
    else
    {
        Console.WriteLine($"{n} is NOT a perfect square.");
        return PerfectSquare;
    }
}
IsSquare(4);
IsSquare(9);
IsSquare(10);
IsSquare(11);
IsSquare(16);
