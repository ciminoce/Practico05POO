using Ejercicio05.Datos;
using Ejercicio05.Entidades;

namespace Ejercicio05.Windows
{
    public partial class FrmMedidas : Form
    {
        private GestorDeMedidas? gestor;
        public FrmMedidas()
        {
            InitializeComponent();
            gestor = new GestorDeMedidas();
        }

        private void TsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            FrmMedidaAE frm = new FrmMedidaAE() { Text = "Agregar Medida" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            Medida medida = frm.GetMedida();
            if (gestor! + medida)
            {
                var r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFila(r, medida);
                AgregarFila(r);
                MostrarTotales();
            }
            else
            {
                MessageBox.Show("Medida existente!!!");
            }
        }

        private void MostrarTotales()
        {
            int cantidad = gestor??0;
            double suma = gestor??0.0;
            TxtCantidad.Text=cantidad.ToString();
            TxtSuma.Text=suma.ToString();
        }

        private void SetearFila(DataGridViewRow r, Medida medida)
        {
            r.Cells[0].Value=medida.ToString();
            r.Tag = medida;
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }
    }
}
