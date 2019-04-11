using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace curso.net
{
    public class StaticMember
    {
        static private int count = 0;
        public StaticMember() { count++; }

        public static int Count { get => count; set => count = value; }

        public int getCount() { return count; }
    }
}
