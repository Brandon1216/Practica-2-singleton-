using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_911
{
    public class Operador
    {
        public int id_Operador { get; set; }
        public string Nombre { get; set; }

        public Operador(int id, string nombre)
        {
            id_Operador = id;
            Nombre = nombre;
        }

        public void AtiendeEmergencia(string tipoEmergencia)
        {
            Console.WriteLine($"Operador{Nombre} atendiendo emergencia de tipo: {tipoEmergencia}");

            switch (tipoEmergencia)
            {
                case "Intento de suicidio":
                    Console.WriteLine("Enviando unidades de apoyo y rescate");
                    break;
                case "Incendio":
                    Console.WriteLine("Enviando bomberos");
                    break;
                case "Accidente":
                    Console.WriteLine("Enviando paramedicos y oficiales");
                    break;
                case "Violeta":
                    Console.WriteLine("Enviando una patrulla");
                    break;
                case "Persona herida":
                    Console.WriteLine("Enviando una ambulancia");
                    break; 

                default:
                    Console.WriteLine("Tipo de emergencia no reconocido");
                    break;

            }
        }
    }

}
