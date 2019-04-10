using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace curso.net
{
    public class Motor
    {
        private int clindros;
        private int pistones;
        private uint consumo;
        private string marca;

        public Motor(int cilindros, int pistones)
        {
            this.clindros = cilindros;
            this.pistones = pistones;
            this.consumo = Convert.ToUInt16(cilindros / pistones); 
        }

        public uint getConsumo()
        {
            return consumo;
        }
    }
}
