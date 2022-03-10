using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic
{
    public class Car
    {
        /* Clase Carro
         Propiedad POO ... */
        private string color; //Cadena
        private int engineCylinderVolumen; //Numero entero
        private int model; //Numero entero

        //Encapsulamiento
        public string Color { get => color; set => color = value; }
        public int EngineCylinderVolumen { get => engineCylinderVolumen; set => engineCylinderVolumen = value; }
        public int Model { get => model; set => model = value; }

        //Metodo que retorna una cadena (string).
        public string stop()
        {
            string msj = "¡El carro de color "+color+" con cilindraje "+engineCylinderVolumen+" y modelo "+model+" esta detenido!";
            return msj;
        }
    }
}