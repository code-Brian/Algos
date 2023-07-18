using System.Text.Json;

int[] MoveZeros(int[] arr)
{
    // Will try to start with bubble sort
    int swapIndex = 0;
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.WriteLine($"i: {i}");
        if(arr[i] == 0 && arr[i+1] != 0)
        {
            for(int j = i; j < arr.Length-1; j++)
            {
                Console.WriteLine($"Found 0 at arr[{j}].");
                swapIndex = arr[j];
                Console.WriteLine($"swapIndex being set to: {arr[j+1]}");
                arr[j] = arr[j+1];
                Console.WriteLine($"arr[{j}] set to: {arr[j+1]}");
                arr[j+1] = swapIndex;
                Console.WriteLine($"arr[{j+1}] set to: {swapIndex}");
            }
        }
    }
    string jsonArray = JsonSerializer.Serialize(arr);
    Console.WriteLine(jsonArray);
    return arr;
}

int[] testArray = new int[]{1,2,0,1,0,1,0,3,0,1}; // should be sorted to: 1, 2, 1, 1, 3, 1, 0, 0, 0, 0

MoveZeros(testArray);
