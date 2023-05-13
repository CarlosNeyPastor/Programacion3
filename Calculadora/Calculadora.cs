using System.Diagnostics.Eventing.Reader;

namespace Calculadora
{
    public partial class FormCalculadora : Form
    {
        // Declaracion de color inicial
        Color colorInicial;
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set de check en true
            CheckResultados.Checked = true;

            // Respaldo de color inicial (Declarado anteriormente en "public partial class FormCalculadora : Form)
            colorInicial = this.BackColor;

            ActualizoPantalla();

            rbCientifica.Checked = true;
        }

        // TextBox
        private void textNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNum2_TextChanged(object sender, EventArgs e)
        {

        }

        // Buttons
        private void btnResta_Click(object sender, EventArgs e)
        {
            Efectua("-");
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Efectua("*");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Efectua("/");
        }


        // ListBox
        private void listResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // CheckBox
        private void CheckMostrarResultado_CheckedChanged(object sender, EventArgs e)
        {
            ActualizoPantalla();
        }

        // ComboBox
        private void cboResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Label
        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        // Button
        private void btnSuma_Click(object sender, EventArgs e)
        {
            Efectua("+");
        }
        double NumeroDouble(string valor)
        {
            double resultado;
            if (!double.TryParse(valor, out resultado))
            {
                resultado = 0;
            }
            return (resultado);
        }

        // Operacion
        void Efectua(string operacion)
        {
            double num1, num2, resultado = 0;
            num1 = NumeroDouble(textNum1.Text);
            num2 = NumeroDouble(textNum2.Text);
            Boolean operOk = true;
            string textoMostrar;

            //
            textNum1.Text = Convert.ToString(num1);
            textNum2.Text = Convert.ToString(num2);
            resultado = num1 + num2;
            lblResultado.Text = Convert.ToString(resultado);

            switch (operacion)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        resultado = num2 / num1;
                    }
                    else
                    {
                        operOk = false;
                    }
                    break;

                default:
                    break;
            }
            if (operOk)
            {
                lblResultado.Text = Convert.ToString(resultado);
                textoMostrar = num1 + operacion + num2 + "=" + resultado;
                listResultado.Items.Add(textoMostrar);
                cboResultado.Items.Add(textoMostrar);

                // Mostrar última operación en ComboBox
                cboResultado.SelectedIndex = cboResultado.Items.Count - 1;
            }
            else
            {
                lblResultado.Text = "No existe";
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ActualizoPantalla();
        }

        // Actualziar pantalla
        void ActualizoPantalla()
        {
            listResultado.Visible = CheckResultados.Checked;
            cboResultado.Visible = CheckResultados.Checked;
            if (CheckFondo.Checked)
            {
                this.BackColor = Color.Yellow;
            }
            else
            {
                this.BackColor = colorInicial;
            }
            gbCientificas.Visible = rbCientifica.Checked;

        } // Actualizar Pantalla

        private void rbCientifica_CheckedChanged(object sender, EventArgs e)
        {
            ActualizoPantalla();
        }
    }

}
