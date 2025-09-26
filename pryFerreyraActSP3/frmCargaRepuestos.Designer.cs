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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaRepuestos));
            tbCarga = new TabControl();
            tabPage1 = new TabPage();
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
            tabPage2 = new TabPage();
            gbConsulta = new GroupBox();
            label1 = new Label();
            btnConsultar = new Button();
            rbImportado = new RadioButton();
            lstResultados = new ListBox();
            cmbConsultaMarca = new ComboBox();
            rbNacional = new RadioButton();
            tbCarga.SuspendLayout();
            tabPage1.SuspendLayout();
            gbDatos.SuspendLayout();
            tabPage2.SuspendLayout();
            gbConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tbCarga
            // 
            tbCarga.Controls.Add(tabPage1);
            tbCarga.Controls.Add(tabPage2);
            tbCarga.Location = new Point(39, 36);
            tbCarga.Name = "tbCarga";
            tbCarga.SelectedIndex = 0;
            tbCarga.Size = new Size(587, 359);
            tbCarga.TabIndex = 9;
            tbCarga.Tag = "";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(gbDatos);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(579, 331);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cargar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbDatos
            // 
            gbDatos.BackColor = Color.White;
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
            gbDatos.Font = new Font("Sitka Small", 9F);
            gbDatos.Location = new Point(28, 57);
            gbDatos.Name = "gbDatos";
            gbDatos.Size = new Size(523, 216);
            gbDatos.TabIndex = 1;
            gbDatos.TabStop = false;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(121, 139);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(120, 22);
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
            txtNumero.Size = new Size(120, 22);
            txtNumero.TabIndex = 13;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Sitka Small", 9F);
            lblPrecio.Location = new Point(61, 140);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(45, 18);
            lblPrecio.TabIndex = 12;
            lblPrecio.Text = "Precio";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Sitka Small", 9F);
            lblNumero.Location = new Point(60, 98);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 18);
            lblNumero.TabIndex = 11;
            lblNumero.Text = "Número";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Sitka Small", 9F);
            lblDesc.Location = new Point(258, 99);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(79, 18);
            lblDesc.TabIndex = 10;
            lblDesc.Text = "Descripción";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Sitka Small", 9F);
            lblOrigen.Location = new Point(257, 47);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(49, 18);
            lblOrigen.TabIndex = 9;
            lblOrigen.Text = "Origen";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Sitka Small", 9F);
            lblMarca.Location = new Point(60, 49);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(46, 18);
            lblMarca.TabIndex = 8;
            lblMarca.Text = "Marca";
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "P", "F", "R" });
            cmbMarca.Location = new Point(121, 46);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(121, 26);
            cmbMarca.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(383, 174);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 27);
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
            cmbOrigen.Size = new Size(121, 26);
            cmbOrigen.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(gbConsulta);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(579, 331);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consultar";
            // 
            // gbConsulta
            // 
            gbConsulta.BackColor = Color.White;
            gbConsulta.Controls.Add(label1);
            gbConsulta.Controls.Add(btnConsultar);
            gbConsulta.Controls.Add(rbImportado);
            gbConsulta.Controls.Add(lstResultados);
            gbConsulta.Controls.Add(cmbConsultaMarca);
            gbConsulta.Controls.Add(rbNacional);
            gbConsulta.Font = new Font("Sitka Small", 9F);
            gbConsulta.Location = new Point(28, 67);
            gbConsulta.Name = "gbConsulta";
            gbConsulta.Size = new Size(523, 197);
            gbConsulta.TabIndex = 9;
            gbConsulta.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 9F);
            label1.Location = new Point(60, 47);
            label1.Name = "label1";
            label1.Size = new Size(46, 18);
            label1.TabIndex = 13;
            label1.Text = "Marca";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(392, 157);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 27);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // rbImportado
            // 
            rbImportado.AutoSize = true;
            rbImportado.Font = new Font("Sitka Small", 9F);
            rbImportado.Location = new Point(368, 44);
            rbImportado.Name = "rbImportado";
            rbImportado.Size = new Size(90, 22);
            rbImportado.TabIndex = 9;
            rbImportado.TabStop = true;
            rbImportado.Text = "Importado";
            rbImportado.UseVisualStyleBackColor = true;
            // 
            // lstResultados
            // 
            lstResultados.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstResultados.FormattingEnabled = true;
            lstResultados.ItemHeight = 18;
            lstResultados.Location = new Point(56, 87);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(411, 58);
            lstResultados.TabIndex = 8;
            // 
            // cmbConsultaMarca
            // 
            cmbConsultaMarca.FormattingEnabled = true;
            cmbConsultaMarca.Items.AddRange(new object[] { "P", "F", "R" });
            cmbConsultaMarca.Location = new Point(106, 43);
            cmbConsultaMarca.Name = "cmbConsultaMarca";
            cmbConsultaMarca.Size = new Size(121, 26);
            cmbConsultaMarca.TabIndex = 2;
            // 
            // rbNacional
            // 
            rbNacional.AutoSize = true;
            rbNacional.Font = new Font("Sitka Small", 9F);
            rbNacional.Location = new Point(265, 43);
            rbNacional.Name = "rbNacional";
            rbNacional.Size = new Size(79, 22);
            rbNacional.TabIndex = 8;
            rbNacional.TabStop = true;
            rbNacional.Text = "Nacional";
            rbNacional.UseVisualStyleBackColor = true;
            // 
            // frmCargaRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(669, 450);
            Controls.Add(tbCarga);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCargaRepuestos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carga de Repuestos ";
            tbCarga.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            tabPage2.ResumeLayout(false);
            gbConsulta.ResumeLayout(false);
            gbConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaskedTextBox maskedTextBox1;
        private TabControl tbCarga;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox gbDatos;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private TextBox txtNumero;
        private Label lblPrecio;
        private Label lblNumero;
        private Label lblDesc;
        private Label lblOrigen;
        private Label lblMarca;
        private ComboBox cmbMarca;
        private Button btnAgregar;
        private ComboBox cmbOrigen;
        private GroupBox gbConsulta;
        private Label label1;
        private Button btnConsultar;
        private RadioButton rbImportado;
        private ListBox lstResultados;
        private ComboBox cmbConsultaMarca;
        private RadioButton rbNacional;
    }
}
