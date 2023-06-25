
//Числовые значения символов нижнего регистра в коде ASCII
//отличаются от значений символов верхнего регистра на величину 32.
//Используя эту  информацию, написать программу,
//которая считывает с клавиатуры и конвертирует все символы нижнего регистра
//в символы верхнего регистра и наоборот.


LetterCase();
Console.ReadLine();

static void LetterCase()
{
    string chars = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

    List<char> lowerСase = new List<char>();
    List<char> upperСase = new List<char>();

    char key;
    int keyDigit;

    for (int i = 0; i < chars.Length; i++)
    {
        lowerСase.Add(chars[i]);

        keyDigit = chars[i];
        keyDigit -= 32;
        key = (char)keyDigit;
        upperСase.Add(key);
    }

    Console.WriteLine("Нижний регистр");
    Show(lowerСase.ToArray());
    Console.WriteLine();
    Console.WriteLine("Верхний регистр");
    Show(upperСase.ToArray());
}


static void Show(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}









