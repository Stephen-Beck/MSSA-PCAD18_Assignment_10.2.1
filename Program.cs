/*
Write a program in C# Sharp to find the positive numbers from a list of numbers using where conditions in LINQ Query.
    Input: { 2, -1, 3, -3, 10, -200}
    Expected output: {2, 3, 10} 
*/

namespace Assignment_10._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new() { 2, -1, 3, -3, 10, -200 };

            var posNums = from num in nums
                          where num > 0
                          select num;

            Console.WriteLine("Find the positive numbers in a list of numbers.");
            Console.WriteLine($" Input: {String.Join(", ", nums)}");
            Console.WriteLine($"Output: {String.Join(", ", posNums)}");
        }
    }
}
