using System;
					
public class HanoiTowers
{
	public static void Main()
	{
		Move(4, 1, 2, 3);
	}
	
	public static void Move(int n, int fro, int to, int spare)
	{
		if (n == 1)
		{
			Print(n, fro, to);
		}
		else
		{
			Move(n - 1, fro, spare, to);
			Move(1, fro, to, spare);
			Move(n - 1, spare, to, fro);
		}					
	}
	
	public static void Print(int n, int fro, int to)
	{
		Console.WriteLine("Moved {0} from {1} to {2}", n, fro, to);
	}
}