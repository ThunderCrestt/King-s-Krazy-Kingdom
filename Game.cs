using System;

namespace K3 {

    public abstract class Game {
        /*attributs*/
        private string _rules;
        private Statement[] _statements = new Statement[2]; 
        private Interface _interface;

        /*Constructeur*/
        public Game(string r, Interface i) {
            this._rules = r;
            this._interface = i;
        }
        /*Getteur et setteur*/
        public string rules
        {
            get { return _rules; }
            set { this._rules = value; }
        }

        public void setStatements(int index,Statement sta)
        {
            _statements[index]=sta;
        }

        public Statement getStatements(int index)
        {
            return _statements[index];
        }

        public virtual void evaluateAnswer()
        {
            /*classe abstraite à redéfinir*/
        }

    }
}
