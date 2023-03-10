// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("AverageNumber Calculator ");
Console.WriteLine("Please enter the first number");
int firstInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the second number");
int secondInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the third number");
int thirdInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the fourth number");
int fourthInput  = Convert.ToInt32(Console.ReadLine());

int result = (firstInput + secondInput + thirdInput + fourthInput) / 4;

Console.WriteLine(result);

                    