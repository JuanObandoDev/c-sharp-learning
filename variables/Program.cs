// program that calculate the area of a rectangle
int sideA; // explicit declaration of the type
int sideB;
// with var we can declare a variable without specifying the type
// and the compiler will infer the type based on the value assigned
var result = 0.0; // implicit declaration of the type

Console.WriteLine("Calculate the area of a rectangle");
Console.WriteLine("Enter the value of side A");
sideA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the value of side B");
sideB = Convert.ToInt32(Console.ReadLine());
result = sideA * sideB;
Console.WriteLine("The area of the rectangle is: " + result + "cm2");
