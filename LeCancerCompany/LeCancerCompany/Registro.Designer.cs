namespace LeCancerCompany
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.enfermoLabel = new System.Windows.Forms.Label();
            this.healthfull = new System.Windows.Forms.CheckBox();
            this.weakness = new System.Windows.Forms.CheckBox();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.cedulaLabel = new System.Windows.Forms.Label();
            this.cedulaBox = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.cerrar = new System.Windows.Forms.Button();
            this.condicionLabel = new System.Windows.Forms.Label();
            this.condicionBox = new System.Windows.Forms.TextBox();
            this.registrarBoton = new System.Windows.Forms.Button();
            this.limpiarBoton = new System.Windows.Forms.Button();
            this.deudaLabel = new System.Windows.Forms.Label();
            this.deudaBox = new System.Windows.Forms.TextBox();
            this.edadLabel = new System.Windows.Forms.Label();
            this.edadBox = new System.Windows.Forms.TextBox();
            this.dolarLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enfermoLabel
            // 
            this.enfermoLabel.AutoSize = true;
            this.enfermoLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enfermoLabel.Location = new System.Drawing.Point(54, 306);
            this.enfermoLabel.Name = "enfermoLabel";
            this.enfermoLabel.Size = new System.Drawing.Size(143, 39);
            this.enfermoLabel.TabIndex = 24;
            this.enfermoLabel.Text = "Enfermo";
            // 
            // healthfull
            // 
            this.healthfull.AutoSize = true;
            this.healthfull.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthfull.Location = new System.Drawing.Point(156, 359);
            this.healthfull.Name = "healthfull";
            this.healthfull.Size = new System.Drawing.Size(83, 43);
            this.healthfull.TabIndex = 7;
            this.healthfull.Text = "No";
            this.healthfull.UseVisualStyleBackColor = true;
            this.healthfull.CheckedChanged += new System.EventHandler(this.healthfull_CheckedChanged);
            // 
            // weakness
            // 
            this.weakness.AutoSize = true;
            this.weakness.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weakness.Location = new System.Drawing.Point(27, 359);
            this.weakness.Name = "weakness";
            this.weakness.Size = new System.Drawing.Size(70, 43);
            this.weakness.TabIndex = 6;
            this.weakness.Text = "Si";
            this.weakness.UseVisualStyleBackColor = true;
            this.weakness.CheckedChanged += new System.EventHandler(this.weakness_CheckedChanged);
            // 
            // genderBox
            // 
            this.genderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.genderBox.Location = new System.Drawing.Point(1276, 129);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(200, 46);
            this.genderBox.TabIndex = 5;
            this.genderBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.genderBox_KeyPress);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(1269, 79);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(92, 39);
            this.genderLabel.TabIndex = 20;
            this.genderLabel.Text = "Sexo";
            // 
            // cedulaLabel
            // 
            this.cedulaLabel.AutoSize = true;
            this.cedulaLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulaLabel.Location = new System.Drawing.Point(5, 83);
            this.cedulaLabel.Name = "cedulaLabel";
            this.cedulaLabel.Size = new System.Drawing.Size(123, 39);
            this.cedulaLabel.TabIndex = 19;
            this.cedulaLabel.Text = "Cédula";
            // 
            // cedulaBox
            // 
            this.cedulaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulaBox.Location = new System.Drawing.Point(12, 132);
            this.cedulaBox.MaxLength = 8;
            this.cedulaBox.Name = "cedulaBox";
            this.cedulaBox.Size = new System.Drawing.Size(275, 45);
            this.cedulaBox.TabIndex = 1;
            this.cedulaBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cedulaBox_KeyPress);
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(686, 80);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(133, 39);
            this.lastName.TabIndex = 17;
            this.lastName.Text = "Apellido";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameBox.Location = new System.Drawing.Point(693, 129);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(324, 45);
            this.lastNameBox.TabIndex = 3;
            this.lastNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastNameBox_KeyPress);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(320, 81);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(134, 39);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Nombre";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(327, 130);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(324, 45);
            this.nameBox.TabIndex = 2;
            this.nameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBox_KeyPress);
            // 
            // cerrar
            // 
            this.cerrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.cerrar.FlatAppearance.BorderSize = 4;
            this.cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.cerrar.ForeColor = System.Drawing.Color.Crimson;
            this.cerrar.Location = new System.Drawing.Point(1436, 12);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(40, 40);
            this.cerrar.TabIndex = 26;
            this.cerrar.Tag = "";
            this.cerrar.Text = "X";
            this.cerrar.UseVisualStyleBackColor = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // condicionLabel
            // 
            this.condicionLabel.AutoSize = true;
            this.condicionLabel.Font = new System.Drawing.Font("Arial", 20F);
            this.condicionLabel.Location = new System.Drawing.Point(318, 306);
            this.condicionLabel.Name = "condicionLabel";
            this.condicionLabel.Size = new System.Drawing.Size(166, 39);
            this.condicionLabel.TabIndex = 27;
            this.condicionLabel.Text = "Condición";
            // 
            // condicionBox
            // 
            this.condicionBox.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condicionBox.Location = new System.Drawing.Point(318, 348);
            this.condicionBox.MaxLength = 1000;
            this.condicionBox.Multiline = true;
            this.condicionBox.Name = "condicionBox";
            this.condicionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.condicionBox.Size = new System.Drawing.Size(699, 225);
            this.condicionBox.TabIndex = 8;
            // 
            // registrarBoton
            // 
            this.registrarBoton.BackColor = System.Drawing.Color.White;
            this.registrarBoton.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.registrarBoton.FlatAppearance.BorderSize = 4;
            this.registrarBoton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(44)))), ((int)(((byte)(136)))));
            this.registrarBoton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(170)))), ((int)(((byte)(215)))));
            this.registrarBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarBoton.Font = new System.Drawing.Font("Arial", 20F);
            this.registrarBoton.Location = new System.Drawing.Point(437, 650);
            this.registrarBoton.Name = "registrarBoton";
            this.registrarBoton.Size = new System.Drawing.Size(250, 100);
            this.registrarBoton.TabIndex = 10;
            this.registrarBoton.Text = "Registrar";
            this.registrarBoton.UseVisualStyleBackColor = false;
            this.registrarBoton.Click += new System.EventHandler(this.registrarBoton_Click);
            // 
            // limpiarBoton
            // 
            this.limpiarBoton.BackColor = System.Drawing.Color.White;
            this.limpiarBoton.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.limpiarBoton.FlatAppearance.BorderSize = 4;
            this.limpiarBoton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(44)))), ((int)(((byte)(136)))));
            this.limpiarBoton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(170)))), ((int)(((byte)(215)))));
            this.limpiarBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiarBoton.Font = new System.Drawing.Font("Arial", 20F);
            this.limpiarBoton.Location = new System.Drawing.Point(859, 650);
            this.limpiarBoton.Name = "limpiarBoton";
            this.limpiarBoton.Size = new System.Drawing.Size(250, 100);
            this.limpiarBoton.TabIndex = 11;
            this.limpiarBoton.Text = "Limpiar";
            this.limpiarBoton.UseVisualStyleBackColor = false;
            this.limpiarBoton.Click += new System.EventHandler(this.limpiarBoton_Click);
            // 
            // deudaLabel
            // 
            this.deudaLabel.AutoSize = true;
            this.deudaLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deudaLabel.Location = new System.Drawing.Point(1057, 299);
            this.deudaLabel.Name = "deudaLabel";
            this.deudaLabel.Size = new System.Drawing.Size(115, 39);
            this.deudaLabel.TabIndex = 32;
            this.deudaLabel.Text = "Deuda";
            // 
            // deudaBox
            // 
            this.deudaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deudaBox.Location = new System.Drawing.Point(1064, 348);
            this.deudaBox.Name = "deudaBox";
            this.deudaBox.Size = new System.Drawing.Size(300, 45);
            this.deudaBox.TabIndex = 9;
            this.deudaBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deudaBox_KeyPress);
            // 
            // edadLabel
            // 
            this.edadLabel.AutoSize = true;
            this.edadLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edadLabel.Location = new System.Drawing.Point(1057, 80);
            this.edadLabel.Name = "edadLabel";
            this.edadLabel.Size = new System.Drawing.Size(94, 39);
            this.edadLabel.TabIndex = 34;
            this.edadLabel.Text = "Edad";
            // 
            // edadBox
            // 
            this.edadBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edadBox.Location = new System.Drawing.Point(1064, 129);
            this.edadBox.MaxLength = 3;
            this.edadBox.Name = "edadBox";
            this.edadBox.Size = new System.Drawing.Size(159, 45);
            this.edadBox.TabIndex = 4;
            // 
            // dolarLabel
            // 
            this.dolarLabel.AutoSize = true;
            this.dolarLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dolarLabel.Location = new System.Drawing.Point(1370, 348);
            this.dolarLabel.Name = "dolarLabel";
            this.dolarLabel.Size = new System.Drawing.Size(36, 39);
            this.dolarLabel.TabIndex = 35;
            this.dolarLabel.Text = "$";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 900);
            this.Controls.Add(this.dolarLabel);
            this.Controls.Add(this.edadLabel);
            this.Controls.Add(this.edadBox);
            this.Controls.Add(this.deudaLabel);
            this.Controls.Add(this.deudaBox);
            this.Controls.Add(this.limpiarBoton);
            this.Controls.Add(this.registrarBoton);
            this.Controls.Add(this.condicionBox);
            this.Controls.Add(this.condicionLabel);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.enfermoLabel);
            this.Controls.Add(this.healthfull);
            this.Controls.Add(this.weakness);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.cedulaLabel);
            this.Controls.Add(this.cedulaBox);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Le Cancer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enfermoLabel;
        private System.Windows.Forms.CheckBox healthfull;
        private System.Windows.Forms.CheckBox weakness;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label cedulaLabel;
        private System.Windows.Forms.TextBox cedulaBox;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Label condicionLabel;
        private System.Windows.Forms.TextBox condicionBox;
        private System.Windows.Forms.Button registrarBoton;
        private System.Windows.Forms.Button limpiarBoton;
        private System.Windows.Forms.Label deudaLabel;
        private System.Windows.Forms.TextBox deudaBox;
        private System.Windows.Forms.Label edadLabel;
        private System.Windows.Forms.TextBox edadBox;
        private System.Windows.Forms.Label dolarLabel;
    }
}