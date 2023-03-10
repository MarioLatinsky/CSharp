// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please enter the first number ");
int firstInput = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number");
int secondInput = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the operation you'd like to do");
char operation = Convert.ToChar(Console.ReadLine());




if(operation ==  '-')
{
double result = firstInput - secondInput;
    Console.WriteLine("The result is: " +result);
}else if(operation == '+')
{
    double result = firstInput + secondInput;
    Console.WriteLine("The result is: " + result);

}
else if(operation == '*')
{
    double result = firstInput * secondInput;
    Console.WriteLine("The result is: " + result);
}
else if(operation == '/')
{

    double result = firstInput / secondInput;
    Console.WriteLine("The result is: " + result);
}
else
{
    Console.WriteLine("You entered an invalid Symbol");
}








