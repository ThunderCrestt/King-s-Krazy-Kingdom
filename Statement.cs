using System;
namespace K3 
{


public class Statement
{
	private string _statement;
	private string _source;
	private long _data;

	public string statement
	{
		get { return _statement; }
		set { _statement = value;}
	}

	public string source
	{
		get { return _source;}
		set { _source=value;}
	}

	public long data
	{
		get { return _data; }
		set { _data = value; }
	}


	public Statement(long d, string s1,string s2=null)

	{
		_data=d;
		_statement=s1;
		_source=s2;

	}

}



}

