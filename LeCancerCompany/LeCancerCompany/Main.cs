using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeCancerCompany
{
    public partial class Main : Form
    {
        public List<Button> Botones = new List<Button>();

        Registro registro = new Registro();
        public static bool registroCreado = false;

        Vizualizador visualizador = new Vizualizador();
        public static bool visorCreado = false;

        public static bool pantallaIncompleta;


        public Main()
        {
            InitializeComponent();

            Botones.Add(registroOpen);
            Botones.Add(visorOpen);
            Botones.Add(cerrar);
            Botones.Add(expandir);

            pantallaIncompleta = this.WindowState == FormWindowState.Normal;
        }

        public void MakeChildForm(Form childForm)
        {
            childForm.MdiParent = this;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void registroOpen_Click(object sender, EventArgs e)
        {
            if (visorCreado)
            {
                visualizador.Dispose();
                visorCreado = false;
            }

            if ( !registroCreado ) {
                registro = new Registro();
                //registro.MdiParent = Main.ActiveForm;
                registro.TopLevel = false;
                contenedor.Controls.Add(registro);
                registro.Show();
                registro.BringToFront();
                //registro.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                registroCreado = true;
            }

        }

        private void visorOpen_Click(object sender, EventArgs e)
        {
            if (registroCreado)
            {
                registro.Dispose();
                registroCreado = false;
            }

            if (!visorCreado)
            {
                visualizador = new Vizualizador();
                //registro.MdiParent = Main.ActiveForm;
                visualizador.TopLevel = false;
                contenedor.Controls.Add(visualizador);
                visualizador.Show();
                visualizador.BringToFront();
                //registro.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                visorCreado = true;
            }
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void expandir_Click(object sender, EventArgs e)
        {
            pantallaIncompleta = this.WindowState == FormWindowState.Normal;

            if (pantallaIncompleta)
            {
                this.WindowState = FormWindowState.Maximized;
                Mover(pantallaIncompleta, 400);

                if (registroCreado) {
                    registro.MoverRegistro(pantallaIncompleta);
                }

                pantallaIncompleta = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                Mover(pantallaIncompleta, 400);

                if (registroCreado)
                {
                    registro.MoverRegistro(pantallaIncompleta);
                }

                pantallaIncompleta = true;
            }
        }

        private void Mover(bool holick, int distancia) 
        {
            if (holick)
            {
                foreach (Button boton in Botones)
                {
                    boton.Left += distancia;
                }
            }
            else
            {
                foreach (Button boton in Botones)
                {
                    boton.Left -= distancia;
                }
            }
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( Convert.ToInt16(e.KeyChar) == 27)
            {
                MessageBox.Show("elmio");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 27)
            {
                MessageBox.Show("elmio");
            }
        }

        


    }
}
