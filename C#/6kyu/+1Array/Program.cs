// See https://aka.ms/new-console-template for more information
bool ValidateArray(int[] num)
{
    bool arrayValid = true;
    for(int i = 0; i < num.Length; i++)
    {
        if(num[i] < 0 || num[i] > 9)
        {
            arrayValid = false;
            return arrayValid;
        }
    }
    return arrayValid;
}

int[] UpArray(int[] num)
{
    string tempString = "";
    int tempInt = 0;
    if(ValidateArray(num))
    {
        for(int i = 0; i < num.Length; i++)
        {
            tempString+=num[i];
        }
    }
    return num;
}

int[] invalidArray = new int[]{-1,2,3,4};
int[] invalidArray2 = new int[]{0,22,21,97};
int[] validArray = new int[]{0,1,2,3};

Console.WriteLine($"invalidArray returns: {ValidateArray(invalidArray)}");
Console.WriteLine($"invalidArray2 returns: {ValidateArray(invalidArray2)}");
Console.WriteLine($"validArray returns: {ValidateArray(validArray)}");

UpArray(validArray);
