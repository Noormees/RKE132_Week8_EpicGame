

string path = @"G:\Мой диск\TKTK\3 aasta\Programmeerimise alused\data\";
string fileName = "chuck.txt";
//string[] lines = File.ReadAllLines(Path.Combine(path, fileName));
//Console.WriteLine(lines.Length);

string[] lines = File.ReadAllLines(path + fileName);

foreach (string hero in lines)
{
    Console.WriteLine(hero);
}