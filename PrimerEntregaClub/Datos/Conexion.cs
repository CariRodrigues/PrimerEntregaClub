using MySql.Data.MySqlClient; //referencia a mysql
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimerEntregaClub.Datos
{
    public class Conexion //debe ser pública
    {
        //declaramos las variables
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion() //asignamos valores a las variables de la conexión
        {
            this.baseDatos = "Proyecto";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "holamundo34";
        }

        //proceso de interacción

        public MySqlConnection CrearConexion()
        {
            //instanciamos una conexion
            MySqlConnection? cadena = new MySqlConnection();

            //bloque try para controlar errores
            try 
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                                          ";port=" + this.puerto +
                                          ";username=" + this.usuario +
                                          ";password=" + this.clave +
                                          ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }
        //para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if (con == null) //quiere decir que la conexion está cerrada
            {
                con = new Conexion();// se crea una nueva
            }
            return con;
        }

    }
}
