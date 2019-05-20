using System;
namespace K3 
{


public class Statement
{
	private string _statement;
	private string _source;
	private double _data;
	private bool _mark;

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

	public double data
	{
		get { return _data; }
		set { _data = value; }
	}

	public bool mark
	{
		get { return _mark;}
		set {_mark=value;}
	}

	public Statement(double d, string s1,string s2=null,bool b=false)

	{
		_data=d;
		_statement=s1;
		_source=s2;
		_mark=b;
	}

}



}

