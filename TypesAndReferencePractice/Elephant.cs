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

		public void HearMessage(string message, Elephant whoSaidIt)
		{
			Console.WriteLine(Name + " heard a message");
			Console.WriteLine(whoSaidIt.Name + " said this: " + message);
		}

		public void SpeakTo(Elephant whoToTalkTo, string message)
		{
			whoToTalkTo.HearMessage(message, this);
		}

	}
}

