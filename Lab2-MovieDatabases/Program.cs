using Lab2_MovieDatabases;

Console.WriteLine("Welcome to the Movie List Application!\n");

//Construct the movie list
List<Movie> movieList = new List<Movie>();
movieList.Add(new Movie("Groundhog Day", "Comedy", 101, 1993));
movieList.Add(new Movie("Donnie Darko", "Sci-fi", 113, 2001));
movieList.Add(new Movie("Scott Pilgrim Vs. The World", "Action", 112, 2010));
movieList.Add(new Movie("Logan", "Action",137, 2017));
movieList.Add(new Movie("Titanic", "Romance", 195, 1997));
movieList.Add(new Movie("The Exorcist", "Horror", 122, 1973));
movieList.Add(new Movie("Pan's Labyrinth", "Fantasy", 119, 2006));
movieList.Add(new Movie("One Flew Over the Cuckoo's Nest", "Drama", 133, 1975));
movieList.Add(new Movie("Get Out", "Horror", 104, 2017));
movieList.Add(new Movie("Forest Gump", "Comedy", 142, 1994));

Console.WriteLine($"There are {movieList.Count} movies in this list.");
Console.WriteLine($"(1)Action (2)Comedy  (3)Drama (4)Fantasy (5)Horror (6)Romance (7)Sci-fi");

do
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
            Console.Write("Please enter a valid number selection:  ");
        }

    }


    switch (num)
    {
        case 1:
            Console.WriteLine("Action Movies:");
            foreach (Movie next in movieList)
            {
                
                if (next.category == "Action")
                {
                    Console.WriteLine(next);
                }
            }
            break;
        case 2:
            Console.WriteLine("Comedy Movies:");
            foreach (Movie next in movieList)
            {
                if (next.category == "Comedy")
                {
                    Console.WriteLine(next);
                }
            }
            break;
        case 3:
            Console.WriteLine("Drama Movies:");
            foreach (Movie next in movieList)
            {
                if (next.category == "Drama")
                {
                    Console.WriteLine(next);
                }
            }
            break;
        case 4:
            Console.WriteLine("Fantasy Movies:");
            foreach (Movie next in movieList)
            {
                if (next.category == "Fantasy")
                {
                    Console.WriteLine(next);
                }
            }
            break;
        case 5:
            Console.WriteLine("Horror Movies:");
            foreach (Movie next in movieList)
            {
                if (next.category == "Horror")
                {
                    Console.WriteLine(next);
                }
            }
            break;
        case 6:
            Console.WriteLine("Romance Movies:"); 
            foreach (Movie next in movieList)
            {
                if (next.category == "Romance")
                {
                    Console.WriteLine(next);
                }
            }
            break;
        case 7:
            Console.WriteLine("Sci-Fi Movies:"); 
            foreach (Movie next in movieList)
            {
                if (next.category == "Sci-fi")
                {
                    Console.WriteLine(next);
                }
            }
            break;
    }


} while (GoAgain());

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


//Extra Hard Challenge: Display the movies for the selected category in alphabetical order.

