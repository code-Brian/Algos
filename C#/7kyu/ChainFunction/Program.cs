// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Including example functions to see how chaining works
double add(double x)
{
    Console.WriteLine($"add being called and {x} being passed in.");
    return x+1;
}

double mul(double x)
{
    Console.WriteLine($"mul being called and {x} being passed in.");
    return x * 30;
}

double Chain(double input, Func<double,double>[] fs)
{
    double result=0;
    double tempInput=0;
    for(int i=0; i<fs.Length; i++)
    {
        // result of previous funciton needs to be passed in to the next function of the list.
        // My idea is to store the input as a temp variable and update it with the result of each iteration.
        // For now, tempInput will be set to result upon each iteration.
        Console.WriteLine($"result: {result}");
        tempInput=result;
        Console.WriteLine($"tempInput: {tempInput}");
        // This works for most instances, but we need to check if the input is being used for the first time.
        if(i==0)
        {
            Console.WriteLine(fs[i].Invoke(input));
            result = fs[i].Invoke(input);
            Console.WriteLine($"result after first run: {result}");
        }
        else
        {
            Console.WriteLine(fs[i].Invoke(tempInput));
            result = fs[i].Invoke(tempInput);
            Console.WriteLine($"result at [{i}]: {result}");
        }
    }
    Console.WriteLine($"Final result is: {result}");
    return result;
}

// This example should return 90
Chain(2, new[]{(Func<double,double>)add, mul});