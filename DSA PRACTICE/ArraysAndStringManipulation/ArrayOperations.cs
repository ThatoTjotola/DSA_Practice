namespace DSA_PRACTICE.ArraysAndStringManipulation
{
    public class ArrayOperations
    {
        static int[] Array = { 1, 2, 3, 4, 5, 6, 7 };
        public static void ArrayInsertAtTheBegining(int target)
        {

            //this is the array 
            //Place a value at the beginning of the array and move over the rest value too be place in beginning is 8
            for (int i = 3; i >= 0; i--)
            {
                // this is for swamppiing
                Array[i + 1] = Array[i];
            }

            Array[0] = target;

            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }
        }

        //Inserting at the end of an array 
        public static void ArrayInsertAtTheEnd(int target)
        {
            int[] array = new int[Array.Length + 1];

            for (int i = 0; i < Array.Length; i++)
            {
                array[i] = Array[i];
            }

            array[array.Length - 1] = target;
            Array = array;

            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }
        }

        /// <summary>
        /// Insert anywhere without overwriting  except for the end on an array
        /// </summary>
        /// <param name="indice"></param>
        /// <param name="target"></param>
        public static void ArrayInsertAnywhere(int indice, int target)

        {
            int[] array = new int[Array.Length + 1];
            //feel the damn array fix data
            //i<3 is where you wanna insert
            for (int i = 0; i < indice; i++)
            {
                array[i] = Array[i];
            }
            //i<3 is where you wanna insert
            for (int i = Array.Length - 1; i >= indice; i--)
            {
                array[i + 1] = Array[i];
            }
            //assignment stuff 
            array[0] = target;
            Array = array;
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }

        }
        /// <summary>
        ///  Scenario deleted specific index in an array
        ///  Delete the Array [0]
        /// </summary>
        public static void ArrayDeletionInArray(int index)
        {
            for (int i = index + 1; i < Array.Length; i++ )
            {
                //swap (remove)
                Array[i - 1] = Array[i];
            }
            //start fresh 
            int[] newArray = new int[Array.Length - 1];

            for(int i = 0;i < newArray.Length; i++)
            {
                newArray[i] = Array[i];
            }

            Array = newArray;

            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }
        }
    }
}
