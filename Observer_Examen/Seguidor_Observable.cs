using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Examen
{
    class Seguidor_Observable : Observador
    {
        //creamos un nombre de usuario
        private string Usuario;
        private Seguidor sujeto_;
        //creamos un constructor para el suscriptor-seguidor
        public Seguidor_Observable(string Suscriptor_Seguidor, Seguidor Nombre)
        {
            //asignamos la variable
            Usuario = Suscriptor_Seguidor;
            sujeto_ = Nombre;
        }
        //metodo que actualiza cambios de estado de los seguidores
        public void actualizar_datos(string salida)
        {
            Console.WriteLine("Notificar a: {0} - {1}", Usuario, salida);
        }



    }
}
