// See https://aka.ms/new-console-template for more information
using System.Text.Json;

int[] TwoSum(int[] numbers, int target)
{
    int firstAddend = 0;
    int secondAddend = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        for(int j = i+1; j < numbers.Length; j++)
        {
            Console.WriteLine($"numbers[i]: {numbers[i]} | numbers[j]: {numbers[j]}");
            if(numbers[i] + numbers[j] == target)
            {
                firstAddend = i;
                secondAddend = j;
                int [] addends = new int[]{firstAddend, secondAddend};
                string addendsArray = JsonSerializer.Serialize(addends);
                Console.WriteLine(addendsArray);
                return addends;
            }
        }
    }
    return numbers;
}

int [] testNumbers = new int[] {1,2,3};
int testTarget = 4;

TwoSum(testNumbers, testTarget);