
//Пользователь вводит строку. Проверить, является ли эта строка палиндромом.
//Палиндромом называется строка, которая одинаково читается слева направо и справа налево.



while (true)
{
    CheckingAStringForAPalindrome();
}


static void CheckingAStringForAPalindrome()
{
    Console.WriteLine("Введите слово, и мы проверим является ли оно палимдромом");
    string text = Console.ReadLine();
    char[] arrayTextReverse = text.ToCharArray();
    Array.Reverse(arrayTextReverse, 0, arrayTextReverse.Length);

    string textReverse = new string(arrayTextReverse);

    if (text.ToLower().Equals(textReverse.ToLower()))
        Console.WriteLine("Это палимдром");
    else
        Console.WriteLine("Это не палимдром");
}

