// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string SortMyString(string s)
{
    // Take the incoming string iterate over each character.
    string SortedString="";
    string EvenString="";
    string OddString="";
    // Iterate over the input string
    for(int i=0; i<s.Length; i++)
    {
        // Sort it into even and odd strings
        if(i == 0 || i % 2 == 0)
        {
            EvenString+=s[i];
        }
        else
        {
            OddString+=s[i];
        }
    }
    // Concat the strings at the end
    SortedString = EvenString + " " + OddString;
    Console.WriteLine(SortedString);
    return SortedString;
}

SortMyString("CodeWars");