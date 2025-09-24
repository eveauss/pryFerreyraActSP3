namespace pryFerreyraActSP3
{
    public partial class frmCargaRepuestos : Form
    {
        public frmCargaRepuestos()
        {
            InitializeComponent();
        }

        Repuesto[] repuestos = new Repuesto[100];
        int CantidadRepuestos = 0;



        private void label2_Click(object sender, EventArgs e)
        {
            if (CantidadRepuestos >= 100)
            {
                MessageBox.Show("Se alcanzó el número de 100 repuestos");
                return;
            }
        }
    }
}
