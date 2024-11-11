namespace Capa_Vista_Mantenimiento
{
    partial class Frm_Mantenimiento_Produccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Mantenimiento_Produccion));
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_Desgaste = new System.Windows.Forms.Label();
            this.Lbl_Area = new System.Windows.Forms.Label();
            this.Lbl_Proximo_Mantenimiento = new System.Windows.Forms.Label();
            this.Lbl_Ultimo_Mantenimiento = new System.Windows.Forms.Label();
            this.Lbl_Mantenimiento_Periodico = new System.Windows.Forms.Label();
            this.Lbl_Hora_Operacion = new System.Windows.Forms.Label();
            this.Lbl_Tipo = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Mantenimiento = new System.Windows.Forms.Label();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.Nud_DesgastePorcentaje = new System.Windows.Forms.NumericUpDown();
            this.Cbo_Area = new System.Windows.Forms.ComboBox();
            this.Dtp_ProximoMantenimiento = new System.Windows.Forms.DateTimePicker();
            this.Dtp_UltimaMantenimiento = new System.Windows.Forms.DateTimePicker();
            this.Txt_MantenimientoPeriodico = new System.Windows.Forms.TextBox();
            this.Nud_HoraOperacion = new System.Windows.Forms.NumericUpDown();
            this.Cbo_TipoMaquina = new System.Windows.Forms.ComboBox();
            this.Txt_ID_Maquinaria = new System.Windows.Forms.TextBox();
            this.Dgv_Mantenimientos = new System.Windows.Forms.DataGridView();
            this.btn_Reporte = new System.Windows.Forms.Button();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.cbo_nombre_maquina = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_DesgastePorcentaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_HoraOperacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Mantenimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.Location = new System.Drawing.Point(405, 263);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(53, 17);
            this.Lbl_Estado.TabIndex = 50;
            this.Lbl_Estado.Text = "Estado";
            // 
            // Lbl_Desgaste
            // 
            this.Lbl_Desgaste.AutoSize = true;
            this.Lbl_Desgaste.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Desgaste.Location = new System.Drawing.Point(405, 220);
            this.Lbl_Desgaste.Name = "Lbl_Desgaste";
            this.Lbl_Desgaste.Size = new System.Drawing.Size(160, 17);
            this.Lbl_Desgaste.TabIndex = 49;
            this.Lbl_Desgaste.Text = "Porcentaje de desgaste";
            // 
            // Lbl_Area
            // 
            this.Lbl_Area.AutoSize = true;
            this.Lbl_Area.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Area.Location = new System.Drawing.Point(407, 180);
            this.Lbl_Area.Name = "Lbl_Area";
            this.Lbl_Area.Size = new System.Drawing.Size(40, 17);
            this.Lbl_Area.TabIndex = 48;
            this.Lbl_Area.Text = "Área";
            // 
            // Lbl_Proximo_Mantenimiento
            // 
            this.Lbl_Proximo_Mantenimiento.AutoSize = true;
            this.Lbl_Proximo_Mantenimiento.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Proximo_Mantenimiento.Location = new System.Drawing.Point(407, 140);
            this.Lbl_Proximo_Mantenimiento.Name = "Lbl_Proximo_Mantenimiento";
            this.Lbl_Proximo_Mantenimiento.Size = new System.Drawing.Size(164, 17);
            this.Lbl_Proximo_Mantenimiento.TabIndex = 47;
            this.Lbl_Proximo_Mantenimiento.Text = "Próximo mantenimiento";
            // 
            // Lbl_Ultimo_Mantenimiento
            // 
            this.Lbl_Ultimo_Mantenimiento.AutoSize = true;
            this.Lbl_Ultimo_Mantenimiento.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ultimo_Mantenimiento.Location = new System.Drawing.Point(407, 101);
            this.Lbl_Ultimo_Mantenimiento.Name = "Lbl_Ultimo_Mantenimiento";
            this.Lbl_Ultimo_Mantenimiento.Size = new System.Drawing.Size(153, 17);
            this.Lbl_Ultimo_Mantenimiento.TabIndex = 46;
            this.Lbl_Ultimo_Mantenimiento.Text = "Último mantenimiento";
            // 
            // Lbl_Mantenimiento_Periodico
            // 
            this.Lbl_Mantenimiento_Periodico.AutoSize = true;
            this.Lbl_Mantenimiento_Periodico.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mantenimiento_Periodico.Location = new System.Drawing.Point(36, 264);
            this.Lbl_Mantenimiento_Periodico.Name = "Lbl_Mantenimiento_Periodico";
            this.Lbl_Mantenimiento_Periodico.Size = new System.Drawing.Size(173, 17);
            this.Lbl_Mantenimiento_Periodico.TabIndex = 45;
            this.Lbl_Mantenimiento_Periodico.Text = "Mantenimiento periódico";
            // 
            // Lbl_Hora_Operacion
            // 
            this.Lbl_Hora_Operacion.AutoSize = true;
            this.Lbl_Hora_Operacion.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Hora_Operacion.Location = new System.Drawing.Point(36, 219);
            this.Lbl_Hora_Operacion.Name = "Lbl_Hora_Operacion";
            this.Lbl_Hora_Operacion.Size = new System.Drawing.Size(133, 17);
            this.Lbl_Hora_Operacion.TabIndex = 44;
            this.Lbl_Hora_Operacion.Text = "Hora de Operación";
            // 
            // Lbl_Tipo
            // 
            this.Lbl_Tipo.AutoSize = true;
            this.Lbl_Tipo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tipo.Location = new System.Drawing.Point(36, 181);
            this.Lbl_Tipo.Name = "Lbl_Tipo";
            this.Lbl_Tipo.Size = new System.Drawing.Size(38, 17);
            this.Lbl_Tipo.TabIndex = 43;
            this.Lbl_Tipo.Text = "Tipo";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.Location = new System.Drawing.Point(36, 141);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(61, 17);
            this.Lbl_Nombre.TabIndex = 42;
            this.Lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Mantenimiento
            // 
            this.lbl_Mantenimiento.AutoSize = true;
            this.lbl_Mantenimiento.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mantenimiento.Location = new System.Drawing.Point(36, 102);
            this.lbl_Mantenimiento.Name = "lbl_Mantenimiento";
            this.lbl_Mantenimiento.Size = new System.Drawing.Size(129, 17);
            this.lbl_Mantenimiento.TabIndex = 41;
            this.lbl_Mantenimiento.Text = "ID Mantenimiento";
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Cbo_Estado.Location = new System.Drawing.Point(579, 263);
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(200, 21);
            this.Cbo_Estado.TabIndex = 37;
            // 
            // Nud_DesgastePorcentaje
            // 
            this.Nud_DesgastePorcentaje.Location = new System.Drawing.Point(731, 221);
            this.Nud_DesgastePorcentaje.Name = "Nud_DesgastePorcentaje";
            this.Nud_DesgastePorcentaje.Size = new System.Drawing.Size(48, 20);
            this.Nud_DesgastePorcentaje.TabIndex = 36;
            // 
            // Cbo_Area
            // 
            this.Cbo_Area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Area.FormattingEnabled = true;
            this.Cbo_Area.Location = new System.Drawing.Point(579, 180);
            this.Cbo_Area.Name = "Cbo_Area";
            this.Cbo_Area.Size = new System.Drawing.Size(200, 21);
            this.Cbo_Area.TabIndex = 35;
            // 
            // Dtp_ProximoMantenimiento
            // 
            this.Dtp_ProximoMantenimiento.Location = new System.Drawing.Point(579, 140);
            this.Dtp_ProximoMantenimiento.Name = "Dtp_ProximoMantenimiento";
            this.Dtp_ProximoMantenimiento.Size = new System.Drawing.Size(200, 20);
            this.Dtp_ProximoMantenimiento.TabIndex = 34;
            // 
            // Dtp_UltimaMantenimiento
            // 
            this.Dtp_UltimaMantenimiento.Location = new System.Drawing.Point(579, 101);
            this.Dtp_UltimaMantenimiento.Name = "Dtp_UltimaMantenimiento";
            this.Dtp_UltimaMantenimiento.Size = new System.Drawing.Size(200, 20);
            this.Dtp_UltimaMantenimiento.TabIndex = 33;
            // 
            // Txt_MantenimientoPeriodico
            // 
            this.Txt_MantenimientoPeriodico.Location = new System.Drawing.Point(215, 263);
            this.Txt_MantenimientoPeriodico.Name = "Txt_MantenimientoPeriodico";
            this.Txt_MantenimientoPeriodico.Size = new System.Drawing.Size(148, 20);
            this.Txt_MantenimientoPeriodico.TabIndex = 32;
            // 
            // Nud_HoraOperacion
            // 
            this.Nud_HoraOperacion.Location = new System.Drawing.Point(321, 221);
            this.Nud_HoraOperacion.Name = "Nud_HoraOperacion";
            this.Nud_HoraOperacion.Size = new System.Drawing.Size(42, 20);
            this.Nud_HoraOperacion.TabIndex = 31;
            // 
            // Cbo_TipoMaquina
            // 
            this.Cbo_TipoMaquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_TipoMaquina.FormattingEnabled = true;
            this.Cbo_TipoMaquina.Location = new System.Drawing.Point(215, 180);
            this.Cbo_TipoMaquina.Name = "Cbo_TipoMaquina";
            this.Cbo_TipoMaquina.Size = new System.Drawing.Size(148, 21);
            this.Cbo_TipoMaquina.TabIndex = 30;
            // 
            // Txt_ID_Maquinaria
            // 
            this.Txt_ID_Maquinaria.Location = new System.Drawing.Point(215, 101);
            this.Txt_ID_Maquinaria.Name = "Txt_ID_Maquinaria";
            this.Txt_ID_Maquinaria.ReadOnly = true;
            this.Txt_ID_Maquinaria.Size = new System.Drawing.Size(148, 20);
            this.Txt_ID_Maquinaria.TabIndex = 28;
            // 
            // Dgv_Mantenimientos
            // 
            this.Dgv_Mantenimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Mantenimientos.Location = new System.Drawing.Point(39, 300);
            this.Dgv_Mantenimientos.Name = "Dgv_Mantenimientos";
            this.Dgv_Mantenimientos.Size = new System.Drawing.Size(740, 283);
            this.Dgv_Mantenimientos.TabIndex = 27;
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.btn_Reporte.BackgroundImage = global::Capa_Vista_Mantenimiento.Properties.Resources.reporte;
            this.btn_Reporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Reporte.FlatAppearance.BorderSize = 0;
            this.btn_Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reporte.ForeColor = System.Drawing.Color.Black;
            this.btn_Reporte.Location = new System.Drawing.Point(532, 21);
            this.btn_Reporte.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(63, 55);
            this.btn_Reporte.TabIndex = 53;
            this.btn_Reporte.UseVisualStyleBackColor = false;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.btn_Ayuda.BackgroundImage = global::Capa_Vista_Mantenimiento.Properties.Resources.preguntas;
            this.btn_Ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Ayuda.FlatAppearance.BorderSize = 0;
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ayuda.Location = new System.Drawing.Point(740, 12);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(39, 38);
            this.btn_Ayuda.TabIndex = 52;
            this.btn_Ayuda.UseVisualStyleBackColor = false;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.btn_Nuevo.BackgroundImage = global::Capa_Vista_Mantenimiento.Properties.Resources.agregar_archivo;
            this.btn_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Nuevo.FlatAppearance.BorderSize = 0;
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo.ForeColor = System.Drawing.Color.Black;
            this.btn_Nuevo.Location = new System.Drawing.Point(185, 21);
            this.btn_Nuevo.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(63, 55);
            this.btn_Nuevo.TabIndex = 51;
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.Btn_Eliminar.BackgroundImage = global::Capa_Vista_Mantenimiento.Properties.Resources.borrar__1_;
            this.Btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Location = new System.Drawing.Point(445, 21);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(63, 55);
            this.Btn_Eliminar.TabIndex = 40;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.Btn_Actualizar.BackgroundImage = global::Capa_Vista_Mantenimiento.Properties.Resources.convenio;
            this.Btn_Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Actualizar.Location = new System.Drawing.Point(357, 21);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(63, 55);
            this.Btn_Actualizar.TabIndex = 39;
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.Btn_Agregar.BackgroundImage = global::Capa_Vista_Mantenimiento.Properties.Resources.ahorrar;
            this.Btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Agregar.FlatAppearance.BorderSize = 0;
            this.Btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Agregar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Agregar.Location = new System.Drawing.Point(269, 21);
            this.Btn_Agregar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(63, 55);
            this.Btn_Agregar.TabIndex = 38;
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // cbo_nombre_maquina
            // 
            this.cbo_nombre_maquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nombre_maquina.FormattingEnabled = true;
            this.cbo_nombre_maquina.Location = new System.Drawing.Point(215, 143);
            this.cbo_nombre_maquina.Name = "cbo_nombre_maquina";
            this.cbo_nombre_maquina.Size = new System.Drawing.Size(148, 21);
            this.cbo_nombre_maquina.TabIndex = 54;
            // 
            // Frm_Mantenimiento_Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(812, 602);
            this.Controls.Add(this.cbo_nombre_maquina);
            this.Controls.Add(this.btn_Reporte);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.Lbl_Estado);
            this.Controls.Add(this.Lbl_Desgaste);
            this.Controls.Add(this.Lbl_Area);
            this.Controls.Add(this.Lbl_Proximo_Mantenimiento);
            this.Controls.Add(this.Lbl_Ultimo_Mantenimiento);
            this.Controls.Add(this.Lbl_Mantenimiento_Periodico);
            this.Controls.Add(this.Lbl_Hora_Operacion);
            this.Controls.Add(this.Lbl_Tipo);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.lbl_Mantenimiento);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.Cbo_Estado);
            this.Controls.Add(this.Nud_DesgastePorcentaje);
            this.Controls.Add(this.Cbo_Area);
            this.Controls.Add(this.Dtp_ProximoMantenimiento);
            this.Controls.Add(this.Dtp_UltimaMantenimiento);
            this.Controls.Add(this.Txt_MantenimientoPeriodico);
            this.Controls.Add(this.Nud_HoraOperacion);
            this.Controls.Add(this.Cbo_TipoMaquina);
            this.Controls.Add(this.Txt_ID_Maquinaria);
            this.Controls.Add(this.Dgv_Mantenimientos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Mantenimiento_Produccion";
            this.Text = "Mantenimiento Maquinaria";
            ((System.ComponentModel.ISupportInitialize)(this.Nud_DesgastePorcentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_HoraOperacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Mantenimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_Desgaste;
        private System.Windows.Forms.Label Lbl_Area;
        private System.Windows.Forms.Label Lbl_Proximo_Mantenimiento;
        private System.Windows.Forms.Label Lbl_Ultimo_Mantenimiento;
        private System.Windows.Forms.Label Lbl_Mantenimiento_Periodico;
        private System.Windows.Forms.Label Lbl_Hora_Operacion;
        private System.Windows.Forms.Label Lbl_Tipo;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Label lbl_Mantenimiento;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.NumericUpDown Nud_DesgastePorcentaje;
        private System.Windows.Forms.ComboBox Cbo_Area;
        private System.Windows.Forms.DateTimePicker Dtp_ProximoMantenimiento;
        private System.Windows.Forms.DateTimePicker Dtp_UltimaMantenimiento;
        private System.Windows.Forms.TextBox Txt_MantenimientoPeriodico;
        private System.Windows.Forms.NumericUpDown Nud_HoraOperacion;
        private System.Windows.Forms.ComboBox Cbo_TipoMaquina;
        private System.Windows.Forms.TextBox Txt_ID_Maquinaria;
        private System.Windows.Forms.DataGridView Dgv_Mantenimientos;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_Reporte;
        private System.Windows.Forms.ComboBox cbo_nombre_maquina;
    }
}