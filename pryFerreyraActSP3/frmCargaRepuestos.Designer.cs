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
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            txtNumero = new TextBox();
            lblPrecio = new Label();
            lblNumero = new Label();
            lblDesc = new Label();
            lblOrigen = new Label();
            lblMarca = new Label();
            cmbMarca = new ComboBox();
            btnAgregar = new Button();
            cmbOrigen = new ComboBox();
            gbConsulta = new GroupBox();
            label1 = new Label();
            btnConsultar = new Button();
            rbImportado = new RadioButton();
            lstResultados = new ListBox();
            cmbConsultaMarca = new ComboBox();
            rbNacional = new RadioButton();
            gbDatos.SuspendLayout();
            gbConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(txtPrecio);
            gbDatos.Controls.Add(txtDescripcion);
            gbDatos.Controls.Add(txtNumero);
            gbDatos.Controls.Add(lblPrecio);
            gbDatos.Controls.Add(lblNumero);
            gbDatos.Controls.Add(lblDesc);
            gbDatos.Controls.Add(lblOrigen);
            gbDatos.Controls.Add(lblMarca);
            gbDatos.Controls.Add(cmbMarca);
            gbDatos.Controls.Add(btnAgregar);
            gbDatos.Controls.Add(cmbOrigen);
            gbDatos.Location = new Point(70, 12);
            gbDatos.Name = "gbDatos";
            gbDatos.Size = new Size(523, 216);
            gbDatos.TabIndex = 0;
            gbDatos.TabStop = false;
            gbDatos.Text = "Ingreso de Datos";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(121, 139);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(120, 23);
            txtPrecio.TabIndex = 15;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(338, 96);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(121, 61);
            txtDescripcion.TabIndex = 14;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(122, 97);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(120, 23);
            txtNumero.TabIndex = 13;
            txtNumero.KeyPress += txtNumero_KeyPress;
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
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(65, 100);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 11;
            lblNumero.Text = "Número";
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
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(257, 50);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(43, 15);
            lblOrigen.TabIndex = 9;
            lblOrigen.Text = "Origen";
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
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "P", "F", "R" });
            cmbMarca.Location = new Point(121, 46);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(121, 23);
            cmbMarca.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(383, 178);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "N", "I" });
            cmbOrigen.Location = new Point(338, 44);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(121, 23);
            cmbOrigen.TabIndex = 3;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 47);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 13;
            label1.Text = "Marca";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(392, 157);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // rbImportado
            // 
            rbImportado.AutoSize = true;
            rbImportado.Location = new Point(368, 44);
            rbImportado.Name = "rbImportado";
            rbImportado.Size = new Size(81, 19);
            rbImportado.TabIndex = 9;
            rbImportado.TabStop = true;
            rbImportado.Text = "Importado";
            rbImportado.UseVisualStyleBackColor = true;
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
            // cmbConsultaMarca
            // 
            cmbConsultaMarca.FormattingEnabled = true;
            cmbConsultaMarca.Items.AddRange(new object[] { "P", "F", "R" });
            cmbConsultaMarca.Location = new Point(106, 43);
            cmbConsultaMarca.Name = "cmbConsultaMarca";
            cmbConsultaMarca.Size = new Size(121, 23);
            cmbConsultaMarca.TabIndex = 2;
            // 
            // rbNacional
            // 
            rbNacional.AutoSize = true;
            rbNacional.Location = new Point(265, 43);
            rbNacional.Name = "rbNacional";
            rbNacional.Size = new Size(72, 19);
            rbNacional.TabIndex = 8;
            rbNacional.TabStop = true;
            rbNacional.Text = "Nacional";
            rbNacional.UseVisualStyleBackColor = true;
            // 
            // frmCargaRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 450);
            Controls.Add(gbConsulta);
            Controls.Add(gbDatos);
            Name = "frmCargaRepuestos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carga de Repuestos ";
            Load += frmCargaRepuestos_Load;
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
        //private TextBox textBox1;
        //private TextBox textBox2;
        //private TextBox textBox3;
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
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private TextBox txtNumero;
    }
}
