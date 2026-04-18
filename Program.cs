using System;
using System.Collections.Generic;
using System.Linq;

//  Enumerado
enum EstadoSolicitud
{
    Pendiente = 1,
    En_Proceso,
    Completada,
    Cancelada
}

// Defincion de Clase
class Solicitud
{
    public int Id { get; set; }
    public string Cliente { get; set; }
    public string Descripcion { get; set; }
    public EstadoSolicitud Estado { get; set; }

    public Solicitud(int id, string cliente, string descripcion)
    {
        Id = id;
        Cliente = cliente;
        Descripcion = descripcion;
        Estado = EstadoSolicitud.Pendiente;
    }

    // Mostrar los Datos
    public void Mostrar()
    {
        Console.WriteLine();
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Cliente: {Cliente}");
        Console.WriteLine($"Descripción: {Descripcion}");
        Console.WriteLine($"Estado: {Estado}");
        Console.WriteLine();
    }
}

class Program
{
    static List<Solicitud> solicitudes = new List<Solicitud>();
    static int contadorId = 1;

    static void Main()
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA DE SOLICITUDES ===");
            Console.WriteLine("1- Registrar solicitud");
            Console.WriteLine("2- Mostrar todas");
            Console.WriteLine("3- Cambiar estado");
            Console.WriteLine("4- Buscar por ID");
            Console.WriteLine("5- Salir");
            Console.Write("\nSeleccione opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Entrada inválida. ;( ");
                Continuar();
                continue;
            }

            switch (opcion)
            {
                case 1: Registrar(); break;
                case 2: Mostrar(); break;
                case 3: CambiarEstado(); break;
                case 4: Buscar(); break;
            }

        } while (opcion != 5);
    }

    // Registrar
    static void Registrar()
    {
        Console.Write("Nombre del cliente: ");
        string cliente = Console.ReadLine();

        Console.Write("Descripción: ");
        string desc = Console.ReadLine();

        solicitudes.Add(new Solicitud(contadorId++, cliente, desc));

        Console.WriteLine("Solicitud registrada.");
        Continuar();
    }

    // Mostrar todas
    static void Mostrar()
    {
        if (solicitudes.Count == 0)
        {
            Console.WriteLine("No hay solicitudes.");
        }
        else
        {
            foreach (var s in solicitudes)
            {
                s.Mostrar();
            }
        }
        Continuar();
    }

    // Cambiar estado con Enumerado (VALIDADO)
    static void CambiarEstado()
    {
        Console.Write("Ingrese ID: ");
        int id = int.Parse(Console.ReadLine());

        var solicitud = solicitudes.FirstOrDefault(s => s.Id == id);

        if (solicitud == null)
        {
            Console.WriteLine("Solicitud no encontrada.");
            Continuar();
            return;
        }

        // Mostrar estado actual

        Console.WriteLine($"\nEstado actual: {solicitud.Estado}");

        // Mostrar opciones disponibles

        Console.WriteLine("\nEstados disponibles:");
        foreach (EstadoSolicitud estado in Enum.GetValues(typeof(EstadoSolicitud)))
        {
            Console.WriteLine($"{(int)estado} - {estado}");
        }

        // Validación

        int opcionEstado;
        bool valido = false;

        do
        {
            Console.Write("\nSeleccione el nuevo estado: ");

            if (int.TryParse(Console.ReadLine(), out opcionEstado) &&
                Enum.IsDefined(typeof(EstadoSolicitud), opcionEstado))
            {
                solicitud.Estado = (EstadoSolicitud)opcionEstado;
                Console.WriteLine(" Estado actualizado correctamente. ");
                valido = true;
            }
            else
            {
                Console.WriteLine(" Estado inválido. Intente nuevamente.");
            }

        } while (!valido);

        Continuar();
    }

    // Buscar por ID
    static void Buscar()
    {
        Console.Write("Ingrese ID: ");
        int id = int.Parse(Console.ReadLine());

        var solicitud = solicitudes.FirstOrDefault(s => s.Id == id);

        if (solicitud == null)
        {
            Console.WriteLine("Solicitud no encontrada.");
        }
        else
        {
            solicitud.Mostrar();
        }

        Continuar();
    }
    static void Continuar()
    {
        Console.WriteLine("\nPresione Caulquier tecla... :)");
        Console.ReadKey();
    }
}