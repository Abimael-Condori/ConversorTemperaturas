using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ConversorTemperaturas
{
    //Clase Estática con métodos estáticos
    public static class Termometro
    {
        //Métodos estáticos para convertir de grados centígrados a farenheit
        public static double convertirC_F(double gradosC) {

            return (gradosC * 9 / 5) + 32;
        
        }
        //Métodos estáticos para convertir de grados farenheit a centígrados
        public static double convertirF_C(double gradosF)
        {

            return (gradosF-32) * 5 / 9;

        }
    }
}