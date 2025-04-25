// See https://aka.ms/new-console-template for more information

namespace Strings 
{
    class Strings 
    {
        static void Main(string[] args)
        {
            string miNombre = "Isabella";
            string mensaje = " la mujersita mas linda es " +  miNombre;
            Console.WriteLine(mensaje);

            string mayusculas = mensaje.ToUpper();
            Console.WriteLine(mayusculas);
            
            string minusculas = mensaje.ToLower();
            Console.WriteLine(minusculas);
        }
        
    }
    
}

