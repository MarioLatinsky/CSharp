
//Math Class

//double x = 3.99;
//double y = 5;
//double a = Math.Pow(x, 3);
//double b = Math.Sqrt(x);
//double c = Math.Abs(x);
//double d = Math.Round(x);
//double e = Math.Ceiling(x);
//double f = Math.Floor(x);
//double g = Math.Max(x, y);
//double h = Math.Min(x, y);

//Console.WriteLine(h);








//Random numbers

//Random random = new Random();


//int num1 = random.Next(1, 7);
//int num2 = random.Next(1, 7);
//int num3 = random.Next(1, 7);

//Console.WriteLine(num1);
//Console.WriteLine(num2);
//Console.WriteLine(num3);



//double num = random.NextDouble();




Console.WriteLine("Enter side A:");

double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter side B:");

double b = Convert.ToDouble(Console.ReadLine());

double c = Math.Sqrt((a * a) + (b * b));
Console.WriteLine("The hypotenuse is: " + c);



Console.ReadKey();