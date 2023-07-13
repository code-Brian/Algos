// See https://aka.ms/new-console-template for more information
string GetMiddle(string str)
{
    if(str.Length % 2 == 0)
    {
        string middleOfString = str.Substring((str.Length/2) - 1, 2);
        Console.WriteLine(middleOfString);
        return middleOfString;
    }
    else
    {
        int middleIndex = str.Length / 2;
        string middleOfString = str.Substring(middleIndex,1);
        Console.WriteLine(middleOfString);
        return middleOfString;
    }

}

GetMiddle("but");
GetMiddle("Asol");