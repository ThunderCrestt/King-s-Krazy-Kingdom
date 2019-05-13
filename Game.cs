using System;

namespace K3 {

    public abstract class Game {
        /*attributs*/
        private string _rules;
        private bool _answer = false;
        private Statement[] _statements; 
        private Inteface _interface;

        /*Constructeur*/
        public Game(string r, Interface i) {
            this._rules = r;
            this._interface = i;
            this._statements = []
        }
        /*Getteur et setteur*/
        public string Rules
        {
            get { return _rules; }
            set { this._rules = value; }
        }

        public virtual void evaluateAnswer()
        {
            /*classe abstraite à redéfinir*/
        }

    }
}
