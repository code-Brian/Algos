// See https://aka.ms/new-console-template for more information

string Likes(string[] name)
{
    string LikedBy = "";
    if(name.Length ==0)
    {
        return LikedBy = "no one likes this";
    }
    else if(name.Length == 1)
    {
        return LikedBy = $"{name[0]} likes this";
    }
    else if(name.Length == 2)
    {
        return LikedBy = $"{name[0]} and {name[1]} like this";
    }
    else if(name.Length == 3)
    {
        return LikedBy = $"{name[0]}, {name[1]} and {name[2]} like this";
    }
    else if(name.Length >= 4)
    {
        return LikedBy = $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
    }
    else
    {
        return LikedBy ="Something went wrong in the force... Check your code and try again";
    }
}

string[] testNames = {"John", "Bill", "Shelly", "Shirley"};

Console.WriteLine(Likes(testNames));