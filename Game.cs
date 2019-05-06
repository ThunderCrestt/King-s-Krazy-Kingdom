using System;
/*using Statement.cs*/

public abstract class Game {
    /*attributs*/
    private string rules;
    private bool answer = false;
    private string[] statements; */*Passer en Statement*/
    /*Constructeur*/
    public Game ()
    { }
    /*Getteur et setteur*/
    public string Rules
    {
        get { return rules; }
        set { this.rules = value; }
    }
    

    public virtual void evaluateAnswer()
    {
        /*A compléter*/
    } 

}
