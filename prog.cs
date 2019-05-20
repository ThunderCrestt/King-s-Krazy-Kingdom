using System;


namespace K3 
{

class main
{

	public static void Main()
	{

		Console.WriteLine("test");
		DataStore d = new DataStore("/");
		d.reset();
		Statement a = d.giveStatement();
		Console.WriteLine(a.data);
		a = d.giveStatement();
		Console.WriteLine(a.data);
		a = d.giveStatement();
		Console.WriteLine(a.data);
		a = d.giveStatement();
		Console.WriteLine(a.data);
		a = d.giveStatement();
		Console.WriteLine(a.data);
		a = d.giveStatement();
		Console.WriteLine(a.data);
		a = d.giveStatement();
		Console.WriteLine(a.data);
		a = d.giveStatement();
		Console.WriteLine(a.data);

	}

}



}