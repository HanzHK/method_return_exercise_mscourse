/* Suppose you have several coins of different values. You're tasked to find two coins whose sum is equal to a target value. 
 * In this exercise, the coins available are represented in an integer array. 
 * You'll need to return the indices of the two coins in a new array. Let's get started!
 * 
 * 1) Choose one number from the array
 * 2) Check other numbers one at a time to see if they add up to the target value
 * 3) Return the result as soon as a match is found
 */

using System;
using System.Drawing;

internal class Program
{
    static void Main(string[] args)
    {
        CoinCount coinCount = new CoinCount();
        coinCount.PrintOutCoinsAv();
        coinCount.PrintOutResult();
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

    // Array which stores aviable coins
    int[] coins = new int[] { 5, 5, 10, 10, 20, 20, 50 };

    public int[] CompareIt()
    {


        // With what number we want to compare it to
        int changeToCompare = TargetNumber();

        for (int i = 0; i < coins.Length; i++)
        {
            
            for (int j = i + 1; j < coins.Length; j++)
            {
                if (coins[i] + coins[j] == changeToCompare)
                {
                    
                    return new int[] { i, j };
                }
            }
        }
                return new int[] { -1, -1 };
    }
    public void PrintOutCoinsAv()
    {
        for (int i = 0; i < coins.Length; i++)
        {
            Console.WriteLine(coins[i]);
        }

        }

    public void PrintOutResult()
    {
        int[] result = CompareIt();

        if (result[0] == -1)
        {
            Console.WriteLine("No valid coin combination found.");
        }
        else
        {
            Console.WriteLine($"Matching coins found at index positions: {result[0]} and {result[1]}");
        }
    }

}