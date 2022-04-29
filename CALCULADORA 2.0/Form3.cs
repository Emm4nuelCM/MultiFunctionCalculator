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
    public partial class Form3 : Form
    {
        #region VALORES
        private string valor0;
        private double valor1;
        private double valor2;
        private double valor3;
        private double valor4;
        private double potencia;
        private string letra;
        //private string fraseInCuad = "Resultado de Interpolacion Cuadratica = ";
        //private string fraseFin = " Aprox.";
        private double operacion;
        #endregion

        #region INICIALIZACION
        public Form3()
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
                valor0 = Convert.ToString(FXBox.Text);
                if (String.IsNullOrEmpty(paroBox.Text))
                {
                    validateUserEntry();
                }
                else
                {
                    valor1 = Convert.ToDouble(paroBox.Text);
                    if (String.IsNullOrEmpty(desdeBox.Text))
                    {
                        validateUserEntry();
                    }
                    else
                    {
                        valor2 = Convert.ToDouble(desdeBox.Text);
                        if (String.IsNullOrEmpty(hastaBox.Text))
                        {
                            validateUserEntry();
                        }
                        else
                        {
                            valor3 = Convert.ToDouble(hastaBox.Text);
                            for(int i = 0; i < valor0.Length; i++)
                            {
                                
                            }
                        

                            if (String.IsNullOrEmpty(errorBox.Text))
                            {
                                validateUserEntry();
                            }
                            else
                            {
                                valor4 = Convert.ToDouble(errorBox.Text);
                                tbDisplayError.Text = (((operacion-valor4) / operacion) * 100).ToString() + "%";
                            }
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
            errorBox.Text = "";
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
                (e.KeyChar != '.') && (e.KeyChar != '^') && (e.KeyChar != 'x'))
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
    }
}
