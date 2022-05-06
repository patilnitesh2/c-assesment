using NiteshConsoleApp1;
using System;
using System.Collections.Generic;
using static NiteshConsoleApp1.StackException;

public class Exeption
{
	public static void Main()
	{
		Stack<int> numbers = new Stack<int>();
		try
		{
			
			numbers.Push(1);
			numbers.Push(2);
			numbers.Push(3);
			numbers.Push(4);
			numbers.Push(5);
			numbers.Pop();

		}
		catch (StackException sfe)
		{
			Console.WriteLine(sfe.ToString());
		}

	}
}