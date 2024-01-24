// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Odd or Even!");

string OddOrEven(int[] array)
{
    int sum = 0;
    for(int i=0; i<array.Length; i++)
    {
        sum+= array[i];
    }
    if(sum%2==0 || sum==0)
    {
        return "even";
    }
    else
    {
        return "odd";
    }
}

Console.WriteLine(OddOrEven(new int[]{1,3,5}));