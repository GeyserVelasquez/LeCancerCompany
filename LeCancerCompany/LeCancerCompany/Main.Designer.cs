namespace LeCancerCompany
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.header = new System.Windows.Forms.Panel();
            this.expandir = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.registroOpen = new System.Windows.Forms.Button();
            this.contenedor = new System.Windows.Forms.Panel();
            this.visorOpen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titulo = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.header.Controls.Add(this.expandir);
            this.header.Controls.Add(this.cerrar);
            this.header.Controls.Add(this.registroOpen);
            this.header.Controls.Add(this.contenedor);
            this.header.Controls.Add(this.visorOpen);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Controls.Add(this.titulo);
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1924, 1055);
            this.header.TabIndex = 3;
            // 
            // expandir
            // 
            this.expandir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.expandir.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.expandir.FlatAppearance.BorderSize = 4;
            this.expandir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.expandir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.expandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expandir.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.expandir.ForeColor = System.Drawing.Color.Crimson;
            this.expandir.Location = new System.Drawing.Point(1320, 22);
            this.expandir.Name = "expandir";
            this.expandir.Size = new System.Drawing.Size(60, 60);
            this.expandir.TabIndex = 8;
            this.expandir.Tag = "";
            this.expandir.Text = "<>";
            this.expandir.UseVisualStyleBackColor = false;
            this.expandir.Click += new System.EventHandler(this.expandir_Click);
            // 
            // cerrar
            // 
            this.cerrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.cerrar.FlatAppearance.BorderSize = 4;
            this.cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold);
            this.cerrar.ForeColor = System.Drawing.Color.Crimson;
            this.cerrar.Location = new System.Drawing.Point(1437, 22);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(60, 60);
            this.cerrar.TabIndex = 7;
            this.cerrar.Tag = "";
            this.cerrar.Text = "X";
            this.cerrar.UseVisualStyleBackColor = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // registroOpen
            // 
            this.registroOpen.AutoEllipsis = true;
            this.registroOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.registroOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registroOpen.Cursor = System.Windows.Forms.Cursors.Default;
            this.registroOpen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.registroOpen.FlatAppearance.BorderSize = 4;
            this.registroOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.registroOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.registroOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registroOpen.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroOpen.ForeColor = System.Drawing.Color.White;
            this.registroOpen.Image = global::LeCancerCompany.Properties.Resources.anadir__2_;
            this.registroOpen.Location = new System.Drawing.Point(947, 1);
            this.registroOpen.Margin = new System.Windows.Forms.Padding(0);
            this.registroOpen.Name = "registroOpen";
            this.registroOpen.Size = new System.Drawing.Size(127, 97);
            this.registroOpen.TabIndex = 0;
            this.registroOpen.Text = "Registrar";
            this.registroOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.registroOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.registroOpen.UseVisualStyleBackColor = false;
            this.registroOpen.Click += new System.EventHandler(this.registroOpen_Click);
            // 
            // contenedor
            // 
            this.contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contenedor.BackColor = System.Drawing.SystemColors.Control;
            this.contenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contenedor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.contenedor.Location = new System.Drawing.Point(0, 100);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(2082, 1055);
            this.contenedor.TabIndex = 4;
            // 
            // visorOpen
            // 
            this.visorOpen.AutoEllipsis = true;
            this.visorOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visorOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.visorOpen.Cursor = System.Windows.Forms.Cursors.Default;
            this.visorOpen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.visorOpen.FlatAppearance.BorderSize = 4;
            this.visorOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.visorOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.visorOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visorOpen.Font = new System.Drawing.Font("Arial Black", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visorOpen.ForeColor = System.Drawing.Color.White;
            this.visorOpen.Image = global::LeCancerCompany.Properties.Resources.anadir__2_;
            this.visorOpen.Location = new System.Drawing.Point(1131, 1);
            this.visorOpen.Margin = new System.Windows.Forms.Padding(0);
            this.visorOpen.Name = "visorOpen";
            this.visorOpen.Size = new System.Drawing.Size(127, 97);
            this.visorOpen.TabIndex = 2;
            this.visorOpen.Text = "Visualizar";
            this.visorOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.visorOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.visorOpen.UseVisualStyleBackColor = false;
            this.visorOpen.Click += new System.EventHandler(this.visorOpen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LeCancerCompany.Properties.Resources.kit_de_primeros_auxilios;
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Arial Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titulo.Location = new System.Drawing.Point(77, 8);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(371, 85);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Le Cancer";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Le Cancer";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button registroOpen;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Button visorOpen;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button expandir;

    }
}

