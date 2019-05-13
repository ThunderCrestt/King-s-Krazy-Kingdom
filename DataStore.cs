using System;

namespace K3 
{
	class DataStore
	{
		private Statement[] _statements;

		public DataStore(string access)
		{
			initialize(access);
		}

		public void initialize(string access)
		{
			//lira la base de donnée, donne nombre d'élément, initialise chacun d'entre eux
			int nbrelement=5;
			_statements =new Statement[nbrelement];
			for(int i =0; i<nbrelement;i++)
			{
				_statements[i]=new Statement(15 ,"coucou","oui",true);
			}
		}

		public void reset()
		{
			foreach(Statement sta in _statements)
			{
				sta.mark=false;
			}
		}


		public Statement giveStatement(int index)
		{
			return _statements[index];
		}


	} 
	
}