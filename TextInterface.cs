using System;
namespace K3
{
    public class TextInterface //: Interface
    {
        //attributs

        //Constructeur
        public TextInterface()
        {
            //Interface(); //Appel au constructeur de la classe mère.
        }

        //Getteur et setteur

        //Méthodes
        public void displayStatement(PlusMinus PM)
        {
            Console.WriteLine("{0} avec {1}", PM.getStatements(0).statement, PM.getStatements(0).data);
            Console.WriteLine("A votre avis, c'est plus ou c'est moins que :");
            Console.WriteLine("{0} avec {1} ?", PM.getStatements(1).statement, PM.getStatements(1).data);
        }

        public void displayGame(PlusMinus plusMinus)
        {
            Console.WriteLine(plusMinus.rules);

        }

        public void displayScore(PlusMinus plusMinus)
        {
            Console.WriteLine("score :{0}",plusMinus.score);
        }
    }
}