
namespace Capa_Vista_Ordenes
{
    partial class Frm_Ordenes_De_Produccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ordenes_De_Produccion));
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Fecha_Fin = new System.Windows.Forms.Label();
            this.lbl_Fecha_Inicio = new System.Windows.Forms.Label();
            this.lbl_A = new System.Windows.Forms.Label();
            this.btn_agregar_producto = new System.Windows.Forms.Button();
            this.dgv_detalle_orden = new System.Windows.Forms.DataGridView();
            this.dtp_buscar_fin = new System.Windows.Forms.DateTimePicker();
            this.dtp_buscar_inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.cbo_producto = new System.Windows.Forms.ComboBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.lbl_estado_orden = new System.Windows.Forms.Label();
            this.lbl_id_orden = new System.Windows.Forms.Label();
            this.cbo_estado_orden = new System.Windows.Forms.ComboBox();
            this.txt_id_orden = new System.Windows.Forms.TextBox();
            this.dgv_ordenes = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_Reporte = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_orden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordenes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(403, 10);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(201, 22);
            this.lbl_Titulo.TabIndex = 54;
            this.lbl_Titulo.Text = "Órdenes de Producción";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Fecha_Fin
            // 
            this.lbl_Fecha_Fin.AutoSize = true;
            this.lbl_Fecha_Fin.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha_Fin.Location = new System.Drawing.Point(831, 102);
            this.lbl_Fecha_Fin.Name = "lbl_Fecha_Fin";
            this.lbl_Fecha_Fin.Size = new System.Drawing.Size(52, 14);
            this.lbl_Fecha_Fin.TabIndex = 53;
            this.lbl_Fecha_Fin.Text = "Fecha Fin";
            // 
            // lbl_Fecha_Inicio
            // 
            this.lbl_Fecha_Inicio.AutoSize = true;
            this.lbl_Fecha_Inicio.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha_Inicio.Location = new System.Drawing.Point(587, 102);
            this.lbl_Fecha_Inicio.Name = "lbl_Fecha_Inicio";
            this.lbl_Fecha_Inicio.Size = new System.Drawing.Size(64, 14);
            this.lbl_Fecha_Inicio.TabIndex = 52;
            this.lbl_Fecha_Inicio.Text = "Fecha Inicio";
            // 
            // lbl_A
            // 
            this.lbl_A.AutoSize = true;
            this.lbl_A.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_A.Location = new System.Drawing.Point(737, 124);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(15, 14);
            this.lbl_A.TabIndex = 51;
            this.lbl_A.Text = "A";
            // 
            // btn_agregar_producto
            // 
            this.btn_agregar_producto.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_producto.Location = new System.Drawing.Point(187, 187);
            this.btn_agregar_producto.Name = "btn_agregar_producto";
            this.btn_agregar_producto.Size = new System.Drawing.Size(150, 23);
            this.btn_agregar_producto.TabIndex = 49;
            this.btn_agregar_producto.Text = "Añadir producto a la orden";
            this.btn_agregar_producto.UseVisualStyleBackColor = true;
            this.btn_agregar_producto.Click += new System.EventHandler(this.btn_agregar_producto_Click);
            // 
            // dgv_detalle_orden
            // 
            this.dgv_detalle_orden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_detalle_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle_orden.Location = new System.Drawing.Point(550, 363);
            this.dgv_detalle_orden.Name = "dgv_detalle_orden";
            this.dgv_detalle_orden.Size = new System.Drawing.Size(546, 263);
            this.dgv_detalle_orden.TabIndex = 48;
            // 
            // dtp_buscar_fin
            // 
            this.dtp_buscar_fin.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_buscar_fin.Location = new System.Drawing.Point(757, 118);
            this.dtp_buscar_fin.Name = "dtp_buscar_fin";
            this.dtp_buscar_fin.Size = new System.Drawing.Size(222, 20);
            this.dtp_buscar_fin.TabIndex = 47;
            // 
            // dtp_buscar_inicio
            // 
            this.dtp_buscar_inicio.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_buscar_inicio.Location = new System.Drawing.Point(509, 118);
            this.dtp_buscar_inicio.Name = "dtp_buscar_inicio";
            this.dtp_buscar_inicio.Size = new System.Drawing.Size(222, 20);
            this.dtp_buscar_inicio.TabIndex = 46;
            // 
            // dtp_fecha_fin
            // 
            this.dtp_fecha_fin.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_fin.Location = new System.Drawing.Point(60, 318);
            this.dtp_fecha_fin.Name = "dtp_fecha_fin";
            this.dtp_fecha_fin.Size = new System.Drawing.Size(222, 20);
            this.dtp_fecha_fin.TabIndex = 45;
            // 
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(60, 281);
            this.dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            this.dtp_fecha_inicio.Size = new System.Drawing.Size(222, 20);
            this.dtp_fecha_inicio.TabIndex = 44;
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.Location = new System.Drawing.Point(5, 192);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(49, 14);
            this.lbl_producto.TabIndex = 43;
            this.lbl_producto.Text = "Producto";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(5, 222);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(47, 14);
            this.lbl_cantidad.TabIndex = 42;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // cbo_producto
            // 
            this.cbo_producto.DisplayMember = "nombreProducto";
            this.cbo_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_producto.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_producto.FormattingEnabled = true;
            this.cbo_producto.Location = new System.Drawing.Point(60, 189);
            this.cbo_producto.Name = "cbo_producto";
            this.cbo_producto.Size = new System.Drawing.Size(121, 22);
            this.cbo_producto.TabIndex = 41;
            this.cbo_producto.ValueMember = "Pk_id_producto";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(60, 219);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 40;
            // 
            // lbl_estado_orden
            // 
            this.lbl_estado_orden.AutoSize = true;
            this.lbl_estado_orden.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado_orden.Location = new System.Drawing.Point(5, 248);
            this.lbl_estado_orden.Name = "lbl_estado_orden";
            this.lbl_estado_orden.Size = new System.Drawing.Size(38, 14);
            this.lbl_estado_orden.TabIndex = 39;
            this.lbl_estado_orden.Text = "Estado";
            // 
            // lbl_id_orden
            // 
            this.lbl_id_orden.AutoSize = true;
            this.lbl_id_orden.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_orden.Location = new System.Drawing.Point(36, 166);
            this.lbl_id_orden.Name = "lbl_id_orden";
            this.lbl_id_orden.Size = new System.Drawing.Size(19, 14);
            this.lbl_id_orden.TabIndex = 38;
            this.lbl_id_orden.Text = "ID";
            // 
            // cbo_estado_orden
            // 
            this.cbo_estado_orden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_estado_orden.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_estado_orden.FormattingEnabled = true;
            this.cbo_estado_orden.Location = new System.Drawing.Point(60, 245);
            this.cbo_estado_orden.Name = "cbo_estado_orden";
            this.cbo_estado_orden.Size = new System.Drawing.Size(121, 22);
            this.cbo_estado_orden.TabIndex = 33;
            // 
            // txt_id_orden
            // 
            this.txt_id_orden.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_orden.Location = new System.Drawing.Point(60, 163);
            this.txt_id_orden.Name = "txt_id_orden";
            this.txt_id_orden.Size = new System.Drawing.Size(100, 20);
            this.txt_id_orden.TabIndex = 32;
            // 
            // dgv_ordenes
            // 
            this.dgv_ordenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ordenes.Location = new System.Drawing.Point(-2, 363);
            this.dgv_ordenes.Name = "dgv_ordenes";
            this.dgv_ordenes.Size = new System.Drawing.Size(546, 263);
            this.dgv_ordenes.TabIndex = 31;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_Cancelar.BackgroundImage = global::Capa_Vista_Ordenes.Properties.Resources.CANCELAR_V4;
            this.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Location = new System.Drawing.Point(255, 86);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(64, 65);
            this.btn_Cancelar.TabIndex = 57;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_Ayuda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_Ayuda.FlatAppearance.BorderSize = 0;
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(1048, 10);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(48, 45);
            this.btn_Ayuda.TabIndex = 56;
            this.btn_Ayuda.UseVisualStyleBackColor = false;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_Reporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_Reporte.FlatAppearance.BorderSize = 0;
            this.btn_Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reporte.Image")));
            this.btn_Reporte.Location = new System.Drawing.Point(8, 10);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(75, 65);
            this.btn_Reporte.TabIndex = 55;
            this.btn_Reporte.UseVisualStyleBackColor = false;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_Salir.BackgroundImage = global::Capa_Vista_Ordenes.Properties.Resources.SALIR_V4;
            this.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Location = new System.Drawing.Point(1034, 86);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(62, 65);
            this.btn_Salir.TabIndex = 50;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_buscar.BackgroundImage = global::Capa_Vista_Ordenes.Properties.Resources.BUCAR_V4;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_buscar.Location = new System.Drawing.Point(437, 98);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(66, 65);
            this.btn_buscar.TabIndex = 37;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_eliminar.BackgroundImage = global::Capa_Vista_Ordenes.Properties.Resources.BORRAR_V4;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Location = new System.Drawing.Point(176, 86);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(64, 65);
            this.btn_eliminar.TabIndex = 36;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_actualizar.BackgroundImage = global::Capa_Vista_Ordenes.Properties.Resources.ACTUALIZAR_V4;
            this.btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Location = new System.Drawing.Point(98, 86);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(62, 65);
            this.btn_actualizar.TabIndex = 35;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_agregar.BackgroundImage = global::Capa_Vista_Ordenes.Properties.Resources.INGRESAR_V4;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Location = new System.Drawing.Point(22, 86);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(61, 65);
            this.btn_agregar.TabIndex = 34;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // Frm_Ordenes_De_Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1102, 637);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.btn_Reporte);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.lbl_Fecha_Fin);
            this.Controls.Add(this.lbl_Fecha_Inicio);
            this.Controls.Add(this.lbl_A);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_agregar_producto);
            this.Controls.Add(this.dgv_detalle_orden);
            this.Controls.Add(this.dtp_buscar_fin);
            this.Controls.Add(this.dtp_buscar_inicio);
            this.Controls.Add(this.dtp_fecha_fin);
            this.Controls.Add(this.dtp_fecha_inicio);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.cbo_producto);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.lbl_estado_orden);
            this.Controls.Add(this.lbl_id_orden);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.cbo_estado_orden);
            this.Controls.Add(this.txt_id_orden);
            this.Controls.Add(this.dgv_ordenes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Ordenes_De_Produccion";
            this.Text = "Órdenes de Producción";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_orden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Fecha_Fin;
        private System.Windows.Forms.Label lbl_Fecha_Inicio;
        private System.Windows.Forms.Label lbl_A;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_agregar_producto;
        private System.Windows.Forms.DataGridView dgv_detalle_orden;
        private System.Windows.Forms.DateTimePicker dtp_buscar_fin;
        private System.Windows.Forms.DateTimePicker dtp_buscar_inicio;
        private System.Windows.Forms.DateTimePicker dtp_fecha_fin;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.ComboBox cbo_producto;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label lbl_estado_orden;
        private System.Windows.Forms.Label lbl_id_orden;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ComboBox cbo_estado_orden;
        private System.Windows.Forms.TextBox txt_id_orden;
        private System.Windows.Forms.DataGridView dgv_ordenes;
        private System.Windows.Forms.Button btn_Reporte;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}