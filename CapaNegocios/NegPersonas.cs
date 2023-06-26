using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NegPersonas 
    {
        AdminPersonas DatosObjPersona = new AdminPersonas();

        public int abmPersonas(string accion, Persona objPersona)
            {
            return DatosObjPersona.abmPersonas(accion, objPersona);
            }

        public DataSet listadoAutos(string cual)
            {
            return DatosObjPersona.listadoAutos(cual);
            }
            
    }
}
