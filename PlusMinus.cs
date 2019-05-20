using System;
using System.IO;
namespace K3 {

public class PlusMinus : Game
{
	private int _score;
	private DataStore _data;

	StreamReader file = new StreamReader(@"rules.txt");
	static string rules = "aha";

	public PlusMinus(Interface inter,DataStore data)
					: base(rules , inter )
	{
			_score = 0;
			_data = data;


			setStatements(0,_data.giveStatement());
			setStatements(1,_data.giveStatement());
	}


	public int score
	{
		get{return _score;}
	}

	private void addScore() 
	{
		_score++;
	}


	public bool evaluateAnswer(string ans)
	{
		bool testAns = false;
		string truAns;

		if (getStatements(0).data > getStatements(1).data) 
		{
			truAns = "-";
		}
		else
		{
			truAns = "+";
		}

		if (ans == truAns)
		{
			testAns = true;
		}
		else 
		{
			testAns = false;
		}

		if (getStatements(0).data == getStatements(1).data) 
		{
			testAns = true;
		}

		if (testAns) 
		{
			this.loopWin();
		}
		else
		{
			this.loopLose();
		}

		return testAns;
	}

	private void loopWin()
	{
		setStatements(0,getStatements(1));
		setStatements(1,_data.giveStatement());
		this.addScore();
	}

	private void loopLose()
	{
		// Affiche score+reset jeu
		//_interface.displayScore();
		_data.reset();

	} 

}

}
