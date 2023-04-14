// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int SecondSymbol(string str, char symbol)
{
    int SecondCharAtIndex = 0;
    Dictionary<char, int> CharDictionary = new Dictionary<char, int>();
    void PrintDictionary(Dictionary<char, int> dictionary)
    {
        foreach(var kvp in dictionary)
        {
            Console.WriteLine($"Key: {kvp.Key} | Value: {kvp.Value}");
        }
    }
    for(int i=0; i<str.Length; i++)
    {
        if(str[i] == symbol && !CharDictionary.ContainsKey(str[i]))
        {
            CharDictionary.Add(str[i], 1);
        }
        else if(str[i] == symbol && CharDictionary.ContainsKey(str[i]))
        {
            CharDictionary[str[i]] += 1;
            if(CharDictionary.ContainsValue(2))
            {
                SecondCharAtIndex = i;
                PrintDictionary(CharDictionary);
                return SecondCharAtIndex;
            }
        }
    }

    if(CharDictionary.ContainsValue(1) || !CharDictionary.ContainsValue(2) || !CharDictionary.ContainsKey(symbol))
    {
        PrintDictionary(CharDictionary);
        return -1;
    }

    else
    {
        PrintDictionary(CharDictionary);
        return -1;
    }
}

Console.WriteLine(SecondSymbol("Hello World",'l'));