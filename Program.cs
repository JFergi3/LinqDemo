using System.Text.Json;

// deserialize mario json from file into List<DonkeyKong>
List<Character> dks = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("dk.json"))!;
// deserialize mario json from file into List<Mario>
List<Character> marios = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("mario.json"))!;
// combine all characters into 1 list
List<Character> characters = [];
characters.AddRange(dks);
characters.AddRange(marios);

// display all characters
// foreach(Character character in characters)
// {
//   Console.WriteLine(character.Display());
// }
Console.Clear();

// display first character
// Console.WriteLine(characters.First().Display());

// display the first 5 characters
// foreach(Character character in characters.Take(5))
// {
//   Console.WriteLine(character.Display());
// }

// display every character except the first 5
// foreach(Character character in characters.Skip(5))
// {
//   Console.WriteLine(character.Display());
// }

// display characters 6-10
// foreach(Character character in characters.Skip(5).Take(5))
// {
//   Console.WriteLine(character.Display());
// }

// display last character
// Console.WriteLine(characters.Last().Display());

// first year character created
// Console.WriteLine(characters.Min(c => c.YearCreated));

// oldest character
// Console.WriteLine(characters.First(c => c.YearCreated == characters.Min(c => c.YearCreated)).Display());

// are there any characters created in 1995?
// bool Character1995 = characters.Any(c => c.YearCreated == 1995);
// Console.WriteLine($"Are there characters created in 1995: {Character1995}");
// how many characters were created in 1995
// Console.WriteLine($"How many? {characters.Count(c => c.YearCreated == 1995)}");
// which characters were created in 1995
// foreach(CharacterDTO characterDTO in characters.Where(c => c.YearCreated == 1995).Select(c => new CharacterDTO{ Id = c.Id, Name = c.Name, Series = c.Series }).OrderBy(c => c.Name))
// {
//   Console.WriteLine(characterDTO.Display());
// }

// how many characters in total (all series)?
// int CharacterCount = characters.Count();
// Console.WriteLine($"There are {CharacterCount} characters in all series");
// how many characters appear in the Mario series?
// int MarioCount = characters.Where(c => c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {MarioCount} characters in the Mario series");
// how many characters appear in the Donkey Kong series?
// int DkCount = characters.Where(c => c.Series.Contains("Donkey Kong")).Count();
// Console.WriteLine($"There are {DkCount} characters in the Donkey Kong series");
// how many characters appear in the Mario & Donkey Kong series?
// int DkMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {DkMarioCount} characters that appear in Mario and Donkey Kong series");
// which characters (name only) appear in Mario and Donkey Kong?
// foreach(String? name in characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Select(c => c.Name))
// {
//  Console.WriteLine($"\t{name}");
// }
// how many characters appear in Donkey Kong and not in Mario?
// int DkNotMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && !c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {DkNotMarioCount} characters that appear in Donkey Kong and Not in Mario series");

// which character(s) has/have the most alias's?
// foreach(var obj in characters.Where(c => c.Alias.Count() == characters.Max(c => c.Alias.Count())).Select(c => new {c.Name, c.Alias})){
//   Console.WriteLine($"{obj.Name} has {obj.Alias.Count()} alias(s):\n\t{String.Join(", ", obj.Alias)}");
// }

// how many letters make up the longest character name(s)
// int LengthOfName = characters.Max(c => c.Name!.Length);
// Console.WriteLine($"There are {characters.Max(c => c.Name!.Length)} letters in the longest character's name");
// which characters have the longest name?
// foreach(string? name in characters.Where(c => c.Name!.Length == LengthOfName).Select(c => c.Name))
// {
//   Console.WriteLine($"\t{name}");
// }

// all characters grouped by year created
// var CharactersByYearCreated = characters.GroupBy(c => c.YearCreated);
// foreach(var characterByYearCreated in CharactersByYearCreated)
// {
//   Console.WriteLine(characterByYearCreated.Key);
//   foreach(var character in characterByYearCreated) {
//     Console.WriteLine($"\t{character.Name}");
//   }
// }

// ----------------------------Assignment--------------------------------------------

// Console.WriteLine($"[1.19a] {characters.Count(c => c.YearCreated == 1981)}"); // 3

