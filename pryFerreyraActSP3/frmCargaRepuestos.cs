namespace pryFerreyraActSP3
{
    public partial class frmCargaRepuestos : Form
    {
        public frmCargaRepuestos()
        {
            InitializeComponent();
        }

        public class Repuesto
        {
            public char Marca { get; set; }
            public char Origen { get; set; }
            public int Numero { get; set; }
            public string Descripcion { get; set; }
            public float Precio { get; set; }
        }

        Repuesto[] repuestos = new Repuesto[100];
        int CantidadRepuestos = 0;



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (CantidadRepuestos >= 100)
            {
                MessageBox.Show("No se pueden agregar más repuestos. Capacidad máxima alcanzada.");
            }

            char Marca = Convert.ToChar(cmbMarca.SelectedItem);
            char Origen = Convert.ToChar(cmbOrigen.SelectedItem);

            if (!"PFR".Contains(Marca) || !"INA".Contains(Origen))
            {
                MessageBox.Show("Marca u Origen inválido.");
                return;
            }

            if (!int.TryParse(txtNumero.Text, out int Numero) || Numero > 999 || Numero < 0)
            {
                MessageBox.Show("Número inválido.");
                return;
            }

            bool numeroExistente = false;
            for (int i = 0; i < CantidadRepuestos; i++)
            {
                if (repuestos != null && repuestos[i].Numero == Numero)
                {
                    numeroExistente = true;
                    break;
                }
            }

            if (numeroExistente)
            {
                MessageBox.Show("Número de repuesto ya existente.");
                return;
            }

            if (txtDescripcion.Text.Length > 50)
            {
                MessageBox.Show("Descripción demasiado larga.");
                return;
            }

            if (!float.TryParse(txtPrecio.Text, out float Precio) || Precio < 0)
            {
                MessageBox.Show("Precio inválido.");
                return;
            }

            repuestos[CantidadRepuestos++] = new Repuesto
            {
                Marca = Marca,
                Origen = Origen,
                Numero = Numero,
                Descripcion = txtDescripcion.Text,
                Precio = Precio
            };

            MessageBox.Show("Repuesto agregado exitosamente.");


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
                MessageBox.Show("No se encontraron repuestos que coincidan con los criterios de búsqueda.");
            }
        }

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

        private void frmCargaRepuestos_Load(object sender, EventArgs e)
        {

        }
    }
}
    

