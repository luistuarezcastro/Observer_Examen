using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Examen
{
    //Primero creamos una interface la cual nos va a permitir actualizar nuestros seguidores
    interface Observador
    {
        //recibe la notificacion del cambio de estado cuando suceda una actualizacion de nuestros videos
        void actualizar_datos(string Notificacion);
    }
}
