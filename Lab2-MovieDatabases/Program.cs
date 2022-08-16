Console.WriteLine("Welcome to the Movie List Application!");

//Construct the movie list
List<Movie> movieList = new List<Movie>();
movieList.Add(new Movie("Groundhog Day", "Comedy"));
movieList.Add(new Movie("Donnie Darko", "Sci-fi"));
movieList.Add(new Movie("Scott Pilgrim Vs. The World", "Action"));
movieList.Add(new Movie("Logan", "Action"));
movieList.Add(new Movie("Titanic", "Romance"));
movieList.Add(new Movie("The Exorcist", "Horror"));
movieList.Add(new Movie("Pan's Labyrinth", "Fantasy"));
movieList.Add(new Movie("One Flew Over the Cuckoo's Nest", "Drama"));
movieList.Add(new Movie("Get Out", "Horror"));
movieList.Add(new Movie("Forest Gump", "Comedy"));


Console.WriteLine($"There are {movieList.Count} movies in this list.");

bool goAgain = true;
while (goAgain == true)
{
    //Ask the user which movies they would like to see display a line for any movie whose category matches the category entered by the user.
    Console.Write("What category are you interested in? ");
    string selectedCategory = Console.ReadLine();

    //Program gives explicit feedback if user enters invalid category
    Movie found = null;

    foreach (Movie next in movieList)
    {
        if (next.category.ToLower() == selectedCategory.ToLower())
        {
            Console.WriteLine(next);
            found = next;
        }
    }

    if (found == null)
    {
        Console.WriteLine($"Sorry, there are no movies in this list under the category {selectedCategory}");
    }

    goAgain = GoAgain();
}

static bool GoAgain()
{
    while (true)
    {
        Console.Write("\nWould you like to search another category? (y/n): ");

        string response = Console.ReadLine().ToLower();

        if (response == "y" || response == "yes")
        {
            return true;
        }
        else if (response == "n" || response == "no")
        {
            Console.WriteLine("Goodbye!");
            return false;
        }
        else
        {
            Console.WriteLine("Please enter yes or no");
        }
    }
}


class Movie
{
    public string title;
    public string category;

    public Movie(string _title, string _category)
    {
        title = _title;
        category = _category;
    }

    public override string ToString()
    {
        return $"Title: {title} ({category})";
    }
}


//Extra Challenge: Standardize the category codes by displaying a menu of categories and having the user select the category by number rather than entering the name.
//Extra Challenge: Expand the information in your Movie class—run time in minutes, year released, etc. Display the additional information when listing movies.
//Extra Hard Challenge: Display the movies for the selected category in alphabetical order.