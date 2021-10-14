using System;

namespace pz_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            Random rnd = new Random();
            for(int i = 0;i < nums.Length;i++)
                nums[i] = rnd.Next(-11, 11);
            for (int i = 0; i < nums.Length; i++)
                Console.WriteLine(nums[i]);

            for(int i = 0,j = nums.Length - 1;i < nums.Length /2 ;i++,j--)
            {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }

            Console.WriteLine("Reverse:");
            for (int i = 0; i < nums.Length; i++)
                Console.WriteLine(nums[i]);
        }

    }
}
