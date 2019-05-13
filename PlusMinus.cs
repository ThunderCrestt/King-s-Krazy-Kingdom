using Game.cs
using DataStore

public class PlusMinus : Game
{
	private int _score;
	private DataStore _data;

	public PlusMinus(string rules, Interface inter,DataStore data)
					: base(rules, inter )
	{
			_score = 0;
			_data = data
			Statement[] _statements = new Statement[] {_data.giveStatement(),_data.giveStatement()};
	}

	private void addScore() 
	{
		_score++;
	}

	public void evaluateAnswer(string ans)
	{
		bool testAns = false;
		string truAns;

		if (_statements[0].data > _statements[1].data) 
		{
			string truAns = "-";
		}
		else
		{
			string truAns = "+";
		}

		if (ans == truAns)
		{
			testAns = true;
		}
		else 
		{
			testAns = false;
		}

		if (_statements[0].data == _statements[1].data) 
		{
			testAns = true;
		}

		if testAns 
		{
			this.loopWin();
		}
		else
		{
			this.looplose();
		}
	}

	private void loopWin()
	{
		_statements[0] = _statements[1];
		_statements[1] = _data.giveStatement();
		this.addScore();
	}

	private void loopLose()
	{
		// Affiche score+reset jeu
		//_interface.displayScore();
		_data.reste();

	}

}