// See https://aka.ms/new-console-template for more information
using System.Text.Json;

// string TitleCase(string title, string minorWords="")
// {
//     // we need to be able to find the beginning of each word in the title
//     int titleWordCount = 1;
//     string tempTitleString = "";
//     for(int i = 0; i < title.Length; i++)
//     {
//         // let's start by putting each word into an index of an array
//         if(title[i] == ' ')
//         {
//             titleWordCount++;
//         }
//         Console.WriteLine(titleWordCount);
//         // we need to compare the title word to the minor words
//         // if the title word is a minor word, change it to lower case
//         // if the tile is all upper case and is not a minor word, change it to upper case on the first char only
//     }
//     string [] titleWordsArray = new string [titleWordCount];
//     titleWordCount = 0;
//     for(int i = 0; i <title.Length; i++)
//     {
//         if(title[i] != ' ')
//         {
//             tempTitleString += title[i];
//         }

//         else
//         {
//             Console.WriteLine($"Temp title string: {tempTitleString}");
//             titleWordsArray[titleWordCount] = tempTitleString;
//             titleWordCount++;
//             tempTitleString = "";
//         }

//         if(title[i] != ' ' && title.Length - 1 == i)
//         {
//             titleWordsArray[titleWordCount] = tempTitleString;
//             Console.WriteLine($"Last temp title string: {tempTitleString}");
//             tempTitleString = "";
//             titleWordCount = 0;
//         }
//     }
//     string jsonTitleWordsArray = JsonSerializer.Serialize(titleWordsArray);
//     Console.WriteLine(jsonTitleWordsArray);
//     return "";
// }

string TitleCase(string title, string minor)
{
    string[] titleWords = title.Split(" ");
    string[] minorWords = minor.Split(" ");
    string jsonArray = JsonSerializer.Serialize(titleWords);
    string jsonMinorArray = JsonSerializer.Serialize(minorWords);
    // Confirm the arrays were split correctly
    Console.WriteLine("Original title words array:" + jsonArray);
    Console.WriteLine("Original minor words array:" + jsonMinorArray);

    for(int i = 0; i < titleWords.Length; i++)
    {
        for(int j = 0; j < titleWords[i].Length; j++)
        {
            string tempString = "";
            if(j == 0)
            {
                // Capitalize the first word, and store it in a temp string.
                tempString = titleWords[i].Substring(0,1).ToUpper() + titleWords[i].Substring(1).ToLower();
                Console.WriteLine("After: " + titleWords[i]);
                titleWords[i] = tempString;
            }
            // Now we need to update the original word in the array
            tempString = "";
        }
    }
    jsonArray = JsonSerializer.Serialize(titleWords);
    Console.WriteLine("Capitalized title array:" + jsonArray);

    for(int i = 1; i < titleWords.Length; i++)
    {
        Console.WriteLine($"On title word: {titleWords[i]}");
        for(int j = 0; j < minorWords.Length; j++)
        {
            Console.WriteLine($"checking title word for: {minorWords[j]}");
            if(titleWords[i].ToLower() == minorWords[j])
            {
                Console.WriteLine($"Minor word found in title: {minorWords[j]}");
            }
        }
    }
    return " ";
}
string minorWords = "a an the of";
string title = "a clash of KINGS";

TitleCase(title,minorWords);