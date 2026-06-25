//a) Function Signature

static int[] ProductExceptSelf(int[] nums)

    //b) Implementation Without Using Division

    using System;

class Program
{
    static int[] ProductExceptSelf(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return new int[0];

        if (nums.Length == 1)
            return new int[] { 1 };

        int n = nums.Length;
        int[] result = new int[n];

        for (int i = 0; i < n; i++)
        {
            int product = 1;

            for (int j = 0; j < n; j++)
            {
                if (i != j)
                    product *= nums[j];
            }

            result[i] = product;
        }

        return result;
    }

    static void Main()
    {
        int[] arr = { 1, 2, 3, 4 };

        int[] result = ProductExceptSelf(arr);

        Console.Write("Output: ");
        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }
}