///prints all permutations of a given string
using System;
					
public class StringPermutation
{
	public static void Main()
	{
		Permutation("", "abc");
	}
	
	public static void Permutation(string prefix, string suffix)
	{
		if (suffix.Length == 0)
		{
			Console.WriteLine(prefix);
		}
		
		for (int i = 0; i < suffix.Length; i++)
		{
			Permutation(prefix+suffix[i], suffix.Remove(i,1));
		}
	}
}