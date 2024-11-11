
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class DeudaProveedores
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
            this.components = new System.ComponentModel.Container();
            this.Dgv_deudas = new System.Windows.Forms.DataGridView();
            this.Cbo_Tipotrans = new System.Windows.Forms.ComboBox();
            this.Cbo_id_proveedor = new System.Windows.Forms.ComboBox();
            this.Txt_Descipcion = new System.Windows.Forms.TextBox();
            this.Lbl_descrip_deuda = new System.Windows.Forms.Label();
            this.Lbl_estado_deuda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_montoDeuda = new System.Windows.Forms.TextBox();
            this.Lbl_Tipotrans = new System.Windows.Forms.Label();
            this.Lbl_monto_dueda = new System.Windows.Forms.Label();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Txt_id_deuda = new System.Windows.Forms.TextBox();
            this.Lbl_id_deuda = new System.Windows.Forms.Label();
            this.Lbl_inicio_deuda = new System.Windows.Forms.Label();
            this.Lbl_vencimiento_deuda = new System.Windows.Forms.Label();
            this.Lbl_id_DeudaP = new System.Windows.Forms.Label();
            this.Txt_idfactura = new System.Windows.Forms.Label();
            this.Cbo_idfactura = new System.Windows.Forms.ComboBox();
            this.Txt_fechaI = new System.Windows.Forms.TextBox();
            this.Txt_fechaV = new System.Windows.Forms.TextBox();
            this.Cbo_efectoT = new System.Windows.Forms.ComboBox();
            this.Txt_efecto = new System.Windows.Forms.Label();
            this.Btn_reportes = new System.Windows.Forms.Button();
            this.Btn_Ayudas = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_deudas)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_deudas
            // 
            this.Dgv_deudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_deudas.Location = new System.Drawing.Point(86, 397);
            this.Dgv_deudas.Name = "Dgv_deudas";
            this.Dgv_deudas.RowHeadersWidth = 51;
            this.Dgv_deudas.RowTemplate.Height = 24;
            this.Dgv_deudas.Size = new System.Drawing.Size(1018, 254);
            this.Dgv_deudas.TabIndex = 104;
            // 
            // Cbo_Tipotrans
            // 
            this.Cbo_Tipotrans.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Tipotrans.FormattingEnabled = true;
            this.Cbo_Tipotrans.Location = new System.Drawing.Point(284, 258);
            this.Cbo_Tipotrans.Name = "Cbo_Tipotrans";
            this.Cbo_Tipotrans.Size = new System.Drawing.Size(121, 30);
            this.Cbo_Tipotrans.TabIndex = 103;
            // 
            // Cbo_id_proveedor
            // 
            this.Cbo_id_proveedor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_id_proveedor.FormattingEnabled = true;
            this.Cbo_id_proveedor.Location = new System.Drawing.Point(285, 215);
            this.Cbo_id_proveedor.Name = "Cbo_id_proveedor";
            this.Cbo_id_proveedor.Size = new System.Drawing.Size(121, 30);
            this.Cbo_id_proveedor.TabIndex = 101;
            // 
            // Txt_Descipcion
            // 
            this.Txt_Descipcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descipcion.Location = new System.Drawing.Point(836, 304);
            this.Txt_Descipcion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Descipcion.Multiline = true;
            this.Txt_Descipcion.Name = "Txt_Descipcion";
            this.Txt_Descipcion.Size = new System.Drawing.Size(268, 31);
            this.Txt_Descipcion.TabIndex = 96;
            // 
            // Lbl_descrip_deuda
            // 
            this.Lbl_descrip_deuda.AutoSize = true;
            this.Lbl_descrip_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descrip_deuda.Location = new System.Drawing.Point(582, 309);
            this.Lbl_descrip_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_descrip_deuda.Name = "Lbl_descrip_deuda";
            this.Lbl_descrip_deuda.Size = new System.Drawing.Size(213, 22);
            this.Lbl_descrip_deuda.TabIndex = 93;
            this.Lbl_descrip_deuda.Text = "Descripcion de la Deuda:";
            // 
            // Lbl_estado_deuda
            // 
            this.Lbl_estado_deuda.AutoSize = true;
            this.Lbl_estado_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado_deuda.Location = new System.Drawing.Point(582, 347);
            this.Lbl_estado_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_estado_deuda.Name = "Lbl_estado_deuda";
            this.Lbl_estado_deuda.Size = new System.Drawing.Size(170, 22);
            this.Lbl_estado_deuda.TabIndex = 92;
            this.Lbl_estado_deuda.Text = "Estado de la Deuda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(625, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 22);
            this.label3.TabIndex = 91;
            this.label3.Text = " ";
            // 
            // Txt_montoDeuda
            // 
            this.Txt_montoDeuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_montoDeuda.Location = new System.Drawing.Point(836, 176);
            this.Txt_montoDeuda.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_montoDeuda.Name = "Txt_montoDeuda";
            this.Txt_montoDeuda.Size = new System.Drawing.Size(268, 30);
            this.Txt_montoDeuda.TabIndex = 90;
            // 
            // Lbl_Tipotrans
            // 
            this.Lbl_Tipotrans.AutoSize = true;
            this.Lbl_Tipotrans.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tipotrans.Location = new System.Drawing.Point(31, 257);
            this.Lbl_Tipotrans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Tipotrans.Name = "Lbl_Tipotrans";
            this.Lbl_Tipotrans.Size = new System.Drawing.Size(178, 22);
            this.Lbl_Tipotrans.TabIndex = 89;
            this.Lbl_Tipotrans.Text = "Tipo de Transacción:";
            // 
            // Lbl_monto_dueda
            // 
            this.Lbl_monto_dueda.AutoSize = true;
            this.Lbl_monto_dueda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_monto_dueda.Location = new System.Drawing.Point(582, 183);
            this.Lbl_monto_dueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_monto_dueda.Name = "Lbl_monto_dueda";
            this.Lbl_monto_dueda.Size = new System.Drawing.Size(147, 22);
            this.Lbl_monto_dueda.TabIndex = 88;
            this.Lbl_monto_dueda.Text = "Monto de Deuda:";
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.AutoCompleteCustomSource.AddRange(new string[] {
            "1. Habilitado",
            "2. Inhabilitado"});
            this.Cbo_estado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Items.AddRange(new object[] {
            "1",
            "0"});
            this.Cbo_estado.Location = new System.Drawing.Point(836, 343);
            this.Cbo_estado.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(268, 30);
            this.Cbo_estado.TabIndex = 87;
            // 
            // Txt_id_deuda
            // 
            this.Txt_id_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id_deuda.Location = new System.Drawing.Point(286, 173);
            this.Txt_id_deuda.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_id_deuda.Name = "Txt_id_deuda";
            this.Txt_id_deuda.Size = new System.Drawing.Size(268, 30);
            this.Txt_id_deuda.TabIndex = 86;
            // 
            // Lbl_id_deuda
            // 
            this.Lbl_id_deuda.AutoSize = true;
            this.Lbl_id_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_deuda.Location = new System.Drawing.Point(32, 178);
            this.Lbl_id_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id_deuda.Name = "Lbl_id_deuda";
            this.Lbl_id_deuda.Size = new System.Drawing.Size(88, 22);
            this.Lbl_id_deuda.TabIndex = 85;
            this.Lbl_id_deuda.Text = "Id Deuda:";
            // 
            // Lbl_inicio_deuda
            // 
            this.Lbl_inicio_deuda.AutoSize = true;
            this.Lbl_inicio_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_inicio_deuda.Location = new System.Drawing.Point(582, 231);
            this.Lbl_inicio_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_inicio_deuda.Name = "Lbl_inicio_deuda";
            this.Lbl_inicio_deuda.Size = new System.Drawing.Size(170, 22);
            this.Lbl_inicio_deuda.TabIndex = 84;
            this.Lbl_inicio_deuda.Text = "Fecha Inicio Deuda:";
            // 
            // Lbl_vencimiento_deuda
            // 
            this.Lbl_vencimiento_deuda.AutoSize = true;
            this.Lbl_vencimiento_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_vencimiento_deuda.Location = new System.Drawing.Point(582, 270);
            this.Lbl_vencimiento_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_vencimiento_deuda.Name = "Lbl_vencimiento_deuda";
            this.Lbl_vencimiento_deuda.Size = new System.Drawing.Size(221, 22);
            this.Lbl_vencimiento_deuda.TabIndex = 83;
            this.Lbl_vencimiento_deuda.Text = "Fecha Vencimiento Deuda:";
            // 
            // Lbl_id_DeudaP
            // 
            this.Lbl_id_DeudaP.AutoSize = true;
            this.Lbl_id_DeudaP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_DeudaP.Location = new System.Drawing.Point(32, 218);
            this.Lbl_id_DeudaP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id_DeudaP.Name = "Lbl_id_DeudaP";
            this.Lbl_id_DeudaP.Size = new System.Drawing.Size(138, 22);
            this.Lbl_id_DeudaP.TabIndex = 81;
            this.Lbl_id_DeudaP.Text = "No. Proveedor: ";
            // 
            // Txt_idfactura
            // 
            this.Txt_idfactura.AutoSize = true;
            this.Txt_idfactura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idfactura.Location = new System.Drawing.Point(33, 342);
            this.Txt_idfactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_idfactura.Name = "Txt_idfactura";
            this.Txt_idfactura.Size = new System.Drawing.Size(100, 22);
            this.Txt_idfactura.TabIndex = 107;
            this.Txt_idfactura.Text = "No. Fctura:";
            // 
            // Cbo_idfactura
            // 
            this.Cbo_idfactura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_idfactura.FormattingEnabled = true;
            this.Cbo_idfactura.Location = new System.Drawing.Point(286, 343);
            this.Cbo_idfactura.Name = "Cbo_idfactura";
            this.Cbo_idfactura.Size = new System.Drawing.Size(121, 30);
            this.Cbo_idfactura.TabIndex = 108;
            // 
            // Txt_fechaI
            // 
            this.Txt_fechaI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_fechaI.Location = new System.Drawing.Point(836, 218);
            this.Txt_fechaI.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_fechaI.Name = "Txt_fechaI";
            this.Txt_fechaI.Size = new System.Drawing.Size(268, 30);
            this.Txt_fechaI.TabIndex = 109;
            // 
            // Txt_fechaV
            // 
            this.Txt_fechaV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_fechaV.Location = new System.Drawing.Point(836, 263);
            this.Txt_fechaV.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_fechaV.Name = "Txt_fechaV";
            this.Txt_fechaV.Size = new System.Drawing.Size(268, 30);
            this.Txt_fechaV.TabIndex = 110;
            // 
            // Cbo_efectoT
            // 
            this.Cbo_efectoT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_efectoT.FormattingEnabled = true;
            this.Cbo_efectoT.Location = new System.Drawing.Point(286, 305);
            this.Cbo_efectoT.Name = "Cbo_efectoT";
            this.Cbo_efectoT.Size = new System.Drawing.Size(121, 30);
            this.Cbo_efectoT.TabIndex = 113;
            // 
            // Txt_efecto
            // 
            this.Txt_efecto.AutoSize = true;
            this.Txt_efecto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_efecto.Location = new System.Drawing.Point(33, 304);
            this.Txt_efecto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_efecto.Name = "Txt_efecto";
            this.Txt_efecto.Size = new System.Drawing.Size(186, 22);
            this.Txt_efecto.TabIndex = 112;
            this.Txt_efecto.Text = "Efecto de Transaccion";
            // 
            // Btn_reportes
            // 
            this.Btn_reportes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_reportes.Image = global::Capa_Vista_Cuentas_Corrientes.Properties.Resources.WhatsApp_Image_2024_11_07_at_9_13_34_PM;
            this.Btn_reportes.Location = new System.Drawing.Point(585, 27);
            this.Btn_reportes.Name = "Btn_reportes";
            this.Btn_reportes.Size = new System.Drawing.Size(65, 59);
            this.Btn_reportes.TabIndex = 114;
            this.toolTip1.SetToolTip(this.Btn_reportes, "Ver Reporte");
            this.Btn_reportes.UseVisualStyleBackColor = true;
            this.Btn_reportes.Click += new System.EventHandler(this.Btn_reportes_Click);
            // 
            // Btn_Ayudas
            // 
            this.Btn_Ayudas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayudas.Image = global::Capa_Vista_Cuentas_Corrientes.Properties.Resources.WhatsApp_Image_2024_11_07_at_9_08_55_PM;
            this.Btn_Ayudas.Location = new System.Drawing.Point(659, 27);
            this.Btn_Ayudas.Name = "Btn_Ayudas";
            this.Btn_Ayudas.Size = new System.Drawing.Size(65, 59);
            this.Btn_Ayudas.TabIndex = 111;
            this.toolTip1.SetToolTip(this.Btn_Ayudas, "Ver Ayuda");
            this.Btn_Ayudas.UseVisualStyleBackColor = true;
            this.Btn_Ayudas.Click += new System.EventHandler(this.Btn_Ayudas_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.Image = global::Capa_Vista_Cuentas_Corrientes.Properties.Resources.cerrar_sesion1;
            this.Btn_salir.Location = new System.Drawing.Point(740, 24);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(63, 65);
            this.Btn_salir.TabIndex = 106;
            this.toolTip1.SetToolTip(this.Btn_salir, "Salir");
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.Image = global::Capa_Vista_Cuentas_Corrientes.Properties.Resources.buscar;
            this.Btn_Buscar.Location = new System.Drawing.Point(522, 24);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(56, 59);
            this.Btn_Buscar.TabIndex = 105;
            this.toolTip1.SetToolTip(this.Btn_Buscar, "Buscar Registro");
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.Image = global::Capa_Vista_Cuentas_Corrientes.Properties.Resources.agregar_archivo;
            this.Btn_Actualizar.Location = new System.Drawing.Point(257, 24);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(62, 59);
            this.Btn_Actualizar.TabIndex = 100;
            this.toolTip1.SetToolTip(this.Btn_Actualizar, "Agregar Registro");
            this.Btn_Actualizar.UseVisualStyleBackColor = true;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = global::Capa_Vista_Cuentas_Corrientes.Properties.Resources.ahorrar3;
            this.Btn_guardar.Location = new System.Drawing.Point(327, 24);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(53, 59);
            this.Btn_guardar.TabIndex = 99;
            this.toolTip1.SetToolTip(this.Btn_guardar, "Guardar Registro");
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Image = global::Capa_Vista_Cuentas_Corrientes.Properties.Resources.borrar2;
            this.Btn_eliminar.Location = new System.Drawing.Point(454, 24);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(60, 59);
            this.Btn_eliminar.TabIndex = 98;
            this.toolTip1.SetToolTip(this.Btn_eliminar, "Borrar Registro");
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.Image = global::Capa_Vista_Cuentas_Corrientes.Properties.Resources.convenio1;
            this.Btn_editar.Location = new System.Drawing.Point(388, 24);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(58, 59);
            this.Btn_editar.TabIndex = 97;
            this.toolTip1.SetToolTip(this.Btn_editar, "Modificar Registro");
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 33);
            this.label1.TabIndex = 115;
            this.label1.Text = "DEUDAS - PROVEEDORES -\r\n";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            // 
            // DeudaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1157, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_reportes);
            this.Controls.Add(this.Cbo_efectoT);
            this.Controls.Add(this.Txt_efecto);
            this.Controls.Add(this.Btn_Ayudas);
            this.Controls.Add(this.Txt_fechaV);
            this.Controls.Add(this.Txt_fechaI);
            this.Controls.Add(this.Cbo_idfactura);
            this.Controls.Add(this.Txt_idfactura);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Dgv_deudas);
            this.Controls.Add(this.Cbo_Tipotrans);
            this.Controls.Add(this.Cbo_id_proveedor);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Txt_Descipcion);
            this.Controls.Add(this.Lbl_descrip_deuda);
            this.Controls.Add(this.Lbl_estado_deuda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_montoDeuda);
            this.Controls.Add(this.Lbl_Tipotrans);
            this.Controls.Add(this.Lbl_monto_dueda);
            this.Controls.Add(this.Cbo_estado);
            this.Controls.Add(this.Txt_id_deuda);
            this.Controls.Add(this.Lbl_id_deuda);
            this.Controls.Add(this.Lbl_inicio_deuda);
            this.Controls.Add(this.Lbl_vencimiento_deuda);
            this.Controls.Add(this.Lbl_id_DeudaP);
            this.Name = "DeudaProveedores";
            this.Text = "DeudaProveedores";
            this.Load += new System.EventHandler(this.DeudaProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_deudas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.DataGridView Dgv_deudas;
        private System.Windows.Forms.ComboBox Cbo_Tipotrans;
        private System.Windows.Forms.ComboBox Cbo_id_proveedor;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.TextBox Txt_Descipcion;
        private System.Windows.Forms.Label Lbl_descrip_deuda;
        private System.Windows.Forms.Label Lbl_estado_deuda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_montoDeuda;
        private System.Windows.Forms.Label Lbl_Tipotrans;
        private System.Windows.Forms.Label Lbl_monto_dueda;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.TextBox Txt_id_deuda;
        private System.Windows.Forms.Label Lbl_id_deuda;
        private System.Windows.Forms.Label Lbl_inicio_deuda;
        private System.Windows.Forms.Label Lbl_vencimiento_deuda;
        private System.Windows.Forms.Label Lbl_id_DeudaP;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Label Txt_idfactura;
        private System.Windows.Forms.ComboBox Cbo_idfactura;
        private System.Windows.Forms.TextBox Txt_fechaI;
        private System.Windows.Forms.TextBox Txt_fechaV;
        private System.Windows.Forms.Button Btn_Ayudas;
        private System.Windows.Forms.ComboBox Cbo_efectoT;
        private System.Windows.Forms.Label Txt_efecto;
        private System.Windows.Forms.Button Btn_reportes;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
    }
}