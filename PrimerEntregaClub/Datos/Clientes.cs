using PrimerEntregaClub.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEntregaClub.Datos
{
    internal class Clientes
    {
        public string Nuevo_Cliente(E_Cliente client)
        {
            string salida; //usamos esta variable para conocer con que n° fue registrado el nuevo ingreso
            //esa variable también nos permite conocer si los datos ingresados ya existen en la tabla
            //(si existen la variable toma el valor 1)


            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoCliente", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = client.NombreC;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = client.ApellidoC;
                comando.Parameters.Add("TipoDoc", MySqlDbType.VarChar).Value = client.TDocC;
                comando.Parameters.Add("Doc", MySqlDbType.VarChar).Value = client.DocC;
                comando.Parameters.Add("FechaNac", MySqlDbType.DateTime).Value = client.FechaNacC;
                comando.Parameters.Add("Tel", MySqlDbType.VarChar).Value = client.TelC;
                comando.Parameters.Add("Domicilio", MySqlDbType.VarChar).Value = client.DomicilioC;
                comando.Parameters.Add("Email", MySqlDbType.VarChar).Value = client.EmailC;
                comando.Parameters.Add("EsSocio", MySqlDbType.Int32).Value = client.EsSocio ? 1 : 0;


                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                                
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            //como proceso final
            
            finally 
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            return salida;
        }
    }
}
