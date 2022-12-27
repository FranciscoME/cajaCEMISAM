using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CajaCEMISAM
{
    class Pacientes
    {
        private int noExp;
        private string nombre;
        private string domicilio;
        private short nivel;

        public Pacientes(int _noExp, string _nombre, string _domicilio, short _nivel)
        {
            noExp = _noExp;
            nombre = _nombre;
            domicilio = _domicilio;
            nivel = _nivel;
        }

        public int NoExp
        {
            get 
            { 
                return noExp; 
            }
            set 
            {
                if (noExp > 0)
                   noExp = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Domicilio
        {
            get
            {
                return domicilio;
            }
            set
            {
                domicilio = value;
            }
        }

        public short Nivel
        {
            get
            {
                return nivel;
            }
            set
            {
                if (nivel > 0)
                    nivel = value;
            }
        }

        public override string ToString()
        {
            return string.Format("No expediente: {0}, nombre: {1}", NoExp, nombre);
        }

    }
}
