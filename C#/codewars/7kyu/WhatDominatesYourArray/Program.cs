// See https://aka.ms/new-console-template for more information
using System.Text.Json;

int Dominator(int[] arr)
{
    int dominatorKey = -1;

    Dictionary<int,int> PotentialDominantNumbers = new Dictionary<int,int>();
    for(int i = 0; i < arr.Length; i++)
    {
        if(!PotentialDominantNumbers.ContainsKey(arr[i]))
        {
            PotentialDominantNumbers.Add(arr[i], 1);
        }
        else if(PotentialDominantNumbers.ContainsKey(arr[i]))
        {
            PotentialDominantNumbers[arr[i]]++;
        }
    }

    if(PotentialDominantNumbers.ContainsValue(arr.Length/2 + 1))
    {
        foreach(var kvp in PotentialDominantNumbers)
        {
            if(kvp.Value == arr.Length/2 + 1)
            {
                dominatorKey = kvp.Key;
            }
        }
    }
    else if(!PotentialDominantNumbers.ContainsValue(arr.Length/2 + 1))
    {
        foreach(var kvp in PotentialDominantNumbers)
        {
            if(kvp.Value >= arr.Length/2 + 1)
            {
                dominatorKey = kvp.Key;
            }
        }
    }

    string jsonString = JsonSerializer.Serialize(PotentialDominantNumbers);
    Console.WriteLine(jsonString);
    Console.WriteLine($"Dominator is: {dominatorKey}");
    return dominatorKey;
}

int[] testArray1 = new int[] {1,1,1,1,1,4,5,6,7};
int[] testArray2 = new int[] {1,1,1,1,1,1,1};
int[] testArray3 = new int[] {1,2,3,4,5,5,5,5,5,5,5,5,5,6,7,8,9};

Dominator(testArray3);