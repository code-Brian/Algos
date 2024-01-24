using System.Text.Json;
// See https://aka.ms/new-console-template for more information
// https://www.codewars.com/kata/57cc847e58a06b1492000264/train/csharp
Console.WriteLine("Hello, Sort-n-Transform!");

// let's see if we can solve a small part of the problem
// create a four character 'word' made up of the characters derived from the first two and the last two numbers in the array
// order should be read as left to right(first, second, second last, last)
// (111, 112, 114,110)
// sort the array into ascending order
// then grab the same characters from the order(first, second, second last, last)

int[] TestNumbers = {111, 112, 113, 114, 115, 113, 114, 110};

string ParseSortedString(int[] arr)
{
    char currentChar = ' ';
    string parsedString = "";
    for(int i=0; i<4; i++)
    {
        if(i < 2)
        {
            currentChar = Convert.ToChar(arr[i]);
            Console.WriteLine(currentChar);
            parsedString += currentChar;
        }
        else if(i == 2)
        {
            currentChar = Convert.ToChar(arr[arr.Length-2]);
            Console.WriteLine(currentChar);
            parsedString += currentChar;
        }
        else
        {
            currentChar = Convert.ToChar(arr[arr.Length-1]);
            Console.WriteLine(currentChar);
            parsedString += currentChar;
        }

        Console.WriteLine($"parsedString: {parsedString}");
    }
    return parsedString;
}


string SortTransform(int[] arr)
{
    string firstWord = "";
    string secondWord = "";
    string thirdWord = "";
    string combinedString = "";

    firstWord = ParseSortedString(arr);
    Console.WriteLine($"firstWord: {firstWord}");

    // Let's see if we can use insertion sort for each sorting challenge
    // Let's do a pseudo cook
    // procedure insertionSort(A: list of sortable items)
    //    n = length(A)
    //    for i = 1 to n - 1 do
    //        j = i
    //        while j > 0 and A[j-1] > A[j] do
    //            swap(A[j], A[j-1])
    //            j = j - 1
    //        end while
    //    end for
    // end procedure

    // Sort by ascending order
    int n = arr.Length;
    for(int i = 0; i < n; i++)
    {
        int j = i;
        while(j > 0 && arr[j-1] > arr[j])
        {
            int temp = arr[j];
            arr[j] = arr[j-1];
            arr[j-1] = temp;
            j--;
        }
    }
    secondWord = ParseSortedString(arr);
    Console.WriteLine($"secondWord: {secondWord}");
    Console.WriteLine($"Sorted in ascending order: {JsonSerializer.Serialize(arr)}");

    // Sort by descending
    for(int i = 0; i < n; i++)
    {
        int j = i;
        while(j > 0 && arr[j-1] < arr[j])
        {
            int temp = arr[j];
            arr[j] = arr[j-1];
            arr[j-1] = temp;
            j--;
        }
    }

    thirdWord = ParseSortedString(arr);
    Console.WriteLine($"thirdWord: {thirdWord}");
    Console.WriteLine($"Sorted by descending: {JsonSerializer.Serialize(arr)}");

    return combinedString = firstWord + "-" + secondWord + "-" + thirdWord + "-" + secondWord;
}

string coolString = SortTransform(TestNumbers);
Console.WriteLine(coolString);