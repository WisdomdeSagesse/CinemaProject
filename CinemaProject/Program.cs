Console.Title = "Ntu Cinema";

string[] movieTitles = { "Black Adam", "Black Panther 2: Wakanda Forever", "Not Another Teen Movie", "Toy Story 5", "Batman", "Justice League(Synderverse)", "High School Musical: The Remake" };
int[] ageRating = { 18, 18, 15, 0, 18, 18, 18, 13 };

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Welcome to NTU Cinema");
Console.WriteLine("These are the films currently showing: ");

for (int i = 0; i < movieTitles.Length; i++)
{
    Console.WriteLine($"{i + 1} - {movieTitles[i]}");
}
Console.Write("Please enter your age: ");
int userAge = Convert.ToInt32(Console.ReadLine());
Console.Write("Select the number of the movie you want to see? ");
int movieNum = (Convert.ToInt32(Console.ReadLine())) - 1; // subtracting 1 from user input to account for zero indexing

while (true)
{
    if (movieNum < 0 || movieNum > movieTitles.Length)
    {
        Console.WriteLine("You have not selected a movie. Please select from the list of available options:");
        for (int i = 0; i < movieTitles.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {movieTitles[i]}");
        }
        movieNum = Convert.ToInt32(Console.ReadLine()) - 1;
    }
    if (userAge < ageRating[movieNum])
    {
        Console.WriteLine("You have selected an age inappropriate movie. Please select an appropriate movie from the list of available options:");
        for (int i = 0; i < movieTitles.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {movieTitles[i]}");
        }
        movieNum = Convert.ToInt32(Console.ReadLine()) - 1;
    }
    break;
}
Console.WriteLine($"You have selected: {movieTitles[movieNum]}");
Console.Write("Would you like a pop corn? ");
string userResponse = Console.ReadLine().ToLower();

if (userResponse == "yes" || userResponse == "y")
    Console.WriteLine("Here is your popcorn, enjoy the movie");
else
    Console.WriteLine("Enjoy the movie");



