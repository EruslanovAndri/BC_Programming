Console.WriteLine("Введите кол-во элементов массива: ");
int amountOfElements = Convert.ToInt32(Console.ReadLine());

int[] array = new int[amountOfElements];
for (int i = 0; i < amountOfElements; i++)
{
    Console.WriteLine("Введите число:");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Начальный массив [" + string.Join(", ", array) + "]");

// Selection Sort

for (int i = 0; i < amountOfElements - 1; i++)
{
    int minElement = i;
    for (int j = i + 1; j < amountOfElements; j++)
    {
        if(array[j] < array[minElement])
        {
            minElement = j;
        }
            int temp;
            temp = array[minElement];
            array[minElement] = array[i];
            array[i] = temp;
    }
}
Console.WriteLine("Конечный массив: [" + string.Join(", ",array) + "]");