using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Examen
{
    class Seguidor : Sujeto
    {
        // lista que nos permite almacenar los observadores que se agg al sujeto observador
        private List<Observador> seguidores = new List<Observador>();
        private string salida;
        //metodo para agregar un seguidor o suscriptor
        public void agregar(Observador suscriptor)
        {
            Console.WriteLine("Se ha agregado un nuevo suscriptor a nuestra pagina");
            seguidores.Add(suscriptor);
        }
        //metodo para eliminar un suscriptor o Seguidor
        public void eliminar(Observador seguidor)
        {
            Console.WriteLine("Se ha eliminado un suscriptor de la pagina");
            seguidores.Remove(seguidor);
        }
        public void Notificacion()
        {
            //Notificamos el cambio de estado de la pagina a cada Seguidor
            foreach (Observador observer in seguidores)
            {
                observer.actualizar_datos(salida);
            }
        }
        //Este metodo es para realizar un cambio de estado que se notifica a cada Seguidor
        // cada que añadimos algo a la tiende este notifica a los seguidores
        public void Cambio()
        {
            Console.WriteLine("Hemos agregado un nuevo video");
            salida = "Jugando minecraft en mi Xbox";
            Notificacion();
        }
    }
}
