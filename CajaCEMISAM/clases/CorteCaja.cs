using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CajaCEMISAM
{
    public class CorteCaja
    {
        string fecha;
        string reciboInicial;
        string reciboFinal;
        string psiquiatria;
        string psicologia;
        string valoracionPsiq;
        string valoracionPsic;
        string valoracionFam;
        string valoracionCal;
        string valoracionNut;
        string consultaNut;
        string platicaNut;
        string valoracionNeu;
        string paqueteNeu;
        string urgencias;
        string revaloracionPsiq;
        string revaloracionPsic;
        string psicoeducacion;
        string reposicionCar;
        string crianzaPositiva;
        string grupoV;
        string neuropsiquiatria;
        string neuropsicologia;
        string total;

        string entrego;
        string observaciones;

        public CorteCaja(string _fecha, string _ReciboInicial, string _reciboFinal, string _psiquiatria,
            string _psicologia, string _valoracionPsiq, string _valoracionPsic, string _valoracionFam, string _valoracionCal,
            string _valoracionNut, string _consultaNut, string _platicaNut, string _valoracionNeu, string _paqueteNeu, string _urgencias,
            string _revaloracionPsiq, string _revaloracionPsic, string _psicoeducacion, string _reposicionCar, string _crianzaPositiva, string _grupoV, string _neuropsiquiatria, string _neuropsicologia, string _total, string _entrego, string _observaciones)
        {
            fecha = _fecha;
            reciboInicial = _ReciboInicial;
            reciboFinal = _reciboFinal;
            psiquiatria = _psiquiatria;
            psicologia = _psicologia;
            valoracionPsiq = _valoracionPsiq;
            valoracionPsic = _valoracionPsic;
            valoracionFam = _valoracionFam;
            valoracionCal = _valoracionCal;
            valoracionNut = _valoracionNut;
            consultaNut = _consultaNut;
            platicaNut = _platicaNut;
            valoracionNeu = _valoracionNeu;
            paqueteNeu = _paqueteNeu;
            urgencias = _urgencias;
            revaloracionPsiq = _revaloracionPsiq;
            revaloracionPsic = _revaloracionPsic;
            psicoeducacion = _psicoeducacion;
            reposicionCar = _reposicionCar;
            crianzaPositiva = _crianzaPositiva;
            grupoV = _grupoV;
            neuropsiquiatria= _neuropsiquiatria;
            neuropsicologia = _neuropsicologia;
            total = _total;
            entrego = _entrego;
            observaciones = _observaciones;

        }

        public string Fecha
        {
            get{return fecha ;}
            set { fecha=value;}
        }
        public string ReciboInicial
        {
            get{return reciboInicial; }
            set { reciboInicial=value;}
        }

        public string ReciboFinal
        {
            get { return reciboFinal; }
            set { reciboFinal = value; }
        }

        public string Psiquiatria
        {
            get { return psiquiatria; }
            set { psiquiatria = value; }
        }

        public string Psicologia
        {
            get { return psicologia; }
            set { psicologia = value; }
        }

        public string ValoracionPsiq
        {
            get { return valoracionPsiq; }
            set { valoracionPsiq = value; }
        }

        public string ValoracionPsic
        {
            get { return valoracionPsic; }
            set { valoracionPsic = value; }
        }

        public string ValoracionFam
        {
            get { return valoracionFam; }
            set { valoracionFam = value; }
        }

        public string ValoracionCal
        {
            get { return valoracionCal; }
            set { valoracionCal = value; }
        }

        public string ValoracionNut
        {
            get { return valoracionNut; }
            set { valoracionNut = value; }
        }

        public string ConsultaNut
        {
            get { return consultaNut; }
            set { consultaNut = value; }
        }

        public string PlaticaNut
        {
            get { return platicaNut; }
            set { platicaNut = value; }
        }

        public string ValoracionNeu
        {
            get { return valoracionNeu; }
            set { valoracionNeu = value; }
        }

        public string PaqueteNeu
        {
            get { return paqueteNeu; }
            set { paqueteNeu = value; }
        }

        public string Urgencias
        {
            get { return urgencias; }
            set { urgencias = value; }
        }

        public string RevaloracionPsiq
        {
            get { return revaloracionPsiq; }
            set { revaloracionPsiq = value; }
        }

        public string RevaloracionPsic
        {
            get { return revaloracionPsic; }
            set { revaloracionPsic = value; }
        }

        public string Psicoeducacion
        {
            get { return psicoeducacion; }
            set { psicoeducacion = value; }
        }

        public string ReposicionCar
        {
            get { return reposicionCar; }
            set { reposicionCar = value; }
        }

        public string CrianzaPositiva
        {
            get { return crianzaPositiva; }
            set { crianzaPositiva = value; }
        }

        public string GrupoV
        {
            get { return grupoV; }
            set { grupoV = value; }
        }

        public string Neuropsiquiatria
        {
            get { return grupoV; }
            set { grupoV = value; }
        }

        public string Neuropsicologia
        {
            get { return neuropsicologia; }
            set { neuropsicologia = value; }
        }


        public string Total
        {
            get { return total; }
            set { total = value; }
        }

        public string Entrego
        {
            get { return entrego; }
            set { entrego = value; }
        }

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

    }
}
