// UEA
// JUAN GABRIEL ZURITA MANOBANDA
// proyecto integrador - Agenda telefónica con temas vistos en la semana  struct, record, array etc
///////////////////
using System;

/// ////Creamos la estrucutra o struct de la agenda con los telefonos que se van a almacenar que sera un primero y otro de referencia 
public struct Telefono
{
    public string Principal { get; set; }
    public string Referencia { get; set; }

    public Telefono(string principal, string referencia)
    {
        Principal = principal;
        Referencia = referencia;
    }
}

// Usamremos  record para alamacenar datos simples simples en este caso los datos de contacto 
public record Contacto(
    string Nombre,
    string Correo,
    string Direccion,
    Telefono Telefonos
);

class Program
{
    static void Main()
    {
        /// Creamos un array  de contactos
        Contacto[] agenda = new Contacto[2];

        // Agregamos contactos
        agenda[0] = new Contacto(
            "Juan Gabriel Zurita M",
            "juanzurita@1234.com",
            "Orellana Sacha",
            new Telefono( "0987654321", "0999999999")
        );

        agenda[1] = new Contacto(
            "chavo del 8",
            "lavecindad@del 8.com",
            "acapulco 2 cuadras a la derecha ",
            new Telefono("0888888888", "0888888882")
        );

        // Mostramos la información de cada contacto con un console.writeline
        foreach (var contacto in agenda)
        {
            Console.WriteLine("\n--- REGISTRO DE AGENDA UEA ------");
            Console.WriteLine($"Nombre: {contacto.Nombre}");
            Console.WriteLine($"Correo: {contacto.Correo}");
            Console.WriteLine($"Dirección: {contacto.Direccion}");
            Console.WriteLine($"Teléfono Principal: {contacto.Telefonos.Principal}");
            Console.WriteLine($"Teléfono de Referencia: {contacto.Telefonos.Referencia}");
        }
    }
}

