string folderPath = @"C:\data";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));

//string[] heroes = { "Harry Potter", "Batman", "Doctor Who", "Princess Leia", "Sherlock Holmes" };
//string[] villains = { "Voldemort", "Daleks", "Darth Vader", "Joker", "Sauron" };

string[] weapon = { "magic wand", "screwdriver", "banana", "spell", "sword" };


string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

string villian = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon); 
Console.WriteLine($"Today {villian} with {villainWeapon} tries to take over the world!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}