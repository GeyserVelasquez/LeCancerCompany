using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace LeCancerCompany
{
    public partial class Registro : Form
    {

        public Registro()
        {
            InitializeComponent();
            if (!Main.pantallaIncompleta)
            {
                MoverRegistro(!Main.pantallaIncompleta);
            }
        }

       public ArrayList conjunto = new ArrayList();

        public void llenarLista() {
            conjunto.Add(nameBox);
            conjunto.Add(lastNameBox);
            conjunto.Add(genderBox);
            conjunto.Add(condicionBox);
            conjunto.Add(weakness);
            conjunto.Add(healthfull);
        }



        private void cerrar_Click(object sender, EventArgs e)
        {   
            this.Dispose();
            Main.registroCreado = false;
        }


        public void MoverRegistro(bool holick)
        {
            if (holick)
            {
                MoverControles(1);

            }
            else
            {
                MoverControles(-1);
            }
        }

        public void MoverControles(int aux){

            nameLabel.Left += 100 * aux; nameBox.Left += 100 * aux; nameBox.Width += 50 * aux;

            lastName.Left += 200 * aux; lastNameBox.Left += 200 * aux; lastNameBox.Width += 50 * aux;
            
            edadLabel.Left += 300 * aux; edadBox.Left += 300 * aux; edadBox.Width += 50 * aux;
            
            genderLabel.Left += 350 * aux; genderBox.Left += 350 * aux; genderBox.Width += 40 * aux;
            
            // Otra fila
            
            condicionLabel.Left += 100 * aux; condicionBox.Left += 100 * aux;
            
            condicionBox.Width = (lastNameBox.Width - nameBox.Left + lastNameBox.Left); condicionBox.Height += 150 * aux;
            
            deudaLabel.Left += 300 * aux; deudaBox.Left += 300 * aux; dolarLabel.Left += 300 * aux;
            
            cerrar.Left += 400 * aux;
            
            registrarBoton.Top += 150 * aux; limpiarBoton.Top += 150 * aux;
            
            registrarBoton.Left += 200 * aux; limpiarBoton.Left += 200 * aux;
            
        }

        private void limpiarBoton_Click(object sender, EventArgs e)
        {
            vaciaRegistro();
        }

        private void vaciaRegistro() 
        {
            cedulaBox.Clear();
            nameBox.Clear();
            lastNameBox.Clear();
            edadBox.Clear();
            genderBox.Text = "";
            weakness.Checked = false;
            healthfull.Checked = false;
            condicionBox.Clear();
            deudaBox.Clear();
        }

        private bool registroValido() {
            List<string> textBoxes = new List<string> { cedulaBox.Text, nameBox.Text, lastNameBox.Text, edadBox.Text, genderBox.Text, condicionBox.Text, deudaBox.Text };

            foreach (string text in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    return false;
                }
            }

            if (!weakness.Checked && !healthfull.Checked) 
            {
                return false;
            }

            return true;
        }

        private void registrarBoton_Click(object sender, EventArgs e)
        {
            if ( !registroValido() ) 
            {
                MessageBox.Show("Por favor, asegurese de llenar todos los campos");
                return; 
            }

            Persona paciente = new Persona(
                cedulaBox.Text,
                nameBox.Text,
                lastNameBox.Text,
                edadBox.Text,
                genderBox.Text,
                condicionBox.Text,
                weakness.Checked,
                deudaBox.Text);

            Console.WriteLine(paciente.cedula+" "+paciente.nombre+" "+paciente.apellido+" "+paciente.edad+" "+paciente.sexo+" "+paciente.condicion+" "+paciente.enfermo+" "+paciente.deuda);
            

            if (!Informacion.anadir(weakness.Checked, paciente))
            {
                MessageBox.Show("Ya se encuentra registrada una persona con esta cedula: " + cedulaBox.Text+".");
            }
            else 
            {
                MessageBox.Show("Paciente registrado de forma exitosa.");
                vaciaRegistro();

            }
        }

        private void genderBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void weakness_CheckedChanged(object sender, EventArgs e)
        {
            if (weakness.Checked) healthfull.Checked = false;

        }

        private void healthfull_CheckedChanged(object sender, EventArgs e)
        {
            if (healthfull.Checked) weakness.Checked = false;

        }

        private void cedulaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void deudaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void noNumber(KeyPressEventArgs e) {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            noNumber(e);
        }

        private void lastNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            noNumber(e);
        }
    }
}
