using System;

namespace TestAkvelon
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
            int Max2nd = FoundMax2nd(array);

            Console.WriteLine("Max second number is : " + Max2nd);
            Console.Read();

        }

        public static int FoundMax2nd(int[] inputArray)
        {
            try
            {
                for (int i = 0; i < 2; i++)
                    for (int j = 0; j < inputArray.Length - 1 - i; j++)
                    {
                        if (inputArray[j] > inputArray[j + 1])
                        {
                            int temp = inputArray[j];
                            inputArray[j] = inputArray[j + 1];
                            inputArray[j + 1] = temp;
                        }
                    }
                return inputArray[inputArray.Length - 2];
            }
            catch (Exception)
            {
                Console.WriteLine("Array is verry small");
            }
            return 0;
        }
    }
    
}
