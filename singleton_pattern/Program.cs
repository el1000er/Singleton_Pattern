using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_pattern
{
    class Program
    {   
        //sin singleton
        static Mozos ListaAnfitrion1 = new Mozos();
        static Mozos ListaAnfitrion2 = new Mozos();

        //con singleton
        static Mozos_singleton ListAnfitrion1Singleton =  Mozos_singleton.ObtenerMozosSingleton();
        static Mozos_singleton ListAnfitrion2Singleton = Mozos_singleton.ObtenerMozosSingleton();

        static void Main(string[] args)
        {
           // Mozos mozos = new Mozos();

            for(int i =0; i<5; i++)
            {
                //Console.WriteLine("El proxumo mozo es: " + mozos.ProximoMozo());  

                //Cada anfitiron tiene una lista de mozos disponibles

                //sin singleton
                Anfitrion1ProximoMozo();
                Anfitrion2ProximoMozo();

            }

            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine("El proxumo mozo es: " + mozos.ProximoMozo());  

                //Cada anfitiron tiene una lista de mozos disponibles

               

                //con singleton
                Anfitrion1ProximoMozo_singleton();
                Anfitrion2ProximoMozo_singleton();
            }
            Console.ReadLine();
        }

        //sin singleton
        private static void Anfitrion1ProximoMozo()
        {
            Console.WriteLine("Host 1 El proximo mozo es: " + ListaAnfitrion1.ProximoMozo());
        }
        private static void Anfitrion2ProximoMozo()
        {
            Console.WriteLine("Host 2 El proximo mozo es: " + ListaAnfitrion2.ProximoMozo());
        }

        //con singleton

        private static void Anfitrion1ProximoMozo_singleton()
        {
            Console.WriteLine("Host 1 El proximo mozo singleton es: " + ListAnfitrion1Singleton.ProximoMozo());
        }
        private static void Anfitrion2ProximoMozo_singleton()
        {
            Console.WriteLine("Host 2 El proximo mozo singleton es: " + ListAnfitrion2Singleton.ProximoMozo());
        }
    }
}
