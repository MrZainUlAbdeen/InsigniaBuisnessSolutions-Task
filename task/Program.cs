using System;
using static task.FibonacciNumber;
namespace task
{
    class SortList
    {
        //function
        public int[] IsSortlist(int[] unSortArry)
        {
            int tempValue;
            for(int i=0; i< unSortArry.Length-1; i++)
            {
                for(int j=i+1; j<unSortArry.Length; j++)
                {
                    if (unSortArry[i] > unSortArry[j])
                    {
                        tempValue = unSortArry[i];
                        unSortArry[i] = unSortArry[j];
                        unSortArry[j] = tempValue;
                    }
                }
            }
            return unSortArry;
        }
    }

    public class FizzBuzz
    {
        public string IsFizzbuzz(int number)
        {
            if (number % 15 == 0)
            {
                return "fizzbuzz";
            }
            else if (number % 3 == 0)
            {
                return "fizz";
            }
            else if (number % 5 == 0)
            {
                return "buzz";
            }
            else
            {
                return number.ToString();
            }
        }
    }

    public class LuckyNumber
    {
        public int getLuckyNumber(int[] numbers)
        {
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
        }
    }

    public class FibonacciNumber
    {
        public int getFibonacciNumer(int number)
        {
            if (number <= 1)
            {
                return number;
            }
            else
            {
                return getFibonacciNumer(number - 1) + getFibonacciNumer(number - 2);

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
            }
            else
            {
                return false;
            }
        }
    }

    class PrimeNumber
    {
        public Boolean IsPrime(int primeNumber)
        {
            int limit = primeNumber + 10;
            int count, i;
            count = 0;
            for (i = 1; i < limit; i++)
            {
                if (primeNumber % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("-------------\n\nThis is Modification Task but never modified\n" +
                "This only use for new branch Purpose-------------");
            Console.WriteLine("\n-------\nPrime Number\n\n------------");
            PrimeNumber obj_PrimeNumber = new PrimeNumber();
            Console.WriteLine(obj_PrimeNumber.IsPrime(9));

            Console.WriteLine("\n-------\nSorted Array\n-------\n");
            //Sorted List
            SortList obj_sortlist = new SortList();
            int[] sortArray = obj_sortlist.IsSortlist(new int[] { 3, 2, 1, 5, 4 });
            foreach (var item in sortArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--------\nFizz Buzz\n-------\n");
            //FizzBuzz
            FizzBuzz obj_fizzBuzz = new FizzBuzz();
            Console.WriteLine(obj_fizzBuzz.IsFizzbuzz(15));

            Console.WriteLine("\n--------\nLucky Number\n-------\n");
            LuckyNumber luckyNumber = new LuckyNumber();
            int[] LuckyArray = {1,2,2,2,3,3,3};
            Console.WriteLine(luckyNumber.getLuckyNumber(LuckyArray));

            Console.WriteLine("\n--------\nFibonacci Number\n-------\n");
            FibonacciNumber obj_fibonacciNumber = new FibonacciNumber();
            Console.WriteLine(obj_fibonacciNumber.getFibonacciNumer(6));

            Console.WriteLine("\n--------\nPalindrome\n-------\n");
            Palindrome obj_palindrome = new Palindrome();
            Console.WriteLine(obj_palindrome.IsPalindrome("civic"));

        }
    }
}