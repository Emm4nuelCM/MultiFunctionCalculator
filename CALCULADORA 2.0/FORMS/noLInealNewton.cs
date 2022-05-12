using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA_2._0
{
    public partial class noLInealNewton : Form
    {
        #region VALORES
        private string funcion;
        private double xi;
        private double xu;
        private double factParo;
        private double operacion;
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
                        if (String.IsNullOrEmpty(derivadaBox.Text))
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
            
            xi = Convert.ToDouble(desdeBox.Text);
            int imax, iter;
            double ea, fxi, fxu, fxr, xr, xrold;
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
                xr = (xu - ((fxu * (xi - xu))) / (fxi - fxu));
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
                dgvResults.Rows[n1].Cells[2].Value = ea + " %";
                dgvResults.Rows[n1].Cells[3].Value = function(xr);

            } while (ea > factParo && iter <= imax);
            //}
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
            MSScriptControl.ScriptControl sc = new MSScriptControl.ScriptControl();
            sc.Language = "VBScript";

            string expression = "", eulerReplace = "";

            if ((FXBox.Text.Contains("e")) && (FXBox.Text.Contains("x")))
            {
                eulerReplace = FXBox.Text.Replace("e", "2.7182818284");
                expression = eulerReplace.Replace("x", x.ToString());
            }
            else
            {
                expression = FXBox.Text.Replace("x", x.ToString());
                //int n2 = dgv2.Rows.Add();
                //dgv2.Rows[n2].Cells[0].Value = expression;
                //dgv2.Rows[n2].Cells[0].Value = function(xu);
                //dgv2.Rows[n2].Cells[0].Value = function(xu)*function(xi);
            }

            double result = sc.Eval(expression);

            return result;
        }

        #endregion
    }
}
