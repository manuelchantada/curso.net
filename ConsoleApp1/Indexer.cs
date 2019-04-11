using System;
using System.Collections.Generic;
using System.Text;

namespace curso.net
{
    public class Indexer
    {
        static public int size = 10;
        private string[] nameList = new string[size];
        
        public Indexer()
        {
            for(int i=0 ; i<size ; i++)
            {
                nameList[i] = "N/D";
            }
        }

        public string this[int index]
        {
            get
            {
                if(index >= 0 && index < size) {return nameList[index];}
                else{return "";}
            }
            set
            {
                if (index >= 0 && index < size) { nameList[index]= value; }
            }
        }

    }
}
