using System;
using System.IO;
using System.Text;
namespace K3 {

public class PlusMinus : Game
{
	private int _score;
	private DataStore _data;

	static new string rules = File.ReadAllText(@"rules.txt");

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


	public int evaluateAnswer(string ans)
	{
		int testAns = 0;
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
			testAns = 1;
		}
		else 
		{
			testAns = 0;
		}

		if (getStatements(0).data == getStatements(1).data) 
		{
			testAns = 1;
		}

		if (testAns==1) 
		{
			testAns = this.loopWin();
		}
		else if(testAns==0)
		{
			this.loopLose();
		}


		return testAns;
	}

	private int loopWin()
	{
		this.addScore();
		setStatements(0,getStatements(1));
		Statement sta=_data.giveStatement();
		if(sta.data!=-1)
		{
			setStatements(1,sta);
			return 1;
		}
		else{_data.reset();return 2;}
	}

	private void loopLose()
	{
		// Affiche score+reset jeu
		//_interface.displayScore();
		_data.reset();

	} 

}

}
