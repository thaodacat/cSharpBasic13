using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = {-5,7, -33, 63, 33, -7, 5};
            int[] numbers = {-3, -5, -7, 30, 0};
            // printNumbers();
            // printOdds();
            // printSum();
            // loopArray(arr);
            // findMax(arr);
            // getAverage(arr);
            // oddArray();
            // greaterThanY(arr, 0);
            // squareArrayValues(arr);
            // eliminateNegatives(numbers);
            // minMaxAverage(numbers);
            // shiftValues(numbers);
            object[]numToStr=numToString(numbers);
            Console.WriteLine(String.Join(", ", numToStr));
        }

        public static void printNumbers()
        {
            for(int i = 1; i <= 255; i++){
                Console.WriteLine(i);
            }
        }
        public static void printOdds()
        {
            for(int i = 1; i <= 255; i=i+2){
                Console.WriteLine(i);
            }
        }
        public static void printSum()
        {
            int sum = 0;
            for(int i = 0; i <= 255; i++){
                sum = sum + i;
                Console.WriteLine($"New number- {i} Sum- {sum}");
            }
        }
        public static void loopArray(int[] num)
        {
            
            for(int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
        }
        public static int findMax(int[] num)
        {
            int max = num[0];
            for(int i = 0; i < num.Length; i++){
                if(num[i] > max)
                {
                    max = num[i];
                }

            }
            Console.WriteLine("The max is " + max);
            return max;
            


        }
        public static void getAverage(int[] num)
        {
            int sum = 0;
            for(int i = 0; i < num.Length; i++)
            {
                // Console.WriteLine(num[i]);
                sum += num[i];
            }
            Console.WriteLine("The sum is " + sum);
            int avg = sum / num.Length;
            Console.WriteLine("The average is " + avg);

        }
        public static int[] oddArray()
        {
            List<int> listArr = new List<int>();
            for( int i = 1; i <= 255; i = i+2)
            {
                listArr.Add(i);
            }
            int[] output = listArr.ToArray();
            for(int j = 0; j < output.Length; j++)
            {
                Console.WriteLine(output[j]);
            }   
            return output; 
        }
        public static int greaterThanY(int[] num, int y)
        {
            int count = 0;
            for(int i = 0; i < num.Length; i++)
            {
                if( num[i] > y)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }
        public static void squareArrayValues(int[] num)
        {
            for(int i = 0; i < num.Length; i++)
            {
                num[i] = num[i] * num[i];
            }
            Console.WriteLine(String.Join(", ", num));

        }
        public static void eliminateNegatives(int[] num)
        {
            for( int i = 0; i < num.Length; i++)
            {
                if( num[i] < 0)
                {
                    num[i] = 0;
                }
            }
            Console.WriteLine(String.Join(", ", num));
        }
        public static void minMaxAverage(int[] num)
        {
            int min = num[0];
            int max = num[0];
            int sum = 0;
            for(int i = 0; i < num.Length; i++)
            {
                sum += num[i];
                if(num[i] > max)
                {
                    max = num[i];
                }
                if(num[i] < min)
                {
                    min = num[i];
                }
                
            }
            int avg = sum / num.Length;
            Console.WriteLine($"Min- {min} Max- {max} Avg- {avg} ");
        }
        public static void shiftValues(int[] num)
        {

            for(int i = 0; i < num.Length-1; i++)
            {
                num[i] = num[i + 1];
            }
            num[num.Length -1] = 0;
            Console.WriteLine(String.Join(", ", num));
        }

        public static object[] numToString(int[] num)
        {
            object[] newArray = new object[num.Length];
            for(var i = 0; i < num.Length; i++)
            {
                if(num[i]<0)
                {
                    newArray[i]="Dojo";
                }
                else{
                    newArray[i]= num[i];
                }
            Console.WriteLine(num[i]);
            }
            return newArray;
        }
    }
}
