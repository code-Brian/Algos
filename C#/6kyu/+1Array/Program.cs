// See https://aka.ms/new-console-template for more information
using System.Text.Json;


int[] UpArray(int[] num)
{
    bool ValidateArray(int[] arr)
    {
        bool isValid = true;
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] < 0 || arr[i] > 9)
            {
                return isValid = false;
            }
            }
        if(arr.Length <= 0)
        {
        isValid = false;
        }
        return isValid;
    }

    if(ValidateArray(num) == false)
    {
        return null;
    }

    if(ValidateArray(num))
    {
        Console.WriteLine("Is this thing turned on?");
        Console.WriteLine($"num[] length - 1: {num.Length - 1}");
        string incomingJsonArray = JsonSerializer.Serialize(num);
        Console.WriteLine($"num at beginning: {incomingJsonArray}");
        bool isIncremented = false;
        for(int i = num.Length-1; i >= 0; i--)
        {
        Console.WriteLine($"num[{i}]: {num[i]}");
        if(num[i] == 9)
        {
            Console.WriteLine($"num[{i}] set to 0");
            num[i] = 0;
            continue;
        }
        else if(num[i] != 9 && isIncremented == false)
        {
            Console.WriteLine("Incrementing");
            num[i]++;
            isIncremented = true;
            string jsonNum = JsonSerializer.Serialize(num);
            Console.WriteLine(jsonNum);
            return num;
        }
        }

        if(isIncremented == false)
        {
        int[] incrementedArray = new int[num.Length+1];
        for(int i = 0; i < incrementedArray.Length; i++)
        {
            if(i == 0)
            {
            incrementedArray[i] = 1;        
            }
            else
            {
            incrementedArray[i] = num[i - 1];
            }
        }
        string jsonNum = JsonSerializer.Serialize(incrementedArray);
        Console.WriteLine(jsonNum);
        return incrementedArray;
        }
    }
    return num;
}




int[] invalidArray = new int[]{-1,2,3,4};
int[] invalidArray2 = new int[]{0,22,21,97};
int[] validArray = new int[]{0,1,9,9};
int[] validArray2 = new int[]{0,1,2,9};

Console.WriteLine($"invalidArray returns: {ValidateArray(invalidArray)}");
Console.WriteLine($"invalidArray2 returns: {ValidateArray(invalidArray2)}");
Console.WriteLine($"validArray returns: {ValidateArray(validArray)}");

UpArray(validArray);
UpArray(validArray2);
