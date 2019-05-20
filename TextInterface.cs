#define DEBUG

using System;
namespace TEST
{
    public class TexteInterface //: Interface
    {
        //attributs

        //Constructeur
        public TexteInterface()
        {
            //Interface(); //Appel au constructeur de la classe mère.
        }

        //Getteur et setteur

        //Méthodes
        public void displayStatement(Statement[] statements)
        {
            Console.WriteLine("{0} avec {1}", statements[0].statement, statements[0].data);
            Console.WriteLine("A votre avis, c'est plus ou c'est moins que :");
            Console.WriteLine("{0} avec {1} ?", statements[1].statement, statements[1].data);
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