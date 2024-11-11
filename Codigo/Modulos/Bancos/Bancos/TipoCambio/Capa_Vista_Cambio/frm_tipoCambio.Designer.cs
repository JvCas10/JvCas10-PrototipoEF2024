
namespace Capa_Vista_Cambio
{
    partial class frm_tipoCambio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_tipoCambio));
            this.cbo_Monedas = new System.Windows.Forms.ComboBox();
            this.dgv_TipoCambio = new System.Windows.Forms.DataGridView();
            this.txt_seleccionar = new System.Windows.Forms.Label();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TipoCambio)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_Monedas
            // 
            this.cbo_Monedas.FormattingEnabled = true;
            this.cbo_Monedas.Location = new System.Drawing.Point(333, 173);
            this.cbo_Monedas.Name = "cbo_Monedas";
            this.cbo_Monedas.Size = new System.Drawing.Size(139, 23);
            this.cbo_Monedas.TabIndex = 10;
            // 
            // dgv_TipoCambio
            // 
            this.dgv_TipoCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TipoCambio.Location = new System.Drawing.Point(24, 22);
            this.dgv_TipoCambio.Name = "dgv_TipoCambio";
            this.dgv_TipoCambio.RowHeadersWidth = 51;
            this.dgv_TipoCambio.RowTemplate.Height = 24;
            this.dgv_TipoCambio.Size = new System.Drawing.Size(278, 288);
            this.dgv_TipoCambio.TabIndex = 9;
            // 
            // txt_seleccionar
            // 
            this.txt_seleccionar.AutoSize = true;
            this.txt_seleccionar.Location = new System.Drawing.Point(331, 147);
            this.txt_seleccionar.Name = "txt_seleccionar";
            this.txt_seleccionar.Size = new System.Drawing.Size(144, 16);
            this.txt_seleccionar.TabIndex = 8;
            this.txt_seleccionar.Text = "Seleecionar una moneda";
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Actualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Actualizar.BackgroundImage")));
            this.btn_Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Actualizar.Location = new System.Drawing.Point(432, 220);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(40, 40);
            this.btn_Actualizar.TabIndex = 7;
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.BackgroundImage")));
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Buscar.Location = new System.Drawing.Point(333, 218);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(40, 42);
            this.btn_Buscar.TabIndex = 6;
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txt_titulo
            // 
            this.txt_titulo.AutoSize = true;
            this.txt_titulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulo.Location = new System.Drawing.Point(330, 59);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(142, 23);
            this.txt_titulo.TabIndex = 11;
            this.txt_titulo.Text = "Tipo de Cambio";
            // 
            // frm_tipoCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(180)))), ((int)(((byte)(2)))));
            this.ClientSize = new System.Drawing.Size(507, 328);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.cbo_Monedas);
            this.Controls.Add(this.dgv_TipoCambio);
            this.Controls.Add(this.txt_seleccionar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Buscar);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_tipoCambio";
            this.Text = "Tipo de Cambio";
            this.Load += new System.EventHandler(this.tipoCambio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TipoCambio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Monedas;
        private System.Windows.Forms.DataGridView dgv_TipoCambio;
        private System.Windows.Forms.Label txt_seleccionar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label txt_titulo;
    }
}