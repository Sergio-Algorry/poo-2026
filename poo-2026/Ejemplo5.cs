using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace poo_2026;
public class Ejemplo5
{
    //public Ejemplo5()
    //{
        //PersonaBD pBD = new PersonaBD();
        //pBD.ObtenerPesona(1);
        //Console.WriteLine("-------------------------");

        //PersonaLista pLista = new PersonaLista();
        //pLista.ObtenerPesona(2);
        //Console.WriteLine("-------------------------");
    //}
    
    public void EjecutarBuscarPersona(IBuscarPersona bp, int id)
    {
        bp.ObtenerPersona(id);
    }

    public IBuscarPersona EjecutarBuscarPersona(TipoBusqueda tipo)
    {
        switch (tipo)
        {
            case TipoBusqueda.BaseDatos:
                PersonaBD bp = new PersonaBD();
                return bp;
            case TipoBusqueda.Lista:
                PersonaLista bpl = new PersonaLista();
                return bpl;
            default:
                throw new ArgumentException("Tipo de búsqueda no válido");
        }
    }
}


//CLASE RESPONSABLE DE OBTENER PERSONAS DESDE LA BASE DE DATOS
public class PersonaBD : IBuscarPersona
{
    public void ObtenerPersona(int id)
    {
        // Simulamos la obtención de una persona desde la base de datos
        Console.WriteLine($"Obteniendo persona id = {id} desde la base de datos...");
    }
}

//CLASE RESPONSABLE DE OBTENER PERSONAS DESDE UNA LISTA
public class PersonaLista : IBuscarPersona
{
    public void ObtenerPersona(int id)
    {
        // Simulamos la obtención de una persona desde la base de datos
        Console.WriteLine($"Obteniendo persona id = {id} desde una lista...");
    }
}

//Interfase
public interface IBuscarPersona
{
    void ObtenerPersona(int id);
}

public enum TipoBusqueda
{
    BaseDatos,
    Lista
}





