
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class Deuda_Clts
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
            this.Txt_montoDeuda = new System.Windows.Forms.TextBox();
            this.Lbl_monto_dueda = new System.Windows.Forms.Label();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Txt_id_deuda = new System.Windows.Forms.TextBox();
            this.Lbl_id_deuda = new System.Windows.Forms.Label();
            this.Lbl_inicio_deuda = new System.Windows.Forms.Label();
            this.Lbl_vencimiento_deuda = new System.Windows.Forms.Label();
            this.Lbl_id_cobra_deuda = new System.Windows.Forms.Label();
            this.Lbl_id_clt_deuda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_estado_deuda = new System.Windows.Forms.Label();
            this.Lbl_descrip_deuda = new System.Windows.Forms.Label();
            this.Txt_Descipcion = new System.Windows.Forms.TextBox();
            this.Cbo_id_clientes = new System.Windows.Forms.ComboBox();
            this.Cbo_id_cobrador = new System.Windows.Forms.ComboBox();
            this.Dgv_deudas = new System.Windows.Forms.DataGridView();
            this.Text_tipoTrans = new System.Windows.Forms.Label();
            this.Cbo_idfactura = new System.Windows.Forms.ComboBox();
            this.Text_IdFactura = new System.Windows.Forms.Label();
            this.Cbo_tipoT = new System.Windows.Forms.ComboBox();
            this.Txt_FechaI = new System.Windows.Forms.TextBox();
            this.Txt_FechaV = new System.Windows.Forms.TextBox();
            this.Cbo_Efecto = new System.Windows.Forms.ComboBox();
            this.Txt_Efecto = new System.Windows.Forms.Label();
            this.Btn_reportes = new System.Windows.Forms.Button();
            this.Btn_Ayudas = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_deudas)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_montoDeuda
            // 
            this.Txt_montoDeuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_montoDeuda.Location = new System.Drawing.Point(739, 178);
            this.Txt_montoDeuda.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_montoDeuda.Name = "Txt_montoDeuda";
            this.Txt_montoDeuda.Size = new System.Drawing.Size(268, 30);
            this.Txt_montoDeuda.TabIndex = 56;
            // 
            // Lbl_monto_dueda
            // 
            this.Lbl_monto_dueda.AutoSize = true;
            this.Lbl_monto_dueda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_monto_dueda.Location = new System.Drawing.Point(510, 193);
            this.Lbl_monto_dueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_monto_dueda.Name = "Lbl_monto_dueda";
            this.Lbl_monto_dueda.Size = new System.Drawing.Size(147, 22);
            this.Lbl_monto_dueda.TabIndex = 54;
            this.Lbl_monto_dueda.Text = "Monto de Deuda:";
            this.Lbl_monto_dueda.Click += new System.EventHandler(this.Lbl_monto_dueda_Click);
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
            this.Cbo_estado.Location = new System.Drawing.Point(739, 341);
            this.Cbo_estado.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(146, 30);
            this.Cbo_estado.TabIndex = 53;
            // 
            // Txt_id_deuda
            // 
            this.Txt_id_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id_deuda.Location = new System.Drawing.Point(269, 183);
            this.Txt_id_deuda.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_id_deuda.Name = "Txt_id_deuda";
            this.Txt_id_deuda.Size = new System.Drawing.Size(171, 30);
            this.Txt_id_deuda.TabIndex = 52;
            // 
            // Lbl_id_deuda
            // 
            this.Lbl_id_deuda.AutoSize = true;
            this.Lbl_id_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_deuda.Location = new System.Drawing.Point(56, 186);
            this.Lbl_id_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id_deuda.Name = "Lbl_id_deuda";
            this.Lbl_id_deuda.Size = new System.Drawing.Size(88, 22);
            this.Lbl_id_deuda.TabIndex = 51;
            this.Lbl_id_deuda.Text = "Id Deuda:";
            // 
            // Lbl_inicio_deuda
            // 
            this.Lbl_inicio_deuda.AutoSize = true;
            this.Lbl_inicio_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_inicio_deuda.Location = new System.Drawing.Point(510, 230);
            this.Lbl_inicio_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_inicio_deuda.Name = "Lbl_inicio_deuda";
            this.Lbl_inicio_deuda.Size = new System.Drawing.Size(170, 22);
            this.Lbl_inicio_deuda.TabIndex = 49;
            this.Lbl_inicio_deuda.Text = "Fecha Inicio Deuda:";
            // 
            // Lbl_vencimiento_deuda
            // 
            this.Lbl_vencimiento_deuda.AutoSize = true;
            this.Lbl_vencimiento_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_vencimiento_deuda.Location = new System.Drawing.Point(510, 269);
            this.Lbl_vencimiento_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_vencimiento_deuda.Name = "Lbl_vencimiento_deuda";
            this.Lbl_vencimiento_deuda.Size = new System.Drawing.Size(221, 22);
            this.Lbl_vencimiento_deuda.TabIndex = 46;
            this.Lbl_vencimiento_deuda.Text = "Fecha Vencimiento Deuda:";
            // 
            // Lbl_id_cobra_deuda
            // 
            this.Lbl_id_cobra_deuda.AutoSize = true;
            this.Lbl_id_cobra_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_cobra_deuda.Location = new System.Drawing.Point(56, 259);
            this.Lbl_id_cobra_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id_cobra_deuda.Name = "Lbl_id_cobra_deuda";
            this.Lbl_id_cobra_deuda.Size = new System.Drawing.Size(113, 22);
            this.Lbl_id_cobra_deuda.TabIndex = 45;
            this.Lbl_id_cobra_deuda.Text = "Id Cobrador:";
            // 
            // Lbl_id_clt_deuda
            // 
            this.Lbl_id_clt_deuda.AutoSize = true;
            this.Lbl_id_clt_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_clt_deuda.Location = new System.Drawing.Point(56, 226);
            this.Lbl_id_clt_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id_clt_deuda.Name = "Lbl_id_clt_deuda";
            this.Lbl_id_clt_deuda.Size = new System.Drawing.Size(99, 22);
            this.Lbl_id_clt_deuda.TabIndex = 44;
            this.Lbl_id_clt_deuda.Text = "Id Cliente: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 33);
            this.label3.TabIndex = 60;
            this.label3.Text = "DEUDAS - CLIENTES -\r\n";
            // 
            // Lbl_estado_deuda
            // 
            this.Lbl_estado_deuda.AutoSize = true;
            this.Lbl_estado_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado_deuda.Location = new System.Drawing.Point(510, 343);
            this.Lbl_estado_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_estado_deuda.Name = "Lbl_estado_deuda";
            this.Lbl_estado_deuda.Size = new System.Drawing.Size(170, 22);
            this.Lbl_estado_deuda.TabIndex = 61;
            this.Lbl_estado_deuda.Text = "Estado de la Deuda:";
            // 
            // Lbl_descrip_deuda
            // 
            this.Lbl_descrip_deuda.AutoSize = true;
            this.Lbl_descrip_deuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descrip_deuda.Location = new System.Drawing.Point(510, 308);
            this.Lbl_descrip_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_descrip_deuda.Name = "Lbl_descrip_deuda";
            this.Lbl_descrip_deuda.Size = new System.Drawing.Size(213, 22);
            this.Lbl_descrip_deuda.TabIndex = 62;
            this.Lbl_descrip_deuda.Text = "Descripcion de la Deuda:";
            // 
            // Txt_Descipcion
            // 
            this.Txt_Descipcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descipcion.Location = new System.Drawing.Point(739, 302);
            this.Txt_Descipcion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Descipcion.Multiline = true;
            this.Txt_Descipcion.Name = "Txt_Descipcion";
            this.Txt_Descipcion.Size = new System.Drawing.Size(268, 31);
            this.Txt_Descipcion.TabIndex = 65;
            // 
            // Cbo_id_clientes
            // 
            this.Cbo_id_clientes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_id_clientes.FormattingEnabled = true;
            this.Cbo_id_clientes.Location = new System.Drawing.Point(268, 225);
            this.Cbo_id_clientes.Name = "Cbo_id_clientes";
            this.Cbo_id_clientes.Size = new System.Drawing.Size(121, 30);
            this.Cbo_id_clientes.TabIndex = 76;
            // 
            // Cbo_id_cobrador
            // 
            this.Cbo_id_cobrador.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_id_cobrador.FormattingEnabled = true;
            this.Cbo_id_cobrador.Location = new System.Drawing.Point(268, 260);
            this.Cbo_id_cobrador.Name = "Cbo_id_cobrador";
            this.Cbo_id_cobrador.Size = new System.Drawing.Size(121, 30);
            this.Cbo_id_cobrador.TabIndex = 77;
            // 
            // Dgv_deudas
            // 
            this.Dgv_deudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_deudas.Location = new System.Drawing.Point(81, 432);
            this.Dgv_deudas.Name = "Dgv_deudas";
            this.Dgv_deudas.RowHeadersWidth = 51;
            this.Dgv_deudas.RowTemplate.Height = 24;
            this.Dgv_deudas.Size = new System.Drawing.Size(926, 197);
            this.Dgv_deudas.TabIndex = 79;
            this.Dgv_deudas.DoubleClick += new System.EventHandler(this.Dgv_deudas_DoubleClick);
            // 
            // Text_tipoTrans
            // 
            this.Text_tipoTrans.AutoSize = true;
            this.Text_tipoTrans.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_tipoTrans.Location = new System.Drawing.Point(55, 302);
            this.Text_tipoTrans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Text_tipoTrans.Name = "Text_tipoTrans";
            this.Text_tipoTrans.Size = new System.Drawing.Size(178, 22);
            this.Text_tipoTrans.TabIndex = 83;
            this.Text_tipoTrans.Text = "Tipo de Transacción:";
            // 
            // Cbo_idfactura
            // 
            this.Cbo_idfactura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_idfactura.FormattingEnabled = true;
            this.Cbo_idfactura.Location = new System.Drawing.Point(268, 376);
            this.Cbo_idfactura.Name = "Cbo_idfactura";
            this.Cbo_idfactura.Size = new System.Drawing.Size(121, 30);
            this.Cbo_idfactura.TabIndex = 86;
            // 
            // Text_IdFactura
            // 
            this.Text_IdFactura.AutoSize = true;
            this.Text_IdFactura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_IdFactura.Location = new System.Drawing.Point(60, 377);
            this.Text_IdFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Text_IdFactura.Name = "Text_IdFactura";
            this.Text_IdFactura.Size = new System.Drawing.Size(109, 22);
            this.Text_IdFactura.TabIndex = 85;
            this.Text_IdFactura.Text = "No. Factura:";
            // 
            // Cbo_tipoT
            // 
            this.Cbo_tipoT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_tipoT.FormattingEnabled = true;
            this.Cbo_tipoT.Location = new System.Drawing.Point(268, 302);
            this.Cbo_tipoT.Name = "Cbo_tipoT";
            this.Cbo_tipoT.Size = new System.Drawing.Size(211, 30);
            this.Cbo_tipoT.TabIndex = 88;
            // 
            // Txt_FechaI
            // 
            this.Txt_FechaI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FechaI.Location = new System.Drawing.Point(739, 224);
            this.Txt_FechaI.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_FechaI.Name = "Txt_FechaI";
            this.Txt_FechaI.Size = new System.Drawing.Size(268, 30);
            this.Txt_FechaI.TabIndex = 89;
            // 
            // Txt_FechaV
            // 
            this.Txt_FechaV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FechaV.Location = new System.Drawing.Point(739, 264);
            this.Txt_FechaV.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_FechaV.Name = "Txt_FechaV";
            this.Txt_FechaV.Size = new System.Drawing.Size(268, 30);
            this.Txt_FechaV.TabIndex = 90;
            // 
            // Cbo_Efecto
            // 
            this.Cbo_Efecto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Efecto.FormattingEnabled = true;
            this.Cbo_Efecto.Location = new System.Drawing.Point(268, 339);
            this.Cbo_Efecto.Name = "Cbo_Efecto";
            this.Cbo_Efecto.Size = new System.Drawing.Size(121, 30);
            this.Cbo_Efecto.TabIndex = 92;
            // 
            // Txt_Efecto
            // 
            this.Txt_Efecto.AutoSize = true;
            this.Txt_Efecto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Efecto.Location = new System.Drawing.Point(51, 339);
            this.Txt_Efecto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_Efecto.Name = "Txt_Efecto";
            this.Txt_Efecto.Size = new System.Drawing.Size(192, 22);
            this.Txt_Efecto.TabIndex = 91;
            this.Txt_Efecto.Text = "Efecto de Transacción:";
            // 
            // Btn_reportes
            // 
            this.Btn_reportes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_reportes.Image = global::Capa_Vista_Cuentas_Corrientes.Properties.Resources.WhatsApp_Image_2024_11_07_at_9_13_34_PM;
            this.Btn_reportes.Location = new System.Drawing.Point(637, 41);
            this.Btn_reportes.Name = "Btn_reportes";
            this.Btn_reportes.Size = new System.Drawing.Size(65, 59);
            this.Btn_reportes.TabIndex = 116;
            this.toolTip1.SetToolTip(this.Btn_reportes, "Ver Reporte");
            this.Btn_reportes.UseVisualStyleBackColor = true;
            this.Btn_reportes.Click += new System.EventHandler(this.Btn_reportes_Click);
            // 
            // Btn_Ayudas
            // 
            this.Btn_Ayudas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayudas.Image = global::Capa_Vista_Cuentas_Corrientes.Properties.Resources.WhatsApp_Image_2024_11_07_at_9_08_55_PM;
            this.Btn_Ayudas.Location = new System.Drawing.Point(708, 41);
            this.Btn_Ayudas.Name = "Btn_Ayudas";
            this.Btn_Ayudas.Size = new System.Drawing.Size(65, 59);
            this.Btn_Ayudas.TabIndex = 115;
            this.toolTip1.SetToolTip(this.Btn_Ayudas, "Ver Ayudas");
            this.Btn_Ayudas.UseVisualStyleBackColor = true;
            this.Btn_Ayudas.Click += new System.EventHandler(this.Btn_Ayudas_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.Image = global::Capa_Vista_Cuentas_Corrientes.Properties.Resources.cerrar_sesion1;
            this.Btn_salir.Location = new System.Drawing.Point(779, 37);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(63, 65);
            this.Btn_salir.TabIndex = 87;
            this.toolTip1.SetToolTip(this.Btn_salir, "Salir");
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.Image = global::Capa_Vista_Cuentas_Corrientes.Properties.Resources.buscar;
            this.Btn_Buscar.Location = new System.Drawing.Point(569, 38);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(62, 62);
            this.Btn_Buscar.TabIndex = 80;
            this.toolTip1.SetToolTip(this.Btn_Buscar, "Buscar Registro");
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.Image = global::Capa_Vista_Cuentas_Corrientes.Properties.Resources.agregar_archivo5;
            this.Btn_Actualizar.Location = new System.Drawing.Point(297, 38);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(60, 62);
            this.Btn_Actualizar.TabIndex = 75;
            this.toolTip1.SetToolTip(this.Btn_Actualizar, "Agregar Registro");
            this.Btn_Actualizar.UseVisualStyleBackColor = true;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = global::Capa_Vista_Cuentas_Corrientes.Properties.Resources.ahorrar3;
            this.Btn_guardar.Location = new System.Drawing.Point(364, 39);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(63, 61);
            this.Btn_guardar.TabIndex = 74;
            this.toolTip1.SetToolTip(this.Btn_guardar, "Guardar Registro");
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Image = global::Capa_Vista_Cuentas_Corrientes.Properties.Resources.borrar2;
            this.Btn_eliminar.Location = new System.Drawing.Point(435, 38);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(58, 62);
            this.Btn_eliminar.TabIndex = 73;
            this.toolTip1.SetToolTip(this.Btn_eliminar, "Eliminar Registro");
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.Image = global::Capa_Vista_Cuentas_Corrientes.Properties.Resources.convenio1;
            this.Btn_editar.Location = new System.Drawing.Point(501, 38);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(60, 62);
            this.Btn_editar.TabIndex = 71;
            this.toolTip1.SetToolTip(this.Btn_editar, "Modificar Registro");
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            // 
            // Deuda_Clts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1084, 744);
            this.Controls.Add(this.Btn_reportes);
            this.Controls.Add(this.Btn_Ayudas);
            this.Controls.Add(this.Cbo_Efecto);
            this.Controls.Add(this.Txt_Efecto);
            this.Controls.Add(this.Txt_FechaV);
            this.Controls.Add(this.Txt_FechaI);
            this.Controls.Add(this.Cbo_tipoT);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Cbo_idfactura);
            this.Controls.Add(this.Text_IdFactura);
            this.Controls.Add(this.Text_tipoTrans);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Dgv_deudas);
            this.Controls.Add(this.Cbo_id_cobrador);
            this.Controls.Add(this.Cbo_id_clientes);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Txt_Descipcion);
            this.Controls.Add(this.Lbl_descrip_deuda);
            this.Controls.Add(this.Lbl_estado_deuda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_montoDeuda);
            this.Controls.Add(this.Lbl_monto_dueda);
            this.Controls.Add(this.Cbo_estado);
            this.Controls.Add(this.Txt_id_deuda);
            this.Controls.Add(this.Lbl_id_deuda);
            this.Controls.Add(this.Lbl_inicio_deuda);
            this.Controls.Add(this.Lbl_vencimiento_deuda);
            this.Controls.Add(this.Lbl_id_cobra_deuda);
            this.Controls.Add(this.Lbl_id_clt_deuda);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Deuda_Clts";
            this.Text = "Deuda_Clts";
            this.Load += new System.EventHandler(this.Deuda_Clts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_deudas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_montoDeuda;
        private System.Windows.Forms.Label Lbl_monto_dueda;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.TextBox Txt_id_deuda;
        private System.Windows.Forms.Label Lbl_id_deuda;
        private System.Windows.Forms.Label Lbl_inicio_deuda;
        private System.Windows.Forms.Label Lbl_vencimiento_deuda;
        private System.Windows.Forms.Label Lbl_id_cobra_deuda;
        private System.Windows.Forms.Label Lbl_id_clt_deuda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_estado_deuda;
        private System.Windows.Forms.Label Lbl_descrip_deuda;
        private System.Windows.Forms.TextBox Txt_Descipcion;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.ComboBox Cbo_id_clientes;
        private System.Windows.Forms.ComboBox Cbo_id_cobrador;
        private System.Windows.Forms.DataGridView Dgv_deudas;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label Text_tipoTrans;
        private System.Windows.Forms.ComboBox Cbo_idfactura;
        private System.Windows.Forms.Label Text_IdFactura;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.ComboBox Cbo_tipoT;
        private System.Windows.Forms.TextBox Txt_FechaI;
        private System.Windows.Forms.TextBox Txt_FechaV;
        private System.Windows.Forms.ComboBox Cbo_Efecto;
        private System.Windows.Forms.Label Txt_Efecto;
        private System.Windows.Forms.Button Btn_reportes;
        private System.Windows.Forms.Button Btn_Ayudas;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}