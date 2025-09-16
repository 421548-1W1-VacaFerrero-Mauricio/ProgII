namespace Ejercicio_4._13
{
    partial class FrmPersonas
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
            this.LblApellidos = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            this.LblTipoDoc = new System.Windows.Forms.Label();
            this.LblDoc = new System.Windows.Forms.Label();
            this.LblEstadoCivil = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblFallecido = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.CbTipoDoc = new System.Windows.Forms.ComboBox();
            this.TxtDoc = new System.Windows.Forms.TextBox();
            this.CbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.RbtnHombre = new System.Windows.Forms.RadioButton();
            this.RbtnMujer = new System.Windows.Forms.RadioButton();
            this.ChbFallecido = new System.Windows.Forms.CheckBox();
            this.LstbPersonas = new System.Windows.Forms.ListBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Location = new System.Drawing.Point(83, 49);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(49, 13);
            this.LblApellidos.TabIndex = 0;
            this.LblApellidos.Text = "Apellidos";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Location = new System.Drawing.Point(83, 88);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(49, 13);
            this.LblNombres.TabIndex = 1;
            this.LblNombres.Text = "Nombres";
            // 
            // LblTipoDoc
            // 
            this.LblTipoDoc.AutoSize = true;
            this.LblTipoDoc.Location = new System.Drawing.Point(46, 127);
            this.LblTipoDoc.Name = "LblTipoDoc";
            this.LblTipoDoc.Size = new System.Drawing.Size(86, 13);
            this.LblTipoDoc.TabIndex = 2;
            this.LblTipoDoc.Text = "Tipo Documento";
            // 
            // LblDoc
            // 
            this.LblDoc.AutoSize = true;
            this.LblDoc.Location = new System.Drawing.Point(70, 166);
            this.LblDoc.Name = "LblDoc";
            this.LblDoc.Size = new System.Drawing.Size(62, 13);
            this.LblDoc.TabIndex = 3;
            this.LblDoc.Text = "Documento";
            // 
            // LblEstadoCivil
            // 
            this.LblEstadoCivil.AutoSize = true;
            this.LblEstadoCivil.Location = new System.Drawing.Point(70, 205);
            this.LblEstadoCivil.Name = "LblEstadoCivil";
            this.LblEstadoCivil.Size = new System.Drawing.Size(62, 13);
            this.LblEstadoCivil.TabIndex = 4;
            this.LblEstadoCivil.Text = "Estado Civil";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(101, 244);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(31, 13);
            this.LblSexo.TabIndex = 5;
            this.LblSexo.Text = "Sexo";
            // 
            // LblFallecido
            // 
            this.LblFallecido.AutoSize = true;
            this.LblFallecido.Location = new System.Drawing.Point(83, 314);
            this.LblFallecido.Name = "LblFallecido";
            this.LblFallecido.Size = new System.Drawing.Size(49, 13);
            this.LblFallecido.TabIndex = 6;
            this.LblFallecido.Text = "Fallecido";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Enabled = false;
            this.TxtApellidos.Location = new System.Drawing.Point(175, 42);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(170, 20);
            this.TxtApellidos.TabIndex = 0;
            // 
            // TxtNombres
            // 
            this.TxtNombres.Enabled = false;
            this.TxtNombres.Location = new System.Drawing.Point(175, 81);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(170, 20);
            this.TxtNombres.TabIndex = 1;
            // 
            // CbTipoDoc
            // 
            this.CbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoDoc.Enabled = false;
            this.CbTipoDoc.FormattingEnabled = true;
            this.CbTipoDoc.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte"});
            this.CbTipoDoc.Location = new System.Drawing.Point(175, 119);
            this.CbTipoDoc.Name = "CbTipoDoc";
            this.CbTipoDoc.Size = new System.Drawing.Size(170, 21);
            this.CbTipoDoc.TabIndex = 2;
            // 
            // TxtDoc
            // 
            this.TxtDoc.Enabled = false;
            this.TxtDoc.Location = new System.Drawing.Point(175, 159);
            this.TxtDoc.Name = "TxtDoc";
            this.TxtDoc.Size = new System.Drawing.Size(170, 20);
            this.TxtDoc.TabIndex = 3;
            // 
            // CbEstadoCivil
            // 
            this.CbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEstadoCivil.Enabled = false;
            this.CbEstadoCivil.FormattingEnabled = true;
            this.CbEstadoCivil.Items.AddRange(new object[] {
            "Soltero(a)",
            "Casado(a)",
            "Conviviente civil.",
            "Separado(a) judicialmente.",
            "Divorciado(a)",
            "Viudo(a)"});
            this.CbEstadoCivil.Location = new System.Drawing.Point(175, 197);
            this.CbEstadoCivil.Name = "CbEstadoCivil";
            this.CbEstadoCivil.Size = new System.Drawing.Size(170, 21);
            this.CbEstadoCivil.TabIndex = 4;
            // 
            // RbtnHombre
            // 
            this.RbtnHombre.AutoSize = true;
            this.RbtnHombre.Enabled = false;
            this.RbtnHombre.Location = new System.Drawing.Point(175, 242);
            this.RbtnHombre.Name = "RbtnHombre";
            this.RbtnHombre.Size = new System.Drawing.Size(62, 17);
            this.RbtnHombre.TabIndex = 5;
            this.RbtnHombre.TabStop = true;
            this.RbtnHombre.Text = "Hombre";
            this.RbtnHombre.UseVisualStyleBackColor = true;
            // 
            // RbtnMujer
            // 
            this.RbtnMujer.AutoSize = true;
            this.RbtnMujer.Enabled = false;
            this.RbtnMujer.Location = new System.Drawing.Point(175, 265);
            this.RbtnMujer.Name = "RbtnMujer";
            this.RbtnMujer.Size = new System.Drawing.Size(51, 17);
            this.RbtnMujer.TabIndex = 6;
            this.RbtnMujer.TabStop = true;
            this.RbtnMujer.Text = "Mujer";
            this.RbtnMujer.UseVisualStyleBackColor = true;
            // 
            // ChbFallecido
            // 
            this.ChbFallecido.AutoSize = true;
            this.ChbFallecido.Enabled = false;
            this.ChbFallecido.Location = new System.Drawing.Point(175, 313);
            this.ChbFallecido.Name = "ChbFallecido";
            this.ChbFallecido.Size = new System.Drawing.Size(15, 14);
            this.ChbFallecido.TabIndex = 7;
            this.ChbFallecido.UseVisualStyleBackColor = true;
            // 
            // LstbPersonas
            // 
            this.LstbPersonas.FormattingEnabled = true;
            this.LstbPersonas.HorizontalScrollbar = true;
            this.LstbPersonas.Location = new System.Drawing.Point(412, 37);
            this.LstbPersonas.Name = "LstbPersonas";
            this.LstbPersonas.Size = new System.Drawing.Size(234, 290);
            this.LstbPersonas.TabIndex = 8;
            this.LstbPersonas.SelectedIndexChanged += new System.EventHandler(this.LstbPersonas_SelectedIndexChanged);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(36, 377);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 9;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(143, 377);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 10;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(250, 377);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrar.TabIndex = 11;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Enabled = false;
            this.BtnGrabar.Location = new System.Drawing.Point(357, 377);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(75, 23);
            this.BtnGrabar.TabIndex = 12;
            this.BtnGrabar.Text = "Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Enabled = false;
            this.BtnCancelar.Location = new System.Drawing.Point(464, 377);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(571, 377);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 14;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGrabar);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.LstbPersonas);
            this.Controls.Add(this.ChbFallecido);
            this.Controls.Add(this.RbtnMujer);
            this.Controls.Add(this.RbtnHombre);
            this.Controls.Add(this.CbEstadoCivil);
            this.Controls.Add(this.TxtDoc);
            this.Controls.Add(this.CbTipoDoc);
            this.Controls.Add(this.TxtNombres);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.LblFallecido);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.LblEstadoCivil);
            this.Controls.Add(this.LblDoc);
            this.Controls.Add(this.LblTipoDoc);
            this.Controls.Add(this.LblNombres);
            this.Controls.Add(this.LblApellidos);
            this.Name = "FrmPersonas";
            this.Text = "A B M Personas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Label LblTipoDoc;
        private System.Windows.Forms.Label LblDoc;
        private System.Windows.Forms.Label LblEstadoCivil;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblFallecido;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.ComboBox CbTipoDoc;
        private System.Windows.Forms.TextBox TxtDoc;
        private System.Windows.Forms.ComboBox CbEstadoCivil;
        private System.Windows.Forms.RadioButton RbtnHombre;
        private System.Windows.Forms.RadioButton RbtnMujer;
        private System.Windows.Forms.CheckBox ChbFallecido;
        private System.Windows.Forms.ListBox LstbPersonas;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSalir;
    }
}

