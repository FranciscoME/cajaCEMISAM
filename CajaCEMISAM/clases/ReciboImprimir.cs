using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CajaCEMISAM.clases
{
    public class ReciboImprimir
    {
         string id;
         string fecha;
         string noExpediente;
         string nombre;
         string direccion;
         string ser1;
         string ser2;
         string ser3;
         string total;
         string nivel;
         string cantLetra;

         public ReciboImprimir(string _id,string _fecha, string _noExpediente, string _nombre, string _direccion, string _ser1, string _ser2, string _ser3, string _total, string _nivel, string _cantLetra)
         {
             id = _id;
             fecha = _fecha;
             noExpediente = _noExpediente;
             nombre = _nombre;
             direccion = _direccion;
             ser1 = _ser1;
             ser2 = _ser2;
             ser3 = _ser3;
             total = _total;
             nivel = _nivel;
             cantLetra = _cantLetra;
         }

         public string Id
         {
             get { return id; }
             set { id = value; }
         }
         public string Fecha
         {
             get { return fecha; }
             set { fecha = value; }
         }
         public string NoExpediente
         {
             get { return noExpediente; }
             set { noExpediente = value; }
         }
         public string Nombre
         {
             get { return nombre; }
             set { nombre = value; }
         }
         public string Direccion
         {
             get { return direccion; }
             set { direccion = value; }
         }
         public string Ser1
         {
             get { return ser1; }
             set { ser1 = value; }
         }
         public string Ser2
         {
             get { return ser2; }
             set { ser2 = value; }
         }
         public string Ser3
         {
             get { return ser3; }
             set { ser3 = value; }
         }
         public string Total
         {
             get { return total; }
             set { total = value; }
         }
         public string Nivel
         {
             get { return nivel; }
             set { nivel = value; }
         }
         public string CantLetra
         {
             get { return cantLetra; }
             set { cantLetra = value; }
         }
    }
}
