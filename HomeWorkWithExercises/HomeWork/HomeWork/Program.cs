// Exercise 5


//int[] intArray = new int[5];
//int result = 0;

//Console.WriteLine("Please enter the first number");
//intArray[0] = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Please enter the second number");
//intArray[1] = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Please enter the third number");
//intArray[2] = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Please enter the fourth number");
//intArray[3] = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Please enter the fifth number");
//intArray[4] = Convert.ToInt32(Console.ReadLine());


//for(int i = 0; i < intArray.Length; i++)
//{

//  result += intArray[i];
//    Console.WriteLine(result);
//}


// Exercise 6


//string[] names = new string[1000];
//int counter = 0;


//while (true)
//{
//    Console.WriteLine("Please enter a name: ");
//    string name = Console.ReadLine();

//    names[counter] = name;
//    counter++;


//    Console.WriteLine("Do you want to enter another name? (Y/N)");
//    string answer = Console.ReadLine();
//    if(answer == "N" || answer == "n")
//    {
//        break; 
//    }

//}

//Console.WriteLine("The names you entered are: ");
//for (int i = 0; i < counter ; i++) {

//    Console.WriteLine(names[i]);
//}


// HOMEWORK 


//TASK 1

//Console.WriteLine("Please enter the first number: ");
//int firstNumber = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please enter the second number: ");
//int secondNumber = Convert.ToInt32(Console.ReadLine());



//int variable = firstNumber;
//firstNumber = secondNumber;
//secondNumber = variable;

//Console.WriteLine("After swapping: ");
//Console.WriteLine("First number = " +firstNumber);
//Console.WriteLine("Second number = " +secondNumber);




//TASK 2 

//int[] numbers = new int[6];
//int sumOfEvenNumbers = 0;
//////int integerCounter = 0; 

//Console.WriteLine("Enter the 6 numbers: ");
//for (int i = 0; i < numbers.Length; i++)
//{
//    ////numbers[integerCounter++] = numbers[i];
//    Console.WriteLine("Enter integer: " +(i+1));
//    numbers[i] = Convert.ToInt32(Console.ReadLine());
//    if (numbers[i] % 2 == 0)
//    {
//        sumOfEvenNumbers += numbers[i];


//    }

//}
//Console.WriteLine("The sum of all integers is: " + sumOfEvenNumbers);



//TASK 3 

//Console.WriteLine("Enter student group 1 or 2: ");

//string[] studentsG1 = { "John", "Nick", "Jack", "Rose", "Victoria" };
//string[] studentsG2 = { "Mario", "Slave", "Leo", "Krste", "Maja" };
//int response = Convert.ToInt32(Console.ReadLine());

//if (response == 1)
//{
//     Console.WriteLine("All the students from the group G1 are: ");

//    for (int i = 0; i < studentsG1.Length; i++)
//    {
//        Console.WriteLine(studentsG1[i]);
        
//    }

//}
//else if (response == 2)
//{
//        Console.WriteLine("All the students from the group G2 are: ");

//    for (int i = 0; i < studentsG2.Length; i++)
//    {

//        Console.WriteLine(studentsG2[i]);
//    }
//}
//else if (response != 1 || response != 2)
//{
//    Console.WriteLine("Please enter the number 1 or 2");
//}
