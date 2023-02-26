
//andmed
//string[] heroes = {"Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo", "Superman", "Spiderman"};
//string[] villains = {"Voldemort", "Darth Vader", "Sauron", "Joker", "Dracula" };


string folderPath = @"G:\Мой диск\TKTK\3 aasta\Programmeerimise alused\data\";
string heroFail = "heroes.txt";
string villainsFail = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFail));//voib kirjutada "folderPath+heroFail"
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainsFail));


string[] weapon = { "Magic Wand", "Banana", "Wooden Sword", "Siper Rower", "Knife",}; 


string hero = GetRandomValueFromArray(heroes); // heroes - massiv; [] - funktsioon
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");


string villain = GetRandomValueFromArray(villains);
string vallainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {vallainWeapon} tries to take over the World!");


static string GetRandomValueFromArray(string[] someArray) // kutsume funk GetRandomValueFromArray; someArray - suvaline vaartus, ehk massiv string tyypi
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;   
}