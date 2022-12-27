using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CajaCEMISAM.Utilerias
{
    class conbd
    {
        static public OleDbConnection conexion;


        static public void iniciarConexion()
        {
            try
            {
                string StrConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Archivos de programa\FME\CajaCEMISAM\Database\bdcaja.accdb";
                conexion = new OleDbConnection(StrConexion);
                conexion.Open();

            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema de conexion con la base de datos!!\nVerifica que la base de datos este cerrada y exista en el directorio correcto","Error",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
            }


            
        }

        static public void cerrarConexion()
        {
            conexion.Close();
        }
    }
}
