using System;

public class Usuario
{
    // Atributos (estado)
    private string nombre;
    private string correo;

    // Constructor
    public Usuario(string nombre, string correo)
    {
        this.nombre = nombre;
        this.correo = correo;
    }

    // Métodos (comportamiento)
    public void MostrarDatos()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Correo: " + correo);
    }

    public void CambiarCorreo(string nuevoCorreo)
    {
        correo = nuevoCorreo;
    }
}
