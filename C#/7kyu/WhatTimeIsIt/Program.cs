// See https://aka.ms/new-console-template for more information
string GetMilitaryTimeFromStandardTime(string time)
{
    string convertedTime = "";
    string tempString = "";
    bool isEvening = false;
    bool isMorning = false;

    for(int i = 0; i <time.Length; i++)
    {

        tempString += time[i];

        if(time[i] == 'A')
        {
            isMorning = true;
            Console.WriteLine("Morning time found.");
        }
        else if(time[i] == 'P')
        {
            isEvening = true;
            Console.WriteLine("Evening time found.");
        }
        Console.WriteLine(time[i]);
    }

    if(isMorning == true)
    {
        if(time[0] == '1' && time[1] == '2')
        {
            Console.WriteLine("Parse needed for AM time containing 12.");
        }
    }
    Console.WriteLine($"isMorning: {isMorning}");
    Console.WriteLine(tempString);
    return convertedTime;
}

GetMilitaryTimeFromStandardTime("12:00:01AM"); // This should return "00:00:01"