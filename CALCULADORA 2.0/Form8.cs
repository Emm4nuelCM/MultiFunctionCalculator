﻿namespace CALCULADORA_2._0
{
    public partial class Form8 : Form
    {
        #region VALORES
        private double valor0;
        private double valor1;
        private double valor2;
        private double valor3;
        private double valor4;
        private string fraseInLin = "Resultado de Interpolacion Lineal = ";
        private string fraseFin = " Aprox.";
        private double operacion;
        #endregion

        #region INICIALIZACION
        public Form8()
        {
            InitializeComponent();
        }
        #endregion

        #region SALIR
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region CALCULAR
        private void calcular_Click(object sender, EventArgs e)
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
                    if (String.IsNullOrEmpty(XBox.Text))
                    {
                        validateUserEntry();
                    }
                    else
                    {
                        valor2 = Convert.ToDouble(XBox.Text);
                        if (String.IsNullOrEmpty(FX0Box.Text))
                        {
                            validateUserEntry();
                        }
                        else
                        {
                            valor3 = Convert.ToDouble(FX0Box.Text);
                            if (String.IsNullOrEmpty(FX1Box.Text))
                            {
                                validateUserEntry();
                            }
                            else
                            {
                                valor4 = Convert.ToDouble(FX1Box.Text);
                                operacion = ((((valor2 - valor1) / (valor0 - valor1)) * valor3) + (((valor2 - valor0) / (valor1 - valor0)) * valor4));
                                tbDisplay.Text = fraseInLin + operacion.ToString() + fraseFin;
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region LIMPIAR
        private void limpiar_Click(object sender, EventArgs e)
        {
            X0Box.Text = "";
            X1Box.Text = "";
            FX0Box.Text = "";
            FX1Box.Text = "";
            XBox.Text = "";
            tbDisplay.Text = "";
        }
        #endregion

        #region CUADRO DE ERROR
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
    }
}
