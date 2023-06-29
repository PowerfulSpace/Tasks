
//Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка.
//Программа должна сосчитать количество введенных пользователем пробелов. 





ReadingCharacters();
Console.ReadLine();

static void ReadingCharacters()
{

	char key = char.MinValue;
	int countSpace = 0;

	do
	{
		key = Console.ReadKey().KeyChar;

		if (key == ' ')
            countSpace++;


    } while (key != '.');

	Console.WriteLine();
	Console.WriteLine($"Количество пробелов было введено: {countSpace}");

}






