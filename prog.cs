using System;


namespace K3 
{

class main
{



	public static void Main()
	{

		

		TextInterface inText = new TextInterface();
		DataStore datas= new DataStore("store.txt");
		PlusMinus PM = new PlusMinus(inText, datas);
		Console.WriteLine();
		inText.displayGame(PM);
		Console.WriteLine();
		while(true){
			

			inText.displayStatement(PM);
			string saisie = Console.ReadLine();
			bool erreursaisie = true;
			while (erreursaisie)
			{
				if (saisie == "-"){erreursaisie = false;}
				else if (saisie == "+"){erreursaisie = false;}
				else 
				{
					Console.WriteLine("Entre + ou - s'il te plait");
					saisie = Console.ReadLine();
				}
			}

			int truAns = PM.evaluateAnswer(saisie);
			inText.displayScore(PM);
			if (truAns==0)
			{	
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Perdue\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("Recommencer ?");
				Console.WriteLine("");
				saisie = Console.ReadLine();
				erreursaisie = true;
				while (erreursaisie)
				{
					if (saisie == "oui"){erreursaisie = false;PM = new PlusMinus(inText, datas);Console.WriteLine("");}
					else if (saisie == "non"){erreursaisie = false;}
					else 
					{
						Console.WriteLine("Entrée oui ou non SVP");
						saisie = Console.ReadLine();
					}
				}
				if (saisie == "non"){break;}
			}
			if (truAns==2)
			{
				Console.WriteLine("OUAH tu as gagné tu es vraiment le meilleur, essaye donc dans une difficulté plus ardu, et clique moi dessus j'adore ça hoooo\n");
				Console.WriteLine("");
				Console.WriteLine("Recommencer ?");
				Console.WriteLine("");
				saisie = Console.ReadLine();
				erreursaisie = true;
				while (erreursaisie)
				{
					if (saisie == "oui"){erreursaisie = false;PM = new PlusMinus(inText, datas);Console.WriteLine("");}
					else if (saisie == "non"){erreursaisie = false;}
					else 
					{
						Console.WriteLine("Entrée oui ou non s'il vous plait au grand seigneur du jeu");
						saisie = Console.ReadLine();
					}
				}
				if (saisie == "non"){break;}
			}

	}


	}

}



}