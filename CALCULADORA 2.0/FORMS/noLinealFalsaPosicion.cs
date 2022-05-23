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

namespace CALCULADORA_2._0
{
    public partial class noLinealFalsaPosicion : Form
    {
        #region VALORES
        private string funcion;
        private double xi;
        private double xu;
        private double factParo;
        private double operacion;
        public bool error; // Variable utilizada para detectar un error
        #endregion

        #region INICIALIZACION
        public noLinealFalsaPosicion()
        {
            InitializeComponent();
        }
        #endregion

        #region VERIFICAR CAMPOS
        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FXBox.Text))
            {
                validateUserEntry();
            }
            else
            {
                double x;
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
                        if (String.IsNullOrEmpty(hastaBox.Text))
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
        }
        #endregion

        #region Calcular
        private void calcular()
        {
            xu = Convert.ToDouble(hastaBox.Text);
            xi = Convert.ToDouble(desdeBox.Text);
            int imax, iter;
            double ea, fxi, fxu, fxr, xr,xrold;
            imax = 30;
            dgvResults.Rows.Clear();
            iter = 0;
            xr = 0;
            fxi = function(xi);
            fxu = function(xu);
            
            

            //if (function(xi) * function(xu) > 0)
            //{
              //  MessageBox.Show("No existe raíz en esos intérvalos.");
            //}
            //else
            //{
                do
                {
                    iter++;

                    xrold = xr;
                    xr = (xu-((fxu*(xi-xu)))/(fxi-fxu));
                    fxr = function(xr);

                    ea = Math.Abs((xr - xrold) / xr) * 100;

                    if (function(xr) * function(xi) < 0)
                    {
                        fxi = (fxi / 2);
                        xu = xr;
                        fxu = fxr;
                    }
                    else if (function(xr) * function(xi) > 0)
                    {
                        xi = xr;
                        fxi = fxr;
                        fxu = (fxu / 2);
                    }
                    else
                    {
                        ea = 0;
                    }

                    int n1 = dgvResults.Rows.Add();

                    dgvResults.Rows[n1].Cells[0].Value = iter;
                    dgvResults.Rows[n1].Cells[1].Value = xr;
                    dgvResults.Rows[n1].Cells[2].Value = function(xr);
                    dgvResults.Rows[n1].Cells[3].Value = ea + " %";
                    

                } while (ea > factParo && iter <= imax);
            //}
        }
        #endregion

        #region SALIR
        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region LIMPIAR
        private void button2_Click(object sender, EventArgs e)
        {
            FXBox.Text = "";
            desdeBox.Text = "";
            hastaBox.Text = "";
            paroBox.Text = "";
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
                (e.KeyChar != '.'))
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

        #endregion 
    }
}
