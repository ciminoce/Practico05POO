using Ejercicio05.Entidades;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio05.Windows
{
    public partial class FrmMedidaAE : Form
    {
        private Medida? medida;
        public FrmMedidaAE()
        {
            InitializeComponent();
        }

        public  Medida GetMedida()
        {
            return medida;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (medida is null)
                {
                    medida = new Medida();
                }
                medida.Valor = double.Parse(TxtMedida.Text);

                var context = new ValidationContext(medida);
                var errores = new List<ValidationResult>();
                var isValid = Validator.TryValidateObject(medida, context, errores, true);
                if (isValid)
                {
                    MessageBox.Show(medida.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(errores.First().ErrorMessage,
                        "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!double.TryParse(TxtMedida.Text, out _))
            {
                valido = false;
                errorProvider1.SetError(TxtMedida, "Medida mal ingresada");
            }
            return valido;
        }
    }
}
