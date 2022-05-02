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
    public partial class noLinealBiseccion : Form
    {
        #region VALORES
        private string funcion;
        private double xi;
        private double xu;
        private double factParo;
        private double operacion;
        #endregion

        #region INICIALIZACION
        public noLinealBiseccion()
        {
            InitializeComponent();
        }
        #endregion

        #region CALCULAR
        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FXBox.Text))
            {
                validateUserEntry();
            }
            else
            {
                funcion = Convert.ToString(FXBox.Text);
                //String[] valor01 = funcion.Split("");
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
                        xi = Convert.ToDouble(desdeBox.Text);
                        if (String.IsNullOrEmpty(hastaBox.Text))
                        {
                            validateUserEntry();
                        }
                        else
                        {
                            xu = Convert.ToDouble(hastaBox.Text);
                            int imax, iter;
                            double ea, xa, xaold;

                            /* xi = a
                             * xd = b
                             * imax = iteraciones maximas
                             * em = error minimo
                             * 
                             * iter = numero de iteraciones
                             * imax = iteraciones maximas
                             */


                            imax = 30; //int.Parse(txtNmax.Text);

                            dgvResults.Rows.Clear();
                            //dgvResultAprox.Rows.Clear();

                            iter = 0;
                            xa = 0;

                            //if (function(xi) * function(xu) > 0)
                            //{
                            //    MessageBox.Show("No existe raíz en esos intérvalos.");
                            //}
                            //else
                            //{
                                do
                                {
                                    iter++;

                                    xaold = xa;
                                    xa = (xi + xu) / 2;

                                    ea = Math.Abs((xa - xaold) / xa) * 100;

                                    if (function(xi) * function(xa) < 0)
                                    {
                                        xu = xa;
                                    }
                                    else if (function(xi) * function(xa) > 0)
                                    {
                                        xi = xa;
                                    }
                                    else
                                    {
                                        ea = 0;
                                    }

                                    int n1 = dgvResults.Rows.Add();

                                    dgvResults.Rows[n1].Cells[0].Value = iter;
                                    dgvResults.Rows[n1].Cells[1].Value = xa;
                                    dgvResults.Rows[n1].Cells[2].Value = ea + " %";
                                    dgvResults.Rows[n1].Cells[3].Value = function(xa);

                            } while (ea > factParo && iter <= imax);

                                //int n2 = dgvResultAprox.Rows.Add();

                                //dgvResultAprox.Rows[n2].Cells[0].Value = iter;
                                //dgvResultAprox.Rows[n2].Cells[1].Value = xa;
                                //dgvResultAprox.Rows[n2].Cells[2].Value = ea + " %";
                            //}
                        }
                    }
                }
            }
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
            tbDisplayError.Text = "";
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
                (e.KeyChar != '.') && (e.KeyChar != '^') && (e.KeyChar != 'x') && (e.KeyChar != '-') && (e.KeyChar != '+'))
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
            }

            double result = sc.Eval(expression);

            return result;
        }
        #endregion
    }
}
