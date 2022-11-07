//There is a queue for the self-checkout tills at the supermarket. Your task is write a function to calculate the total time required for all the customers to check out!
//input

//    customers: an array of positive integers representing the queue. Each integer represents a customer, and its value is the amount of time they require to check out.
//    n: a positive integer, the number of checkout tills.

//output

//The function should return an integer, the total time required.

using System;

public class Kata
{
    public static long QueueTime(int[] customers, int n)
    {
      int[] total = new int[n];

      for (int i = 0; i < customers.Length; i++) {
        total[0] += customers[i];
        Array.Sort(total);
      }

      return total[n - 1];
    }
}
