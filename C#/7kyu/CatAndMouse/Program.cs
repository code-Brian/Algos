// See https://aka.ms/new-console-template for more information
string CatMouse(string str)
{
    Console.WriteLine($"Input string is: {str}");
    int Distance = 0;
    for(int i = 0; i < str.Length; i++)
    {
        Console.WriteLine($"str[i]: {str[i]}");
        if( str[i].Equals('.'))
        {
            Console.WriteLine($"Distance is: {Distance}");
            Distance +=1;
        }
        Console.WriteLine($"Distance set to: {Distance}");
    }
    if(Distance <= 3)
    {
        string CatTakesTheMouse = "Caught!";
        Console.WriteLine(CatTakesTheMouse);
        return CatTakesTheMouse;
    }
    else if(Distance > 3)
    {
        string MouseEscapesTheCat = "Escaped!";
        Console.WriteLine(MouseEscapesTheCat);
        return MouseEscapesTheCat;
    }
    return str;
}

// Cat catches the mouse if it's within three dots
CatMouse("C...m");

// Cat will not catch the mouse if it is more than three dots away
CatMouse("C....m");