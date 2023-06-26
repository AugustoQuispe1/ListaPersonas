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
	
namespace ListaPersonas
	{
	public partial class Form1 :Form
		{
		NegPersonas objNegPersonas = new NegPersonas();
		public DataTable DT { get; set; } = new DataTable();
		DataSet ds = new DataSet();
		private Persona persona = new Persona();


		public Form1()
			{
			dataGridView1.ColumnCount = 4;
			dataGridView1.Columns[0].HeaderText = "Codigo";
			dataGridView1.Columns[1].HeaderText = "Nombre";
			dataGridView1.Columns[2].HeaderText = "Apellido";
			dataGridView1.Columns[3].HeaderText = "Edad";



			InitializeComponent();
			}
		}
	}
