using System.Text;


//Дано целое число в диапазоне 100–999. Вывести строку-описание данного числа,
//например: 256 — «двести пятьдесят шесть», 814 — «восемьсот четырнадцать».


while (true)
{
    DisplayANumberInARange();
}


static void DisplayANumberInARange()
{
    StringBuilder line = new StringBuilder();
    var digits = IsDigit();

    int digit = digits.Item1;
    string stringDigit = digits.Item2;


    if (digit > 0 && digit < 1000)
    {
        if (digit >= 100)
        {
            line.Append(Enum.GetValues(typeof(HundredthsEnum)).GetValue((int)Char.GetNumericValue(stringDigit[0])) + " ");

            if (digit >= 100 && (int)Enum.GetValues(typeof(DecimalEnum2)).GetValue((int)Char.GetNumericValue(stringDigit[2])) == 0 || (int)Enum.GetValues(typeof(DecimalEnum2)).GetValue((int)Char.GetNumericValue(stringDigit[1])) == 0)
            {
                if (digit >= 10 && (int)Enum.GetValues(typeof(DecimalEnum2)).GetValue((int)Char.GetNumericValue(stringDigit[2])) == 0 && (int)Enum.GetValues(typeof(DecimalEnum2)).GetValue((int)Char.GetNumericValue(stringDigit[1])) == 0)
                {                  
                }
                else if (digit >= 10 && (int)Enum.GetValues(typeof(DecimalEnum2)).GetValue((int)Char.GetNumericValue(stringDigit[2])) == 0)
                {
                    line.Append(Enum.GetValues(typeof(DecimalEnum2)).GetValue((int)Char.GetNumericValue(stringDigit[1])) + " ");
                }
                else
                {
                    line.Append(Enum.GetValues(typeof(DigitEnum)).GetValue((int)Char.GetNumericValue(stringDigit[2])) + " ");
                }
            }
            else
            {
                if (digit < 20)
                {
                    if (digit < 10)
                    {
                        line.Append(Enum.GetValues(typeof(DigitEnum)).GetValue((int)Char.GetNumericValue(stringDigit[2])) + " ");
                    }
                    else
                    {
                        line.Append(Enum.GetValues(typeof(DecimalEnum1)).GetValue((int)Char.GetNumericValue(stringDigit[1])) + " ");
                    }
                }
                else
                {
                    line.Append(Enum.GetValues(typeof(DecimalEnum2)).GetValue((int)Char.GetNumericValue(stringDigit[1])) + " ");
                    line.Append(Enum.GetValues(typeof(DigitEnum)).GetValue((int)Char.GetNumericValue(stringDigit[2])) + " ");
                }
            }
        }
        if (digit < 100)
        {
            if (digit >= 10 && (int)Enum.GetValues(typeof(DecimalEnum2)).GetValue((int)Char.GetNumericValue(stringDigit[1])) == 0)
            {
                line.Append(Enum.GetValues(typeof(DecimalEnum2)).GetValue((int)Char.GetNumericValue(stringDigit[0])) + " ");
            }
            else
            {
                if (digit < 20)
                {
                    if (digit < 10)
                    {
                        line.Append(Enum.GetValues(typeof(DigitEnum)).GetValue((int)Char.GetNumericValue(stringDigit[0])) + " ");
                    }
                    else
                    {
                        line.Append(Enum.GetValues(typeof(DecimalEnum1)).GetValue((int)Char.GetNumericValue(stringDigit[1])) + " ");
                    }
                }
                else
                {
                    line.Append(Enum.GetValues(typeof(DecimalEnum2)).GetValue((int)Char.GetNumericValue(stringDigit[0])) + " ");
                    line.Append(Enum.GetValues(typeof(DigitEnum)).GetValue((int)Char.GetNumericValue(stringDigit[1])) + " ");
                }
            }
           
        }
        
    }
    else
        Console.WriteLine($"Ваше число {digit} Не попадает в диапазон от 0 до 1000");

    Console.WriteLine(line.ToString());
}

static (int,string) IsDigit()
{
    int digit;
    string stringDigit = string.Empty;
    bool isDigit = false;
    do
    {
        stringDigit = Console.ReadLine();
        isDigit = int.TryParse(stringDigit, out digit);
    } while (!isDigit);
    return (digit,stringDigit);
}


enum DigitEnum
{
    ноль = 0,
    один = 1,
    два = 2,
    три = 3,
    четыре = 4,
    пять = 5,
    шесть = 6,
    семь = 7,
    восемь = 8,
    девять = 9
}

enum DecimalEnum1
{
    ноль = 0,
    одиннадцать = 1,
    двенадцать = 2,
    тринадцать = 3,
    четырнадцать = 4,
    пятнадцать = 5,
    шестнадцать = 6,
    семнадцать = 7,
    восемнадцать = 8,
    девятнадцать = 9
}
enum DecimalEnum2
{
    ноль = 0,
    десять = 1,
    двадцать = 2,
    тридцать = 3,
    сорок = 4,
    пятьдесят = 5,
    шестьдесят = 6,
    семьдесят = 7,
    восемьдесят = 8,
    девяносто = 9
}

enum HundredthsEnum
{
    ноль = 0,
    сто = 1,
    двесте = 2,
    триста = 3,
    четыреста = 4,
    пятьсот = 5,
    шестьсот = 6,
    семьсот = 7,
    восемьсот = 8,
    девятьсот = 9
}