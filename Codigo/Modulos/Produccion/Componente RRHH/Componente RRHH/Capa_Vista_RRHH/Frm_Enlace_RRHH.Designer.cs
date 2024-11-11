
namespace Capa_Vista_RRHH
{
    partial class Frm_Enlace_RRHH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Enlace_RRHH));
            this.lbl_id_rrhh = new System.Windows.Forms.Label();
            this.lbl_empleado = new System.Windows.Forms.Label();
            this.lbl_salario = new System.Windows.Forms.Label();
            this.lbl_dias = new System.Windows.Forms.Label();
            this.lbl_total_pago = new System.Windows.Forms.Label();
            this.lbl_horas = new System.Windows.Forms.Label();
            this.lbl_total_horas = new System.Windows.Forms.Label();
            this.lbl_horas_extras = new System.Windows.Forms.Label();
            this.lbl_total_horas_extras = new System.Windows.Forms.Label();
            this.lbl_total_mano_obra = new System.Windows.Forms.Label();
            this.Txt_id_RRHH_prod = new System.Windows.Forms.TextBox();
            this.txt_Total_Dias = new System.Windows.Forms.TextBox();
            this.txt_Total_Horas = new System.Windows.Forms.TextBox();
            this.txt_Total_Horas_Extras = new System.Windows.Forms.TextBox();
            this.txt_Total_Mano_de_Obra = new System.Windows.Forms.TextBox();
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
            this.cbo_Empleado = new System.Windows.Forms.ComboBox();
            this.cbo_Salario = new System.Windows.Forms.ComboBox();
            this.cbo_Horas_Extras = new System.Windows.Forms.ComboBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.cbo_Dias = new System.Windows.Forms.ComboBox();
            this.cbo_Horas = new System.Windows.Forms.ComboBox();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.lbl_calcular = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id_rrhh
            // 
            this.lbl_id_rrhh.AutoSize = true;
            this.lbl_id_rrhh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_rrhh.Location = new System.Drawing.Point(66, 182);
            this.lbl_id_rrhh.Name = "lbl_id_rrhh";
            this.lbl_id_rrhh.Size = new System.Drawing.Size(89, 22);
            this.lbl_id_rrhh.TabIndex = 6;
            this.lbl_id_rrhh.Text = "ID RRHH";
            // 
            // lbl_empleado
            // 
            this.lbl_empleado.AutoSize = true;
            this.lbl_empleado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empleado.Location = new System.Drawing.Point(66, 231);
            this.lbl_empleado.Name = "lbl_empleado";
            this.lbl_empleado.Size = new System.Drawing.Size(90, 22);
            this.lbl_empleado.TabIndex = 7;
            this.lbl_empleado.Text = "Empleado";
            // 
            // lbl_salario
            // 
            this.lbl_salario.AutoSize = true;
            this.lbl_salario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salario.Location = new System.Drawing.Point(66, 274);
            this.lbl_salario.Name = "lbl_salario";
            this.lbl_salario.Size = new System.Drawing.Size(68, 22);
            this.lbl_salario.TabIndex = 8;
            this.lbl_salario.Text = "Salario";
            // 
            // lbl_dias
            // 
            this.lbl_dias.AutoSize = true;
            this.lbl_dias.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dias.Location = new System.Drawing.Point(66, 315);
            this.lbl_dias.Name = "lbl_dias";
            this.lbl_dias.Size = new System.Drawing.Size(47, 22);
            this.lbl_dias.TabIndex = 9;
            this.lbl_dias.Text = "Dias";
            // 
            // lbl_total_pago
            // 
            this.lbl_total_pago.AutoSize = true;
            this.lbl_total_pago.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_pago.Location = new System.Drawing.Point(66, 360);
            this.lbl_total_pago.Name = "lbl_total_pago";
            this.lbl_total_pago.Size = new System.Drawing.Size(95, 22);
            this.lbl_total_pago.TabIndex = 10;
            this.lbl_total_pago.Text = "Total Pago";
            // 
            // lbl_horas
            // 
            this.lbl_horas.AutoSize = true;
            this.lbl_horas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horas.Location = new System.Drawing.Point(359, 183);
            this.lbl_horas.Name = "lbl_horas";
            this.lbl_horas.Size = new System.Drawing.Size(58, 22);
            this.lbl_horas.TabIndex = 11;
            this.lbl_horas.Text = "Horas";
            // 
            // lbl_total_horas
            // 
            this.lbl_total_horas.AutoSize = true;
            this.lbl_total_horas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_horas.Location = new System.Drawing.Point(353, 226);
            this.lbl_total_horas.Name = "lbl_total_horas";
            this.lbl_total_horas.Size = new System.Drawing.Size(104, 22);
            this.lbl_total_horas.TabIndex = 12;
            this.lbl_total_horas.Text = "Total Horas";
            // 
            // lbl_horas_extras
            // 
            this.lbl_horas_extras.AutoSize = true;
            this.lbl_horas_extras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horas_extras.Location = new System.Drawing.Point(353, 274);
            this.lbl_horas_extras.Name = "lbl_horas_extras";
            this.lbl_horas_extras.Size = new System.Drawing.Size(113, 22);
            this.lbl_horas_extras.TabIndex = 13;
            this.lbl_horas_extras.Text = "Horas Extras";
            // 
            // lbl_total_horas_extras
            // 
            this.lbl_total_horas_extras.AutoSize = true;
            this.lbl_total_horas_extras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_horas_extras.Location = new System.Drawing.Point(353, 315);
            this.lbl_total_horas_extras.Name = "lbl_total_horas_extras";
            this.lbl_total_horas_extras.Size = new System.Drawing.Size(159, 22);
            this.lbl_total_horas_extras.TabIndex = 14;
            this.lbl_total_horas_extras.Text = "Total Horas Extras";
            // 
            // lbl_total_mano_obra
            // 
            this.lbl_total_mano_obra.AutoSize = true;
            this.lbl_total_mano_obra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_mano_obra.Location = new System.Drawing.Point(353, 360);
            this.lbl_total_mano_obra.Name = "lbl_total_mano_obra";
            this.lbl_total_mano_obra.Size = new System.Drawing.Size(170, 22);
            this.lbl_total_mano_obra.TabIndex = 15;
            this.lbl_total_mano_obra.Text = "Total Mano de Obra";
            // 
            // Txt_id_RRHH_prod
            // 
            this.Txt_id_RRHH_prod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id_RRHH_prod.Location = new System.Drawing.Point(161, 183);
            this.Txt_id_RRHH_prod.Name = "Txt_id_RRHH_prod";
            this.Txt_id_RRHH_prod.Size = new System.Drawing.Size(121, 30);
            this.Txt_id_RRHH_prod.TabIndex = 16;
            // 
            // txt_Total_Dias
            // 
            this.txt_Total_Dias.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_Dias.Location = new System.Drawing.Point(161, 360);
            this.txt_Total_Dias.Name = "txt_Total_Dias";
            this.txt_Total_Dias.ReadOnly = true;
            this.txt_Total_Dias.Size = new System.Drawing.Size(121, 30);
            this.txt_Total_Dias.TabIndex = 18;
            // 
            // txt_Total_Horas
            // 
            this.txt_Total_Horas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_Horas.Location = new System.Drawing.Point(529, 226);
            this.txt_Total_Horas.Name = "txt_Total_Horas";
            this.txt_Total_Horas.ReadOnly = true;
            this.txt_Total_Horas.Size = new System.Drawing.Size(124, 30);
            this.txt_Total_Horas.TabIndex = 20;
            // 
            // txt_Total_Horas_Extras
            // 
            this.txt_Total_Horas_Extras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_Horas_Extras.Location = new System.Drawing.Point(529, 312);
            this.txt_Total_Horas_Extras.Name = "txt_Total_Horas_Extras";
            this.txt_Total_Horas_Extras.ReadOnly = true;
            this.txt_Total_Horas_Extras.Size = new System.Drawing.Size(124, 30);
            this.txt_Total_Horas_Extras.TabIndex = 21;
            // 
            // txt_Total_Mano_de_Obra
            // 
            this.txt_Total_Mano_de_Obra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_Mano_de_Obra.Location = new System.Drawing.Point(529, 360);
            this.txt_Total_Mano_de_Obra.Name = "txt_Total_Mano_de_Obra";
            this.txt_Total_Mano_de_Obra.ReadOnly = true;
            this.txt_Total_Mano_de_Obra.Size = new System.Drawing.Size(124, 30);
            this.txt_Total_Mano_de_Obra.TabIndex = 22;
            // 
            // dgv_empleados
            // 
            this.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleados.Location = new System.Drawing.Point(23, 410);
            this.dgv_empleados.Name = "dgv_empleados";
            this.dgv_empleados.RowHeadersWidth = 51;
            this.dgv_empleados.RowTemplate.Height = 24;
            this.dgv_empleados.Size = new System.Drawing.Size(746, 150);
            this.dgv_empleados.TabIndex = 26;
            // 
            // cbo_Empleado
            // 
            this.cbo_Empleado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Empleado.FormattingEnabled = true;
            this.cbo_Empleado.Location = new System.Drawing.Point(161, 226);
            this.cbo_Empleado.Name = "cbo_Empleado";
            this.cbo_Empleado.Size = new System.Drawing.Size(121, 30);
            this.cbo_Empleado.TabIndex = 27;
            // 
            // cbo_Salario
            // 
            this.cbo_Salario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Salario.FormattingEnabled = true;
            this.cbo_Salario.Location = new System.Drawing.Point(161, 275);
            this.cbo_Salario.Name = "cbo_Salario";
            this.cbo_Salario.Size = new System.Drawing.Size(121, 30);
            this.cbo_Salario.TabIndex = 28;
            // 
            // cbo_Horas_Extras
            // 
            this.cbo_Horas_Extras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Horas_Extras.FormattingEnabled = true;
            this.cbo_Horas_Extras.Location = new System.Drawing.Point(529, 272);
            this.cbo_Horas_Extras.Name = "cbo_Horas_Extras";
            this.cbo_Horas_Extras.Size = new System.Drawing.Size(124, 30);
            this.cbo_Horas_Extras.TabIndex = 29;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_titulo.Location = new System.Drawing.Point(298, 21);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(225, 23);
            this.lbl_titulo.TabIndex = 35;
            this.lbl_titulo.Text = "Calculo de Mano de Obra";
            // 
            // cbo_Dias
            // 
            this.cbo_Dias.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Dias.FormattingEnabled = true;
            this.cbo_Dias.Location = new System.Drawing.Point(161, 318);
            this.cbo_Dias.Name = "cbo_Dias";
            this.cbo_Dias.Size = new System.Drawing.Size(121, 30);
            this.cbo_Dias.TabIndex = 36;
            // 
            // cbo_Horas
            // 
            this.cbo_Horas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Horas.FormattingEnabled = true;
            this.cbo_Horas.Location = new System.Drawing.Point(529, 181);
            this.cbo_Horas.Name = "cbo_Horas";
            this.cbo_Horas.Size = new System.Drawing.Size(121, 30);
            this.cbo_Horas.TabIndex = 37;
            // 
            // btn_reportes
            // 
            this.btn_reportes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_reportes.BackgroundImage = global::Capa_Vista_RRHH.Properties.Resources.impresora;
            this.btn_reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_reportes.Location = new System.Drawing.Point(576, 66);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(92, 74);
            this.btn_reportes.TabIndex = 38;
            this.btn_reportes.UseVisualStyleBackColor = false;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Ayuda.BackgroundImage = global::Capa_Vista_RRHH.Properties.Resources.AYUDA_V4;
            this.btn_Ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Ayuda.Location = new System.Drawing.Point(471, 63);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(83, 77);
            this.btn_Ayuda.TabIndex = 34;
            this.btn_Ayuda.UseVisualStyleBackColor = false;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Salir.BackgroundImage = global::Capa_Vista_RRHH.Properties.Resources.SALIR_V4;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Salir.Location = new System.Drawing.Point(741, 12);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(80, 77);
            this.btn_Salir.TabIndex = 33;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Consultar.BackgroundImage = global::Capa_Vista_RRHH.Properties.Resources.BUCAR_V4;
            this.btn_Consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Consultar.Location = new System.Drawing.Point(363, 62);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(88, 77);
            this.btn_Consultar.TabIndex = 32;
            this.btn_Consultar.UseVisualStyleBackColor = false;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Guardar.BackgroundImage = global::Capa_Vista_RRHH.Properties.Resources.guardar;
            this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Guardar.Location = new System.Drawing.Point(262, 62);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(82, 78);
            this.btn_Guardar.TabIndex = 5;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Calcular.BackgroundImage = global::Capa_Vista_RRHH.Properties.Resources.ACTUALIZAR_V4;
            this.btn_Calcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Calcular.Location = new System.Drawing.Point(680, 231);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(89, 83);
            this.btn_Calcular.TabIndex = 4;
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Nuevo.BackgroundImage = global::Capa_Vista_RRHH.Properties.Resources.INGRESAR_V4;
            this.btn_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Nuevo.Location = new System.Drawing.Point(151, 63);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(82, 77);
            this.btn_Nuevo.TabIndex = 0;
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // lbl_calcular
            // 
            this.lbl_calcular.AutoSize = true;
            this.lbl_calcular.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calcular.Location = new System.Drawing.Point(685, 203);
            this.lbl_calcular.Name = "lbl_calcular";
            this.lbl_calcular.Size = new System.Drawing.Size(81, 23);
            this.lbl_calcular.TabIndex = 39;
            this.lbl_calcular.Text = "Calcular";
            // 
            // Frm_Enlace_RRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 596);
            this.Controls.Add(this.lbl_calcular);
            this.Controls.Add(this.btn_reportes);
            this.Controls.Add(this.cbo_Horas);
            this.Controls.Add(this.cbo_Dias);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.cbo_Horas_Extras);
            this.Controls.Add(this.cbo_Salario);
            this.Controls.Add(this.cbo_Empleado);
            this.Controls.Add(this.dgv_empleados);
            this.Controls.Add(this.txt_Total_Mano_de_Obra);
            this.Controls.Add(this.txt_Total_Horas_Extras);
            this.Controls.Add(this.txt_Total_Horas);
            this.Controls.Add(this.txt_Total_Dias);
            this.Controls.Add(this.Txt_id_RRHH_prod);
            this.Controls.Add(this.lbl_total_mano_obra);
            this.Controls.Add(this.lbl_total_horas_extras);
            this.Controls.Add(this.lbl_horas_extras);
            this.Controls.Add(this.lbl_total_horas);
            this.Controls.Add(this.lbl_horas);
            this.Controls.Add(this.lbl_total_pago);
            this.Controls.Add(this.lbl_dias);
            this.Controls.Add(this.lbl_salario);
            this.Controls.Add(this.lbl_empleado);
            this.Controls.Add(this.lbl_id_rrhh);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.btn_Nuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Enlace_RRHH";
            this.Text = "Mano de obra";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label lbl_id_rrhh;
        private System.Windows.Forms.Label lbl_empleado;
        private System.Windows.Forms.Label lbl_salario;
        private System.Windows.Forms.Label lbl_dias;
        private System.Windows.Forms.Label lbl_total_pago;
        private System.Windows.Forms.Label lbl_horas;
        private System.Windows.Forms.Label lbl_total_horas;
        private System.Windows.Forms.Label lbl_horas_extras;
        private System.Windows.Forms.Label lbl_total_horas_extras;
        private System.Windows.Forms.Label lbl_total_mano_obra;
        private System.Windows.Forms.TextBox Txt_id_RRHH_prod;
        private System.Windows.Forms.TextBox txt_Total_Dias;
        private System.Windows.Forms.TextBox txt_Total_Horas;
        private System.Windows.Forms.TextBox txt_Total_Horas_Extras;
        private System.Windows.Forms.TextBox txt_Total_Mano_de_Obra;
        private System.Windows.Forms.DataGridView dgv_empleados;
        private System.Windows.Forms.ComboBox cbo_Empleado;
        private System.Windows.Forms.ComboBox cbo_Salario;
        private System.Windows.Forms.ComboBox cbo_Horas_Extras;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.ComboBox cbo_Dias;
        private System.Windows.Forms.ComboBox cbo_Horas;
        private System.Windows.Forms.Button btn_reportes;
        private System.Windows.Forms.Label lbl_calcular;
    }
}