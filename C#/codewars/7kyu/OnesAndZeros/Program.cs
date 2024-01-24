// See https://aka.ms/new-console-template for more information
int BinaryArrayToNumber(int[] BinaryArray)
{
    string binaryString = "";
    int binaryNumber = 0;
    for(int i = 0; i<BinaryArray.Length; i++)
    {
        binaryString += BinaryArray[i].ToString();
    }
    return binaryNumber = Convert.ToInt32(binaryString,2);
}

int [] binaryTest = new int [] {0,0,0,1};

Console.WriteLine(BinaryArrayToNumber(binaryTest));