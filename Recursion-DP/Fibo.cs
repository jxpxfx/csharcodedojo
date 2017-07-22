/// Fibonacci using recursion / DP / memoization
using System;
using System.Collections;
					
public class Fibo
{
	public static void Main()
	{
		int n = 4000;
		Console.WriteLine(FibMemo(n));
	}	
	
	public static Hashtable ht = new Hashtable();
	public static int FibMemo(int n)
	{
		if (n ==0 || n ==1)
		{
			return n;
		}
		else
		{
			if (!ht.Contains(n))
			{
				ht.Add(n, FibMemo(n-1) + FibMemo(n-2));
			}
			return (int) ht[n];			
			
		}		
		
	}
	
	public static int Fib(int n)
	{
		if (n ==0 || n ==1)
		{
			return n;
		}
		else
		{
			return Fib(n-1) + Fib(n-2);
		}
	}
}