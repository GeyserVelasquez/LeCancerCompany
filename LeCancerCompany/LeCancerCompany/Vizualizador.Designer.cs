namespace LeCancerCompany
{
    partial class Vizualizador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vizualizador));
            this.visorPacientes = new System.Windows.Forms.DataGridView();
            this.hombre = new System.Windows.Forms.CheckBox();
            this.mujer = new System.Windows.Forms.CheckBox();
            this.otros = new System.Windows.Forms.CheckBox();
            this.enfermito = new System.Windows.Forms.CheckBox();
            this.sano = new System.Windows.Forms.CheckBox();
            this.intervaloEdadLabel = new System.Windows.Forms.Label();
            this.edadBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contadorSanos = new System.Windows.Forms.TextBox();
            this.contSanosLabel = new System.Windows.Forms.Label();
            this.countLabelEnfermos = new System.Windows.Forms.Label();
            this.contadorEnfermos = new System.Windows.Forms.TextBox();
            this.contadorTotalLabel = new System.Windows.Forms.Label();
            this.contadorTotal = new System.Windows.Forms.TextBox();
            this.deudaTotalLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enfermo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.visorPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // visorPacientes
            // 
            this.visorPacientes.AllowUserToAddRows = false;
            this.visorPacientes.AllowUserToDeleteRows = false;
            this.visorPacientes.AllowUserToOrderColumns = true;
            this.visorPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.visorPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.visorPacientes.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.visorPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.visorPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cedula,
            this.nombre,
            this.apellido,
            this.edad,
            this.sexo,
            this.enfermo,
            this.condicion,
            this.deuda});
            this.visorPacientes.GridColor = System.Drawing.Color.Crimson;
            this.visorPacientes.Location = new System.Drawing.Point(24, 23);
            this.visorPacientes.Name = "visorPacientes";
            this.visorPacientes.RowHeadersVisible = false;
            this.visorPacientes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visorPacientes.RowTemplate.Height = 24;
            this.visorPacientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.visorPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.visorPacientes.Size = new System.Drawing.Size(1505, 576);
            this.visorPacientes.TabIndex = 1;
            // 
            // hombre
            // 
            this.hombre.AutoSize = true;
            this.hombre.Checked = true;
            this.hombre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hombre.Location = new System.Drawing.Point(567, 617);
            this.hombre.Name = "hombre";
            this.hombre.Size = new System.Drawing.Size(155, 42);
            this.hombre.TabIndex = 3;
            this.hombre.Text = "Hombre";
            this.hombre.UseVisualStyleBackColor = true;
            this.hombre.CheckedChanged += new System.EventHandler(this.Hombre_CheckedChanged);
            // 
            // mujer
            // 
            this.mujer.AutoSize = true;
            this.mujer.Checked = true;
            this.mujer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mujer.Location = new System.Drawing.Point(762, 617);
            this.mujer.Name = "mujer";
            this.mujer.Size = new System.Drawing.Size(120, 42);
            this.mujer.TabIndex = 4;
            this.mujer.Text = "Mujer";
            this.mujer.UseVisualStyleBackColor = true;
            this.mujer.CheckedChanged += new System.EventHandler(this.mujer_CheckedChanged);
            // 
            // otros
            // 
            this.otros.AutoSize = true;
            this.otros.Checked = true;
            this.otros.CheckState = System.Windows.Forms.CheckState.Checked;
            this.otros.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otros.Location = new System.Drawing.Point(914, 617);
            this.otros.Name = "otros";
            this.otros.Size = new System.Drawing.Size(103, 42);
            this.otros.TabIndex = 5;
            this.otros.Text = "Otro";
            this.otros.UseVisualStyleBackColor = true;
            this.otros.CheckedChanged += new System.EventHandler(this.otros_CheckedChanged);
            // 
            // enfermito
            // 
            this.enfermito.AutoSize = true;
            this.enfermito.Checked = true;
            this.enfermito.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enfermito.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enfermito.Location = new System.Drawing.Point(160, 620);
            this.enfermito.Name = "enfermito";
            this.enfermito.Size = new System.Drawing.Size(162, 42);
            this.enfermito.TabIndex = 2;
            this.enfermito.Text = "Enfermo";
            this.enfermito.UseVisualStyleBackColor = true;
            this.enfermito.CheckedChanged += new System.EventHandler(this.enfermito_CheckedChanged);
            // 
            // sano
            // 
            this.sano.AutoSize = true;
            this.sano.Checked = true;
            this.sano.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sano.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sano.Location = new System.Drawing.Point(29, 620);
            this.sano.Name = "sano";
            this.sano.Size = new System.Drawing.Size(115, 42);
            this.sano.TabIndex = 1;
            this.sano.Text = "Sano";
            this.sano.UseVisualStyleBackColor = true;
            this.sano.CheckedChanged += new System.EventHandler(this.sano_CheckedChanged);
            // 
            // intervaloEdadLabel
            // 
            this.intervaloEdadLabel.AutoSize = true;
            this.intervaloEdadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervaloEdadLabel.Location = new System.Drawing.Point(1193, 624);
            this.intervaloEdadLabel.Name = "intervaloEdadLabel";
            this.intervaloEdadLabel.Size = new System.Drawing.Size(154, 38);
            this.intervaloEdadLabel.TabIndex = 9;
            this.intervaloEdadLabel.Text = "Menor de";
            // 
            // edadBox
            // 
            this.edadBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edadBox.FormattingEnabled = true;
            this.edadBox.Items.AddRange(new object[] {
            "",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "45",
            "50"});
            this.edadBox.Location = new System.Drawing.Point(1358, 621);
            this.edadBox.Name = "edadBox";
            this.edadBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.edadBox.Size = new System.Drawing.Size(73, 46);
            this.edadBox.TabIndex = 10;
            this.edadBox.Tag = "6";
            this.edadBox.SelectedIndexChanged += new System.EventHandler(this.edadBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1437, 624);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "años";
            // 
            // contadorSanos
            // 
            this.contadorSanos.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contadorSanos.Location = new System.Drawing.Point(149, 707);
            this.contadorSanos.Name = "contadorSanos";
            this.contadorSanos.ReadOnly = true;
            this.contadorSanos.Size = new System.Drawing.Size(136, 45);
            this.contadorSanos.TabIndex = 12;
            // 
            // contSanosLabel
            // 
            this.contSanosLabel.AutoSize = true;
            this.contSanosLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contSanosLabel.Location = new System.Drawing.Point(31, 713);
            this.contSanosLabel.Name = "contSanosLabel";
            this.contSanosLabel.Size = new System.Drawing.Size(108, 38);
            this.contSanosLabel.TabIndex = 13;
            this.contSanosLabel.Text = "Sanos";
            // 
            // countLabelEnfermos
            // 
            this.countLabelEnfermos.AutoSize = true;
            this.countLabelEnfermos.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabelEnfermos.Location = new System.Drawing.Point(346, 713);
            this.countLabelEnfermos.Name = "countLabelEnfermos";
            this.countLabelEnfermos.Size = new System.Drawing.Size(156, 38);
            this.countLabelEnfermos.TabIndex = 15;
            this.countLabelEnfermos.Text = "Enfermos";
            // 
            // contadorEnfermos
            // 
            this.contadorEnfermos.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contadorEnfermos.Location = new System.Drawing.Point(512, 710);
            this.contadorEnfermos.Name = "contadorEnfermos";
            this.contadorEnfermos.ReadOnly = true;
            this.contadorEnfermos.Size = new System.Drawing.Size(136, 45);
            this.contadorEnfermos.TabIndex = 14;
            // 
            // contadorTotalLabel
            // 
            this.contadorTotalLabel.AutoSize = true;
            this.contadorTotalLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contadorTotalLabel.Location = new System.Drawing.Point(725, 716);
            this.contadorTotalLabel.Name = "contadorTotalLabel";
            this.contadorTotalLabel.Size = new System.Drawing.Size(84, 38);
            this.contadorTotalLabel.TabIndex = 17;
            this.contadorTotalLabel.Text = "Total";
            // 
            // contadorTotal
            // 
            this.contadorTotal.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contadorTotal.Location = new System.Drawing.Point(817, 710);
            this.contadorTotal.Name = "contadorTotal";
            this.contadorTotal.ReadOnly = true;
            this.contadorTotal.Size = new System.Drawing.Size(136, 45);
            this.contadorTotal.TabIndex = 16;
            // 
            // deudaTotalLabel
            // 
            this.deudaTotalLabel.AutoSize = true;
            this.deudaTotalLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deudaTotalLabel.Location = new System.Drawing.Point(1110, 713);
            this.deudaTotalLabel.Name = "deudaTotalLabel";
            this.deudaTotalLabel.Size = new System.Drawing.Size(186, 38);
            this.deudaTotalLabel.TabIndex = 19;
            this.deudaTotalLabel.Text = "Deuda Total";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(1310, 707);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(218, 45);
            this.textBox3.TabIndex = 18;
            // 
            // id
            // 
            this.id.FillWeight = 40.60914F;
            this.id.HeaderText = "#";
            this.id.Name = "id";
            // 
            // cedula
            // 
            this.cedula.FillWeight = 120.1405F;
            this.cedula.HeaderText = "C.I";
            this.cedula.Name = "cedula";
            // 
            // nombre
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.DefaultCellStyle = dataGridViewCellStyle1;
            this.nombre.FillWeight = 120.1405F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.FillWeight = 120.1405F;
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // edad
            // 
            this.edad.HeaderText = "Edad";
            this.edad.Name = "edad";
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            // 
            // enfermo
            // 
            this.enfermo.FillWeight = 120.1405F;
            this.enfermo.HeaderText = "Enfermo";
            this.enfermo.Name = "enfermo";
            // 
            // condicion
            // 
            this.condicion.FillWeight = 120.1405F;
            this.condicion.HeaderText = "Condicion";
            this.condicion.Name = "condicion";
            // 
            // deuda
            // 
            this.deuda.FillWeight = 120.1405F;
            this.deuda.HeaderText = "Deuda";
            this.deuda.Name = "deuda";
            // 
            // Vizualizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1942, 1080);
            this.Controls.Add(this.deudaTotalLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.contadorTotalLabel);
            this.Controls.Add(this.contadorTotal);
            this.Controls.Add(this.countLabelEnfermos);
            this.Controls.Add(this.contadorEnfermos);
            this.Controls.Add(this.contSanosLabel);
            this.Controls.Add(this.contadorSanos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edadBox);
            this.Controls.Add(this.intervaloEdadLabel);
            this.Controls.Add(this.otros);
            this.Controls.Add(this.mujer);
            this.Controls.Add(this.hombre);
            this.Controls.Add(this.enfermito);
            this.Controls.Add(this.sano);
            this.Controls.Add(this.visorPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vizualizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Le Cancer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Vizualizador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visorPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView visorPacientes;
        private System.Windows.Forms.CheckBox hombre;
        private System.Windows.Forms.CheckBox mujer;
        private System.Windows.Forms.CheckBox otros;
        private System.Windows.Forms.CheckBox enfermito;
        private System.Windows.Forms.CheckBox sano;
        private System.Windows.Forms.Label intervaloEdadLabel;
        private System.Windows.Forms.ComboBox edadBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contadorSanos;
        private System.Windows.Forms.Label contSanosLabel;
        private System.Windows.Forms.Label countLabelEnfermos;
        private System.Windows.Forms.TextBox contadorEnfermos;
        private System.Windows.Forms.Label contadorTotalLabel;
        private System.Windows.Forms.TextBox contadorTotal;
        private System.Windows.Forms.Label deudaTotalLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn enfermo;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn deuda;
    }
}