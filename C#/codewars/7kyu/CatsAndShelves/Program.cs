// See https://aka.ms/new-console-template for more information
Console.WriteLine("Meow, World!");

int Cats(int start, int finish)
{
    int numberOfJumps = 0;
    while(start < finish)
    {
        if(finish - start >= 3)
        {
            start+=3;
            numberOfJumps++;
        }
        else if(finish - start < 3)
        {
            start+=1;
            numberOfJumps++;
        }
    }
    Console.WriteLine($"It took {numberOfJumps} to get to the end.");
    return numberOfJumps;
}

Console.WriteLine(Cats(2,5));