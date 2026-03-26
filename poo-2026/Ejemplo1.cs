using System;
using System.Collections.Generic;
using System.Text;

namespace poo_2026
{
    public class Ejemplo1
    {
        CamposyPropiedades ej = new CamposyPropiedades();
        
        public Ejemplo1()
        {
            ej.Nombre = "PEPE";
            Console.WriteLine(ej.Nombre);
        }
    }

    public class  CamposyPropiedades
    {
        private string nombre;

        public String Nombre { get; set; }

        //private string nombre;

        //public string Nombre
        //{
        //    get { return nombre; }
        //    set 
        //    { 
        //        if (value == "")
        //        {
        //            nombre = "ERROR";
        //        }
        //        else
        //        {
        //            nombre = value;
        //        }
        //    }
        //}

    }
}
