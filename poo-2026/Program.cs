using poo_2026;

//Ejemplo1 ej1 = new Ejemplo1();

//Ejemplo2 ej = new Ejemplo2();

//Ejemplo3 ej = new Ejemplo3();

//Ejemplo4 ej = new Ejemplo4();

Ejemplo5 ej = new Ejemplo5();

//ej.EjecutarBuscarPersona(new PersonaBD(), 1);
//PersonaBD pBD = new PersonaBD();
//ej.EjecutarBuscarPersona(pBD, 1);
//Console.WriteLine("-------------------------");

//ej.EjecutarBuscarPersona(new PersonaLista(), 2);
//Console.WriteLine("-------------------------");

IBuscarPersona buscadorBD = ej.EjecutarBuscarPersona(TipoBusqueda.BaseDatos);
buscadorBD.ObtenerPersona(1);
Console.WriteLine("-------------------------");

var buscadorLista = ej.EjecutarBuscarPersona(TipoBusqueda.Lista);
buscadorLista.ObtenerPersona(1);
Console.WriteLine("-------------------------");
