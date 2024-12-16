using DSA_PRACTICE.ArraysAndStringManipulation;

namespace DSA_PRACTICE;

public class Output
{
    public static void Main(String[] args)
    {
        //TwoSum.calculate(9);

        int[] target = TwoSum.TwoSums(TwoSum.nums ,17);
        Console.WriteLine($"Indices: [{target[0]}, {target[1]}]");
    }
}