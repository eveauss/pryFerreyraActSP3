namespace pryFerreyraActSP3
{
    public partial class frmCargaRepuestos : Form
    {
        public frmCargaRepuestos()
        {
            InitializeComponent();
        }

        public struct Repuesto
        {
            public char Marca;
            public char Origen;
            public int Numero;
            public string Descripcion;
            public float Precio;
        }

        const int MAX = 100;
        Repuesto[] repuestos = new Repuesto[MAX];
        int CantidadRepuestos = 0;



        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

      

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (CantidadRepuestos >= MAX)
            {
                MessageBox.Show("No se pueden agregar más repuestos. Capacidad máxima alcanzada.");
            }

            char Marca = Convert.ToChar(cmbMarca.SelectedItem);
            char Origen = rbNacional.Checked ? 'N' : 'I';

            if (!"PFR".Contains(Marca) || !"NI".Contains(Origen))
            {
                MessageBox.Show("Marca u Origen inválido.");
                return;
            }

            if (!int.TryParse(txtNumero.Text, out int numero) || numero < 0 || numero > 999999)
            {
                MessageBox.Show("Número inválido.");
                return;
            }


            for (int i = 0; i < CantidadRepuestos; i++)
            {
                if (repuestos != null && repuestos[i].Numero == numero)
                {
                    MessageBox.Show("Número de repuesto ya existente.");
                    return;
                }
            }



            if (txtDescripcion.Text.Length > 50)
            {
                MessageBox.Show("LA descripción no puede superar los 50 caracteres.");
                return;
            }

            if (!float.TryParse(txtPrecio.Text, out float Precio) || Precio < 0)
            {
                MessageBox.Show("Precio inválido.");
                return;
            }

            repuestos[CantidadRepuestos].Marca = Marca;
            repuestos[CantidadRepuestos].Origen = Origen;
            repuestos[CantidadRepuestos].Numero = numero;
            repuestos[CantidadRepuestos].Descripcion = txtDescripcion.Text;
            repuestos[CantidadRepuestos].Precio = Precio;

            CantidadRepuestos++;

            MessageBox.Show("Repuesto agregado exitosamente.");

            txtNumero.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            cmbMarca.SelectedIndex = -1;
            cmbOrigen.SelectedIndex = -1;
            rbNacional.Checked = false;
            rbImportado.Checked = false;

            txtNumero.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            char marca = cmbConsultaMarca.Text.FirstOrDefault();
            char origen = rbNacional.Checked ? 'N' : 'I';

            for (int i = 0; i < CantidadRepuestos; i++)
            {
                if (repuestos != null &&
                    repuestos[i].Marca == marca &&
                    repuestos[i].Origen == origen)
                {
                    string resultado = " N°" + repuestos[i].Numero +
                        "-" + repuestos[i].Descripcion +
                        "- $" + repuestos[i].Precio.ToString("F2");
                    lstResultados.Items.Add(resultado);
                }
            }

            if (lstResultados.Items.Count == 0)
            {
                MessageBox.Show("No se encontraron repuestos con esos criterios.");
            }
        }
    }
}
    

