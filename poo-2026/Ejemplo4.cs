using System;
using System.Collections.Generic;
using System.Text;

namespace poo_2026
{
    public class Ejemplo4
    {
        PracticaMetodo pcSinArg = new PracticaMetodo();
        PracticaMetodo pc = new PracticaMetodo("Nuevo Pepe");
        PracticaMetodo pcCompleto;
        PracticaMetodo pcConAntiguedad = new PracticaMetodo(5, "PepeAntiguo");

        public Ejemplo4()
        {
            pcCompleto = new PracticaMetodo("Pepe completo", 50);

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

    public class PracticaMetodo
    {
        #region Propiedades
        public string Nombre { get; set; } = "PEPE por defecto";
        public int Edad { get; set; }
        public int Antiguedad { get; set; } = 0;

        #endregion

        #region Constructores
        public PracticaMetodo()
        {
            //Nombre = "Pepe";
            Edad = 20;
        }

        public PracticaMetodo(string nombre) : this()
        {
            Nombre = nombre;
        }

        public PracticaMetodo(string nombre, int edad) : this()
        {
            Nombre = nombre;
            Edad = edad;
        }

        public PracticaMetodo(int antiguedad, string nombre) : this()
        {
            Nombre = nombre;
            Antiguedad = antiguedad;
        }
        #endregion

        #region Metodos
        public void RestarAntiguedad()
        {
            Antiguedad--;
        }

        public bool EsMayorDeEdad()
        {
            return Edad >= 18;
        }

        public string EsMayorDeEdad(int edadAComparar)
        {
            if (Edad >= edadAComparar)
            {
                return $"Es mayor o igual a {edadAComparar}";
            }
            else
            {
                return $"Es menor a {edadAComparar}";
            }
        }

        #endregion
    }
}
    
