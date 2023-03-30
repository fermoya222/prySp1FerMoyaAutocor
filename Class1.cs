using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySp1FerMoya
{
    internal class ClassMascota
    {
        // propiedades
        public string nombre { get; set; }
        public string especie { get; set; }
        public int peso { get; set; }
        public string sexo { get; set; }
        public int edad { get; set; }
        public string historiaClinica {get; set; }

        //metodosd
        public string ObtenerDatos()
        {
            return nombre + " " + especie + " " + peso + " " + sexo + " " + edad + " " + historia + " ";
        }

    }
}
