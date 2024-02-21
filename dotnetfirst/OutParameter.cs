//in ref  , we need to initialize a variable before passing it as a paramter to the function
//in out  , we can directly pass the variable as parameter without initialize




// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int a = 10;
//         int b = 5;
//         int sum = 0; // Initialize variables for ref parameters
//         int difference = 0;

// Call the method to get sum and difference
//         CalculateSumAndDifference(a, b, ref sum, ref difference);

// Output the results
//         Console.WriteLine("Sum: " + sum); // Output: Sum: 15
//         Console.WriteLine("Difference: " + difference); // Output: Difference: 5
//     }

//     static void CalculateSumAndDifference(int x, int y, ref int sum, ref int difference)
//     {
//         sum = x + y; // Calculate sum
//         difference = x - y; // Calculate difference
//     }
// }


//above code is written using ref , which will cause errros.....here's why-->>>

//1-->>Initialization Requirement:

// When using ref, the variables must be initialized before they are passed to the method. In this case, we have to initialize sum and difference before calling CalculateSumAndDifference.




//2--> Expectation of Existing Values:

// When using ref, the method may assume that the variables passed to it already have some meaningful values. In the context of this example, if sum and difference were meaningful values before calling CalculateSumAndDifference, the method would overwrite them without considering their original values.
// Now, the primary problem with using ref in this context is that it doesn't clearly communicate the intent of the method. The CalculateSumAndDifference method isn't expected to modify existing values of sum and difference, but rather to calculate them from scratch.

// By using out parameters instead of ref, you explicitly signal that the method is responsible for initializing and providing the values of sum and difference, which can help improve code readability and maintainability. Additionally, using out parameters ensures that any existing values of sum and difference are ignored, preventing accidental overwrites.








// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int a = 10;
//         int b = 5;
//         int sum;
//         int difference;

// Call the method to get sum and difference
//         CalculateSumAndDifference(a, b, out sum, out difference);

// Output the results
//         Console.WriteLine("Sum: " + sum); // Output: Sum: 15
//         Console.WriteLine("Difference: " + difference); // Output: Difference: 5
//     }

//     static void CalculateSumAndDifference(int x, int y, out int sum, out int difference)
//     {
//         sum = x + y; // Calculate sum
//         difference = x - y; // Calculate difference
//     }
// }


//using out parameter a function can return multiple values
//here's how-->>


// In the provided code, the function CalculateSumAndDifference is returning multiple values using out parameters. Specifically, the function signature looks like this:

// static void CalculateSumAndDifference(int x, int y, out int sum, out int difference)


// Here, the out keyword is used to signal that the sum and difference variables are output parameters, meaning they will be assigned values by the function and returned to the caller. This happens when the function executes these lines:

// sum = x + y; // Assign the sum of x and y to the out parameter 'sum'
//difference = x - y; // Assign the difference of x and y to the out parameter 'difference'



// So, the function is effectively returning multiple values (sum and difference) to the caller by using out parameters. This approach allows the function to calculate both the sum and the difference of x and y and return them simultaneously.

// If we were to attempt to achieve the same behavior using ref parameters, it would be more cumbersome and less clear, as it would require initializing the sum and difference variables before calling the function, and the function would simply modify their values without necessarily indicating that it is returning multiple values. Therefore, using out parameters is more appropriate and clearer in this context.





















//example -2  explaining how using out the function is returning multiple values but using ref it is not
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int number = 5;
//         int square;
//         int cube;

// Call the method to calculate square and cube
//         CalculateSquareAndCube(number, out square, out cube);

// Output the results
//         Console.WriteLine("Square: " + square); // Output: Square: 25
//         Console.WriteLine("Cube: " + cube);     // Output: Cube: 125
//     }

//     static void CalculateSquareAndCube(int num, out int square, out int cube)
//     {
//         square = num * num;  // Return square of the number
//         cube = num * num * num; // Return cube of the number
// Function is returning multiple values here using out parameters , because we do not initialize the values when we are using out
//     }
// }



//using ref
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int number = 5;
//         int square = 0; // Initialize square variable
//         int cube = 0;   // Initialize cube variable

// Call the method to calculate square and cube
//         CalculateSquareAndCube(number, ref square, ref cube);

// Output the results
//         Console.WriteLine("Square: " + square); // Output: Square: 25
//         Console.WriteLine("Cube: " + cube);     // Output: Cube: 125
//     }

//     static void CalculateSquareAndCube(int num, ref int square, ref int cube)
//     {
//         square = num * num;  // Modify square of the number
//         cube = num * num * num; // Modify cube of the number
// It appears that the function is returning multiple values here, but it's actually modifying existing variables using ref parameters
//     }
// }
