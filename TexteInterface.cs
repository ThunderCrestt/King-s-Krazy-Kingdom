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
#if (DEBUG)
        public void displayStratement()
        {
            Console.Write("%s avec %d", "la population française : ", 65000000);
        }
#else
    public void displayStatement(Statement statement)
    {
        Console.Write("%s avec %d", "la population française : "/*statement.getStatement()*/, 65000000/*statement.getData*/);
    }
#endif

        public void displayGame(/*PlusMinus plusMinus*/)
        {
            Console.Write(", versus , c'est plus ou c'est moins ? : )");

        }
/*
        public void displayScore(PlusMinus plusMinus)
        {
            //A compléter
        }*/
    }
}