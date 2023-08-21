
//Напишите программу «Дешифратор», которая бы в текстовом файле
//могла бы заменить все предлоги на слово «Hello!».  



using System.Text.RegularExpressions;

string patch = @"D:\Testing\Test.txt";
using StreamReader reader = new StreamReader(patch);
string text = reader.ReadToEnd();
string[] prepositions = new string[] { "в", "без", "до", "для", "за", "через", "над", "по", "из", "у", "около", "под", "о", "про", "на", "к", "между", "перед", "при", "с", "между" };

string pattert = @"\b(в|между|без|до|для|за|через|над|по|из|у|около|под|о|про|на|к|между|перед|при|с|между)\b";
string pattertReplace = @"«Hello!»";
Regex regex = new Regex(pattert);

var result = regex.Replace(text, pattertReplace);

Console.WriteLine(result);


Console.ReadLine();