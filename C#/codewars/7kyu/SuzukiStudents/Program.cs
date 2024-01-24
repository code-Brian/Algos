// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Suzuki Frens!");

string[] LineupStudents(String str)
{
    string[] Students = str.Split(new[] {' '});

    for (int i=0; i < Students.Length; i++)
    {
        Console.WriteLine(Students[i]);
    }

    return Students;
}

string TestString = "xxa xxb xxc xxd xa xb xc xd";

LineupStudents(TestString);