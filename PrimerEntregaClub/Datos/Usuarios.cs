﻿using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PrimerEntregaClub.Datos
{
    internal class Usuarios
    {
        //creamos un método que retorne una tabla con la info
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {
            MySqlDataReader resultado; //variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                //elcomando es un elemento que almacena en este caso, el nombre
                //del procedimiento almacenado y la referencia a la conexion
                MySqlCommand comando = new MySqlCommand
                    ("IngresoLogin", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;
                //definimos los parámetros que tiene el procedure

                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_Usu;
                //abrimos la conexion
                sqlCon.Open();
                resultado = comando.ExecuteReader();//almacenamos el resultado en la variable
                tabla.Load(resultado); //Cargamos la tabla con el resultado

                return tabla;
                //de esta forma esta asociado el metodo con el procedure que esta almacenado en MySQL
            }
            catch (Exception ex)
            {
                throw;
            }
            //como proceso final

            finally 
            {
                if(sqlCon.State==ConnectionState.Open)
                {sqlCon.Close();};
            }
            
        }
    }
}

