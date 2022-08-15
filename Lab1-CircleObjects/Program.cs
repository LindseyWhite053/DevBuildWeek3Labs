Console.WriteLine("----------------------------");
Console.WriteLine("Welcome to the Circle Tester");
Console.WriteLine("----------------------------");

int circleCount = 0;
double radius = 0;

bool goAgain = true;
while (goAgain)
{
    bool isDouble = false;
    while (!isDouble)
    {
        //prompt the user to enter a radius; the user may enter a decimal number.
        Console.Write("Enter radius: ");
        string input = Console.ReadLine();
        isDouble = Double.TryParse(input, out radius);

        //Display an error if the user enters invalid data and asks the user again for a radius.
        if (!isDouble)
        {
            Console.Write("Invalid entry. ");
        }
    }

    //Create a Circle object, and display the circumference and area.
    Circle Circle = new Circle(radius);
    Console.WriteLine(Circle);


    //Keep track of how many circles you create. 
    circleCount++;


    //The application asks the user whether they want to do another.
    goAgain = GoAgain();

    //The application displays a “goodbye” message that also indicates the number of circles the user built when the user chooses not to continue.
    if (!goAgain)
    {
       if (circleCount == 1)
        {
            Console.WriteLine($"You created 1 circle. Goodbye!");
        } else
        {
            Console.WriteLine($"You created {circleCount} circles. Goodbye!");
        }

    }
} 



static bool GoAgain()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.Write("\nWould you like to create another circle? (y/n): ");
        // Ask the user for their input
        string response = Console.ReadLine();
        response = response.ToLower();
        // Check if they typed "y". If so, return true.
        // Otherwise return false.   YES   yes
        if (response == "y" || response == "yes")
        {
            return true;
        }
        else if (response == "n" || response == "no")
        {          
            return false;
        }
        else
        {
            Console.WriteLine("Please enter yes or no");

        }
    }
}


class Circle
{
    //Radius(double)
    public double radius;
    public double circumference;
    public double area;

    public Circle(double _radius)
    {
        radius = _radius;
        circumference = CalculateCircumference(_radius);
        area = CalculateArea(_radius);
    }

    //Method to calculate circumference
    public double CalculateCircumference(double _radius)
    {
        double calcCircumerence = _radius * 2 * Math.PI;
        return calcCircumerence;
    }

    //Method to calculate Area
    public double CalculateArea(double _radius)
    {
        double calcArea = _radius * _radius * Math.PI;
        return calcArea;
    }

    public override string ToString()
    {
        return $"Circumference: {circumference} \nArea: {area}";
    }

}



//Extra Challenge: Practice formatting so the numbers print with two decimal places.
//Extra Challenge: Make a class called Rectangle that does all of the above, like Circle, except for a rectangle. There will be two member variables: Length and Width.
//Extra Challenge: Make a class called Sphere. This will include only a radius for a member variable and will instead calculate surface area and volume.



