namespace DSA_PRACTICE.ArraysAndStringManipulation
{

    //Linear search is the simplest search algorithm.You loop through every element in the array,
    //one by one, to find the target value.
    public class LinearSearch
    {
        static int[] Array = { 1, 2, 3, 4, 5, 6, 7 };

         public static bool Linearsearch(int key)
        {

            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == key)
                {
                    Console.WriteLine("Exists");
                }

            }
            return false;

        }
    }
}
