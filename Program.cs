// See https://aka.ms/new-console-template for more information
Console.WriteLine("¡Hola mundo!");
Console.ReadLine();

    var nombre = Console.ReadLine();
    EscribirMensaje("Carlos");
    EscribirMensaje(nombre);
    EscribirMensaje(nombre);
    EscribirMensaje(nombre);
    EscribirMensaje(nombre);
    EscribirMensaje(nombre);
    EscribirMensaje(nombre);


  static string EscribirMensaje(string nombreLocal)
  {
    Console.WriteLine("Adios " + nombreLocal);
    return "Hola" + nombreLocal;
  }