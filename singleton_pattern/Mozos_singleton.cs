using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_pattern
{
    public class Mozos_singleton
    {
        //2 creamos una propiedad private, readonly (no se puede sobreescribir) y static (no necesitamos hacer un new [intanciar] para acceder a la propiedad
        //aca se instancia la clase, esta clase se crea al momento que se empieza a usar (Lazy instantiation)
        private static readonly Mozos_singleton _instancia = new Mozos_singleton();
        private List<string> mozos = new List<string>();
        private int proximoMozo = 0;
        //1 cambiamos el constructor a private (pero como se instancia la clase si es privado?
        
        private Mozos_singleton()
        {
            mozos.Add("Tim");
            mozos.Add("Sue");
            mozos.Add("Alan");
            mozos.Add("Mary");
        }
        //3 creamos un metodo publico, esto va a retornar la instancia de la clase, y va a ser la misma clase
        //entonces todos van a tener la misma informacion
        public static Mozos_singleton ObtenerMozosSingleton()
        {
            return _instancia;
        }
        public string ProximoMozo()
        {
            string output = mozos[proximoMozo];
            proximoMozo += 1;
            if (proximoMozo >= mozos.Count)
            {
                proximoMozo = 0;
            }
            return output;
        }
    }
}