// foreach (var character in characters.Where(c => c.YearCreated == 1981).Select(c => new { c.Name, c.Series }))
// {
//    Console.WriteLine($"[1.19b] {character.Name} - {character.Series}");
// } // Donkey Kong, Pauline, Mario

// Console.WriteLine($"[1.19c] {characters.Count(c => c.YearCreated == 1981 && c.Series.Contains("Mario"))}"); // 2

// foreach (string? name in characters
//     .Where(c => c.YearCreated == 1981 && c.Series.Contains("Mario"))
//     .Select(c => c.Name))
// {
//     Console.WriteLine($"[1.19d] {name}");
// } // Donkey Kong, Mario

// Console.WriteLine($"[1.19e] {characters.Count(c => c.YearCreated == 1981 && c.Series.Contains("Donkey Kong"))}"); // 3

// foreach (string? name in characters
//     .Where(c => c.YearCreated == 1981 && c.Series.Contains("Donkey Kong"))
//     .Select(c => c.Name))
// {
//     Console.WriteLine($"[1.19f] {name}");
// }   // Donkey kong, Pauline, Mario

//--------------------------1.20

// Console.WriteLine($"[1.20a] {characters.Count(c => c.FirstAppearance == "Donkey Kong 64")}"); // 9 

// foreach (string? name in characters .Where(c => c.FirstAppearance == "Donkey Kong 64").Select(c => c.Name))
// {
//     Console.WriteLine($"[1.20b] {name}");
// } // Tiny Kong, Chunky Kong, Manky Kong, Lanky Kong, Banana Fairy Queen, K. Lumsy, Snide, Scoff, Mad Jack 

//--------------------------1.21

// Console.WriteLine($"[1.21a] {characters.Any(c => c.Alias.Count == 0 || c.Alias == null)} "); // True

// Console.WriteLine($"[1.21b] {characters.Count(c => c.Alias.Count == 0)}"); // 37

// foreach (var character in characters .Where(c => c.Alias.Count == 0) .Select(c => new { c.Name, c.Alias, c.Series }))
// {
//     Console.WriteLine($"[1.21c] {character.Name} - {String.Join(", ", character.Alias)} - {character.Series}");
// }

// Console.WriteLine($"[1.21d] {characters.Any(c => c.Alias.Count == 0 && c.Series.Contains("Mario"))}"); // True

// Console.WriteLine($"[1.21e] {characters.Count(c => c.Alias.Count == 0 && c.Series.Contains("Mario"))}"); // 5

// foreach (var character in characters .Where(c => c.Alias.Count == 0 && c.Series.Contains("Mario")) .Select(c => new {c.Name, c.Alias }))
// {
//     Console.WriteLine($"[1.21f] {character.Name} - {String.Join(", ", character.Alias)}");
// } // Diddy Kong, Toad, Wario, Waluigi, Rosalina

// Console.WriteLine($"[1.21g] {characters.Any(c => c.Alias.Count == 0 && c.Series.Contains("Donkey Kong"))}"); // True

// Console.WriteLine($"[1.21h] {characters.Count(c => c.Alias.Count == 0 && c.Series.Contains("Donkey Kong"))}"); // 33

// foreach (var character in characters .Where(c => c.Alias.Count == 0 && c.Series.Contains("Donkey Kong")) .Select(c => new {c.Name, c.Alias }))
// {
//     Console.WriteLine($"[1.21i] {character.Name} - {String.Join(", ", character.Alias)}");
// }

// -----------------------1.22

// Console.WriteLine($"[1.22a] {characters.Any(c => c.Alias.Any(a => a == "Snowmad King"))}"); // True

// foreach (var character in characters .Where(c => c.Alias.Any(a => a == "Snowmad King")).Select(c => new {c.Name, c.Alias }))
// {
//     Console.WriteLine($"[1.22b] {character.Name} - {String.Join(", ", character.Alias)}"); // Lord Fredrik - Snowmad King
// }

// Console.WriteLine($"[1.23a] {characters.Any(c => c.Alias.Any(a => a == "Winter Kong"))}"); // False

foreach (var character in characters .Where(c => c.Alias.Any(a => a == "Winter Kong")).Select(c => new {c.Name, c.Alias }))
{
    Console.WriteLine($"[1.23b] {character.Name} - {String.Join(", ", character.Alias)}"); 
}
