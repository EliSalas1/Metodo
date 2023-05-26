using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_METODOOOS.Clases
{
    public class Funciones
    {
        //La clase es una plantilla que permite crear:
        //Objetos  y Metodos

        #region Esta es una suma
        public int Suma(int num1, int num2, int num3, int num4) //Esta esperando un numero // (Se llaman parametros o que esta adentro del)
        {
            int resultado = num1+ num2+ num3 + num4;
            return resultado;

        }
        #endregion

        public void Resta()//(int num1, int num2, int num3, int num4) //Esta esperando un numero // (Se llaman parametros o que esta adentro del)
        {
            int num1 = 2;
            int num2= 2;
            int num3 = 2;
            int num4 = 2;

            int resultado = num1 - num2;
            Console.WriteLine("El resultado es: " + resultado);
        

        }
    }
}

