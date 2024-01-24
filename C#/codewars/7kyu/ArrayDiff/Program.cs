// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, ArrayDiff Meme!");

int[] FindArrayDiff(int[] a,int[] b)
{
    List<int> tempNums = new List<int>();
    List<int> uniqueNums = new List<int>();
    for(int i=0; i < a.Length; i++)
    {
        tempNums.Add(a[i]);
    }

    for(int i=0; i < b.Length; i++)
    {
        if(!tempNums.Contains(b[i]))
        {
            Console.WriteLine($"New unique value found at b[{i}]. Value: {b[i]}");
            uniqueNums.Add(b[i]);
        }
    }

    return uniqueNums.ToArray();
}

int[] uniques = FindArrayDiff(new int[]{1,1, 2,3,4}, new int[]{1,2,3,5});
for(int i=0; i<uniques.Length; i++)
{
    Console.WriteLine(uniques[i]);
}