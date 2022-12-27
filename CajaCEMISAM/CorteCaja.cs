using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CajaCEMISAM
{
    class CorteCaja
    {
        string fecha;
        string reciboInicial;
        string reciboFinal;
        string valoracionEquipo;
        string psicodiagnostico;
        string psicoeducacion;
        string sesionPsicoterapeutica;
        string consultaEspecialidad;
        string entrega;
        string observaciones;

        public CorteCaja(string _fecha, string _ReciboInicial, string _reciboFinal, string _valoracionEquipo, string _psicodiagnostico, string _psicoeducacion, string _sesionPsicoterapeutica, string _consultaEspecialidad, string _entrega, string _observaciones)
        {
            fecha = _fecha;
            reciboInicial = _ReciboInicial;
            reciboFinal = _reciboFinal;
            valoracionEquipo = _valoracionEquipo;
            psicodiagnostico = _psicodiagnostico;
            psicoeducacion = _psicoeducacion;
            sesionPsicoterapeutica = _sesionPsicoterapeutica;
            consultaEspecialidad = _consultaEspecialidad;
            entrega = _entrega;
            observaciones = _observaciones;
        }


    }
}
