using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Referenciar Modelos
using Lanco_Project.Models;
//Utilizar clases y objetos de SQL
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Lanco_Project.Data
{
    public class ContactoDatos
    {   // Se guarda en una variable la cadena de conexion almacenada en el archivo Web.config
        string connStr = ConfigurationManager.ConnectionStrings["conndb"].ConnectionString;

        //Definir metodo para obtener la lista de Contactos en la tabla SQL
        //Clase publica y es una lista del modelo previamente creado (ContactoModel) y se le asigna el nombre GetContactoList
        public List<ContactoModel> GetContactoList()
        {
            //Se crea una variable lista oContactoList a partir del modelo ContactoModel y se guadan los valores obtenidos del Modelo
            List<ContactoModel> oContactoList = new List<ContactoModel>();
            //Se hace uso de la cadena de conexion para establecer la conexion
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                //Se define el procedimiento almacenado a ejecutar y como segundo parametro la conexion
                SqlCommand oCmd = new SqlCommand("sp_Listar", oConn);
                //Define el tipo de comando Cmd
                oCmd.CommandType = CommandType.StoredProcedure;
                //Se abre la cadena de conexion
                oConn.Open();
                
                //se ejecuta el comando con el procedimiento almacenado y se leen los valores
                using (SqlDataReader oDr = oCmd.ExecuteReader())
                {   //lee uno a uno los registros
                    while (oDr.Read())
                    {   //con el metodo add añadimos a la variable oContactoList los registros con el modelo ContactoModel
                        oContactoList.Add(new ContactoModel()
                        {   //Se llaman las propiedades a utilizar y se convierten al tipo de dato creado en la DB
                            IdContact = Convert.ToInt32(oDr["IdContacto"]),
                            Name = oDr["Nombre"].ToString(),
                            Phone = oDr["Telefono"].ToString(),
                            Email = oDr["Correo"].ToString()
                        });
                    }
                }
            }
            //Me retorna la lista de contacto con todos los registros obtenidos del procedimiento almacenado el cual es un SELECT
            return oContactoList;
        }

        //Definir metodo para guardar un Contacto en la tabla SQL
        //Case publica que retornara un entero y va a recibir un objeto del ContactModel y se nombra como oRute(se debia cambiar la nomenclatura)
        public int  AddContact(ContactoModel oRoute)
        {   //Se declara una variable de respuesta
            int _iResponse = 0;
            //intenta el codigo
            try
            {   //usar la cadena para crear la conexion
                using (SqlConnection oConn = new SqlConnection(connStr))
                {   //se define el comando cmd a ejecutar con el procedimiento almacenado "sp_Guardar" como segundo parametro la cadena de conexion a usar
                    SqlCommand oCmd = new SqlCommand("sp_Guardar", oConn);
                    //se abre la conexion
                    oConn.Open();
                    //Define el tipo de comando Cmd (Procedimiento Almacenado)
                    oCmd.CommandType = CommandType.StoredProcedure;
                    //Define los parametros a usar del procedimiento almacenado y se envian los valores de oRoute
                    oCmd.Parameters.AddWithValue("Nombre", oRoute.Name);
                    oCmd.Parameters.AddWithValue("Telefono", oRoute.Phone);
                    oCmd.Parameters.AddWithValue("Correo", oRoute.Email);
                    //Ejecutar el procedimiento almacenado sin devolver valores
                    oCmd.ExecuteNonQuery();

                    _iResponse = 1;
                }
            }
            //captura el error
            catch (Exception ex)
            {
                string msg = ex.Message;
                _iResponse = 0;
            }
            //Retorna la variable de respuesta
            return _iResponse;
        }
        public int EditContact(ContactoModel oRoute)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("sp_Editar", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("IdContacto", oRoute.IdContact);
                    oCmd.Parameters.AddWithValue("Nombre ", oRoute.Name);
                    oCmd.Parameters.AddWithValue("Telefono", oRoute.Phone);
                    oCmd.Parameters.AddWithValue("Correo", oRoute.Email);

                    oCmd.ExecuteNonQuery();

                    _iResponse = 1;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                _iResponse = 0;
            }

            return _iResponse;
        }
        public int DeleteContact(int idContacto)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("sp_Eliminar", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("@IdContacto", idContacto);

                    oCmd.ExecuteNonQuery();

                    _iResponse = 1;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                _iResponse = 0;
            }

            return _iResponse;
        }

    }
}