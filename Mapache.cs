using System;

namespace Animals
{
    enum TipoAlimentacion
    {
        CARNIVORO,
        HERBIVORO,
        OMNIVORO,
        INSECTIVORO
    }

    class Mapache
    {
        
        bool hembra;
        bool vivo;
        float tamanio; //cm
        float peso; //kg
        
        public string color;
        public string nombre;
       
        public static bool viviparo = true;
        public static TipoAlimentacion tipoAlimentacion = TipoAlimentacion.OMNIVORO;

    
        public Mapache(bool hembra, float tamanio, float peso, string color, string nombre)
        {
            
            this.vivo = true;

            
            this.hembra = hembra;
            
            this.tamanio = tamanio;
            this.peso = peso;
            this.color = color;
            this.nombre = nombre;
        }


        private string ObtenerNombreAMostrar()
        {
            string nombreAMostrar;
            if (this.nombre != null)
            {
                
                nombreAMostrar = this.nombre;
            }
            else
            {
                nombreAMostrar = "Mapache";
            }
            return nombreAMostrar;
        }

        
        public void Moverse()
        {
            
            string nombreAMostrar = ObtenerNombreAMostrar();
            
            Console.WriteLine("*" + nombreAMostrar + " se mueve*");
            
        }

        public void Comer()
        {
            
            string nombreAMostrar = ObtenerNombreAMostrar();
            
            Console.WriteLine("*" + nombreAMostrar + " entra en el bote de basura*");
        }

        public void Trepar()
        {
            

            Console.WriteLine("*Mapache se sube a un árbol*");
        }

        public void Hablar()
        {
            Console.WriteLine("*Happy mapache noises*");
        }

        
    }
}