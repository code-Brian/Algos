using System.Text.Json;

int[] MoveZeros(int[] arr)
{
    int tempIndex = 0;
    // Will try to start with bubble sort
    for(int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"i: {i}");
        if(arr[i] == 0)
        {
            Console.WriteLine($"Zero found at: arr[{i}]");
            for(int j = i; j < arr.Length- i - 2; j++)
            {
                tempIndex = arr[j];
                Console.WriteLine($"Setting tempIndex: {tempIndex}");

                arr[j] = arr[j+1];
                Console.WriteLine($"Swapping arr[{j}]: {arr[j]} for arr[{j+1}]: {arr[j+1]}");
                arr[j+1] = tempIndex;
            }
        }
    }
    string jsonArray = JsonSerializer.Serialize(arr);
    Console.WriteLine(jsonArray);
    return arr;
}

int[] testArray = new int[]{1,2,0,1,0,1,0,3,0,1}; // should be sorted to: 1, 2, 1, 1, 3, 1, 0, 0, 0, 0
int[] randomArray = new int[]{2,2,3,2,0,1,0,3,4,5,0,3,4,2,5,5,1,0,0,4,4,3,5,0,5,5,1,3,0,5,5,5,1,3,0,5,3,1,1,1,0,0};

MoveZeros(testArray);
MoveZeros(randomArray);
