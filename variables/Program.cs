// program that calculate the area of a rectangle
int sideA;
int sideB;
int result;

Console.WriteLine("Calculate the area of a rectangle");
Console.WriteLine("Enter the value of side A");
sideA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the value of side B");
sideB = Convert.ToInt32(Console.ReadLine());
result = sideA * sideB;
Console.WriteLine("The area of the rectangle is: " + result + "cm2");
