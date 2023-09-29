using System;
namespace TypesAndReferencePractice
{
	public class Elephant
	{
		public string? Name;
		public int EarSize;
		public void WhoAmI()
		{
			Console.WriteLine("My Name is " + Name + ".");
			Console.WriteLine("My Ears are " + EarSize + " inches tall.");
		}

	}
}

