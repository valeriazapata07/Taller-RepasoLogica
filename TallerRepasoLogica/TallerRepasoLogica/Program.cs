
using TallerRepasoLogica.PuentesMadison;
using CosechandoACaballo;
using Shared;

Console.WriteLine("TALLER REPASO LOGICA");

Console.WriteLine();

Console.WriteLine("1. Puentes de Madison");
Console.WriteLine("2. Cosechando a caballo");

Console.WriteLine();

int opcion = ConsoleExtension.GetInt("Seleccione una opcion: ");

Console.WriteLine();

if (opcion == 1)
{
    string puente = ConsoleExtension.GetString(
        "Ingrese el puente: ") ?? "";

    while (puente != "")
    {
        if (PuentesMadison.EsValido(puente))
        {
            Console.WriteLine("VALIDO");
        }
        else
        {
            Console.WriteLine("INVALIDO");
        }

        Console.WriteLine();

        puente = ConsoleExtension.GetString(
            "Ingrese otro puente (Enter para terminar): ") ?? "";
    }
}
else if (opcion == 2)
{
    string frutos = ConsoleExtension.GetString(
        "Ingrese ubicación de los frutos: ") ?? "";

    while (frutos != "")
    {
        string posicionInicial = ConsoleExtension.GetString(
            "Ingrese posición inicial del caballo: ") ?? "";

        string movimientos = ConsoleExtension.GetString(
            "Ingrese los movimientos del caballo: ") ?? "";

        CaballoCosecha caballo = new CaballoCosecha(
            frutos,
            posicionInicial
        );

        string[] listaMovimientos = movimientos.Split(',');

        foreach (string movimiento in listaMovimientos)
        {
            caballo.Mover(movimiento.Trim());
        }

        Console.WriteLine();

        Console.WriteLine(
            "Los frutos recogidos son: " +
            caballo.ObtenerFrutosRecogidos()
        );

        Console.WriteLine();

        frutos = ConsoleExtension.GetString(
            "Ingrese otra ubicación de frutos (Enter para terminar): ") ?? "";
    }
}
else
{
    Console.WriteLine("Opcion no valida.");
}
