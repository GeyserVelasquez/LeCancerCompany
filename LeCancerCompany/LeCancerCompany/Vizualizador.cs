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
    public partial class Vizualizador : Form
    {
        public Vizualizador()
        {
            InitializeComponent();
            llenarGrid();
        }

        private void llenarGrid() {

            foreach (Persona paciente in Informacion.enfermos) {

                visorPacientes.Rows.Add(
                    ++Informacion.contador,
                    paciente.cedula,
                    paciente.nombre,
                    paciente.apellido,
                    paciente.edad,
                    paciente.sexo,
                    "Positivo",
                    paciente.condicion,
                    paciente.deuda);

                Informacion.contadorEnfermos++;
                Informacion.contadorDeuda += paciente.deuda;
            }

            foreach (Persona paciente in Informacion.saludables)
            {

                visorPacientes.Rows.Add(
                    ++Informacion.contador,
                    paciente.cedula,
                    paciente.nombre,
                    paciente.apellido,
                    paciente.edad,
                    paciente.sexo,
                    "Negativo",
                    paciente.condicion,
                    paciente.deuda);

                Informacion.contadorSanos++;
                Informacion.contadorDeuda += paciente.deuda;
            }

            alterarContador();
        }

        private void filtrarGrid()
        {
            reiniciarContador();

            foreach (DataGridViewRow fila in visorPacientes.Rows)
            {
                bool mostrarFila = true;

                // Filtrar por estado de salud
                if (!string.IsNullOrEmpty(Convert.ToString(fila.Cells["enfermo"].Value)))
                {
                    if (!sano.Checked && Convert.ToString(fila.Cells["enfermo"].Value) == "Negativo")
                    {
                        mostrarFila = false;
                    }
                    if (!enfermito.Checked && Convert.ToString(fila.Cells["enfermo"].Value) == "Positivo")
                    {
                        mostrarFila = false;
                    }
                }

                // Filtrar por sexo
                if (!string.IsNullOrEmpty(Convert.ToString(fila.Cells["sexo"].Value)))
                {
                    if (!hombre.Checked && Convert.ToString(fila.Cells["sexo"].Value) == "Masculino")
                    {
                        mostrarFila = false;
                    }
                    if (!mujer.Checked && Convert.ToString(fila.Cells["sexo"].Value) == "Femenino")
                    {
                        mostrarFila = false;
                    }
                    if (!otros.Checked && Convert.ToString(fila.Cells["sexo"].Value) == "Otro")
                    {
                        mostrarFila = false;
                    }
                }

                // Filtrar por edad
                if (edadBox.SelectedIndex != -1)
                {
                    if (!string.IsNullOrEmpty(edadBox.Text))
                    {
                        if (Convert.ToInt16(fila.Cells["edad"].Value) > Convert.ToInt16(edadBox.Text))
                        {
                            mostrarFila = false;
                        }
                    }
                }

                fila.Visible = mostrarFila;

                if (mostrarFila) 
                {
                    double deuda = Convert.ToDouble(fila.Cells["deuda"].Value);
                    Informacion.contadorDeuda += deuda;
                }
            }


        }


        private void sano_CheckedChanged(object sender, EventArgs e)
        {

            //foreach (DataGridViewRow fila in visorPacientes.Rows)
            //{
            //    if (!sano.Checked)
            //    {
            //        if (Convert.ToString(fila.Cells["enfermo"].Value) == "Negativo")
            //        {
            //            fila.Visible = false;
            //        }
            //    }
            //    else
            //    {
            //        if (Convert.ToString(fila.Cells["enfermo"].Value) == "Negativo")
            //        {
            //            fila.Visible = true;
            //        }
            //    }
            //}
            filtrarGrid();

        }

        private void enfermito_CheckedChanged(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow fila in visorPacientes.Rows)
            //{
            //    if (!enfermito.Checked)
            //    {
            //        if (Convert.ToString(fila.Cells["enfermo"].Value) == "positivo")
            //        {
            //            fila.Visible = false;
            //        }
            //    }
            //    else
            //    {
            //        if (Convert.ToString(fila.Cells["enfermo"].Value) == "positivo")
            //        {
            //            fila.Visible = true;
            //        }
            //    }
            //}
            filtrarGrid();

        }

        private void Hombre_CheckedChanged(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow fila in visorPacientes.Rows)
            //{
            //    if (!hombre.Checked)
            //    {
            //        if (Convert.ToString(fila.Cells["sexo"].Value) == "Masculino")
            //        {
            //            fila.Visible = false;
            //        }
            //    }
            //    else {
            //        if (Convert.ToString(fila.Cells["sexo"].Value) == "Masculino")
            //        {
            //            fila.Visible = true;
            //        }
            //    }
            //}
            filtrarGrid();

        }

        private void mujer_CheckedChanged(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow fila in visorPacientes.Rows)
            //{
            //    if (!mujer.Checked)
            //    {
            //        if (Convert.ToString(fila.Cells["sexo"].Value) == "Femenino")
            //        {
            //            fila.Visible = false;
            //        }
            //    }
            //    else
            //    {
            //        if (Convert.ToString(fila.Cells["sexo"].Value) == "Femenino")
            //        {
            //            fila.Visible = true;
            //        }
            //    }
            //}
            filtrarGrid();

        }

        private void otros_CheckedChanged(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow fila in visorPacientes.Rows)
            //{
            //    if (!otros.Checked)
            //    {
            //        if (Convert.ToString(fila.Cells["sexo"].Value) == "Otro")
            //        {
            //            fila.Visible = false;
            //        }
            //    }
            //    else
            //    {
            //        if (Convert.ToString(fila.Cells["sexo"].Value) == "Otro")
            //        {
            //            fila.Visible = false;
            //        }
            //    }
            //}

            filtrarGrid();

        }

        private void edadBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //foreach (datagridviewrow fila in visorpacientes.rows)
            //{
            //    if (convert.toint16(fila.cells["edad"].value) < convert.toint16(edadbox.text))
            //    {
            //        fila.visible = false;
            //    }
            //    else
            //    {
            //        fila.visible = true;
            //    }

            //}

            filtrarGrid();
        }

        public void alterarContador() 
        {
            contadorEnfermos.Text = Convert.ToString(Informacion.contadorEnfermos);
            contadorSanos.Text = Convert.ToString(Informacion.contadorSanos);
            contadorTotal.Text = Convert.ToString(Informacion.contadorEnfermos + Informacion.contadorSanos);
        }

        public void reiniciarContador() 
        {
            Informacion.contadorDeuda = 0;
            Informacion.contadorEnfermos = 0;
            Informacion.contadorSanos = 0;
        }

        private void Vizualizador_Load(object sender, EventArgs e)
        {
        }
    }

    
}
