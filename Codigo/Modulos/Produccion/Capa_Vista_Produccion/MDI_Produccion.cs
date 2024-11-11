using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_Cierre_Produccion;
using Capa_Vista_Polizas_Prod;
using Capa_Vista_Receta;
using Capa_Vista_RRHH;
using Capa_Vista_Sistema_Produccion;
using Capa_Vista_Ordenes;
using Capa_Vista_Lotes;
using Capa_Vista_Mantenimiento;
using Capa_Vista_Maquinaria;
using System.Drawing.Imaging;

namespace Capa_Vista_Produccion
{
    public partial class MDI_Produccion : Form
    {
        // Variables para capturar la posición y el tamaño del formulario antes de maximizar
        int lx, ly;
        int sw, sh;
        private bool arrastrando = false;
        private Point posicionInicialCursor;
        private Point posicionInicialFormulario;

        // Variables para almacenar la referencia a los formularios de cierre y pólizas
        private Frm_Cierre cierreForm;
        private Frm_Polizas_Prod polizasForm;
        private Frm_Enlace_RRHH rrhhForm;
        private Frm_Recetas recetasForm;
        private Frm_Ordenes_De_Produccion opForm;
        private Frm_Sistema_Produccion spForm;
        private Frm_Lotes lForm;
        private Frm_Mantenimiento_Produccion mpForm;
        private Frm_Maquinaria mForm;

        public MDI_Produccion(string idUsuario)
        {
            InitializeComponent();
            this.IsMdiContainer = true;  // Configura el formulario como contenedor MDI
            ocultaSubMenu(); // Solo oculta los menús al inicio
            lbl_user.Text = idUsuario;

            // Configura el evento Tick de timer1 y comienza a ejecutarlo
            timer1.Tick += ActualizarFechaHora;
            timer1.Interval = 1000; // 1 segundo
            timer1.Start(); // Iniciar el Timer

            // Asignar eventos de arrastre al panelBarraTitulo
            panelBarraTitulo.MouseDown += PanelBarraTitulo_MouseDown;
            panelBarraTitulo.MouseMove += PanelBarraTitulo_MouseMove;
            panelBarraTitulo.MouseUp += PanelBarraTitulo_MouseUp;
        }

        string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

        // Evento MouseDown para iniciar el arrastre
        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrando = true;
            posicionInicialCursor = Cursor.Position;
            posicionInicialFormulario = this.Location;
        }

