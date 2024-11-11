
namespace Capa_Vista_Sistema_Produccion
{
    partial class Frm_Sistema_Produccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Sistema_Produccion));
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Id_Proceso = new System.Windows.Forms.Label();
            this.txt_idProceso = new System.Windows.Forms.TextBox();
            this.lbl_receta = new System.Windows.Forms.Label();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.lbl_proceso_detalle = new System.Windows.Forms.Label();
            this.txt_idProcesoDetalle = new System.Windows.Forms.TextBox();
            this.lbl_costo_agua = new System.Windows.Forms.Label();
            this.lbl_costo_luz = new System.Windows.Forms.Label();
            this.lbl_mano_obra = new System.Windows.Forms.Label();
            this.lbl_duracion = new System.Windows.Forms.Label();
            this.lbl_costo_total = new System.Windows.Forms.Label();
            this.lbl_Costo_unitario = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_empleado = new System.Windows.Forms.Label();
            this.lbl_Maquinaria = new System.Windows.Forms.Label();
            this.lbl_Orden = new System.Windows.Forms.Label();
            this.txt_costo_agua = new System.Windows.Forms.TextBox();
            this.txt_costo_luz = new System.Windows.Forms.TextBox();
            this.txt_mano_obra = new System.Windows.Forms.TextBox();
            this.nud_duracion_horas = new System.Windows.Forms.NumericUpDown();
            this.txt_costo_t = new System.Windows.Forms.TextBox();
            this.txt_costo_u = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.cbo_empleado = new System.Windows.Forms.ComboBox();
            this.dgv_detalle_orden = new System.Windows.Forms.DataGridView();
            this.cbo_maquinaria = new System.Windows.Forms.ComboBox();
            this.cbo_orden = new System.Windows.Forms.ComboBox();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_asignar = new System.Windows.Forms.Button();
            this.btn_Reporte = new System.Windows.Forms.Button();
            this.gpb_Orden = new System.Windows.Forms.GroupBox();
            this.gpb_Costos = new System.Windows.Forms.GroupBox();
            this.txt_idReceta = new System.Windows.Forms.TextBox();
            this.txt_idProducto = new System.Windows.Forms.TextBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_duracion_horas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_orden)).BeginInit();
            this.gpb_Orden.SuspendLayout();
            this.gpb_Costos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(336, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(263, 31);
            this.lbl_Titulo.TabIndex = 63;
            this.lbl_Titulo.Text = "Sistema de Producción";
            // 
            // lbl_Id_Proceso
            // 
            this.lbl_Id_Proceso.AutoSize = true;
            this.lbl_Id_Proceso.Location = new System.Drawing.Point(29, 110);
            this.lbl_Id_Proceso.Name = "lbl_Id_Proceso";
            this.lbl_Id_Proceso.Size = new System.Drawing.Size(56, 14);
            this.lbl_Id_Proceso.TabIndex = 62;
            this.lbl_Id_Proceso.Text = "Id Proceso";
            // 
            // txt_idProceso
            // 
            this.txt_idProceso.Location = new System.Drawing.Point(28, 126);
            this.txt_idProceso.Name = "txt_idProceso";
            this.txt_idProceso.ReadOnly = true;
            this.txt_idProceso.Size = new System.Drawing.Size(117, 20);
            this.txt_idProceso.TabIndex = 3;
            // 
            // lbl_receta
            // 
            this.lbl_receta.AutoSize = true;
            this.lbl_receta.Location = new System.Drawing.Point(333, 42);
            this.lbl_receta.Name = "lbl_receta";
            this.lbl_receta.Size = new System.Drawing.Size(50, 14);
            this.lbl_receta.TabIndex = 60;
            this.lbl_receta.Text = "Id Receta";
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Location = new System.Drawing.Point(333, 2);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(61, 14);
            this.lbl_producto.TabIndex = 59;
            this.lbl_producto.Text = "Id Producto";
            // 
            // lbl_proceso_detalle
            // 
            this.lbl_proceso_detalle.AutoSize = true;
            this.lbl_proceso_detalle.Location = new System.Drawing.Point(183, 2);
            this.lbl_proceso_detalle.Name = "lbl_proceso_detalle";
            this.lbl_proceso_detalle.Size = new System.Drawing.Size(89, 14);
            this.lbl_proceso_detalle.TabIndex = 58;
            this.lbl_proceso_detalle.Text = "Id Proceso detalle";
            // 
            // txt_idProcesoDetalle
            // 
            this.txt_idProcesoDetalle.Location = new System.Drawing.Point(180, 18);
            this.txt_idProcesoDetalle.Name = "txt_idProcesoDetalle";
            this.txt_idProcesoDetalle.ReadOnly = true;
            this.txt_idProcesoDetalle.Size = new System.Drawing.Size(117, 20);
            this.txt_idProcesoDetalle.TabIndex = 9;
            // 
            // lbl_costo_agua
            // 
            this.lbl_costo_agua.AutoSize = true;
            this.lbl_costo_agua.Location = new System.Drawing.Point(180, 117);
            this.lbl_costo_agua.Name = "lbl_costo_agua";
            this.lbl_costo_agua.Size = new System.Drawing.Size(57, 14);
            this.lbl_costo_agua.TabIndex = 52;
            this.lbl_costo_agua.Text = "Costo agua";
            // 
            // lbl_costo_luz
            // 
            this.lbl_costo_luz.AutoSize = true;
            this.lbl_costo_luz.Location = new System.Drawing.Point(35, 158);
            this.lbl_costo_luz.Name = "lbl_costo_luz";
            this.lbl_costo_luz.Size = new System.Drawing.Size(67, 14);
            this.lbl_costo_luz.TabIndex = 51;
            this.lbl_costo_luz.Text = "Costo de Luz";
            // 
            // lbl_mano_obra
            // 
            this.lbl_mano_obra.AutoSize = true;
            this.lbl_mano_obra.Location = new System.Drawing.Point(180, 78);
            this.lbl_mano_obra.Name = "lbl_mano_obra";
            this.lbl_mano_obra.Size = new System.Drawing.Size(72, 14);
            this.lbl_mano_obra.TabIndex = 50;
            this.lbl_mano_obra.Text = "Mano de Obra";
            // 
            // lbl_duracion
            // 
            this.lbl_duracion.AutoSize = true;
            this.lbl_duracion.Location = new System.Drawing.Point(180, 43);
            this.lbl_duracion.Name = "lbl_duracion";
            this.lbl_duracion.Size = new System.Drawing.Size(49, 14);
            this.lbl_duracion.TabIndex = 49;
            this.lbl_duracion.Text = "Duración";
            // 
            // lbl_costo_total
            // 
            this.lbl_costo_total.AutoSize = true;
            this.lbl_costo_total.Location = new System.Drawing.Point(40, 118);
            this.lbl_costo_total.Name = "lbl_costo_total";
            this.lbl_costo_total.Size = new System.Drawing.Size(62, 14);
            this.lbl_costo_total.TabIndex = 48;
            this.lbl_costo_total.Text = "Costo Total";
            // 
            // lbl_Costo_unitario
            // 
            this.lbl_Costo_unitario.AutoSize = true;
            this.lbl_Costo_unitario.Location = new System.Drawing.Point(41, 78);
            this.lbl_Costo_unitario.Name = "lbl_Costo_unitario";
            this.lbl_Costo_unitario.Size = new System.Drawing.Size(76, 14);
            this.lbl_Costo_unitario.TabIndex = 47;
            this.lbl_Costo_unitario.Text = "Costo Unitario";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(41, 42);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(47, 14);
            this.lbl_cantidad.TabIndex = 46;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // lbl_empleado
            // 
            this.lbl_empleado.AutoSize = true;
            this.lbl_empleado.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empleado.Location = new System.Drawing.Point(35, 1);
            this.lbl_empleado.Name = "lbl_empleado";
            this.lbl_empleado.Size = new System.Drawing.Size(53, 14);
            this.lbl_empleado.TabIndex = 45;
            this.lbl_empleado.Text = "Empleado";
            // 
            // lbl_Maquinaria
            // 
            this.lbl_Maquinaria.AutoSize = true;
            this.lbl_Maquinaria.Location = new System.Drawing.Point(27, 56);
            this.lbl_Maquinaria.Name = "lbl_Maquinaria";
            this.lbl_Maquinaria.Size = new System.Drawing.Size(58, 14);
            this.lbl_Maquinaria.TabIndex = 44;
            this.lbl_Maquinaria.Text = "Maquinaria";
            // 
            // lbl_Orden
            // 
            this.lbl_Orden.AutoSize = true;
            this.lbl_Orden.Location = new System.Drawing.Point(27, 16);
            this.lbl_Orden.Name = "lbl_Orden";
            this.lbl_Orden.Size = new System.Drawing.Size(35, 14);
            this.lbl_Orden.TabIndex = 43;
            this.lbl_Orden.Text = "Orden";
            // 
            // txt_costo_agua
            // 
            this.txt_costo_agua.Location = new System.Drawing.Point(180, 134);
            this.txt_costo_agua.Name = "txt_costo_agua";
            this.txt_costo_agua.Size = new System.Drawing.Size(117, 20);
            this.txt_costo_agua.TabIndex = 12;
            // 
            // txt_costo_luz
            // 
            this.txt_costo_luz.Location = new System.Drawing.Point(38, 174);
            this.txt_costo_luz.Name = "txt_costo_luz";
            this.txt_costo_luz.Size = new System.Drawing.Size(117, 20);
            this.txt_costo_luz.TabIndex = 8;
            // 
            // txt_mano_obra
            // 
            this.txt_mano_obra.Location = new System.Drawing.Point(180, 94);
            this.txt_mano_obra.Name = "txt_mano_obra";
            this.txt_mano_obra.Size = new System.Drawing.Size(117, 20);
            this.txt_mano_obra.TabIndex = 11;
            // 
            // nud_duracion_horas
            // 
            this.nud_duracion_horas.Location = new System.Drawing.Point(180, 57);
            this.nud_duracion_horas.Name = "nud_duracion_horas";
            this.nud_duracion_horas.Size = new System.Drawing.Size(120, 20);
            this.nud_duracion_horas.TabIndex = 10;
            // 
            // txt_costo_t
            // 
            this.txt_costo_t.Location = new System.Drawing.Point(38, 134);
            this.txt_costo_t.Name = "txt_costo_t";
            this.txt_costo_t.ReadOnly = true;
            this.txt_costo_t.Size = new System.Drawing.Size(117, 20);
            this.txt_costo_t.TabIndex = 7;
            // 
            // txt_costo_u
            // 
            this.txt_costo_u.Location = new System.Drawing.Point(38, 94);
            this.txt_costo_u.Name = "txt_costo_u";
            this.txt_costo_u.Size = new System.Drawing.Size(117, 20);
            this.txt_costo_u.TabIndex = 6;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(38, 57);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(117, 20);
            this.txt_cantidad.TabIndex = 5;
            // 
            // cbo_empleado
            // 
            this.cbo_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_empleado.FormattingEnabled = true;
            this.cbo_empleado.Location = new System.Drawing.Point(38, 18);
            this.cbo_empleado.Name = "cbo_empleado";
            this.cbo_empleado.Size = new System.Drawing.Size(123, 22);
            this.cbo_empleado.TabIndex = 4;
            // 
            // dgv_detalle_orden
            // 
            this.dgv_detalle_orden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_detalle_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle_orden.Location = new System.Drawing.Point(69, 296);
            this.dgv_detalle_orden.Name = "dgv_detalle_orden";
            this.dgv_detalle_orden.Size = new System.Drawing.Size(852, 277);
            this.dgv_detalle_orden.TabIndex = 19;
            // 
            // cbo_maquinaria
            // 
            this.cbo_maquinaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_maquinaria.FormattingEnabled = true;
            this.cbo_maquinaria.Location = new System.Drawing.Point(28, 72);
            this.cbo_maquinaria.Name = "cbo_maquinaria";
            this.cbo_maquinaria.Size = new System.Drawing.Size(123, 22);
            this.cbo_maquinaria.TabIndex = 2;
            // 
            // cbo_orden
            // 
            this.cbo_orden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_orden.FormattingEnabled = true;
            this.cbo_orden.Location = new System.Drawing.Point(28, 33);
            this.cbo_orden.Name = "cbo_orden";
            this.cbo_orden.Size = new System.Drawing.Size(123, 22);
            this.cbo_orden.TabIndex = 1;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_Ayuda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_Ayuda.FlatAppearance.BorderSize = 0;
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ayuda.Image = global::Capa_Vista_Sistema_Produccion.Properties.Resources.AYUDA_V4;
            this.btn_Ayuda.Location = new System.Drawing.Point(919, 76);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(50, 48);
            this.btn_Ayuda.TabIndex = 17;
            this.btn_Ayuda.UseVisualStyleBackColor = false;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_salir.BackgroundImage = global::Capa_Vista_Sistema_Produccion.Properties.Resources.SALIR_V4;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir.Location = new System.Drawing.Point(927, 9);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(42, 54);
            this.btn_salir.TabIndex = 18;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_asignar
            // 
            this.btn_asignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_asignar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_asignar.FlatAppearance.BorderSize = 0;
            this.btn_asignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_asignar.Image = global::Capa_Vista_Sistema_Produccion.Properties.Resources.INGRESAR_V4;
            this.btn_asignar.Location = new System.Drawing.Point(13, 76);
            this.btn_asignar.Name = "btn_asignar";
            this.btn_asignar.Size = new System.Drawing.Size(45, 50);
            this.btn_asignar.TabIndex = 15;
            this.btn_asignar.UseVisualStyleBackColor = false;
            this.btn_asignar.Click += new System.EventHandler(this.btn_asignar_Click);
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_Reporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_Reporte.FlatAppearance.BorderSize = 0;
            this.btn_Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reporte.Image = global::Capa_Vista_Sistema_Produccion.Properties.Resources.impresora;
            this.btn_Reporte.Location = new System.Drawing.Point(12, 9);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(46, 43);
            this.btn_Reporte.TabIndex = 16;
            this.btn_Reporte.UseVisualStyleBackColor = false;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // gpb_Orden
            // 
            this.gpb_Orden.Controls.Add(this.lbl_Id_Proceso);
            this.gpb_Orden.Controls.Add(this.txt_idProceso);
            this.gpb_Orden.Controls.Add(this.lbl_Maquinaria);
            this.gpb_Orden.Controls.Add(this.lbl_Orden);
            this.gpb_Orden.Controls.Add(this.cbo_maquinaria);
            this.gpb_Orden.Controls.Add(this.cbo_orden);
            this.gpb_Orden.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Orden.Location = new System.Drawing.Point(138, 94);
            this.gpb_Orden.Name = "gpb_Orden";
            this.gpb_Orden.Size = new System.Drawing.Size(161, 168);
            this.gpb_Orden.TabIndex = 67;
            this.gpb_Orden.TabStop = false;
            this.gpb_Orden.Text = "Ordenes";
            // 
            // gpb_Costos
            // 
            this.gpb_Costos.Controls.Add(this.lbl_receta);
            this.gpb_Costos.Controls.Add(this.lbl_producto);
            this.gpb_Costos.Controls.Add(this.lbl_proceso_detalle);
            this.gpb_Costos.Controls.Add(this.txt_idReceta);
            this.gpb_Costos.Controls.Add(this.txt_idProducto);
            this.gpb_Costos.Controls.Add(this.txt_idProcesoDetalle);
            this.gpb_Costos.Controls.Add(this.lbl_costo_agua);
            this.gpb_Costos.Controls.Add(this.lbl_costo_luz);
            this.gpb_Costos.Controls.Add(this.lbl_mano_obra);
            this.gpb_Costos.Controls.Add(this.lbl_duracion);
            this.gpb_Costos.Controls.Add(this.lbl_costo_total);
            this.gpb_Costos.Controls.Add(this.lbl_Costo_unitario);
            this.gpb_Costos.Controls.Add(this.lbl_cantidad);
            this.gpb_Costos.Controls.Add(this.lbl_empleado);
            this.gpb_Costos.Controls.Add(this.txt_costo_agua);
            this.gpb_Costos.Controls.Add(this.txt_costo_luz);
            this.gpb_Costos.Controls.Add(this.txt_mano_obra);
            this.gpb_Costos.Controls.Add(this.nud_duracion_horas);
            this.gpb_Costos.Controls.Add(this.txt_costo_t);
            this.gpb_Costos.Controls.Add(this.txt_costo_u);
            this.gpb_Costos.Controls.Add(this.txt_cantidad);
            this.gpb_Costos.Controls.Add(this.cbo_empleado);
            this.gpb_Costos.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Costos.Location = new System.Drawing.Point(376, 76);
            this.gpb_Costos.Name = "gpb_Costos";
            this.gpb_Costos.Size = new System.Drawing.Size(490, 208);
            this.gpb_Costos.TabIndex = 68;
            this.gpb_Costos.TabStop = false;
            // 
            // txt_idReceta
            // 
            this.txt_idReceta.Location = new System.Drawing.Point(336, 58);
            this.txt_idReceta.Name = "txt_idReceta";
            this.txt_idReceta.ReadOnly = true;
            this.txt_idReceta.Size = new System.Drawing.Size(117, 20);
            this.txt_idReceta.TabIndex = 14;
            // 
            // txt_idProducto
            // 
            this.txt_idProducto.Location = new System.Drawing.Point(336, 18);
            this.txt_idProducto.Name = "txt_idProducto";
            this.txt_idProducto.ReadOnly = true;
            this.txt_idProducto.Size = new System.Drawing.Size(117, 20);
            this.txt_idProducto.TabIndex = 13;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.Location = new System.Drawing.Point(13, 150);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(45, 50);
            this.btn_actualizar.TabIndex = 69;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // Frm_Sistema_Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(981, 585);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.gpb_Costos);
            this.Controls.Add(this.gpb_Orden);
            this.Controls.Add(this.btn_Reporte);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_asignar);
            this.Controls.Add(this.dgv_detalle_orden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Sistema_Produccion";
            this.Text = "Sistema de producción";
            ((System.ComponentModel.ISupportInitialize)(this.nud_duracion_horas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_orden)).EndInit();
            this.gpb_Orden.ResumeLayout(false);
            this.gpb_Orden.PerformLayout();
            this.gpb_Costos.ResumeLayout(false);
            this.gpb_Costos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Id_Proceso;
        private System.Windows.Forms.TextBox txt_idProceso;
        private System.Windows.Forms.Label lbl_receta;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.Label lbl_proceso_detalle;
        private System.Windows.Forms.TextBox txt_idProcesoDetalle;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_asignar;
        private System.Windows.Forms.Label lbl_costo_agua;
        private System.Windows.Forms.Label lbl_costo_luz;
        private System.Windows.Forms.Label lbl_mano_obra;
        private System.Windows.Forms.Label lbl_duracion;
        private System.Windows.Forms.Label lbl_costo_total;
        private System.Windows.Forms.Label lbl_Costo_unitario;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_empleado;
        private System.Windows.Forms.Label lbl_Maquinaria;
        private System.Windows.Forms.Label lbl_Orden;
        private System.Windows.Forms.TextBox txt_costo_agua;
        private System.Windows.Forms.TextBox txt_costo_luz;
        private System.Windows.Forms.TextBox txt_mano_obra;
        private System.Windows.Forms.NumericUpDown nud_duracion_horas;
        private System.Windows.Forms.TextBox txt_costo_t;
        private System.Windows.Forms.TextBox txt_costo_u;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.ComboBox cbo_empleado;
        private System.Windows.Forms.DataGridView dgv_detalle_orden;
        private System.Windows.Forms.ComboBox cbo_maquinaria;
        private System.Windows.Forms.ComboBox cbo_orden;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_Reporte;
        private System.Windows.Forms.GroupBox gpb_Orden;
        private System.Windows.Forms.GroupBox gpb_Costos;
        private System.Windows.Forms.TextBox txt_idReceta;
        private System.Windows.Forms.TextBox txt_idProducto;
        private System.Windows.Forms.Button btn_actualizar;
    }
}