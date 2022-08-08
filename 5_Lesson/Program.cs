// Быстрая сортировка.

/*
1. [1, 0, -6, 2, 5, 3, 2]
2. pivit = array[6] (опорный элемент)
3. Вызвать шаги 1-2 для подмассива слеыва от pivot и справа от pivot.

*/

int[] array = { 0, -5, 2, 3, 5, 9, -1, 7 };
QuickSort(array, 0, array.Length - 1);
Console.Write($"Отсортированный массив {string.Join(",", array)}");

void QuickSort(int[] intputArray, int minIndex, int maxIndex)
{   
    if(minIndex >= maxIndex) return;
    int pivot = GetPivotIndex(intputArray, minIndex, maxIndex);
    QuickSort(intputArray, minIndex, pivot - 1);
    QuickSort(intputArray, pivot + 1, maxIndex);
    return;
}
int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
{
    int pivotIndex = minIndex - 1;
    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (inputArray[i] < inputArray[maxIndex])
        {
            pivotIndex++;
            Swap(inputArray, i, pivotIndex);
        }
    }
    pivotIndex++;
    Swap(inputArray, pivotIndex, maxIndex);
    return pivotIndex;
}

void Swap(int[] inputArray, int leftValue, int rightValue)
{
    int temp = inputArray[leftValue];
    inputArray[leftValue] = inputArray[rightValue];
    inputArray[rightValue] = temp;
}

// Work