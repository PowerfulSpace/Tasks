
//Подсчитать количество слов во введенном предложении. Решить двумя способами.




CountingWordsInTheEnteredSentence();
Console.ReadLine();


static void CountingWordsInTheEnteredSentence()
{
    string text = "Подсчитать количество слов во введенном предложении. Решить двумя способами";
    //string text = Console.ReadLine();
    string[] words;

    words = text.Replace(".", "").Split(" ");

    Console.WriteLine($"Количество слов в ведённом предлежении: {words.Length}");
}









