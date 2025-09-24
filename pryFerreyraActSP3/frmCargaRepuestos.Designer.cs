namespace pryFerreyraActSP3
{
    partial class frmCargaRepuestos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbDatos = new GroupBox();
            cmbMarca = new ComboBox();
            cmbOrigen = new ComboBox();
            this.txtNumero = new TextBox();
            this.txtDescripcion = new TextBox();
            this.txtPrecio = new TextBox();
            btnAgregar = new Button();
            gbConsulta = new GroupBox();
            cmbConsultaMarca = new ComboBox();
            rbNacional = new RadioButton();
            rbImportado = new RadioButton();
            btnConsultar = new Button();
            lstResultados = new ListBox();
            lblMarca = new Label();
            lblOrigen = new Label();
            lblDesc = new Label();
            lblNumero = new Label();
            lblPrecio = new Label();
            label1 = new Label();
            gbDatos.SuspendLayout();
            gbConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(lblPrecio);
            gbDatos.Controls.Add(lblNumero);
            gbDatos.Controls.Add(lblDesc);
            gbDatos.Controls.Add(lblOrigen);
            gbDatos.Controls.Add(lblMarca);
            gbDatos.Controls.Add(cmbMarca);
            gbDatos.Controls.Add(btnAgregar);
            gbDatos.Controls.Add(cmbOrigen);
            gbDatos.Controls.Add(this.txtNumero);
            gbDatos.Controls.Add(this.txtDescripcion);
            gbDatos.Controls.Add(this.txtPrecio);
            gbDatos.Location = new Point(70, 12);
            gbDatos.Name = "gbDatos";
            gbDatos.Size = new Size(523, 216);
            gbDatos.TabIndex = 0;
            gbDatos.TabStop = false;
            gbDatos.Text = "Ingreso de Datos";
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(121, 46);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(121, 23);
            cmbMarca.TabIndex = 2;
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Location = new Point(338, 44);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(121, 23);
            cmbOrigen.TabIndex = 3;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new Point(121, 95);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new Size(121, 23);
            this.txtNumero.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new Point(338, 95);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new Size(121, 66);
            this.txtDescripcion.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new Point(121, 138);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new Size(121, 23);
            this.txtPrecio.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(383, 178);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += this.btnAgregar_Click;
            // 
            // gbConsulta
            // 
            gbConsulta.Controls.Add(label1);
            gbConsulta.Controls.Add(btnConsultar);
            gbConsulta.Controls.Add(rbImportado);
            gbConsulta.Controls.Add(lstResultados);
            gbConsulta.Controls.Add(cmbConsultaMarca);
            gbConsulta.Controls.Add(rbNacional);
            gbConsulta.Location = new Point(70, 234);
            gbConsulta.Name = "gbConsulta";
            gbConsulta.Size = new Size(523, 197);
            gbConsulta.TabIndex = 8;
            gbConsulta.TabStop = false;
            gbConsulta.Text = "Consulta";
            // 
            // cmbConsultaMarca
            // 
            cmbConsultaMarca.FormattingEnabled = true;
            cmbConsultaMarca.Location = new Point(106, 43);
            cmbConsultaMarca.Name = "cmbConsultaMarca";
            cmbConsultaMarca.Size = new Size(121, 23);
            cmbConsultaMarca.TabIndex = 2;
            // 
            // rbNacional
            // 
            rbNacional.AutoSize = true;
            rbNacional.Location = new Point(246, 43);
            rbNacional.Name = "rbNacional";
            rbNacional.Size = new Size(72, 19);
            rbNacional.TabIndex = 8;
            rbNacional.TabStop = true;
            rbNacional.Text = "Nacional";
            rbNacional.UseVisualStyleBackColor = true;
            // 
            // rbImportado
            // 
            rbImportado.AutoSize = true;
            rbImportado.Location = new Point(368, 43);
            rbImportado.Name = "rbImportado";
            rbImportado.Size = new Size(81, 19);
            rbImportado.TabIndex = 9;
            rbImportado.TabStop = true;
            rbImportado.Text = "importado";
            rbImportado.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(392, 157);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.ItemHeight = 15;
            lstResultados.Location = new Point(56, 87);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(411, 64);
            lstResultados.TabIndex = 8;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(65, 51);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 8;
            lblMarca.Text = "Marca";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(257, 50);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(43, 15);
            lblOrigen.TabIndex = 9;
            lblOrigen.Text = "Origen";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(258, 99);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(69, 15);
            lblDesc.TabIndex = 10;
            lblDesc.Text = "Descripción";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(65, 100);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 11;
            lblNumero.Text = "Número";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(66, 142);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 12;
            lblPrecio.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 47);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 13;
            label1.Text = "Marca";
            // 
            // frmCargaRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 450);
            Controls.Add(gbConsulta);
            Controls.Add(gbDatos);
            Name = "frmCargaRepuestos";
            Text = "Carga de Repuestos ";
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            gbConsulta.ResumeLayout(false);
            gbConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDatos;
        private ComboBox cmbMarca;
        private ComboBox cmbOrigen;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnAgregar;
        private GroupBox gbConsulta;
        private RadioButton rbImportado;
        private ListBox lstResultados;
        private ComboBox cmbConsultaMarca;
        private RadioButton rbNacional;
        private Button btnConsultar;
        private Label lblOrigen;
        private Label lblMarca;
        private Label lblDesc;
        private Label lblNumero;
        private Label lblPrecio;
        private Label label1;
    }
}
