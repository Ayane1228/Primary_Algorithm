using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 加一
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 7, 8, 9 };
            Console.WriteLine("原數組為:");
            showArr(nums);
            Console.WriteLine("加一數組為:");
            int[] plusArr = PlusOne(nums);
            showArr(plusArr);
            Console.ReadKey();

        }
        public static void showArr(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }

        private static int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (++digits[i] != 10)
                {
                    return digits;
                }
                else
                {
                    digits[i] = 0;
                    if (i == 0)
                    {
                        //增加数组长度，扩容
                        int[] newDigits = new int[digits.Length + 1];
                        for (int j = 0; j < digits.Length; j++)
                        {
                            newDigits[j + 1] = digits[j];
                        }
                        newDigits[0] = 1;
                        return newDigits;
                    }
                }
            }
            return null;
        }







    }
}
