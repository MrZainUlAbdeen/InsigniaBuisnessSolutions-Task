using System;
using static task.FibonacciNumber;

namespace task
{
    class SortedList
    {

        //function
        public int[] Sortedlist(int[] arry)
        {
            int temp;
            for(int i=0; i<arry.Length-1; i++)
            {
                for(int j=i+1; j<arry.Length; j++)
                {
                    if (arry[i] > arry[j])
                    {
                        temp = arry[i];
                        arry[i] = arry[j];
                        arry[j] = temp;
                    }
                }
            }
            return arry;
        }
    }

    public class FizzBuzz
    {
        public string Fizzbuss(int number)
        {
            if (number % 15 == 0)
            {
                return "fizzbuzz";
                //Console.Write("fizzBuzz(" + number + ") = fizzbuzz");
            }
            else if (number % 3 == 0)
            {
                return "fizz";
                //Console.Write("fizzBuzz(" + number + ") = fizz");
            }
            else if (number % 5 == 0)
            {
                return "buzz";
                //Console.WriteLine("fizzBuzz(" + number + ") = fizzbuzz");
            }
            else
            {
                return number.ToString();
                //Console.WriteLine("fizzBuzz(" + number + ") = " + number);
            }
        }
    }

    public class LuckyNumber
    {
        public int getLuckyNumber(int[] numbers)
        {
            //foreach (var number in LuckyNumberArry)
            //{
            //    Console.WriteLine(number);
            //}
            //{1,2,3,4,5,2,3}
            //int Count = 1;
            //Array.Sort(LuckyNumberArry);
            //for (int i = 0; i < LuckyNumberArry.Length - 1; i++)
            //{
            //for (int j = i + 1; j < LuckyNumberArry.Length; j++)
            //{
            //if (LuckyNumberArry[i] == LuckyNumberArry[i + 1])
            //{
            //Console.WriteLine(LuckyNumberArry[i]);
            //Count++;
            //Console.WriteLine(LuckyNumberArry[i]);
            //}
            //    //}
            //}
            //Console.WriteLine(Count);
            //{ 1, 2, 2, 3, 9, 8, 7,3,3,3 ,1}
            //{ 1,2,2,3, 9, 8, 7,3,3 ,1}

            var countMap = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if (!countMap.ContainsKey(number))
                {
                    countMap[number] = 0;
                }

                countMap[number] = countMap[number] + 1;
            }

            var luckyNumber = -1;
            foreach (var entry in countMap)
            {
                if (entry.Key == entry.Value && entry.Key > luckyNumber)
                {
                    luckyNumber = entry.Key;
                }
            }

            return luckyNumber;
            //List<int> duplicates = new List<int>();
          
            //foreach (var item in LuckyNumberArry)
            //{
            //    int count = 0;

            //    foreach (var luckynumber in LuckyNumberArry)
            //    {
            //        if (item == luckynumber)
            //        {
            //            count++;

            //            if(count > 1)
            //            {
            //                //if (!duplicates.Contains(luckynumber))
            //                //{
            //                    //duplicates.Add(luckynumber);
            //                    if(count == luckynumber)
            //                    {
            //                    //Console.WriteLine("   " + luckynumber);
            //                    duplicates.Add(luckynumber);
                                
            //                }
                                
            //                //}
            //            }
            //        }
            //    }
            //}
            //foreach(var a in duplicates)
            //{

            //}
            //foreach (var item in duplicates)
            //{
            //    Console.WriteLine(item);
            //}





            //IGrouping<int, int> max =
            //LuckyNumberArry.GroupBy(n => n).OrderByDescending(g => g.Count()).First();
            //int z = max.Key; int y = max.Count();
            ////Console.WriteLine("Maximum number repeated is " + max.Key +
            ////  " and it is repeated " + max.Count() + " times"
            ////);
            //if (max.Key == max.Count())
            //{
            //    Console.WriteLine("Lucky");
            //}
            //else
            //{
            //    Console.WriteLine(-1);
            //}
        }
    }

    public class FibonacciNumber
    {
        public int getFibnumer(int number)
        {
            if (number <= 1)
            {
                return number;
            }
            else
            {
                return getFibnumer(number - 1) + getFibnumer(number - 2);

            }
        }
    }
    public class Palindrome
    {
        public Boolean IsPalindrome(string input)
        {
            // Converting string to character array
            char[] charArray = input.ToCharArray();

            // Declaring an empty string
            string reversedString = String.Empty;

            // Iterating the each character from right to left
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reversedString += charArray[i];
            }

            // Return the reversed string.
            if(input == reversedString)
            {
                return true;
                //Console.WriteLine("IsPalindrome("+ input +") == true");
            }
            else
            {
                return false;
                //Console.WriteLine("IsPalindrome(" + input + ") == false");
            }
        }
    }

    class Program
    {
        public Boolean IsPrime(int number)
        {
            int limit = number + 10;
            int count, i;
            count = 0;
            for (i = 1; i < limit; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
                //Console.WriteLine("isPrimeNumber(" + number + ")==true");
            }
            else
            {
                return false;
                //Console.WriteLine("isPrimeNumber(" + number + ")==false");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n-------\nPrime Number\n-------\n");
            Program obj = new Program();
            Console.WriteLine(obj.IsPrime(9));

            Console.WriteLine("\n-------\nSorted Array\n-------\n");
            //Sorted List
            SortedList sortlist = new SortedList();
            Console.WriteLine(sortlist.Sortedlist(new int[] { 3, 2, 1, 5, 4 }));

            Console.WriteLine("\n--------\nFizz Buzz\n-------\n");
            //FizzBuzz
            FizzBuzz fizzBuzz = new FizzBuzz();
            Console.WriteLine(fizzBuzz.Fizzbuss(15));

            Console.WriteLine("\n--------\nLucky Number\n-------\n");
            LuckyNumber luckyNumber = new LuckyNumber();
            int[] LuckyArray = {1,2,2,2,3,3,3};
            Console.WriteLine(luckyNumber.getLuckyNumber(LuckyArray));
            //Console.WriteLine(luckyNumber.getLuckyNumber(new int[]{ 1, 2, 2, 3, 3 }));

            Console.WriteLine("\n--------\nFibonacci Number\n-------\n");
            FibonacciNumber fibonacciNumber = new FibonacciNumber();
            Console.WriteLine(fibonacciNumber.getFibnumer(6));

            Console.WriteLine("\n--------\nPalindrome\n-------\n");
            Palindrome palindrome1 = new Palindrome();
            Console.WriteLine(palindrome1.IsPalindrome("civic"));

        }
    }
}