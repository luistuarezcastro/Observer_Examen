using System;

namespace Observer_Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancia de Seguidor de nuestro canal de youtube
            Seguidor videos = new Seguidor();
            // instancia de Seguidor_Observable, los suscriptores que se añadan a nuestro canal
            Seguidor_Observable suscriptor1 = new Seguidor_Observable("willyrex", videos);
            videos.agregar(suscriptor1);
            Seguidor_Observable suscriptor2 = new Seguidor_Observable("Robleis", videos);
            videos.agregar(suscriptor2);
            Seguidor_Observable suscriptor3 = new Seguidor_Observable("Spreent", videos);
            videos.agregar(suscriptor3);
            Seguidor_Observable suscriptor4 = new Seguidor_Observable("Josua2408", videos);
            videos.agregar(suscriptor4);
            
            //ciclo para cambiar de estado del observable
            //sirve para notificar si se agrego o se elimino un seguidor
            for (int z = 0; z < 2; z++)
            {
                videos.Cambio();
            }
            // eliminamos suscriptores
            Console.WriteLine();
            videos.eliminar(suscriptor3);
            // cambiamos el estado del observable para que notifique las y los suscriptores eliminados
            for (int y = 0; y < 1; y++)
            {
                videos.Cambio();
            }
            Console.WriteLine();
            //de igual manera podemos añadir nuevos suscriptores
            Seguidor_Observable suscriptor5 = new Seguidor_Observable("Steve 071", videos);
            videos.agregar(suscriptor5);
            //cambio de estado para actualizar
            videos.Cambio();
        }
    }
}
