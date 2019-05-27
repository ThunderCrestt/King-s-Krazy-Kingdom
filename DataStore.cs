using System;
using System.Collections.Generic;
using System.IO;

namespace K3 
{
	public class DataStore
	{
		private List<Statement> _statements = new List<Statement>();
		private Random rnd = new Random();
		private string _access;

		public DataStore(string access)
		{
			_access=access;
			initialize(_access);
		}

		public void initialize(string access)
		{
			
			string line;
			//lira la base de donnée, donne nombre d'élément, initialise chacun d'entre eux
			StreamReader file = new StreamReader(_access);
			int _nbrelement = int.Parse(file.ReadLine());			
			for(int i =0; i<_nbrelement;i++)
			{
				line = file.ReadLine();
				if(line ==null){}

				int d = int.Parse(file.ReadLine());
				string sta = file.ReadLine();
				string source = file.ReadLine();
				_statements.Add(new Statement(d ,sta,source));
			}
		}



		public void reset()
		{
			initialize(_access);
		}


		public Statement giveStatement()
		{
			if(_statements.Count>0)
			{
				int index = rnd.Next(_statements.Count);
				Statement si = _statements[index];
				_statements.RemoveAt(index);
				return si;
			}
			else
			{return new Statement(-1,"fini","bravo");}
		}



	} 
	
}