using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CajaCEMISAM.clases
{
    class Recibos
    {
        DateTime fecha;
        string serv1;
        string serv2;
        string serv3;
        int cser1;
        int cser2;
        int cser3;
        int cantidad;
        int noExpediente;

        public Recibos(DateTime _fecha, string _serv1, string _serv2, string _serv3, int _cser1,int _cser2, int _cser3, int _cantidad, int _noExpediente)
        {
            fecha = _fecha;
            serv1 = _serv1;
            serv2 = _serv2;
            serv3 = _serv3;
            cser1 = _cser1;
            cser2 = _cser2;
            cser3 = _cser3;
            cantidad = _cantidad;
            noExpediente = _noExpediente;
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }

        public string Serv1
        {
            get
            {
                return serv1;
            }
            set
            {
                serv1 = value;
            }
        }

        public string Serv2
        {
            get
            {
                return serv2;
            }
            set
            {
                serv2 = value;
            }
        }

        public string Serv3
        {
            get
            {
                return serv3;
            }
            set
            {
                serv3 = value;
            }
        }

        public int Cserv1
        {
            get
            {
                return cser1;
            }
            set
            {
                cser1 = value;
            }
        }

        public int Cserv2
        {
            get
            {
                return cser2;
            }
            set
            {
                cser2 = value;
            }
        }

        public int Cserv3
        {
            get
            {
                return cser3;
            }
            set
            {
                cser3 = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad = value;
            }
        }

        public int NoExpediente
        {
            get
            {
                return noExpediente;
            }
            set
            {
                noExpediente = value;
            }
        }
    }
}
