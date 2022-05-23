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



namespace CALCULADORA_2._0
{
    public partial class noLInealNewton : Form
    {
        #region VALORES
        private string funcion;
        private double xi;
        private double factParo;
        public bool error; // Variable utilizada para detectar un error
        #endregion

        #region INICIALIZACION
        public noLInealNewton()
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
                if (String.IsNullOrEmpty(paroBox.Text))
                {
                    validateUserEntry();
                }
                else
                {
                    factParo = Convert.ToDouble(paroBox.Text);
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

        #region Calcular
        private void calcular()
        {
            xi = Convert.ToDouble(desdeBox.Text);
            int imax, iter;
            double ea, xr, xrold;
            imax = 30;
            dgvResults.Rows.Clear();
            iter = 0;
            xr = 0;

            do
            {
                iter++;

                xrold = xr;
                xr = xi - (function(xi) / derivate(xi));
                xi = xr;
                ea = Math.Abs((xr - xrold) / xr) * 100;

                int n1 = dgvResults.Rows.Add();
                dgvResults.Rows[n1].Cells[0].Value = iter;
                dgvResults.Rows[n1].Cells[1].Value = xr;
                dgvResults.Rows[n1].Cells[2].Value = ea + " %";
                dgvResults.Rows[n1].Cells[3].Value = function(xi);
                dgvResults.Rows[n1].Cells[4].Value = derivate(xi);

            } while (ea > factParo && iter <= imax);
        }
        #endregion

        #region SALIR
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region LIMPIAR 
        private void button1_Click(object sender, EventArgs e)
        {
            FXBox.Text = "";
            desdeBox.Text = "";
            paroBox.Text = "";
            derivadaBox.Text = "";
            dgvResults.Rows.Clear();
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

        #region FUNCION
        private double function(double x)
        {
            string expression = FXBox.Text;
            double evalDouble = 0;

            error = false;

            try
            {
                // Puede ser lento a la hora de ejecutar .Replace
                if (expression.Contains("ℯ"))
                {
                    expression = expression.Replace("ℯ", "e");
                }

                if (expression.Contains("√"))
                {
                    expression = expression.Replace("√", "sqrt");
                }

                if (expression.Contains("π"))
                {
                    expression = expression.Replace("π", "pi");
                }

                if (expression.Contains("sin⁻¹"))
                {
                    expression = expression.Replace("sin⁻¹", "arcsin");
                }

                if (expression.Contains("cos⁻¹"))
                {
                    expression = expression.Replace("cos⁻¹", "arccos");
                }

                if (expression.Contains("tan⁻¹"))
                {
                    expression = expression.Replace("tan⁻¹", "arctan");
                }

                if (expression.Contains("x"))
                {
                    expression = expression.Replace("x", "(" + x + ")".ToString());
                }

                var expr = MathS.FromString(expression);

                expr.Simplify(); // Simplificar expresiones complicadas

                evalDouble = (double)expr.EvalNumerical();
            }
            catch (Exception err)
            {
                error = true;

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
                    0, "https://www.google.com.mx/?hl=es-419"
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
                    0, "https://www.google.com.mx/?hl=es-419"
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
                    0, "https://www.google.com.mx/?hl=es-419"
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
                    0, "https://www.google.com.mx/?hl=es-419"
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
                    0, "https://www.google.com.mx/?hl=es-419"
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
                    0, "https://www.google.com.mx/?hl=es-419"
                    );
                }
            }
            return evalDouble;
        }

        #endregion

        #region Derivada
        private double derivate(double x)
        {
            string expression = derivadaBox.Text;
            double evalDouble = 0;

            error = false;

            try
            {
                // Puede ser lento a la hora de ejecutar .Replace
                if (expression.Contains("ℯ"))
                {
                    expression = expression.Replace("ℯ", "e");
                }

                if (expression.Contains("√"))
                {
                    expression = expression.Replace("√", "sqrt");
                }

                if (expression.Contains("π"))
                {
                    expression = expression.Replace("π", "pi");
                }

                if (expression.Contains("sin⁻¹"))
                {
                    expression = expression.Replace("sin⁻¹", "arcsin");
                }

                if (expression.Contains("cos⁻¹"))
                {
                    expression = expression.Replace("cos⁻¹", "arccos");
                }

                if (expression.Contains("tan⁻¹"))
                {
                    expression = expression.Replace("tan⁻¹", "arctan");
                }

                if (expression.Contains("x"))
                {
                    expression = expression.Replace("x", "("+x+")".ToString());
                }
                
                var expr = MathS.FromString(expression);
                expr.Simplify(); // Simplificar expresiones complicadas
                evalDouble = (double)expr.EvalNumerical();
            }
            catch (Exception err)
            {
                error = true;

                if (err.Message.Contains("no viable alternative at input"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, por favor escriba la función correctamente.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR[num]",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://www.google.com.mx/?hl=es-419"
                    );
                }

                if (err.Message.Contains("mismatched input"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, por favor no escriba signos o símbolos repetidos.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR[num]",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://www.google.com.mx/?hl=es-419"
                    );
                }

                if (err.Message.Contains("extraneous input"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, por favor escriba la función correctamente.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR[num]",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://www.google.com.mx/?hl=es-419"
                    );
                }

                if (err.Message.Contains("Cannot cast from AngouriMath.Entity+Number+Complex to System.Double"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, la función es muy compleja para su solución.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR[num]",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://www.google.com.mx/?hl=es-419"
                    );
                }

                if (err.Message.Contains("Result cannot be represented as a simple number!"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, por favor escriba la función correctamente.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR[num]",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://www.google.com.mx/?hl=es-419"
                    );
                }

                if (err.Message.Contains("token recognition error at"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, por favor escriba la función correctamente.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR[num]",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://www.google.com.mx/?hl=es-419"
                    );
                }
            }
            return evalDouble;
        }

        //ACTUALIZACION DE DERIVADA //ACTUALIZACION DE DERIVADA //ACTUALIZACION DE DERIVADA
        private void FXBox_MouseLeave(object sender, EventArgs e)
        {
            derivadaBox.Text = "0";
            //Exception User-Unhandled
            error = false;
            try
            {
                derivadaBox.Text = FXBox.Text.Differentiate("x").Simplify().ToString();
            }
            catch (Exception err)
            {
                error = true;
                if (err.Message.Contains("user unhandled"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, por favor escriba la función correctamente.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR100",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://www.google.com.mx/?hl=es-419"
                    );
                }
            }
        }
        #endregion
    }
}
