using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace curso.net
{
    public class Auto
    {
        private string marca;
        private int año;
        private Motor motor;
        private uint capacidadNafta;
        private uint combustible;
        public Luz[] Luces = new Luz[10];

        public Auto(string marca, int año, Motor motor, uint capacidadNafta)
        {
            this.marca = marca;
            this.año = año;
            this.motor = motor;
            this.capacidadNafta = capacidadNafta;
        }

        public void cargarNafta(uint litros)
        {
            if (litros+combustible > capacidadNafta ){
                throw new System.ArgumentException("La cantidad de litros a cargar excede la capadidad del auto", "original");
            }
            combustible += litros;
        }

        public uint getAutonomia()
        {
            return combustible / motor.getConsumo() * 100;
        }

        public bool viajar(int kilometros){
            return true;
        }



    }
}
