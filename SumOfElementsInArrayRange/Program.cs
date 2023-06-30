
//Дан двумерный массив размерностью 5х5,
//заполненный случайными числами из диапазона от -100 до 100.
//Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.


SumOfElementsInArrayRange();
Console.ReadLine();

static void SumOfElementsInArrayRange()
{
    int[,] array = GetArrayRandomDigits();
    ShowTwoDimensionalArray(array);

    var elementsMinAndMaxIndex = GetMinAndMaxIndexArray(array);
    var cheking = IndexChek(elementsMinAndMaxIndex.Item1, elementsMinAndMaxIndex.Item2);
    int[] elementMinIndex = cheking.Item1;
    int[] elementMaxIndex = cheking.Item2;

    List<int> digits = new List<int>();
    int sum = 0;

    for (int i = elementMinIndex[0]; i <= elementMaxIndex[0]; i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {

            if (i == elementMinIndex[0] && elementMinIndex[1] > k)
            {
                continue;
            }

            digits.Add(array[i, k]);
            sum += array[i, k];

            if (i == elementMaxIndex[0] && k == elementMaxIndex[1])
            {
                break;
            }
        }
    }

    ShowOneDimensionalArray(digits.ToArray());

    Console.WriteLine($"Сумма элементов в диапазоне равна: {sum}");
}

static (int[], int[]) IndexChek(int[] arrayX, int[] arrayY)
{

    if (arrayX[0] > arrayY[0])
    {
        return (arrayY, arrayX);      
    }
    else
    {
        if (arrayX[0] == arrayY[0] && arrayX[1] > arrayY[1])
        {
            return (arrayY, arrayX);
        }
        return (arrayX, arrayY);
    }
}

static (int[], int[]) GetMinAndMaxIndexArray(int[,] array)
{
    int elementMinValue = array[0, 0];
    int elementMaxValue = array[array.GetLength(0) - 1, array.GetLength(1) - 1];

    int[] elementMinIndex = new int[2] { 0, 0 };
    int[] elementMaxIndex = new int[2] { array.GetLength(0) - 1, array.GetLength(1) - 1 };

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (elementMinValue > array[i,j])
            {
                elementMinValue = array[i, j];
                elementMinIndex[0] = i;
                elementMinIndex[1] = j;
            }
        }
    }
    for (int i = array.GetLength(0) - 1; i >= 0; i--)
    {
        for (int j = array.GetLength(1) - 1; j >= 0; j--)
        {
            if (elementMaxValue < array[i, j])
            {
                elementMaxValue = array[i, j];
                elementMaxIndex[0] = i;
                elementMaxIndex[1] = j;
            }
        }
    }


    return (elementMinIndex, elementMaxIndex);
}

static int[,] GetArrayRandomDigits()
{
    Random random = new Random();
    int[,] array = new int[5, 5];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(-100, 100);
        }
    }
    return array;
}

static void ShowTwoDimensionalArray(int[,] array)
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
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}