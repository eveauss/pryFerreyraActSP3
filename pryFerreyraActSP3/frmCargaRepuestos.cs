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

           
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }
    }
}
    

