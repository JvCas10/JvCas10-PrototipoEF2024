
namespace Capa_Vista_Receta
{
    partial class Frm_Recetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Recetas));
            this.lbl_id_receta = new System.Windows.Forms.Label();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_area = new System.Windows.Forms.Label();
            this.lbl_cama = new System.Windows.Forms.Label();
            this.lbl_dias = new System.Windows.Forms.Label();
            this.lbl_horas = new System.Windows.Forms.Label();
            this.txt_id_recetas = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.txt_Area = new System.Windows.Forms.TextBox();
            this.txt_Cama = new System.Windows.Forms.TextBox();
            this.txt_Dias = new System.Windows.Forms.TextBox();
            this.txt_Horas = new System.Windows.Forms.TextBox();
            this.dgv_Recetas = new System.Windows.Forms.DataGridView();
            this.cbo_Producto = new System.Windows.Forms.ComboBox();
            this.lbl_titulo_recetas = new System.Windows.Forms.Label();
            this.lbl_id_detalle = new System.Windows.Forms.Label();
            this.lbl_receta = new System.Windows.Forms.Label();
            this.lbl_productos = new System.Windows.Forms.Label();
            this.lbl_cantidades = new System.Windows.Forms.Label();
            this.lbl_Detalles = new System.Windows.Forms.Label();
            this.txt_id_detalle = new System.Windows.Forms.TextBox();
            this.txt_Cantidad_Detalle = new System.Windows.Forms.TextBox();
            this.dgv_Recetas_Detalles = new System.Windows.Forms.DataGridView();
            this.cbo_Producto_Detalle = new System.Windows.Forms.ComboBox();
            this.cbo_Receta_Detalle = new System.Windows.Forms.ComboBox();
            this.btn_Reportes = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_Actualizar_Detalle = new System.Windows.Forms.Button();
            this.btn_Modificar_Detalle = new System.Windows.Forms.Button();
            this.btn_Guardar_Detalle = new System.Windows.Forms.Button();
            this.btn_Nuevo_Detalle = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recetas_Detalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id_receta
            // 
            this.lbl_id_receta.AutoSize = true;
            this.lbl_id_receta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_receta.Location = new System.Drawing.Point(97, 174);
            this.lbl_id_receta.Name = "lbl_id_receta";
            this.lbl_id_receta.Size = new System.Drawing.Size(89, 22);
            this.lbl_id_receta.TabIndex = 0;
            this.lbl_id_receta.Text = "ID Receta";
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.Location = new System.Drawing.Point(97, 218);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(81, 22);
            this.lbl_producto.TabIndex = 1;
            this.lbl_producto.Text = "Producto";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(97, 264);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(107, 22);
            this.lbl_descripcion.TabIndex = 2;
            this.lbl_descripcion.Text = "Descripcion";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(97, 315);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(81, 22);
            this.lbl_cantidad.TabIndex = 3;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // lbl_area
            // 
            this.lbl_area.AutoSize = true;
            this.lbl_area.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_area.Location = new System.Drawing.Point(394, 171);
            this.lbl_area.Name = "lbl_area";
            this.lbl_area.Size = new System.Drawing.Size(49, 22);
            this.lbl_area.TabIndex = 4;
            this.lbl_area.Text = "Area";
            // 
            // lbl_cama
            // 
            this.lbl_cama.AutoSize = true;
            this.lbl_cama.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cama.Location = new System.Drawing.Point(394, 216);
            this.lbl_cama.Name = "lbl_cama";
            this.lbl_cama.Size = new System.Drawing.Size(55, 22);
            this.lbl_cama.TabIndex = 5;
            this.lbl_cama.Text = "Cama";
            // 
            // lbl_dias
            // 
            this.lbl_dias.AutoSize = true;
            this.lbl_dias.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dias.Location = new System.Drawing.Point(394, 264);
            this.lbl_dias.Name = "lbl_dias";
            this.lbl_dias.Size = new System.Drawing.Size(47, 22);
            this.lbl_dias.TabIndex = 6;
            this.lbl_dias.Text = "Dias";
            // 
            // lbl_horas
            // 
            this.lbl_horas.AutoSize = true;
            this.lbl_horas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horas.Location = new System.Drawing.Point(394, 316);
            this.lbl_horas.Name = "lbl_horas";
            this.lbl_horas.Size = new System.Drawing.Size(58, 22);
            this.lbl_horas.TabIndex = 7;
            this.lbl_horas.Text = "Horas";
            // 
            // txt_id_recetas
            // 
            this.txt_id_recetas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_recetas.Location = new System.Drawing.Point(218, 175);
            this.txt_id_recetas.Name = "txt_id_recetas";
            this.txt_id_recetas.Size = new System.Drawing.Size(133, 30);
            this.txt_id_recetas.TabIndex = 8;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.Location = new System.Drawing.Point(218, 264);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(133, 30);
            this.txt_Descripcion.TabIndex = 10;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cantidad.Location = new System.Drawing.Point(218, 316);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(133, 30);
            this.txt_Cantidad.TabIndex = 11;
            // 
            // txt_Area
            // 
            this.txt_Area.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Area.Location = new System.Drawing.Point(460, 175);
            this.txt_Area.Name = "txt_Area";
            this.txt_Area.Size = new System.Drawing.Size(117, 30);
            this.txt_Area.TabIndex = 12;
            // 
            // txt_Cama
            // 
            this.txt_Cama.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cama.Location = new System.Drawing.Point(460, 216);
            this.txt_Cama.Name = "txt_Cama";
            this.txt_Cama.Size = new System.Drawing.Size(117, 30);
            this.txt_Cama.TabIndex = 13;
            // 
            // txt_Dias
            // 
            this.txt_Dias.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Dias.Location = new System.Drawing.Point(460, 264);
            this.txt_Dias.Name = "txt_Dias";
            this.txt_Dias.Size = new System.Drawing.Size(117, 30);
            this.txt_Dias.TabIndex = 14;
            // 
            // txt_Horas
            // 
            this.txt_Horas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Horas.Location = new System.Drawing.Point(460, 313);
            this.txt_Horas.Name = "txt_Horas";
            this.txt_Horas.Size = new System.Drawing.Size(117, 30);
            this.txt_Horas.TabIndex = 15;
            // 
            // dgv_Recetas
            // 
            this.dgv_Recetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Recetas.Location = new System.Drawing.Point(34, 378);
            this.dgv_Recetas.Name = "dgv_Recetas";
            this.dgv_Recetas.RowHeadersWidth = 51;
            this.dgv_Recetas.RowTemplate.Height = 24;
            this.dgv_Recetas.Size = new System.Drawing.Size(633, 165);
            this.dgv_Recetas.TabIndex = 16;
            this.dgv_Recetas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Recetas_CellContentClick);
            // 
            // cbo_Producto
            // 
            this.cbo_Producto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Producto.FormattingEnabled = true;
            this.cbo_Producto.Location = new System.Drawing.Point(218, 216);
            this.cbo_Producto.Name = "cbo_Producto";
            this.cbo_Producto.Size = new System.Drawing.Size(133, 30);
            this.cbo_Producto.TabIndex = 17;
            // 
            // lbl_titulo_recetas
            // 
            this.lbl_titulo_recetas.AutoSize = true;
            this.lbl_titulo_recetas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_recetas.Location = new System.Drawing.Point(294, 16);
            this.lbl_titulo_recetas.Name = "lbl_titulo_recetas";
            this.lbl_titulo_recetas.Size = new System.Drawing.Size(78, 23);
            this.lbl_titulo_recetas.TabIndex = 18;
            this.lbl_titulo_recetas.Text = "Recetas";
            // 
            // lbl_id_detalle
            // 
            this.lbl_id_detalle.AutoSize = true;
            this.lbl_id_detalle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_detalle.Location = new System.Drawing.Point(826, 209);
            this.lbl_id_detalle.Name = "lbl_id_detalle";
            this.lbl_id_detalle.Size = new System.Drawing.Size(93, 22);
            this.lbl_id_detalle.TabIndex = 24;
            this.lbl_id_detalle.Text = "ID Detalle";
            // 
            // lbl_receta
            // 
            this.lbl_receta.AutoSize = true;
            this.lbl_receta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_receta.Location = new System.Drawing.Point(1089, 207);
            this.lbl_receta.Name = "lbl_receta";
            this.lbl_receta.Size = new System.Drawing.Size(64, 22);
            this.lbl_receta.TabIndex = 25;
            this.lbl_receta.Text = "Receta";
            // 
            // lbl_productos
            // 
            this.lbl_productos.AutoSize = true;
            this.lbl_productos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productos.Location = new System.Drawing.Point(826, 263);
            this.lbl_productos.Name = "lbl_productos";
            this.lbl_productos.Size = new System.Drawing.Size(81, 22);
            this.lbl_productos.TabIndex = 26;
            this.lbl_productos.Text = "Producto";
            // 
            // lbl_cantidades
            // 
            this.lbl_cantidades.AutoSize = true;
            this.lbl_cantidades.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidades.Location = new System.Drawing.Point(1085, 262);
            this.lbl_cantidades.Name = "lbl_cantidades";
            this.lbl_cantidades.Size = new System.Drawing.Size(81, 22);
            this.lbl_cantidades.TabIndex = 27;
            this.lbl_cantidades.Text = "Cantidad";
            // 
            // lbl_Detalles
            // 
            this.lbl_Detalles.AutoSize = true;
            this.lbl_Detalles.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Detalles.Location = new System.Drawing.Point(1009, 16);
            this.lbl_Detalles.Name = "lbl_Detalles";
            this.lbl_Detalles.Size = new System.Drawing.Size(177, 23);
            this.lbl_Detalles.TabIndex = 28;
            this.lbl_Detalles.Text = "Detalles de Recetas";
            // 
            // txt_id_detalle
            // 
            this.txt_id_detalle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_detalle.Location = new System.Drawing.Point(925, 207);
            this.txt_id_detalle.Name = "txt_id_detalle";
            this.txt_id_detalle.Size = new System.Drawing.Size(146, 30);
            this.txt_id_detalle.TabIndex = 29;
            // 
            // txt_Cantidad_Detalle
            // 
            this.txt_Cantidad_Detalle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cantidad_Detalle.Location = new System.Drawing.Point(1172, 262);
            this.txt_Cantidad_Detalle.Name = "txt_Cantidad_Detalle";
            this.txt_Cantidad_Detalle.Size = new System.Drawing.Size(164, 30);
            this.txt_Cantidad_Detalle.TabIndex = 32;
            // 
            // dgv_Recetas_Detalles
            // 
            this.dgv_Recetas_Detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Recetas_Detalles.Location = new System.Drawing.Point(798, 371);
            this.dgv_Recetas_Detalles.Name = "dgv_Recetas_Detalles";
            this.dgv_Recetas_Detalles.RowHeadersWidth = 51;
            this.dgv_Recetas_Detalles.RowTemplate.Height = 24;
            this.dgv_Recetas_Detalles.Size = new System.Drawing.Size(551, 172);
            this.dgv_Recetas_Detalles.TabIndex = 33;
            // 
            // cbo_Producto_Detalle
            // 
            this.cbo_Producto_Detalle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Producto_Detalle.FormattingEnabled = true;
            this.cbo_Producto_Detalle.Location = new System.Drawing.Point(925, 262);
            this.cbo_Producto_Detalle.Name = "cbo_Producto_Detalle";
            this.cbo_Producto_Detalle.Size = new System.Drawing.Size(146, 30);
            this.cbo_Producto_Detalle.TabIndex = 34;
            // 
            // cbo_Receta_Detalle
            // 
            this.cbo_Receta_Detalle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Receta_Detalle.FormattingEnabled = true;
            this.cbo_Receta_Detalle.Location = new System.Drawing.Point(1172, 207);
            this.cbo_Receta_Detalle.Name = "cbo_Receta_Detalle";
            this.cbo_Receta_Detalle.Size = new System.Drawing.Size(164, 30);
            this.cbo_Receta_Detalle.TabIndex = 35;
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Reportes.BackgroundImage = global::Capa_Vista_Receta.Properties.Resources.impresora;
            this.btn_Reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Reportes.Location = new System.Drawing.Point(677, 218);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Size = new System.Drawing.Size(98, 89);
            this.btn_Reportes.TabIndex = 42;
            this.btn_Reportes.UseVisualStyleBackColor = false;
            this.btn_Reportes.Click += new System.EventHandler(this.btn_Reportes_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Salir.BackgroundImage = global::Capa_Vista_Receta.Properties.Resources.SALIR_V4;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Salir.Location = new System.Drawing.Point(1340, 16);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(79, 78);
            this.btn_Salir.TabIndex = 41;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Ayuda.BackgroundImage = global::Capa_Vista_Receta.Properties.Resources.AYUDA_V4;
            this.btn_Ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Ayuda.Location = new System.Drawing.Point(677, 124);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(98, 81);
            this.btn_Ayuda.TabIndex = 40;
            this.btn_Ayuda.UseVisualStyleBackColor = false;
            this.btn_Ayuda.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Actualizar_Detalle
            // 
            this.btn_Actualizar_Detalle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Actualizar_Detalle.BackgroundImage = global::Capa_Vista_Receta.Properties.Resources.EDITAR_V4;
            this.btn_Actualizar_Detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Actualizar_Detalle.Location = new System.Drawing.Point(1187, 57);
            this.btn_Actualizar_Detalle.Name = "btn_Actualizar_Detalle";
            this.btn_Actualizar_Detalle.Size = new System.Drawing.Size(99, 83);
            this.btn_Actualizar_Detalle.TabIndex = 39;
            this.btn_Actualizar_Detalle.UseVisualStyleBackColor = false;
            this.btn_Actualizar_Detalle.Click += new System.EventHandler(this.btn_Actualizar_Detalle_Click);
            // 
            // btn_Modificar_Detalle
            // 
            this.btn_Modificar_Detalle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Modificar_Detalle.BackgroundImage = global::Capa_Vista_Receta.Properties.Resources.BUCAR_V4;
            this.btn_Modificar_Detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Modificar_Detalle.Location = new System.Drawing.Point(1072, 58);
            this.btn_Modificar_Detalle.Name = "btn_Modificar_Detalle";
            this.btn_Modificar_Detalle.Size = new System.Drawing.Size(94, 83);
            this.btn_Modificar_Detalle.TabIndex = 38;
            this.btn_Modificar_Detalle.UseVisualStyleBackColor = false;
            this.btn_Modificar_Detalle.Click += new System.EventHandler(this.btn_Modificar_Detalle_Click);
            // 
            // btn_Guardar_Detalle
            // 
            this.btn_Guardar_Detalle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Guardar_Detalle.BackgroundImage = global::Capa_Vista_Receta.Properties.Resources.guardar;
            this.btn_Guardar_Detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Guardar_Detalle.Location = new System.Drawing.Point(958, 57);
            this.btn_Guardar_Detalle.Name = "btn_Guardar_Detalle";
            this.btn_Guardar_Detalle.Size = new System.Drawing.Size(91, 84);
            this.btn_Guardar_Detalle.TabIndex = 37;
            this.btn_Guardar_Detalle.UseVisualStyleBackColor = false;
            this.btn_Guardar_Detalle.Click += new System.EventHandler(this.btn_Guardar_Detalle_Click);
            // 
            // btn_Nuevo_Detalle
            // 
            this.btn_Nuevo_Detalle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Nuevo_Detalle.BackgroundImage = global::Capa_Vista_Receta.Properties.Resources.INGRESAR_V4;
            this.btn_Nuevo_Detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Nuevo_Detalle.Location = new System.Drawing.Point(847, 56);
            this.btn_Nuevo_Detalle.Name = "btn_Nuevo_Detalle";
            this.btn_Nuevo_Detalle.Size = new System.Drawing.Size(85, 85);
            this.btn_Nuevo_Detalle.TabIndex = 36;
            this.btn_Nuevo_Detalle.UseVisualStyleBackColor = false;
            this.btn_Nuevo_Detalle.Click += new System.EventHandler(this.btn_Nuevo_Detalle_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Eliminar.BackgroundImage = global::Capa_Vista_Receta.Properties.Resources.BORRAR_V4;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Eliminar.Location = new System.Drawing.Point(497, 57);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(90, 83);
            this.btn_Eliminar.TabIndex = 23;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Actualizar.BackgroundImage = global::Capa_Vista_Receta.Properties.Resources.EDITAR_V4;
            this.btn_Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Actualizar.Location = new System.Drawing.Point(389, 56);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(88, 83);
            this.btn_Actualizar.TabIndex = 22;
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Modificar.BackgroundImage = global::Capa_Vista_Receta.Properties.Resources.BUCAR_V4;
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Modificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Modificar.Location = new System.Drawing.Point(282, 57);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(90, 84);
            this.btn_Modificar.TabIndex = 21;
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Guardar.BackgroundImage = global::Capa_Vista_Receta.Properties.Resources.guardar;
            this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Guardar.Location = new System.Drawing.Point(179, 56);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(87, 84);
            this.btn_Guardar.TabIndex = 20;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Nuevo.BackgroundImage = global::Capa_Vista_Receta.Properties.Resources.INGRESAR_V4;
            this.btn_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Nuevo.Location = new System.Drawing.Point(81, 56);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(81, 84);
            this.btn_Nuevo.TabIndex = 19;
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // Frm_Recetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1431, 555);
            this.Controls.Add(this.btn_Reportes);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.btn_Actualizar_Detalle);
            this.Controls.Add(this.btn_Modificar_Detalle);
            this.Controls.Add(this.btn_Guardar_Detalle);
            this.Controls.Add(this.btn_Nuevo_Detalle);
            this.Controls.Add(this.cbo_Receta_Detalle);
            this.Controls.Add(this.cbo_Producto_Detalle);
            this.Controls.Add(this.dgv_Recetas_Detalles);
            this.Controls.Add(this.txt_Cantidad_Detalle);
            this.Controls.Add(this.txt_id_detalle);
            this.Controls.Add(this.lbl_Detalles);
            this.Controls.Add(this.lbl_cantidades);
            this.Controls.Add(this.lbl_productos);
            this.Controls.Add(this.lbl_receta);
            this.Controls.Add(this.lbl_id_detalle);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.lbl_titulo_recetas);
            this.Controls.Add(this.cbo_Producto);
            this.Controls.Add(this.dgv_Recetas);
            this.Controls.Add(this.txt_Horas);
            this.Controls.Add(this.txt_Dias);
            this.Controls.Add(this.txt_Cama);
            this.Controls.Add(this.txt_Area);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_id_recetas);
            this.Controls.Add(this.lbl_horas);
            this.Controls.Add(this.lbl_dias);
            this.Controls.Add(this.lbl_cama);
            this.Controls.Add(this.lbl_area);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.lbl_id_receta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Recetas";
            this.Text = "Recetas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recetas_Detalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id_receta;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_area;
        private System.Windows.Forms.Label lbl_cama;
        private System.Windows.Forms.Label lbl_dias;
        private System.Windows.Forms.Label lbl_horas;
        private System.Windows.Forms.TextBox txt_id_recetas;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_Area;
        private System.Windows.Forms.TextBox txt_Cama;
        private System.Windows.Forms.TextBox txt_Dias;
        private System.Windows.Forms.TextBox txt_Horas;
        private System.Windows.Forms.DataGridView dgv_Recetas;
        private System.Windows.Forms.ComboBox cbo_Producto;
        private System.Windows.Forms.Label lbl_titulo_recetas;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label lbl_id_detalle;
        private System.Windows.Forms.Label lbl_receta;
        private System.Windows.Forms.Label lbl_productos;
        private System.Windows.Forms.Label lbl_cantidades;
        private System.Windows.Forms.Label lbl_Detalles;
        private System.Windows.Forms.TextBox txt_id_detalle;
        private System.Windows.Forms.TextBox txt_Cantidad_Detalle;
        private System.Windows.Forms.DataGridView dgv_Recetas_Detalles;
        private System.Windows.Forms.ComboBox cbo_Producto_Detalle;
        private System.Windows.Forms.ComboBox cbo_Receta_Detalle;
        private System.Windows.Forms.Button btn_Nuevo_Detalle;
        private System.Windows.Forms.Button btn_Guardar_Detalle;
        private System.Windows.Forms.Button btn_Modificar_Detalle;
        private System.Windows.Forms.Button btn_Actualizar_Detalle;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Reportes;
    }
}