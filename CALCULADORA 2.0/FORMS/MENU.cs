namespace CALCULADORA_2._0
{
    public partial class MENU : Form
    {
        #region INITIALIZE
        public MENU()
        {
            InitializeComponent();
            customizeDesign();
        }
        #endregion


        #region SHOWANDHIDE FUNCTION
        private void customizeDesign()
        {
            panelSubmenu1.Visible = false;
            panelSubmenu2.Visible = false;
            panelSubmenu3.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelSubmenu1.Visible == true)
                panelSubmenu1.Visible = false;
            if (panelSubmenu2.Visible == true)
                panelSubmenu2.Visible = false;
            if (panelSubmenu3.Visible == true)
                panelSubmenu3.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        #endregion


        #region ECUACIONES NO LINEALES
        private void master1_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenu1);
        }

        //BAIRSTOW
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            hideSubmenu();
        }

        //BISECCION
        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new noLinealBiseccion());
            hideSubmenu();
        }

        //FALSA POSICION
        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new noLinealFalsaPosicion());
            hideSubmenu();
        }

        //NEWTON
        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form5());
            hideSubmenu();
        }

        //SECANTE
        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new Form6());
            hideSubmenu();
        }

        //SUSTITUCION SUCESIVA
        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new Form7());
            hideSubmenu();
        }
        #endregion


        #region INTERPOLACION
        private void master2_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenu2);
        }

        //LINEAL
        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new intLineal());
            hideSubmenu();
        }

        //CUADRATICA
        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new intCuadratica());
            hideSubmenu();
        }
        #endregion


        #region SUBMENU3

        private void master3_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenu3);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        #endregion


        #region OPENFORMS
        private Form activeForm = null;
        private void openChildForm(Form optionMaster)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = optionMaster;
            optionMaster.TopLevel = false;
            optionMaster.FormBorderStyle = FormBorderStyle.None;
            optionMaster.Dock = DockStyle.Fill;
            panelOptionMaster.Controls.Add(optionMaster);
            panelOptionMaster.Tag = optionMaster;
            optionMaster.BringToFront();
            optionMaster.Show();
        }
        #endregion

        
    }
}