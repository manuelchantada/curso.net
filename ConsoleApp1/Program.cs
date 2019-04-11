using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace curso.net
{
    public class Program
    {

        public unsafe static void exchange(int *a, int *b)
        {
            int temp = *a;
            *a = *b;
            *b = temp;
        }
        static void Main(string[] args)
        {

        }
    }



  

}
