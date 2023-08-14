using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Entidades;
using CapaNegocios;
using System.Diagnostics.Eventing.Reader;

namespace ListaPersonas
	{
	public partial class Form1 :Form
		{
        //NegPersonas objNegPersonas = new NegPersonas();
        NegPersonas objNegPersonas = new NegPersonas();
        //public DataTable DT { get; set; } = new DataTable();
        DataSet ds = new DataSet();
		private Persona persona = new Persona();


		public Form1()
			{
		
			//CrearDGV();
			InitializeComponent();
            //DataGridView dataGridView1 = new DataGridView();
			dataGridView1.Columns.Add("0", "Codigo");
			dataGridView1.Columns.Add("1", "Nombre");
			dataGridView1.Columns.Add("2", "Apellido");
			dataGridView1.Columns.Add("3", "Edad");

			dataGridView1.Columns[0].Width = 100;
			dataGridView1.Columns[1].Width = 100;
			dataGridView1.Columns[2].Width = 100;
			dataGridView1.Columns[3].Width = 60;
            LlenarDGV();

            }

		private void btnCargar_Click(object sender, EventArgs e)
			{
			int nGrabados = -1;
			CargarPersonas();



			nGrabados = objNegPersonas.abmPersonas("Alta", persona);
			if (nGrabados == -1)
				{
				MessageBox.Show("No se pudo grabar la persona en el sistema");
				}
			else
				{
				MessageBox.Show("Se pudo grabar la persona en el sistema con exito");
				LlenarDGV();


				}
			}

		public void limpiarpantalla()
			{
			textBox1.Text = string.Empty;
			textBox2.Text = string.Empty;
			textBox3.Text = string.Empty;
			textBox4.Text = string.Empty;

			}

		private void CargarPersonas()
			{
			persona.Codigo = Convert.ToInt32(textBox1.Text);
			persona.Nombre = textBox2.Text;
			persona.Apellido = textBox3.Text;
			persona.Edad = Convert.ToInt32(textBox4.Text);
			}
		
		





		
		private void LlenarDGV()
			{
			//dataGridView1.Rows.Clear();
			DataSet ds = new DataSet();
			ds = objNegPersonas.listadoAutos("Todos");
			

			if (ds.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow dr in ds.Tables[0].Rows)
					{
					dataGridView1.Rows.Add(dr[0]?.ToString() ?? "", dr[1], dr[2], dr[3]?.ToString() ?? "");
					limpiarpantalla();
					}
				}
			else
				MessageBox.Show("No hay personas cargadas en el sistema");
			}

		

		private void btnBorrar_Click(object sender, EventArgs e)
			{
			int nGrabados = -1;
			nGrabados = objNegPersonas.abmPersonas("Borrar", persona);
			dataGridView1.Rows.Clear();
			LlenarDGV();
			MessageBox.Show("Se elimino el registro con exito");

			}
		}	}
