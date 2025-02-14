/* Suppose you have several coins of different values. You're tasked to find two coins whose sum is equal to a target value. 
 * In this exercise, the coins available are represented in an integer array. 
 * You'll need to return the indices of the two coins in a new array. Let's get started!
 * 
 * 1) Choose one number from the array
 * 2) Check other numbers one at a time to see if they add up to the target value
 * 3) Return the result as soon as a match is found
 */

using System;

internal class Program
{
    static void Main(string[] args)
    {
        CoinCount coinCount = new CoinCount();
        coinCount.CompareIt();
    }

}
internal class CoinCount
{
    public int TargetNumber()
    {
        int result;
        Console.Write("Please choose your number: ");

        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Invalid input. Try again please.");
            
        }

        return result;
    }
    public bool CompareIt()
    {
        // Array which stores aviable coins
        int[] coins = new int[] { 5, 5, 10, 10, 20, 20, 50 };

        // With what number we want to compare it to
        int changeToCompare = TargetNumber();

        for (int i = 0; i < coins.Length ; i++)
        {
            Console.WriteLine($"Checking first coin: {coins[i]}");
        }

        return true;
    }

}