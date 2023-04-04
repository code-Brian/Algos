// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, ArrayDiff Meme!");

// TODO: Figure out how compare the values between the incoming arrays.
// If there is a value that is not shared between the arrays, 
// add it to an array that will hold and return the discovered unique values.
int[] FindArrayDiff(int[] a,int[] b)
{
    int[] uniqueNums ={0};
    for(int i=0; i<a.Length; i++){
        Console.WriteLine($"a at index {i} is: {a[i]}");
        for(int j=0; j<b.Length; j++)
        {
            Console.WriteLine($"b at index {j} is: {b[j]}");
            if(a[i] != b[j])
            {
                Console.WriteLine("Unique value!");
                Console.WriteLine($"a: {a[i]} b:{b[j]}");
            }
        }
    }
    return uniqueNums;
}

FindArrayDiff(new int[]{1,2,3,4}, new int[]{1,2,3});