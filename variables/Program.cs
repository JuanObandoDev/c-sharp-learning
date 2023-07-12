// program that calculate the area of a rectangle
int sideA; // explicit declaration of the type
int sideB;
// with var we can declare a variable without specifying the type
// and the compiler will infer the type based on the value assigned
var resultRectangle = 0.0; // implicit declaration of the type

Console.WriteLine("Calculate the area of a rectangle");
Console.WriteLine("Enter the value of side A");
sideA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the value of side B");
sideB = Convert.ToInt32(Console.ReadLine());
resultRectangle = sideA * sideB;
Console.WriteLine("The area of the rectangle is: " + resultRectangle + "cm2");

// calculating the area of a circle
var resultCircle = 0d; // with d or f we can specify the type of the variable between double or float
const double Pi = 3.14159265359; // with const we can declare a constant variable
Console.WriteLine("Calculate the area of a circle");
Console.WriteLine("Enter the value of the radius");
double radius = Convert.ToDouble(Console.ReadLine());
resultCircle = Pi * Math.Pow(radius, 2);
Console.WriteLine("The area of the circle is: " + resultCircle + "cm2");

