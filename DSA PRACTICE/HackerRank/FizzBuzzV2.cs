namespace DSA_PRACTICE.HackerRank
{
    public class FizzBuzzV2
    {

        //FIZZBUZ OPTIMIZED 

        public static void fizzBuzz2(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string result = "";
                if (i % 3 == 0) result += "Fizz";
                if (i % 5 == 0) result += "Buzz";

                Console.WriteLine(string.IsNullOrEmpty(result) ? i.ToString() : result);
            }
        }

    }
}
