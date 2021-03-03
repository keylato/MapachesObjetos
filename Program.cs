using System;

namespace Animals
{
    class Program
    {
        // En POO, las funciones y procedimientos se llaman métodos
        // En todo programa, se debe incluir un punto inicial
        // El nombre estándar para el método que inicia un programa
        // es "main": static void Main
        // 
        // void -> no devuelve ningún valor (es un procedimiento)
        // static -> entorno estático; trabajando a nivel clase en vez de objeto
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            DecirHolaMundo();
            
            // string nombre;
            // Usar clase como tipo de variable
            // new -> construir algo
            // new Mapache() -> Llamar al método constructor y crear un nuevo Mapache
            Mapache mapache1 = new Mapache(true, 40f, 3.5f, "gris", "Mapía");
            Mapache mapache2 = new Mapache (true,35f, 3.8f, "cafecito", "Ramona");
            Mapache mapache3 = new Mapache (false, 45f, 2.5f, "negro con blanco", "Josefo");
            //TODO: Crear 2 mapaches distintos
            // Mapache mapache2 = new Mapache();

            //TODO: Agregar propiedad nombre a cada Mapache

            // Tiene un nombre vacío
            // Mapache mapache4 = new Mapache(false, 50f, 4.5f, "gris", "");
            // No tiene nombre
            Mapache mapache4 = new Mapache(false, 50f, 4.5f, "gris", null);

            // null para cadenas de texto o datos más complejos

            // int -> 0
            // string -> ""
            // float -> 0f
            // double -> 0.0
            // bool -> false

            // Mostrar información de uno de los mapaches
            // Console.WriteLine(mapache1); //Animals.Mapache
            
            // . -> "acceder hacia dentro"
            Console.WriteLine("Mapache #1");
            Console.WriteLine("Color: " + mapache1.color);
            Console.WriteLine("Nombre: " + mapache1.nombre);

            // TODO: imprimir datos del mapache sin nombre
            Console.WriteLine("Mapache #4");
            Console.WriteLine("Color: " + mapache4.color);
            Console.WriteLine("Nombre: " + mapache4.nombre);

            // acciones
            mapache1.Moverse();
            mapache4.Moverse();

            mapache1.Comer();
            mapache4.Comer();

            // Información general sobre mapaches
            Console.WriteLine("---------------");
            Console.WriteLine("Información general sobre mapaches");
            Console.WriteLine("");
            if (Mapache.viviparo)
            {
                Console.WriteLine("Vivíparo");
            }
            else
            {
                Console.WriteLine("Ovíparo");
            }
            if (Mapache.tipoAlimentacion == TipoAlimentacion.CARNIVORO)
            {
                Console.WriteLine("Carnívoro");
            }
            else if (Mapache.tipoAlimentacion == TipoAlimentacion.HERBIVORO)
            {
                Console.WriteLine("Herbívoro");
            }
            else if (Mapache.tipoAlimentacion == TipoAlimentacion.OMNIVORO)
            {
                Console.WriteLine("Omnívoro");
            }
        }

        

    }
}
