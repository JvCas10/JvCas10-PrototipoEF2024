
namespace Capa_Vista_Movimientos
{
    partial class frm_movimiento_bancario
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
            this.Txt_mov = new System.Windows.Forms.Label();
            this.Dgv_Mov = new System.Windows.Forms.DataGridView();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.Txt_ID = new System.Windows.Forms.Label();
            this.txtCuentaId = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtMetodoPago = new System.Windows.Forms.TextBox();
            this.Txt_fecha = new System.Windows.Forms.Label();
            this.Txt_tipo = new System.Windows.Forms.Label();
            this.Txt_monto = new System.Windows.Forms.Label();
            this.Txt_desc = new System.Windows.Forms.Label();
            this.Txt_metodo = new System.Windows.Forms.Label();
            this.Txt_estado = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Mov)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_mov
            // 
            this.Txt_mov.AutoSize = true;
            this.Txt_mov.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_mov.Location = new System.Drawing.Point(211, 34);
            this.Txt_mov.Name = "Txt_mov";
            this.Txt_mov.Size = new System.Drawing.Size(385, 31);
            this.Txt_mov.TabIndex = 0;
            this.Txt_mov.Text = "MOVIMIENTOS BANCARIOS";
            this.Txt_mov.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dgv_Mov
            // 
            this.Dgv_Mov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Mov.Location = new System.Drawing.Point(38, 212);
            this.Dgv_Mov.Name = "Dgv_Mov";
            this.Dgv_Mov.Size = new System.Drawing.Size(735, 226);
            this.Dgv_Mov.TabIndex = 1;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(655, 157);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(108, 34);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // Txt_ID
            // 
            this.Txt_ID.AutoSize = true;
            this.Txt_ID.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ID.Location = new System.Drawing.Point(35, 91);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(88, 15);
            this.Txt_ID.TabIndex = 4;
            this.Txt_ID.Text = "ID Movimiento";
            // 
            // txtCuentaId
            // 
            this.txtCuentaId.Location = new System.Drawing.Point(38, 109);
            this.txtCuentaId.Name = "txtCuentaId";
            this.txtCuentaId.Size = new System.Drawing.Size(100, 20);
            this.txtCuentaId.TabIndex = 5;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(207, 109);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 7;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(207, 157);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(378, 109);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 9;
            // 
            // txtMetodoPago
            // 
            this.txtMetodoPago.Location = new System.Drawing.Point(378, 157);
            this.txtMetodoPago.Name = "txtMetodoPago";
            this.txtMetodoPago.Size = new System.Drawing.Size(100, 20);
            this.txtMetodoPago.TabIndex = 10;
            // 
            // Txt_fecha
            // 
            this.Txt_fecha.AutoSize = true;
            this.Txt_fecha.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_fecha.Location = new System.Drawing.Point(35, 137);
            this.Txt_fecha.Name = "Txt_fecha";
            this.Txt_fecha.Size = new System.Drawing.Size(39, 15);
            this.Txt_fecha.TabIndex = 12;
            this.Txt_fecha.Text = "Fecha";
            // 
            // Txt_tipo
            // 
            this.Txt_tipo.AutoSize = true;
            this.Txt_tipo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_tipo.Location = new System.Drawing.Point(204, 91);
            this.Txt_tipo.Name = "Txt_tipo";
            this.Txt_tipo.Size = new System.Drawing.Size(32, 15);
            this.Txt_tipo.TabIndex = 13;
            this.Txt_tipo.Text = "Tipo";
            // 
            // Txt_monto
            // 
            this.Txt_monto.AutoSize = true;
            this.Txt_monto.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_monto.Location = new System.Drawing.Point(204, 139);
            this.Txt_monto.Name = "Txt_monto";
            this.Txt_monto.Size = new System.Drawing.Size(44, 15);
            this.Txt_monto.TabIndex = 14;
            this.Txt_monto.Text = "Monto";
            // 
            // Txt_desc
            // 
            this.Txt_desc.AutoSize = true;
            this.Txt_desc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_desc.Location = new System.Drawing.Point(375, 91);
            this.Txt_desc.Name = "Txt_desc";
            this.Txt_desc.Size = new System.Drawing.Size(71, 15);
            this.Txt_desc.TabIndex = 15;
            this.Txt_desc.Text = "Descripcion";
            // 
            // Txt_metodo
            // 
            this.Txt_metodo.AutoSize = true;
            this.Txt_metodo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_metodo.Location = new System.Drawing.Point(375, 139);
            this.Txt_metodo.Name = "Txt_metodo";
            this.Txt_metodo.Size = new System.Drawing.Size(96, 15);
            this.Txt_metodo.TabIndex = 16;
            this.Txt_metodo.Text = "Método de pago";
            // 
            // Txt_estado
            // 
            this.Txt_estado.AutoSize = true;
            this.Txt_estado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_estado.Location = new System.Drawing.Point(521, 114);
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.Size = new System.Drawing.Size(44, 15);
            this.Txt_estado.TabIndex = 17;
            this.Txt_estado.Text = "Estado";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(38, 157);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 18;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(493, 131);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(655, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Ayudas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frm_movimiento_bancario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(180)))), ((int)(((byte)(2)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.Txt_estado);
            this.Controls.Add(this.Txt_metodo);
            this.Controls.Add(this.Txt_desc);
            this.Controls.Add(this.Txt_monto);
            this.Controls.Add(this.Txt_tipo);
            this.Controls.Add(this.Txt_fecha);
            this.Controls.Add(this.txtMetodoPago);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtCuentaId);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.Dgv_Mov);
            this.Controls.Add(this.Txt_mov);
            this.Name = "frm_movimiento_bancario";
            this.Text = "frm_movimiento_bancario";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Mov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_mov;
        private System.Windows.Forms.DataGridView Dgv_Mov;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label Txt_ID;
        private System.Windows.Forms.TextBox txtCuentaId;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtMetodoPago;
        private System.Windows.Forms.Label Txt_fecha;
        private System.Windows.Forms.Label Txt_tipo;
        private System.Windows.Forms.Label Txt_monto;
        private System.Windows.Forms.Label Txt_desc;
        private System.Windows.Forms.Label Txt_metodo;
        private System.Windows.Forms.Label Txt_estado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button button1;
    }
}