
//Числовые значения символов нижнего регистра в коде ASCII
//отличаются от значений символов верхнего регистра на величину 32.
//Используя эту  информацию, написать программу,
//которая считывает с клавиатуры и конвертирует все символы нижнего регистра
//в символы верхнего регистра и наоборот.


LetterCase();
Console.ReadLine();

static void LetterCase()
{
    string myChars = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

    List<char> MyCase = new List<char>();


    char key;
    int keyDigit;

    for (int i = 0; i < myChars.Length; i++)
    {
        keyDigit = myChars[i];
        if (keyDigit >= 1040 && keyDigit <= 1071)
        {
            keyDigit += 32;
            key = (char)keyDigit;
            MyCase.Add(key);
        }
        else if(keyDigit >= 1072 && keyDigit <= 1103)
        {
            keyDigit -= 32;
            key = (char)keyDigit;
            MyCase.Add(key);
        }
    }
    Show(myChars.ToArray());
    Console.WriteLine();
    Show(MyCase.ToArray());
}


static void Show(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}









