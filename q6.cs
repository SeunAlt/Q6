using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare an array alpha of 50 components of the type float
        float[] alpha = new float[50];

        // Initialize the array so that the first 25 components are equal to the square of the index variable
        for (int i = 0; i < 25; i++)
        {
            alpha[i] = i * i;
        }

        // Initialize the array so that the last 25 components are equal to three times the index variable
        for (int i = 25; i < 50; i++)
        {
            alpha[i] = i * 3;
        }

        // Output the array so that 10 elements per line are printed
        for (int i = 0; i < 50; i++)
        {
            // Print each element with a space
            Console.Write(alpha[i] + " ");
            // If the index is a multiple of 10, print a new line
            if ((i + 1) % 10 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}

