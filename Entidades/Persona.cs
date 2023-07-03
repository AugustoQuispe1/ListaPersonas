using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
	{
	public class Persona
		{
		//atributos
		public int Codigo { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public int Edad { get; set; }
		public DataTable DT { get; set; } = new DataTable();


		public bool CargarPersonas(Persona personas)
			{
			bool res = false;
			if (!Validar(personas))
				{

				DT.Rows.Add();
				int i = DT.Rows.Count - 1;

				DT.Rows[i]["Codigo"] = Codigo;
				DT.Rows[i]["Nombre"] = Nombre;
				DT.Rows[i]["Apellido"] = Apellido;
				DT.Rows[i]["Edad"] = Edad;

				DT.WriteXml("Autos.xml");

				res = true;
				}
			return res;
			}

		private bool Validar(Persona personas)
			{
			bool res = false;
			int fila = BuscarFilaPersonas(Nombre);

			if (fila != -1)
				{
				res = true;
				}

			return res;
			}

		public int BuscarFilaPersonas(string pers)
			{
			int fila = -1;

			for (int i = 0; i < DT.Rows.Count; i++)
				{
				if (DT.Rows[i]["Nombre"].ToString() == pers)
					{
					fila = i;
					break;
					}
				}
			return fila;













			}
		}
	}
