using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class PatternSingletton
    {
        private static PatternSingletton _instance = null ;
        public string ConexionDB = "";
        //en la primera instancia asinga la cadena de conexion en ConnexionDb
        //el objeto se crea una sola vez
        private PatternSingletton()
        {
            ConexionDB = "Server=(local);Database=nameDatabase; Trusted_Connection=true;";
        }
        //despues de haber construido el objeto, en su segunda llamada solo se ejecutara la instancia
        //orden de ejecucion de primera instancia :
        //metodo Instance / get /(_instance==null) new PatternSingleton(); / string ConnexionDb="" / ConexionDB="cadena de conexion" en constructor / return _instance
        //orden de ejecucion de llamados 2do, 3ro, etc. :
        //metodo Instance / get /(_instance==null) new PatternSingleton(); / return _instance
        public static PatternSingletton Instance {
            get
            {
                if (_instance==null)
                    _instance = new PatternSingletton();

                return _instance; 
            }
        }

       
    }
}
