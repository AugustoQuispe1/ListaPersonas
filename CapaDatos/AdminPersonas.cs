﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Entidades;

namespace CapaDatos
	{
	public class AdminPersonas : DatosConexion
		{
		public int abmPersonas(string accion, Persona objPersona)
			{
			int resultado = -1;
			string orden = string.Empty;

			if (accion == "Alta")
			{
				orden = "INSERT INTO Personas VALUES ('" + objPersona.Codigo + "','" + objPersona.Nombre + "','" + objPersona.Apellido + "','" + objPersona.Edad + "');";
			}


			if (accion == "Borrar")
			{
				orden = "DELETE FROM Personas WHERE Codigo='" + objPersona.Codigo + "';";
			}



			OleDbCommand cmd = new OleDbCommand(orden, conexion);
			try
			{
				Abrirconexion();
				resultado = cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				throw new Exception("Error al tratar de guardar o borrar los datos", e);
			}
			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
			return resultado;
			
			}

		public DataSet listadoAutos(string cual)
			{
			string orden = string.Empty;
			if (cual != "Todos")
				{
				orden = "SELECT * FROM Personas WHERE Codigo = " + cual + ";";
				}

			else
				{
				orden = "select * from Personas;";
				}

			OleDbCommand cmd = new OleDbCommand(orden, conexion);
			DataSet ds = new DataSet();
			OleDbDataAdapter da = new OleDbDataAdapter();
			try
				{
				Abrirconexion();
				cmd.ExecuteNonQuery();
				da.SelectCommand = cmd;
				da.Fill(ds);
				}
			catch (Exception e)
				{
				throw new Exception("Error al listar Personas", e);
				}
			finally
				{
				Cerrarconexion();
				cmd.Dispose();
				}
			return ds;
			}
		}
	}
