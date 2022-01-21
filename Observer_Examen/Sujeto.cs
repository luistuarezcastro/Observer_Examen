using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Examen
{
    interface Sujeto
    {
        //El siguiente metodo permite agregar seguidores al objeto el cual va a ser observador
        void agregar(Observador suscriptor);
        // Elimina al seguidor de la lista
        void eliminar(Observador suscriptor);
        // Ultimo metodo para notificar los cambios
        void Notificacion();
    }
}
