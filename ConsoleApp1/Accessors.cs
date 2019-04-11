using System;
using System.Collections.Generic;
using System.Text;

namespace curso.net
{
    public abstract class Accessible
    {
        public abstract int PrivateVariable { get; set; }
    }

    public class Obj : Accessible
    {
        private int privateInt;
        public override int PrivateVariable
        {
            get { return privateInt; }
            set { privateInt = value; }
        }
    }
}
