using System;

class MainClass
{
  public static void Main(string[] args)
	{
    Console.Write ("type SCNUM:-");
		string SCNUM = "11233344455";
		string input = Console.ReadLine();
		if(input != SCNUM)
		{
			Console.WriteLine("wrong press enter and reopen the app");
			Console.ReadLine();
		}else
		{
			if(input == SCNUM)
			{
				Console.WriteLine("you win!!!!");
        Console.ReadLine();
			}
		}
  }
}