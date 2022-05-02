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
    public partial class intCuadratica : Form
    {
        #region VALORES
        private double valor0;
        private double valor1;
        private double valor2;
        private double valor3;
        private double valor4;
        private double valor5;
        private double valor6;
        private double valor7;
        private string fraseInCuad = "Resultado de Interpolacion Cuadratica = ";
        private string fraseFin = " Aprox.";
        private double operacion;
        #endregion

        #region INICIALIZACION
        public intCuadratica()
        {
            InitializeComponent();
        }
        #endregion

        #region CALCULAR
        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(X0Box.Text))
            {
                validateUserEntry();
            }
            else
            {
                valor0 = Convert.ToDouble(X0Box.Text);
                if (String.IsNullOrEmpty(X1Box.Text))
                {
                    validateUserEntry();
                }
                else
                {
                    valor1 = Convert.ToDouble(X1Box.Text);
                    if (String.IsNullOrEmpty(X2Box.Text))
                    {
                        validateUserEntry();
                    }
                    else
                    {
                        valor2 = Convert.ToDouble(X2Box.Text);
                        if (String.IsNullOrEmpty(XBox.Text))
                        {
                            validateUserEntry();
                        }
                        else
                        {
                            valor3 = Convert.ToDouble(XBox.Text);
                            if (String.IsNullOrEmpty(FX0Box.Text))
                            {
                                validateUserEntry();
                            }
                            else
                            {
                                valor4 = Convert.ToDouble(FX0Box.Text);
                                if (String.IsNullOrEmpty(FX1Box.Text))
                                {
                                    validateUserEntry();
                                }
                                else
                                {
                                    valor5 = Convert.ToDouble(FX1Box.Text);
                                    if (String.IsNullOrEmpty(FX2Box.Text))
                                    {
                                        validateUserEntry();
                                    }
                                    else
                                    {
                                        valor6 = Convert.ToDouble(FX2Box.Text);
                                        operacion = (((valor3-valor1)/(valor0-valor1))*((valor3-valor2)/(valor0-valor2))*valor4)+
                                                    (((valor3-valor0)/(valor1-valor0))*((valor3-valor2)/(valor1-valor2))*valor5)+
                                                    (((valor3-valor0)/(valor2-valor0))*((valor3-valor1)/(valor2-valor1))*valor6);
                                        tbDisplay.Text = fraseInCuad + operacion.ToString() + fraseFin;
                                        if (String.IsNullOrEmpty(errorBox.Text))
                                        {
                                            tbDisplayError.Text = "";
                                        }
                                        else
                                        {
                                            valor7 = Convert.ToDouble(errorBox.Text);
                                            tbDisplayError.Text = (((valor7 - operacion) / valor7) * 100).ToString() + "%";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region SALIR
        private void salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region LIMPIAR
        private void button2_Click(object sender, EventArgs e)
        {
            X0Box.Text = "";
            X1Box.Text = "";
            X2Box.Text = "";
            FX0Box.Text = "";
            FX1Box.Text = "";
            FX2Box.Text = "";
            XBox.Text = "";
            tbDisplay.Text = "";
            tbDisplayError.Text = "";
            errorBox.Text = "";
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
    }
}
