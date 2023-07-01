


//Дан двумерный массив размерностью 5х5, заполненный случайными числами из диапазона от 0 до 100.
//Найти максимальные элементы каждого столбца.


MaximumValuesOfEachArrayColumn();
Console.ReadLine();


static void MaximumValuesOfEachArrayColumn()
{
    int[,] array = GetArrayRandomDigits();
    int[] columnsValuesMax = new int[array.GetLength(1)];
    Show(array);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        columnsValuesMax[i] = array[i, 0];
        for (int j = 1; j <= array.GetLength(1); j++)
        {
            if (columnsValuesMax[i] < array[i, j - 1])
            {
                columnsValuesMax[i] = array[i, j - 1];
            }
        }
    }
    ShowOneDimensionalArray(columnsValuesMax);
}




static int[,] GetArrayRandomDigits()
{
    Random random = new Random();
    int[,] array = new int[5, 5];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 100);
        }
    }
    return array;
}

static void Show(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

static void ShowOneDimensionalArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
        Console.WriteLine();
    }
}