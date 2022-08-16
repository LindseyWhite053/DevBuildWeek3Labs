Console.WriteLine("----------------------------");
Console.WriteLine("Welcome to the Circle Tester");
Console.WriteLine("----------------------------");

int circleCount = 0;
int rectangleCount = 0;
int sphereCount = 0;
double radius = 0;
double height = 0;
double width = 0;

//List<Circle> circles = new List<Circle>();
//List<Rectangle> rectangles = new List<Rectangle>();
//List<Sphere> sphere = new List<Sphere>();

bool goAgain = true;
while (goAgain)
{


    Console.WriteLine("Would you like to create a (1)Circle, (2)Rectangle, or (3)Sphere?");
    string selection = Console.ReadLine();
    
    bool isDouble = false;
    switch (selection)
    {
        case "1":
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
            break;

        case "2":
            while (!isDouble)
            {
                //prompt the user to enter a height; the user may enter a decimal number.
                Console.Write("Enter height: ");
                string input = Console.ReadLine();
                isDouble = Double.TryParse(input, out height);

                //Display an error if the user enters invalid data and asks the user again for a radius.
                if (!isDouble)
                {
                    Console.Write("Invalid entry. ");
                }
            }

            isDouble = false;
            while (!isDouble)
            {
                //prompt the user to enter a height; the user may enter a decimal number.
                Console.Write("Enter width: ");
                string input = Console.ReadLine();
                isDouble = Double.TryParse(input, out width);

                //Display an error if the user enters invalid data and asks the user again for a radius.
                if (!isDouble)
                {
                    Console.Write("Invalid entry. ");
                }
            }

            //Create a Circle object, and display the circumference and area.
            Rectangle rectangle = new Rectangle(height, width);
            Console.WriteLine(rectangle);


            //Keep track of how many rectangle you create. 
            rectangleCount++;
            break;

        case "3":
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
            Sphere Sphere = new Sphere(radius);
            Console.WriteLine(Sphere);


            //Keep track of how many circles you create. 
            sphereCount++;
            break;

    }

    //Ask if the user would like to do another.
    goAgain = GoAgain();

    //The application displays a “goodbye” message that also indicates the number of circles the user built when the user chooses not to continue.
    if (!goAgain)
    {
       if (circleCount == 1 && rectangleCount == 0 && sphereCount == 0)
        {
            Console.WriteLine($"You created 1 circle. Goodbye!");
        } else if (circleCount == 0 && rectangleCount == 1 && sphereCount == 0)
        {
            Console.WriteLine($"You created 1 rectangle. Goodbye!");
        }
        else if (circleCount == 0 && rectangleCount == 0 && sphereCount == 1)
        {
            Console.WriteLine($"You created 1 sphere. Goodbye!");
        }
        else
        {
            Console.WriteLine($"You created {circleCount} circles, {rectangleCount} rectangles, and {sphereCount} spheres. Goodbye!");
        }

    }
} 



static bool GoAgain()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.Write("\nWould you like to create another shape? (y/n): ");
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
        circumference = FindCircumference(_radius);
        area = FindArea(_radius);
    }

    //Method to calculate circumference
    public double FindCircumference(double _radius)
    {
        double circumerence = _radius * 2 * Math.PI;
        circumerence = Math.Round(circumerence, 2);
        return circumerence;
    }

    //Method to calculate Area
    public double FindArea(double _radius)
    {
        double area = _radius * _radius * Math.PI;
        area = Math.Round(area, 2);
        return area;
    }

    public override string ToString()
    {
        return $"Circumference: {circumference} \nArea: {area}";
    }

}

class Rectangle
{
    double height;
    double width;
    double perimeter;
    double area;

    public Rectangle(double _height, double _width)
    {
        height = _height;
        width = _width;
        perimeter = FindPerimeter();
        area = FindArea();
    }

    public double FindPerimeter()
    {
        perimeter = height * width * 2;
        return perimeter;
    }

    public double FindArea()
    {
        area = height * width;
        return area; 
    }

    public override string ToString()
    {
        return $"Perimeter: {perimeter} \nArea: {area}";
    }

}



class Sphere
{
    //Radius(double)
    public double radius;
    public double surfaceArea;
    public double volume;

    public Sphere(double _radius)
    {
        radius = _radius;
        surfaceArea = FindSurfaceArea(_radius);
        volume = FindVolume(_radius);
    }

    //Method to calculate circumference
    public double FindSurfaceArea(double _radius)
    {
        double surfaceArea = 4 * Math.PI * Math.Pow(_radius, 2); 
        surfaceArea = Math.Round(surfaceArea, 2);
        return surfaceArea;
    }

    //Method to calculate Area
    public double FindVolume(double _radius)
    {
        double volume = Math.PI * 4 / 3 * Math.Pow(_radius, 3);
        volume = Math.Round(volume, 2);
        return volume;
    }

    public override string ToString()
    {
        return $"Surface Area: {surfaceArea} \nVolume: {volume}";
    }

}


