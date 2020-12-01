namespace Presentacion1
{
    partial class Consultar
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
            this.tablaDePulsaciones = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDePulsaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaDePulsaciones
            // 
            this.tablaDePulsaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDePulsaciones.Location = new System.Drawing.Point(23, 68);
            this.tablaDePulsaciones.Margin = new System.Windows.Forms.Padding(1);
            this.tablaDePulsaciones.MultiSelect = false;
            this.tablaDePulsaciones.Name = "tablaDePulsaciones";
            this.tablaDePulsaciones.RowHeadersWidth = 102;
            this.tablaDePulsaciones.RowTemplate.Height = 40;
            this.tablaDePulsaciones.Size = new System.Drawing.Size(632, 262);
            this.tablaDePulsaciones.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(17, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 32);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tabla de Pulsaciones";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion1.Properties.Resources.COLOURlovers_com_Steel_Trap_Closed;
            this.ClientSize = new System.Drawing.Size(677, 443);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tablaDePulsaciones);
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDePulsaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaDePulsaciones;
        private System.Windows.Forms.Label label6;
    }
}