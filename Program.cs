using System;

namespace CountSubstringOccurrences
{
	public class MainClass
	{
		public static void Main()
		{
			var getText = Console.ReadLine().ToLower();
			var getString = Console.ReadLine().ToLower();

			var count = 0;

			int i = getText.IndexOf(getString);
			int old = i;

			if (i != -1)
			{
				count++;
			}

			while (true)
			{
				i = getText.IndexOf(getString, i+1);

				if (i > old)
				{
					count++;
					old = i;
				}
				else
				{
					break;
				}
			}

			Console.WriteLine(count);
		}
	}
}
