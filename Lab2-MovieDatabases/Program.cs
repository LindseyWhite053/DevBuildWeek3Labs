Console.WriteLine("Welcome to the Movie List Application!\n");

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
Console.WriteLine($"(1)Action (2)Comedy  (3)Drama (4)Fantasy (5)Horror (6)Romance (7)Sci-fi");

bool goAgain = true;
while (goAgain == true)
{
    int num = 0;

    //Ask the user which movies they would like to see display a line for any movie whose category matches the category entered by the user
    Console.Write("\nWhat category are you interested in?(enter the number selection):  ");
    bool valid = false;
    while (valid == false)
    {

        valid = int.TryParse(Console.ReadLine(), out num);

        if (num < 1 || num > 7)
            {
                valid = false;

            }

        if (valid == false)
        {
            Console.Write("Please enter a valid number selection:  " );
        }

    }


    switch (num)
    {
        case 1:
            foreach (Movie next in movieList)
            {
                if (next.category == "Action")
                {
                    Console.WriteLine(next);
                }
            }
            break;
        case 2:
            foreach (Movie next in movieList)
            {
                if (next.category == "Comedy")
                {
                    Console.WriteLine(next);
                }
            }
            break;
        case 3:
            foreach (Movie next in movieList)
            {
                if (next.category == "Drama")
                {
                    Console.WriteLine(next);
                }
            }
            break;
        case 4:
            foreach (Movie next in movieList)
            {
                if (next.category == "Fantasy")
                {
                    Console.WriteLine(next);
                }
            }
            break;
        case 5:
            foreach (Movie next in movieList)
            {
                if (next.category == "Horror")
                {
                    Console.WriteLine(next);
                }
            }
            break;
        case 6:
            foreach (Movie next in movieList)
            {
                if (next.category == "Romance")
                {
                    Console.WriteLine(next);
                }
            }
            break;
        case 7:
            foreach (Movie next in movieList)
            {
                if (next.category == "Sci-fi")
                {
                    Console.WriteLine(next);
                }
            }
            break;
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
        return $"{title} ({category})";
    }
}


//Extra Challenge: Expand the information in your Movie class—run time in minutes, year released, etc. Display the additional information when listing movies.
//Extra Hard Challenge: Display the movies for the selected category in alphabetical order.

