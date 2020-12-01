namespace Presentacion1
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConsultarTodos = new System.Windows.Forms.Button();
            this.labelMostrarPulsacion = new System.Windows.Forms.Label();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.labelPulsacion = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelCedula = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelTituloInicio = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonConsultarTodos
            // 
            this.buttonConsultarTodos.Location = new System.Drawing.Point(60, 299);
            this.buttonConsultarTodos.Name = "buttonConsultarTodos";
            this.buttonConsultarTodos.Size = new System.Drawing.Size(107, 23);
            this.buttonConsultarTodos.TabIndex = 31;
            this.buttonConsultarTodos.Text = "Consultar Todos";
            this.buttonConsultarTodos.UseVisualStyleBackColor = true;
            this.buttonConsultarTodos.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelMostrarPulsacion
            // 
            this.labelMostrarPulsacion.AutoSize = true;
            this.labelMostrarPulsacion.BackColor = System.Drawing.Color.Silver;
            this.labelMostrarPulsacion.ForeColor = System.Drawing.Color.Black;
            this.labelMostrarPulsacion.Location = new System.Drawing.Point(154, 258);
            this.labelMostrarPulsacion.Name = "labelMostrarPulsacion";
            this.labelMostrarPulsacion.Size = new System.Drawing.Size(13, 13);
            this.labelMostrarPulsacion.TabIndex = 27;
            this.labelMostrarPulsacion.Text = "0";
            // 
            // TxtEdad
            // 
            this.TxtEdad.BackColor = System.Drawing.Color.Silver;
            this.TxtEdad.Location = new System.Drawing.Point(157, 218);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(137, 20);
            this.TxtEdad.TabIndex = 26;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.Silver;
            this.TxtNombre.Location = new System.Drawing.Point(156, 154);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(137, 20);
            this.TxtNombre.TabIndex = 24;
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(187, 299);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(107, 23);
            this.botonGuardar.TabIndex = 23;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
            // 
            // TxtCedula
            // 
            this.TxtCedula.BackColor = System.Drawing.Color.Silver;
            this.TxtCedula.Location = new System.Drawing.Point(157, 118);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(137, 20);
            this.TxtCedula.TabIndex = 22;
            // 
            // labelPulsacion
            // 
            this.labelPulsacion.AutoSize = true;
            this.labelPulsacion.BackColor = System.Drawing.Color.Silver;
            this.labelPulsacion.ForeColor = System.Drawing.Color.Black;
            this.labelPulsacion.Location = new System.Drawing.Point(73, 257);
            this.labelPulsacion.Name = "labelPulsacion";
            this.labelPulsacion.Size = new System.Drawing.Size(53, 13);
            this.labelPulsacion.TabIndex = 21;
            this.labelPulsacion.Text = "Pulsacion";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.BackColor = System.Drawing.Color.Silver;
            this.labelEdad.ForeColor = System.Drawing.Color.Black;
            this.labelEdad.Location = new System.Drawing.Point(73, 221);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(32, 13);
            this.labelEdad.TabIndex = 20;
            this.labelEdad.Text = "Edad";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.BackColor = System.Drawing.Color.Silver;
            this.labelSexo.ForeColor = System.Drawing.Color.Black;
            this.labelSexo.Location = new System.Drawing.Point(73, 189);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(31, 13);
            this.labelSexo.TabIndex = 19;
            this.labelSexo.Text = "Sexo";
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.BackColor = System.Drawing.Color.Silver;
            this.labelCedula.ForeColor = System.Drawing.Color.Black;
            this.labelCedula.Location = new System.Drawing.Point(73, 125);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(40, 13);
            this.labelCedula.TabIndex = 18;
            this.labelCedula.Text = "Cedula";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Silver;
            this.labelNombre.ForeColor = System.Drawing.Color.Black;
            this.labelNombre.Location = new System.Drawing.Point(73, 157);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 17;
            this.labelNombre.Text = "Nombre";
            // 
            // labelTituloInicio
            // 
            this.labelTituloInicio.AutoSize = true;
            this.labelTituloInicio.BackColor = System.Drawing.Color.Silver;
            this.labelTituloInicio.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloInicio.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelTituloInicio.Location = new System.Drawing.Point(85, 49);
            this.labelTituloInicio.Name = "labelTituloInicio";
            this.labelTituloInicio.Size = new System.Drawing.Size(184, 32);
            this.labelTituloInicio.TabIndex = 32;
            this.labelTituloInicio.Text = "Pulsaciones";
            this.labelTituloInicio.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(187, 328);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(107, 23);
            this.buttonBuscar.TabIndex = 33;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(60, 328);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(107, 23);
            this.buttonEliminar.TabIndex = 34;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // comboSexo
            // 
            this.comboSexo.BackColor = System.Drawing.Color.Silver;
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboSexo.Location = new System.Drawing.Point(157, 190);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(136, 21);
            this.comboSexo.TabIndex = 35;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion1.Properties.Resources.COLOURlovers_com_Steel_Trap_Closed;
            this.ClientSize = new System.Drawing.Size(362, 385);
            this.Controls.Add(this.comboSexo);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.labelTituloInicio);
            this.Controls.Add(this.buttonConsultarTodos);
            this.Controls.Add(this.labelMostrarPulsacion);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.labelPulsacion);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.labelCedula);
            this.Controls.Add(this.labelNombre);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConsultarTodos;
        private System.Windows.Forms.Label labelMostrarPulsacion;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label labelPulsacion;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTituloInicio;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.ComboBox comboSexo;
    }
}

