using System;
using System.Collections.Generic;
using System.Text;

namespace poo_2026
{
    public class Ejemplo3
    {
        PracticaConstructor pcSinArg = new PracticaConstructor();
        PracticaConstructor pc = new PracticaConstructor("Nuevo Pepe");
        PracticaConstructor pcCompleto;
        PracticaConstructor pcConAntiguedad = new PracticaConstructor(5, "PepeAntiguo");

        public Ejemplo3()
        {
            pcCompleto = new PracticaConstructor("Pepe completo", 50);

            Console.WriteLine("Constructor SIN firma");
            Console.WriteLine(pcSinArg.Nombre);
            Console.WriteLine(pcSinArg.Edad);
            Console.WriteLine(pcSinArg.Antiguedad);

            Console.WriteLine("Constructor CON firma string");
            Console.WriteLine(pc.Nombre);
            Console.WriteLine(pc.Edad);
            Console.WriteLine(pc.Antiguedad);

            Console.WriteLine("Constructor CON firma string e int");
            Console.WriteLine(pcCompleto.Nombre);
            Console.WriteLine(pcCompleto.Edad);
            Console.WriteLine(pcCompleto.Antiguedad);

            Console.WriteLine("Constructor CON firma int e string");
            Console.WriteLine(pcConAntiguedad.Nombre);
            Console.WriteLine(pcConAntiguedad.Edad);
            Console.WriteLine(pcConAntiguedad.Antiguedad);
        }
    }

    public class  PracticaConstructor
    {
        public string Nombre { get; set; } = "PEPE por defecto";
        public int Edad { get; set; }
        public int Antiguedad { get; set; } = 0;

        public PracticaConstructor()
        {
            //Nombre = "Pepe";
            Edad = 20;
        }

        public PracticaConstructor(string nombre) : this()
        {
            Nombre = nombre;
        }

        public PracticaConstructor(string nombre, int edad) : this()
        {
            Nombre = nombre;
            Edad = edad;
        }

        public PracticaConstructor(int antiguedad, string nombre) : this()
        {
            Nombre = nombre;
            Antiguedad= antiguedad;
        }
    }
}