        // Evento MouseMove para mover el formulario mientras se arrastra
        private void PanelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastrando)
            {
                Point diferencia = Point.Subtract(Cursor.Position, new Size(posicionInicialCursor));
                this.Location = Point.Add(posicionInicialFormulario, new Size(diferencia));
            }
        }

        // Evento MouseUp para finalizar el arrastre
        private void PanelBarraTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrando = false;
        }

        // Ocultar submenús al iniciar (sin cerrar al abrir otro)
        private void ocultaSubMenu()
        {
            panelMenuProcesos.Visible = false;
            panelMenuMantenimiento.Visible = false;
        }

        // Evento Tick del Timer para actualizar la fecha y hora
        private void ActualizarFechaHora(object sender, EventArgs e)
        {
            lbl_fecha_y_hora.Text = DateTime.Now.ToString("G"); // Muestra la fecha y hora actual
        }

        // Mostrar u ocultar submenús (ahora se permite que los dos estén abiertos al mismo tiempo)
        private void muestraSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true; // Solo muestra el panel si está oculto
            }
            else
            {
                subMenu.Visible = false; // Oculta el panel si ya está visible
            }
        }

        // Función para cerrar el formulario
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Funcionalidades de botones de procesos
        // Botón de mantenimiento
        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            /*
              * Acá va la lógica para abrir el formulario de Mantenimientos
            */
        }

        // Botón de órdenes de producción
        private void btnOrdenesProduccion_Click(object sender, EventArgs e)
        {
            // Verifica si el formulario de pólizas ya está abierto
            if (opForm == null || opForm.IsDisposed)
            {
                pb_Fondo.Visible = false;

                // Crea el formulario de pólizas y configura sus propiedades
                opForm = new Frm_Ordenes_De_Produccion();
                opForm.MdiParent = this;
                opForm.StartPosition = FormStartPosition.CenterScreen;

                // Maneja el evento FormClosing para volver a mostrar pb_Fondo al cerrar el formulario
                opForm.FormClosing += (s, args) => { pb_Fondo.Visible = true; };

                // Muestra el formulario de pólizas
                opForm.Show();
            }
            else
            {
                opForm.BringToFront(); // Si el formulario ya está abierto, lo trae al frente
            }
        }

        // Botón de maquinaria
        private void btnMaquinaria_Click_1(object sender, EventArgs e)
        {
            // Verifica si el formulario de pólizas ya está abierto
            if (mForm == null || mForm.IsDisposed)
            {
                pb_Fondo.Visible = false;

                // Crea el formulario de pólizas y configura sus propiedades
                mForm = new Frm_Maquinaria();
                mForm.MdiParent = this;
                mForm.StartPosition = FormStartPosition.CenterScreen;

                // Maneja el evento FormClosing para volver a mostrar pb_Fondo al cerrar el formulario
                mForm.FormClosing += (s, args) => { pb_Fondo.Visible = true; };

                // Muestra el formulario de pólizas
                mForm.Show();
            }
            else
            {
                mForm.BringToFront(); // Si el formulario ya está abierto, lo trae al frente
            }
        }

        // Botón de empleados (enlace a RRHH)
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            
               // Verifica si el formulario de cierre ya está abierto
            if (rrhhForm == null || rrhhForm.IsDisposed)
            {
                pb_Fondo.Visible = false;

                // Crea el formulario de cierre y configura sus propiedades
                rrhhForm = new Frm_Enlace_RRHH();
                rrhhForm.MdiParent = this;
                rrhhForm.StartPosition = FormStartPosition.CenterScreen;

                // Maneja el evento FormClosing para volver a mostrar pb_Fondo al cerrar el formulario
                rrhhForm.FormClosing += (s, args) => { pb_Fondo.Visible = true; };

                // Muestra el formulario de cierre
                rrhhForm.Show();
            }
            else
            {
                rrhhForm.BringToFront(); // Si el formulario ya está abierto, lo trae al frente
            }
        }

        // Botón de cierre
        private void btnCierre_Click(object sender, EventArgs e)
        {
            // Verifica si el formulario de cierre ya está abierto
            if (cierreForm == null || cierreForm.IsDisposed)
            {
                pb_Fondo.Visible = false;

                // Crea el formulario de cierre y configura sus propiedades
                cierreForm = new Frm_Cierre();
                cierreForm.MdiParent = this;
                cierreForm.StartPosition = FormStartPosition.CenterScreen;

                // Maneja el evento FormClosing para volver a mostrar pb_Fondo al cerrar el formulario
                cierreForm.FormClosing += (s, args) => { pb_Fondo.Visible = true; };

                // Muestra el formulario de cierre
                cierreForm.Show();
            }
            else
            {
                cierreForm.BringToFront(); // Si el formulario ya está abierto, lo trae al frente
            }
        }

        // Botón de enlace a contabilidad (Pólizas)
        private void btnPolizas_Click(object sender, EventArgs e)
        {
            // Verifica si el formulario de pólizas ya está abierto
            if (polizasForm == null || polizasForm.IsDisposed)
            {
                pb_Fondo.Visible = false;

                // Crea el formulario de pólizas y configura sus propiedades
                polizasForm = new Frm_Polizas_Prod();
                polizasForm.MdiParent = this;
                polizasForm.StartPosition = FormStartPosition.CenterScreen;

                // Maneja el evento FormClosing para volver a mostrar pb_Fondo al cerrar el formulario
                polizasForm.FormClosing += (s, args) => { pb_Fondo.Visible = true; };

                // Muestra el formulario de pólizas
                polizasForm.Show();
            }
            else
            {
                polizasForm.BringToFront(); // Si el formulario ya está abierto, lo trae al frente
            }
        }

        // Botón de implosión/explosión de materiales
        private void btnImplosionExplosion_Click(object sender, EventArgs e)
        {
            /*
              * Acá va la lógica para abrir el formulario de Implosión y Explosión
            */
        }

        // Botón de sistema de producción
        private void btnProduccion_Click(object sender, EventArgs e)
        {
            // Verifica si el formulario de pólizas ya está abierto
            if (spForm == null || spForm.IsDisposed)
            {
                pb_Fondo.Visible = false;

                // Crea el formulario de pólizas y configura sus propiedades
                spForm = new Frm_Sistema_Produccion();
                spForm.MdiParent = this;
                spForm.StartPosition = FormStartPosition.CenterScreen;

                // Maneja el evento FormClosing para volver a mostrar pb_Fondo al cerrar el formulario
                spForm.FormClosing += (s, args) => { pb_Fondo.Visible = true; };

                // Muestra el formulario de pólizas
                spForm.Show();
            }
            else
            {
                spForm.BringToFront(); // Si el formulario ya está abierto, lo trae al frente
            }
        }


        // Botón de lotes
        private void btnLotes_Click_1(object sender, EventArgs e)
        {
            // Verifica si el formulario de pólizas ya está abierto
            if (lForm == null || lForm.IsDisposed)
            {
                pb_Fondo.Visible = false;

                // Crea el formulario de pólizas y configura sus propiedades
                lForm = new Frm_Lotes();
                lForm.MdiParent = this;
                lForm.StartPosition = FormStartPosition.CenterScreen;

                // Maneja el evento FormClosing para volver a mostrar pb_Fondo al cerrar el formulario
                lForm.FormClosing += (s, args) => { pb_Fondo.Visible = true; };

                // Muestra el formulario de pólizas
                lForm.Show();
            }
            else
            {
                lForm.BringToFront(); // Si el formulario ya está abierto, lo trae al frente
            }
        }
        #endregion

        // Mostrar el submenú de procesos
        private void btnMenuProcesos_Click(object sender, EventArgs e)
        {
            muestraSubMenu(panelMenuProcesos);
        }

        // Mostrar el submenú de mantenimiento
        private void btnMenuMantenimiento_Click_1(object sender, EventArgs e)
        {
            muestraSubMenu(panelMenuMantenimiento);
        }

        // Minimizar el formulario
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Maximizar el formulario
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            btn_Maximizar.Visible = false;
            btn_Restaurar.Visible = true;
        }

        private void Btn_Recetas_Click_1(object sender, EventArgs e)
        {
            
            // Verifica si el formulario de pólizas ya está abierto
            if (recetasForm == null || recetasForm.IsDisposed)
            {
                pb_Fondo.Visible = false;

                // Crea el formulario de pólizas y configura sus propiedades
                recetasForm = new Frm_Recetas();
                recetasForm.MdiParent = this;
                recetasForm.StartPosition = FormStartPosition.CenterScreen;

                // Maneja el evento FormClosing para volver a mostrar pb_Fondo al cerrar el formulario
                recetasForm.FormClosing += (s, args) => { pb_Fondo.Visible = true; };

                // Muestra el formulario de pólizas
                recetasForm.Show();
            }
            else
            {
                recetasForm.BringToFront(); // Si el formulario ya está abierto, lo trae al frente
            }
        }

        private void btnMantenimiento_Click_1(object sender, EventArgs e)
        {
            // Verifica si el formulario de pólizas ya está abierto
            if (mpForm == null || mpForm.IsDisposed)
            {
                pb_Fondo.Visible = false;

                // Crea el formulario de pólizas y configura sus propiedades
                mpForm = new Frm_Mantenimiento_Produccion();
                mpForm.MdiParent = this;
                mpForm.StartPosition = FormStartPosition.CenterScreen;

                // Maneja el evento FormClosing para volver a mostrar pb_Fondo al cerrar el formulario
                mpForm.FormClosing += (s, args) => { pb_Fondo.Visible = true; };

                // Muestra el formulario de pólizas
                mpForm.Show();
            }
            else
            {
                mpForm.BringToFront(); // Si el formulario ya está abierto, lo trae al frente
            }
        }

        // Restaurar el tamaño original de la ventana
        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            btn_Maximizar.Visible = true;
            btn_Restaurar.Visible = false;
        }

        // Función para salir del formulario
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
