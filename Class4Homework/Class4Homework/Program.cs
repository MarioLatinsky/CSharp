



int sumNumbers(int firstNumber, int secondNumber)
{
    int result = firstNumber + secondNumber;
    return result;
}




int subtractNumbers(int firstNumber, int secondNumber)
{
    int result = firstNumber - secondNumber;
    return result;
}


int multiplyNumbers(int firstNumber, int secondNumber)
{
    int result = firstNumber * secondNumber;
    return result;
}


int divideNumbers(int firstNumber, int secondNumber)
{
     
    if(secondNumber == 0 || firstNumber == 0)
    {
        Console.WriteLine("Error, invalid input");
        
        return 0;
    }

    int result = firstNumber / secondNumber;
    
    return result;
}





Console.WriteLine("Please enter the first number: ");
int userInput = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter an operator you would want to use: ");
char operation = char.Parse(Console.ReadLine());

Console.WriteLine(" Please enter the second number: ");
int secondInput = int.Parse(Console.ReadLine());






switch (operation)
{
    case '+':

        int sumResult = sumNumbers(userInput, secondInput);
        Console.WriteLine($"{userInput} + {secondInput} = {sumResult}");
        break;

    case '-':
        int subtractResult = subtractNumbers(userInput, secondInput);
        Console.WriteLine($"{userInput} + {secondInput} = {subtractResult}");
        break;

    case '*':
        int multiplyResult = multiplyNumbers(userInput, secondInput);
        Console.WriteLine($"{userInput} + {secondInput} = {multiplyResult}");
        break;

    case '/':
        int divideResult = divideNumbers(userInput, secondInput);
        Console.WriteLine($"{userInput} + {secondInput} = {divideResult}");
        break;

    default:
        Console.WriteLine("invalid input");
        break;
}



