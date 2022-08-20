// Работает только с цифрами
//  Сортировка подсчетом.

Console.Clear();
int[] array = { -10, -5, 0, 4, 2, 10, 20, 5, 30 };

int[] sortedArray = CountingSortExtanded(array);
Console.WriteLine(string.Join(", ", sortedArray));

int[] CountingSortExtanded(int[] inputArray)
{
    int max = inputArray.Max();
    int min = inputArray.Min();
    int offset = -min;

    int[] sortedArray = new int[inputArray.Length];
    int[] counters = new int[max + offset + 1];

    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i] + offset]++;
    }
    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            sortedArray[index] = i - offset;
            index++;
        }
    }
    return sortedArray;
}