namespace Ejercicio03Fer.Windows
{
    public partial class frmCuadrado : Form
    {
        public frmCuadrado()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                var lado = int.Parse(txtLado.Text);
                if (lado >= 1 && lado <= 100)
                {
                    var perimetro = CalcularPerimetro(lado);
                    var superficie = CalcularSuperficie(lado);
                    MessageBox.Show($"El perímetro es {perimetro} y la superficie es {superficie}",
                        "Resultado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    InicializarControles();

                }
                else
                {
                    MessageBox.Show("Valor del lado fuera del rango permitido",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtLado.SelectAll();//selecciona el contenido del cuadro de texto
                    txtLado.Focus();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Valor del lado no válido",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                InicializarControles();
            }

        }

        private void InicializarControles()
        {
            txtLado.Clear();//Limpia el cuadro de texto
            txtLado.Focus();//Posiciona el cursor en el cuadro de texto
        }

        private int CalcularPerimetro(int lado)
        {
            return lado * 4;
        }
        private double CalcularSuperficie(int lado)
        {
            return Math.Pow(lado, 2);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void frmCuadrado_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr=MessageBox.Show("¿Desea salir del programa?", "Pregunta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.No ) {
                e.Cancel= true;
            }
        }
    }
}