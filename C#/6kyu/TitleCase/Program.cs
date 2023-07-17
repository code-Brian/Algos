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

string TitleCase(string title, string minorWords)
{
    string[] titleWords = title.Split(" ");
    foreach (string word in titleWords)
    {
        Console.WriteLine(word);
    }
    return " ";
}

string minorWords = "";
string title = "the big black clock";

TitleCase(title,minorWords);