
namespace Capa_Vista_Cierre_Produccion
{
    partial class Frm_Cierre_Reporte
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Reporte_Cierre1 = new Capa_Vista_Cierre_Produccion.Reporte_Cierre();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Reporte_Cierre2 = new Capa_Vista_Cierre_Produccion.Reporte_Cierre();
            this.Reporte_Cierre3 = new Capa_Vista_Cierre_Produccion.Reporte_Cierre();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.Reporte_Cierre1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1104, 727);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = "C:\\Users\\DELL-PC\\OneDrive\\Escritorio\\1. AS_2 Producción 60%\\asis22k24proy2\\Report" +
    "es\\Modulos\\Produccion\\Cierre_Produccion\\Reporte_Cierre.rpt";
            this.crystalReportViewer2.Size = new System.Drawing.Size(1104, 727);
            this.crystalReportViewer2.TabIndex = 1;
            // 
            // Frm_Cierre_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 727);
            this.Controls.Add(this.crystalReportViewer2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Frm_Cierre_Reporte";
            this.Text = "Frm_Cierre_Reporte";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Reporte_Cierre Reporte_Cierre1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private Reporte_Cierre Reporte_Cierre2;
        private Reporte_Cierre Reporte_Cierre3;
    }
}