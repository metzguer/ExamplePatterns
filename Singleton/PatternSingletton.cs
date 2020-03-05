using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class PatternSingletton
    {
        private static PatternSingletton _instance = null ;
        public string mensaje = "";

        protected PatternSingletton()
        {
            mensaje = "Intance unique";
        }

        public static PatternSingletton instance {
            get
            {
                return (_instance == null) ? new PatternSingletton() : null ; 
            }
        }

       
    }
}
