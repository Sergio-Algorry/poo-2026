using System;
using System.Collections.Generic;
using System.Text;

namespace poo_2026
{
    public class Ejemplo9
    {
        public List<int> listaNumeros { get; set; } = new List<int>()
        {
            10, 20, 30, 40, 50
        };
        public List<string> listaNombres { get; set; } = new List<string>()
        {
            "Juan", "María", "Pedro", "Ana", "Luis"
        };
        public Ejemplo9()
        {
            //Console.WriteLine($"Elemento en posicion 3: {listaNumeros[2]}");
            //Console.WriteLine("-------------------");

            //foreach (var item in listaNumeros)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-------------------");

            //listaNumeros.Add(60);
            //listaNumeros.Add(70);
            //foreach (var item in listaNumeros)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-------------------");

            //listaNumeros.Remove(40);
            //listaNumeros.RemoveAt(0);
            //listaNumeros.RemoveAt(1);
            //foreach (var item in listaNumeros)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-------------------");

            //listaNumeros.Clear();
            //foreach (var item in listaNumeros)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-------------------");

            Console.WriteLine($"Cantidad de Elementos: {listaNombres.Count}");
            foreach (var item in listaNombres)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------");

            listaNombres.Sort();
            foreach (var item in listaNombres)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------");

            listaNombres.Reverse();
            foreach (var item in listaNombres)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------");

            listaNombres.Sort(2,2,default);
            foreach (var item in listaNombres)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------");
        }
    }
}
