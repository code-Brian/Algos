// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, CircleSlash!");

int CircleSlash(int n)
{
    int victorIndex = 0;
    Boolean noWinner = true;
    List<int> playerList = new List<int>();
    for(int i=1; i<=n; i++)
    {
        playerList.Add(i);
        // playerList.Insert(i, 0);
    }
    while(noWinner)
    {
        int i = 0;
        if(playerList[i+1]!=0)
        {
            Console.WriteLine($"Player {playerList[i]} now has the sword.");
            Console.WriteLine($"Player {playerList[i+1]} has been eliminated by Player {playerList[i]}.");
            playerList.RemoveAt(i+1);
            playerList.Insert(i+1, 0);
            if(playerList[i+=2]!=0 && i<=playerList.Count)
            {
                i+=2;
                Console.WriteLine($"Player {playerList[i]} now has the sword.");
            }
            else if(playerList[i+=2]!=0 && i>=playerList.Count)
            {
                i=0;
                if(playerList[i]!=0)
                {
                    Console.WriteLine($"Player {playerList[i]} now has the sword.");
                    i+=2;
                }
                else if(playerList[i+1]!=0)
                {
                    Console.WriteLine($"Player {playerList[i]} now has the sword.");
                    i+=2;
                }
            }
        }
        else if(playerList[i+1]==0)
        {
            i++;
            continue;
        }
    }

    Console.WriteLine(playerList.Count);
    return victorIndex;
}

CircleSlash(5);