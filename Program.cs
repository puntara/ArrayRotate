using System;

namespace example
{
    class Program
        
    { 
        static void Rightrotate(int []arr, int k, int n)
        {
            for(int i= 0; i<k; i++)
            {
                RightRotateOne(arr, n);
            }
        }
        static void RightRotateOne(int []arr, int n)
        {
            int i;
            int interim = arr[n-1];
            for(i=n-1; i>0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[i] = interim;

        }
        static void print(int[]arr, int n)
        {
            for (int i =0; i < n; i++)
            {
                Console.Write(arr[i] + "  ");
            }
        }
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7,8,9 };
            Rightrotate(array1, 1, 9);
            print(array1, 9);
           
        }
    }
}
