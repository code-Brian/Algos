// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, CircleSlash!");
void CheckArray(int[] a)
{
    for(int i=0; i < a.Length; i++)
    {
        Console.WriteLine(a[i]);
    }
}

int CircleSlash(int n)
{
    int currentPlayer = 1;
    int victor = 0;
    bool gameOn = true;
    int[] defeatedPlayers = new int[n];
    while(gameOn)
    {
        if(defeatedPlayers[currentPlayer-1]==0)
        {
            CheckArray(defeatedPlayers);
            Console.WriteLine($"Current player: {currentPlayer} | Status: {defeatedPlayers[currentPlayer-1]}");
            Console.WriteLine($"{currentPlayer} kills {currentPlayer + 1} and passes to {currentPlayer + 2}");
            Console.WriteLine($"Player {currentPlayer + 1} status set to: {defeatedPlayers[currentPlayer + 1] = 1}");
            currentPlayer++;
            CheckArray(defeatedPlayers);
            Console.WriteLine($"Next player: {currentPlayer}");
        }
    }
    return victor;
}


CircleSlash(5);