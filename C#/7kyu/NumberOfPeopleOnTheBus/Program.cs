// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Number of People on the Bus!");

int Number(List<int[]> peopleListInOut)
{
    int peopleOnTheBus = 0;
    foreach(int[] busStop in peopleListInOut)
    {
        peopleOnTheBus += busStop[0];
        peopleOnTheBus -= busStop[1];
    }
    return peopleOnTheBus;
}
List<int[]> peopleList = new List<int[]>(){new[]{10,0},new[]{3,5}, new[]{5,8}};
Number(peopleList);