//Variable names should be short yet meaningful.
// The choice of a variable name should be memoriable.
// Designed to indicate to the casual observer the intent of its use. 

// The integer variable stores he first number
// Ask the ser to input the first number
Console.WriteLine("Type in the first number, and then press Enter key");
int firstNumber = Convert.ToInt32(Console.ReadLine());

// Ask the user to type the second number.
Console.WriteLine("Type the second number, and then press Enter");
int secondNumber = Convert.ToInt32(Console.ReadLine());

//Perfom the calculation
int result = firstNumber + secondNumber;

//Output the answer to the console
Console.WriteLine("Adding {0} and {1} give the answer {2}", firstNumber, secondNumber, result);



