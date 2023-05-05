// See https://aka.ms/new-console-template for more information
using System.Text.Json;
Console.WriteLine("Hello, BubbleSortOnce!");

int[] BubbleSortOnce(int[] input)
{
    List<int> BubbledArray = input.ToList();
    Console.WriteLine($"List count is: {BubbledArray.Count}");
    for(int i = 0; i < BubbledArray.Count; i++)
    {
        if(i+1 < BubbledArray.Count-1)
        {
            if(BubbledArray[i] >= BubbledArray[i+1])
            {
                BubbledArray.Insert(i, BubbledArray[i+1]);
                BubbledArray.RemoveAt(i+2);
            }
        }
        else if(i+1 == BubbledArray.Count-1)
        {
            if(BubbledArray[i] > BubbledArray[i+1])
            {
                BubbledArray.Insert(i, BubbledArray[i+1]);
                BubbledArray.RemoveAt(i+2);
            }
        }
    }
    return BubbledArray.ToArray();
}
int[] TestInts = new int[]{9,7,5,3,1,2,4,6,8};

int[] ExpectedResult = new int[]{7,5,3,1,2,4,6,8,9};

string jsonString = JsonSerializer.Serialize(BubbleSortOnce(TestInts));
Console.WriteLine(jsonString);

if(BubbleSortOnce(TestInts) == ExpectedResult)
{
    Console.WriteLine("They be equal, fren");
}