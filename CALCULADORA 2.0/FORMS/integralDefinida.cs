using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AngouriMath;
using AngouriMath.Extensions;

namespace CALCULADORA_2._0.FORMS
{
    public partial class integralDefinida : Form
    {
        #region VALORES
        private string funcion;
        private double desde;
        private double hasta;
        
        
        public bool error; // Variable utilizada para detectar un error
        #endregion

        #region INICIALIZACION
        public integralDefinida()
        {
            InitializeComponent();
        }
        #endregion

        #region VERIFICAR CAMPOS
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FXBox.Text))
            {
                validateUserEntry();
            }
            else
            {
                funcion = Convert.ToString(FXBox.Text);
                if (String.IsNullOrEmpty(hastaBox.Text))
                {
                    validateUserEntry();
                }
                else
                {
                    hasta = Convert.ToDouble(hastaBox.Text);
                    if (String.IsNullOrEmpty(desdeBox.Text))
                    {
                        validateUserEntry();
                    }
                    else
                    {
                        calcular();
                    }
                }
            }
        }
        #endregion

        #region CALCULAR
        private void calcular()
        {
            double a, b, evalDouble;
            string expression = FXBox.Text;

            a = double.Parse(desdeBox.Text);
            b = double.Parse(hastaBox.Text);

            switch (expression)
            {
                case var euler when expression.Contains("ℯ"):
                    expression = expression.Replace("ℯ", "e");
                    break;
                case var sqrt when expression.Contains("√"):
                    expression = expression.Replace("√", "sqrt");
                    break;
                case var pi when expression.Contains("π"):
                    expression = expression.Replace("π", "pi");
                    break;
                case var arcsin when expression.Contains("sin⁻¹"):
                    expression = expression.Replace("sin⁻¹", "arcsin");
                    break;
                case var arccos when expression.Contains("cos⁻¹"):
                    expression = expression.Replace("cos⁻¹", "arccos");
                    break;
                case var arctan when expression.Contains("tan⁻¹"):
                    expression = expression.Replace("tan⁻¹", "arctan");
                    break;
            }
            DXBox.Text = expression.Integrate("x").ToString();
            Entity integral = expression.Integrate("x").Simplify();

            string integralPartA = integral.ToString();
            string integralPartB = integral.ToString();

            switch (integralPartA)
            {
                case var euler when integralPartA.Contains("ℯ"):
                    integralPartA = integralPartA.Replace("ℯ", "e");
                    break;
                case var sqrt when integralPartA.Contains("√"):
                    integralPartA = integralPartA.Replace("√", "sqrt");
                    break;
                case var pi when integralPartA.Contains("π"):
                    integralPartA = integralPartA.Replace("π", "pi");
                    break;
                case var arcsin when integralPartA.Contains("sin⁻¹"):
                    integralPartA = integralPartA.Replace("sin⁻¹", "arcsin");
                    break;
                case var arccos when integralPartA.Contains("cos⁻¹"):
                    integralPartA = integralPartA.Replace("cos⁻¹", "arccos");
                    break;
                case var arctan when integralPartA.Contains("tan⁻¹"):
                    integralPartA = integralPartA.Replace("tan⁻¹", "arctan");
                    break;
                case var xValue when integralPartA.Contains("x"):
                    integralPartA = integralPartA.Replace("x", a.ToString());
                    break;
            }

            switch (integralPartB)
            {
                case var euler when integralPartB.Contains("ℯ"):
                    integralPartB = integralPartB.Replace("ℯ", "e");
                    break;
                case var sqrt when integralPartB.Contains("√"):
                    integralPartB = integralPartA.Replace("√", "sqrt");
                    break;
                case var pi when integralPartB.Contains("π"):
                    integralPartB = integralPartB.Replace("π", "pi");
                    break;
                case var arcsin when integralPartB.Contains("sin⁻¹"):
                    integralPartB = integralPartB.Replace("sin⁻¹", "arcsin");
                    break;
                case var arccos when integralPartB.Contains("cos⁻¹"):
                    integralPartB = integralPartB.Replace("cos⁻¹", "arccos");
                    break;
                case var arctan when integralPartB.Contains("tan⁻¹"):
                    integralPartB = integralPartB.Replace("tan⁻¹", "arctan");
                    break;
                case var xValue when integralPartB.Contains("x"):
                    integralPartB = integralPartB.Replace("x", b.ToString());
                    break;
            }

            if (integralPartB.Contains("ln") || integralPartA.Contains("ln"))
            {
                string calculateLn;
                string[] partInferiorA, partInferiorB;

                partInferiorA = expression.Split('/');
                partInferiorB = expression.Split('/');

                partInferiorA[1] = partInferiorA[1].Replace("x", a.ToString());
                partInferiorB[1] = partInferiorB[1].Replace("x", b.ToString());

                calculateLn = "-ln(" + partInferiorA[1] + ") - (-ln(" + partInferiorB[1] + "))";

                evalDouble = (double)calculateLn.EvalNumerical();
            } else
            {
                evalDouble = (double)(integralPartB.EvalNumerical() - integralPartA.EvalNumerical());
                resultadoBox.Text = "Approx " + evalDouble.ToString() + "u^2";
            }
            try
            {

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

                if (err.Message.Contains("no viable alternative at input"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, por favor escriba la función correctamente.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR100",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://github.com/JohnyDeCoder/rootprox#err100"
                    );
                }

                if (err.Message.Contains("mismatched input"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, por favor no escriba signos o símbolos repetidos.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR101",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://github.com/JohnyDeCoder/rootprox#err101"
                    );
                }

                if (err.Message.Contains("extraneous input"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, por favor escriba la función correctamente.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR102",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://github.com/JohnyDeCoder/rootprox#err102"
                    );
                }

                if (err.Message.Contains("Cannot cast from AngouriMath.Entity+Number+Complex to System.Double"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, la función es muy compleja para su solución.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR103",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://github.com/JohnyDeCoder/rootprox#err103"
                    );
                }

                if (err.Message.Contains("Result cannot be represented as a simple number!"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, por favor escriba la función correctamente.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR104",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://github.com/JohnyDeCoder/rootprox#err104"
                    );
                }

                if (err.Message.Contains("token recognition error at"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, por favor escriba la función correctamente.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR105",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://github.com/JohnyDeCoder/rootprox#err105"
                    );
                }
            }
        }
        #endregion

        #region SALIR
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region FALTAPORRELLENAR
        private void validateUserEntry()
        {
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "Faltan Cuadros Por Rellenar";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                //this.Close();
            }
        }
        #endregion

        #region RECIBIR FORMULA
        private void Box2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '^') && (e.KeyChar != 'x') && (e.KeyChar != '-') && (e.KeyChar != '+') && (e.KeyChar != '*') && (e.KeyChar != 'e'))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region SOLONUMEROS
        private void Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region LIMPIAR
        private void button1_Click(object sender, EventArgs e)
        {
            desdeBox.Text = "";
            hastaBox.Text = "";
            DXBox.Text = "0";
            FXBox.Text = "";
            resultadoBox.Text = "";
        }
        #endregion
    }
}
