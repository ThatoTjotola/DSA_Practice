using DSA_PRACTICE.ArraysAndStringManipulation;
using DSA_PRACTICE.HackerRank;

namespace DSA_PRACTICE;

public class Output
{
    public static void Main(String[] args)
    {
        /// TwoSum
        //int[] target = TwoSum.TwoSums(TwoSum.nums ,17);
        //Console.WriteLine($"Indices: [{target[0]}, {target[1]}]");

        /////KadansAlgorithm
        // int result = KadanesAlgorithm.maxSubArray(KadanesAlgorithm.Numbers);
        // Console.WriteLine($"Output{result}");

        //  FizzBuzz
        Console.WriteLine("Enter a number for FizzBuzz:");
        int n;

        // Check if user input is valid
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number:");
        }

        Console.WriteLine("\nFizzBuzz Output:");
        FizzBuzzV2.fizzBuzz2(n); // Call 
    }
}