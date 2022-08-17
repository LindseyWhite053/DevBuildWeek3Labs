Console.WriteLine("----------------------------");
Console.WriteLine("Welcome to the Circle Tester");
Console.WriteLine("----------------------------");

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
            Circle circ = new Circle(radius);
            Console.WriteLine(circ);
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
            Rectangle rect = new Rectangle(height, width);
            Console.WriteLine(rect);
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
            Sphere spher = new Sphere(radius);
            Console.WriteLine(spher);
            break;

    }

    //Ask if the user would like to do another.
    goAgain = GoAgain();

    //The application displays a “goodbye” message that also indicates the number of circles the user built when the user chooses not to continue.
    if (!goAgain)
    {
       if (Circle.count == 1 && Rectangle.count == 0 && Sphere.count == 0)
        {
            Console.WriteLine($"You created 1 circle. Goodbye!");
        } else if (Circle.count == 0 && Rectangle.count == 1 && Sphere.count == 0)
        {
            Console.WriteLine($"You created 1 rectangle. Goodbye!");
        }
        else if (Circle.count == 0 && Rectangle.count == 0 && Sphere.count == 1)
        {
            Console.WriteLine($"You created 1 sphere. Goodbye!");
        }
        else
        {
            Console.WriteLine($"You created {Circle.count} circle(s), {Rectangle.count} rectangle(s), and {Sphere.count} sphere(s). Goodbye!");
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
    public static int count;
    
    //Radius(double)
    public double radius;


    public Circle(double _radius)
    {
        count++;
        
        radius = _radius;
    }

    //Method to calculate circumference
    public double FindCircumference()
    {
        double circumerence = radius * 2 * Math.PI;
        circumerence = Math.Round(circumerence, 2);
        return circumerence;
    }

    //Method to calculate Area
    public double FindArea()
    {
        double area = radius * radius * Math.PI;
        area = Math.Round(area, 2);
        return area;
    }

    public override string ToString()
    {
        return $"Circumference: {FindCircumference()}  \nArea: {FindArea()}";
    }
}

class Rectangle
{
    public static int count;
    
    public double height;
    public double width;

    public Rectangle(double _height, double _width)
    {
        count++;
        
        height = _height;
        width = _width;
    }

    public double FindPerimeter()
    {
        double perimeter = height * width * 2;
        return perimeter;
    }

    public double FindArea()
    {
        double area = height * width;
        return area; 
    }

    public override string ToString()
    {
        return $"Perimeter: {FindPerimeter()} \nArea: {FindArea()}";
    }

}



class Sphere
{
    public static int count; 

    public double radius;

    public Sphere(double _radius)
    {
        count++;
        
        radius = _radius;
    }

    public double FindSurfaceArea()
    {
        double surfaceArea = 4 * Math.PI * Math.Pow(radius, 2); 
        surfaceArea = Math.Round(surfaceArea, 2);
        return surfaceArea;
    }

    public double FindVolume()
    {
        double volume = Math.PI * 4 / 3 * Math.Pow(radius, 3);
        volume = Math.Round(volume, 2);
        return volume;
    }

    public override string ToString()
    {
        return $"Surface Area: {FindSurfaceArea()} \nVolume: {FindVolume()}";
    }

}


