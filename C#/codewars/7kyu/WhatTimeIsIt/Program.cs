// See https://aka.ms/new-console-template for more information
string GetMilitaryTimeFromStandardTime(string time)
{
    string convertedTime = "";
    string tempString = "";
    int tempInt = 0;
    bool isPM = false;
    bool isAM = false;

    for(int i = 0; i <time.Length; i++)
    {

        tempString += time[i];

        if(time[i] == 'A')
        {
            isAM = true;
            Console.WriteLine("Morning time found.");
        }
        else if(time[i] == 'P')
        {
            isPM = true;
            Console.WriteLine("Evening time found.");
        }
        Console.WriteLine(time[i]);
    }

    if(isAM == true)
    {
        if(time.Substring(0,2) == "12")
        {
            Console.WriteLine("Parse needed for AM time containing 12.");
            convertedTime = "00" + time.Substring(2,6);
        }
        else 
        {
            convertedTime = time.Substring(0,8);
        }
    }

    if(isPM == true)
    {
        if(time.Substring(0,2) == "12")
        {
            convertedTime = time.Substring(0,8);
            Console.WriteLine($"convertedTime is: {convertedTime}");
            return convertedTime = time.Substring(0,8);
        }

        Console.WriteLine("Evening time found");
        tempString = time.Substring(0,2);
        tempInt = int.Parse(tempString) + 12;
        tempString = tempInt.ToString();
        convertedTime = tempString + time.Substring(2,6);
        Console.WriteLine(tempInt);
    }
    Console.WriteLine($"convertedTime is: {convertedTime}");
    return convertedTime;
}

// GetMilitaryTimeFromStandardTime("12:00:01AM"); // This should return "00:00:01"
// GetMilitaryTimeFromStandardTime("07:00:00AM");
GetMilitaryTimeFromStandardTime("07:00:00PM");
GetMilitaryTimeFromStandardTime("12:00:00PM");