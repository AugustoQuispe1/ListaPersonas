namespace ListaPersonas
	{
	partial class Form1
		{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
			{
			if (disposing && (components != null))
				{
				components.Dispose();
				}
			base.Dispose(disposing);
			}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
			{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblApellido = new System.Windows.Forms.Label();
			this.lblEdad = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.btnCargar = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(42, 94);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(442, 239);
			this.dataGridView1.TabIndex = 0;
			// 
			// lblCodigo
			// 
			this.lblCodigo.AutoSize = true;
			this.lblCodigo.Location = new System.Drawing.Point(536, 120);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(40, 13);
			this.lblCodigo.TabIndex = 1;
			this.lblCodigo.Text = "Codigo";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(581, 120);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 2;
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(536, 162);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(44, 13);
			this.lblNombre.TabIndex = 3;
			this.lblNombre.Text = "Nombre";
			// 
			// lblApellido
			// 
			this.lblApellido.AutoSize = true;
			this.lblApellido.Location = new System.Drawing.Point(536, 203);
			this.lblApellido.Name = "lblApellido";
			this.lblApellido.Size = new System.Drawing.Size(44, 13);
			this.lblApellido.TabIndex = 4;
			this.lblApellido.Text = "Apellido";
			// 
			// lblEdad
			// 
			this.lblEdad.AutoSize = true;
			this.lblEdad.Location = new System.Drawing.Point(536, 243);
			this.lblEdad.Name = "lblEdad";
			this.lblEdad.Size = new System.Drawing.Size(32, 13);
			this.lblEdad.TabIndex = 5;
			this.lblEdad.Text = "Edad";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(581, 159);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(581, 200);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 7;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(581, 240);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 8;
			// 
			// btnCargar
			// 
			this.btnCargar.Location = new System.Drawing.Point(581, 295);
			this.btnCargar.Name = "btnCargar";
			this.btnCargar.Size = new System.Drawing.Size(75, 23);
			this.btnCargar.TabIndex = 9;
			this.btnCargar.Text = "Cargar";
			this.btnCargar.UseVisualStyleBackColor = true;
			// 
			// btnBorrar
			// 
			this.btnBorrar.Location = new System.Drawing.Point(581, 344);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(75, 23);
			this.btnBorrar.TabIndex = 10;
			this.btnBorrar.Text = "Borrar";
			this.btnBorrar.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.btnCargar);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.lblEdad);
			this.Controls.Add(this.lblApellido);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblCodigo);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblApellido;
		private System.Windows.Forms.Label lblEdad;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button btnCargar;
		private System.Windows.Forms.Button btnBorrar;
		}
	}

