
//. Пользователь вводит русский текст. Подсчитать количество слов, которые заканчиваются на гласную букву.



CountingWordsThatEndInAVowel();
Console.ReadLine();


static void CountingWordsThatEndInAVowel()
{
    char[] vowels = new char[] { 'а','и','е','ё','о','у','ы','э','ю','я'};
    string text = "Пользователь вводит русский текст. Подсчитать количество слов, которые заканчиваются на гласную букву";
    
    string[] allWords;
    List<string> wordsEndingInAVowel = new List<string>();

    allWords = text.Replace(".", "").Split(" ");

    foreach (var word in allWords)
    {
        for (int i = 0; i < vowels.Length; i++)
        {
            if (word.EndsWith(vowels[i]))
            {
                wordsEndingInAVowel.Add(word);
                break;
            }
        } 
    }
    Console.WriteLine("Все слова которые заканчиваются на гласную букву");
    Console.WriteLine();
    foreach (var item in wordsEndingInAVowel)
    {
        Console.Write(item + " ");
    }
}
