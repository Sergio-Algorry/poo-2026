using System;
using System.Collections.Generic;
using System.Text;

namespace poo_2026
{
    public class Ejemplo8
    {
        int[] numeros = { 1, 2, 3, 4, 5 };
        int[] numerosSinDatos = { };
        string[] palabras = { "Hola", "Mundo", "C#", "Programación" };
        string[] nombres = {};
        DateTime[] fechas = { new DateTime(2020, 1, 1), new DateTime(2021, 2, 15), new DateTime(2022, 3, 30) };

        public Ejemplo8()
        {
            #region Metodos y clases genericas

            //Util.Imprimir($"Cantidad de números: {Utilidades.CantidadDeElementos(numeros)}");
            //Util.Imprimir($"Cantidad de palabras: {Utilidades.CantidadDeElementos(palabras)}");
            //Util.Imprimir($"Cantidad de fechas: {Utilidades.CantidadDeElementos(fechas)}");

            //Util.Imprimir($"Cantidad de números: {Utilidades.CantidadDeElementos<int>(numeros)}");
            //Util.Imprimir($"Cantidad de palabras: {Utilidades.CantidadDeElementos<string>(palabras)}");
            //Util.Imprimir($"Cantidad de fechas: {Utilidades.CantidadDeElementos<DateTime>(fechas)}");

            //UtilidadesArreglos<int> utilInt = new UtilidadesArreglos<int>();
            //Util.Imprimir(
            //    $"Primer elemento o valor por defecto: {utilInt.PrimerElementoOValorPorDefecto(numeros)}");
            //Util.Imprimir(
            //    $"Primer elemento o valor por defecto: {utilInt.PrimerElementoOValorPorDefecto(numerosSinDatos)}");

            //UtilidadesArreglos<string> utilString = new UtilidadesArreglos<string>();
            //Util.Imprimir(
            //    $"Primer elemento o valor por defecto: {utilString.PrimerElementoOValorPorDefecto(palabras)}");
            //Util.Imprimir(
            //    $"Primer elemento o valor por defecto: {utilString.PrimerElementoOValorPorDefecto(nombres)}");

            //UtilidadesArreglos<DateTime> utilFecha = new UtilidadesArreglos<DateTime>();
            //Util.Imprimir(
            //    $"Primer elemento o valor por defecto: {utilFecha.PrimerElementoOValorPorDefecto(fechas).ToString("dd/MM/yyyy")}");
            //Util.Imprimir(
            //    $"Ultimo elemento o valor por defecto: {utilFecha.UltimoElementoOValorPorDefecto(fechas).ToString("dd/MM/yyyy")}");
            #endregion

            #region Control de restricciones
            UtilidadesArreglos<Vehiculo> utilVehiculo = new UtilidadesArreglos<Vehiculo>();
            UtilidadesArreglos<Auto> utilAuto = new UtilidadesArreglos<Auto>();
            #endregion
        }


        //public static class Utilidades
        //{
        //    public static int CantidadDeElementos(int[] arreglo)
        //    {
        //        return arreglo.Length;
        //    }
        //    public static int CantidadDeElementos(string[] arreglo)
        //    {
        //        return arreglo.Length;
        //    }
        //    public static int CantidadDeElementos(DateTime[] arreglo)
        //    {
        //        return arreglo.Length;
        //    }
        //}
        public static int CantidadDeElementos<T>(T[] arreglo)
        {
            return arreglo.Length;
        }
    }

    //public class UtilidadesArreglos<T>
    //public class UtilidadesArreglos<T,E>
    //public class UtilidadesArreglos<T> where T : class
    //public class UtilidadesArreglos<T> where T : struct
    public class UtilidadesArreglos<T> where T : IVehiculo, new()
    {
            public T PrimerElementoOValorPorDefecto(T[] arreglo)
            {
                if (arreglo.Length > 0)
                {
                    return arreglo[0];
                }
                else
                {
                    return default(T);
                }
            }

            public T UltimoElementoOValorPorDefecto(T[] arreglo)
            {
                if (arreglo.Length > 0)
                {
                    return arreglo[arreglo.Length - 1];
                }
                else
                {
                    return default(T);
                }
            }
        }

    public class  Vehiculo : IVehiculo
    {
        
    }

    public class  Auto : Vehiculo
    {
        private string Marca;
        public Auto(string marca)
        {
           Marca = marca;
        }

        public Auto()
        {
            
        }
    }
}
