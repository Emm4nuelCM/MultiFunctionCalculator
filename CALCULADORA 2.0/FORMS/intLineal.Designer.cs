namespace CALCULADORA_2._0
{
    partial class intLineal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(intLineal));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.valoresBox = new System.Windows.Forms.GroupBox();
            this.errorBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FX1Box = new System.Windows.Forms.TextBox();
            this.FX0Box = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.XBox = new System.Windows.Forms.TextBox();
            this.X1Box = new System.Windows.Forms.TextBox();
            this.X0Box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.calcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbDisplayError = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tittle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.valoresBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(708, 566);
            this.dataGridView1.TabIndex = 11;
            // 
            // valoresBox
            // 
            this.valoresBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.valoresBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.valoresBox.Controls.Add(this.errorBox);
            this.valoresBox.Controls.Add(this.label6);
            this.valoresBox.Controls.Add(this.label2);
            this.valoresBox.Controls.Add(this.label1);
            this.valoresBox.Controls.Add(this.FX1Box);
            this.valoresBox.Controls.Add(this.FX0Box);
            this.valoresBox.Controls.Add(this.label10);
            this.valoresBox.Controls.Add(this.label11);
            this.valoresBox.Controls.Add(this.label7);
            this.valoresBox.Controls.Add(this.label9);
            this.valoresBox.Controls.Add(this.XBox);
            this.valoresBox.Controls.Add(this.X1Box);
            this.valoresBox.Controls.Add(this.X0Box);
            this.valoresBox.Controls.Add(this.label8);
            this.valoresBox.Controls.Add(this.label3);
            this.valoresBox.Controls.Add(this.label4);
            this.valoresBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.valoresBox.ForeColor = System.Drawing.Color.White;
            this.valoresBox.Location = new System.Drawing.Point(104, 22);
            this.valoresBox.Name = "valoresBox";
            this.valoresBox.Size = new System.Drawing.Size(452, 197);
            this.valoresBox.TabIndex = 17;
            this.valoresBox.TabStop = false;
            this.valoresBox.Text = "VALORES";
            // 
            // errorBox
            // 
            this.errorBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorBox.Location = new System.Drawing.Point(311, 146);
            this.errorBox.Multiline = true;
            this.errorBox.Name = "errorBox";
            this.errorBox.ShortcutsEnabled = false;
            this.errorBox.Size = new System.Drawing.Size(130, 30);
            this.errorBox.TabIndex = 20;
            this.errorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.errorBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(257, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 30);
            this.label6.TabIndex = 18;
            this.label6.Text = "Er=";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "X   =";
            // 
            // FX1Box
            // 
            this.FX1Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FX1Box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FX1Box.Location = new System.Drawing.Point(311, 101);
            this.FX1Box.Multiline = true;
            this.FX1Box.Name = "FX1Box";
            this.FX1Box.ShortcutsEnabled = false;
            this.FX1Box.Size = new System.Drawing.Size(130, 30);
            this.FX1Box.TabIndex = 16;
            this.FX1Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FX1Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // FX0Box
            // 
            this.FX0Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FX0Box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FX0Box.Location = new System.Drawing.Point(311, 49);
            this.FX0Box.Multiline = true;
            this.FX0Box.Name = "FX0Box";
            this.FX0Box.ShortcutsEnabled = false;
            this.FX0Box.Size = new System.Drawing.Size(130, 30);
            this.FX0Box.TabIndex = 15;
            this.FX0Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FX0Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(258, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "1";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(223, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 30);
            this.label11.TabIndex = 13;
            this.label11.Text = "f(X   )=";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(258, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(223, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 30);
            this.label9.TabIndex = 11;
            this.label9.Text = "f(X   )=";
            // 
            // XBox
            // 
            this.XBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.XBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.XBox.Location = new System.Drawing.Point(77, 144);
            this.XBox.Multiline = true;
            this.XBox.Name = "XBox";
            this.XBox.ShortcutsEnabled = false;
            this.XBox.Size = new System.Drawing.Size(130, 30);
            this.XBox.TabIndex = 10;
            this.XBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.XBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // X1Box
            // 
            this.X1Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.X1Box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.X1Box.Location = new System.Drawing.Point(77, 96);
            this.X1Box.Multiline = true;
            this.X1Box.Name = "X1Box";
            this.X1Box.ShortcutsEnabled = false;
            this.X1Box.Size = new System.Drawing.Size(130, 30);
            this.X1Box.TabIndex = 8;
            this.X1Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.X1Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // X0Box
            // 
            this.X0Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.X0Box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.X0Box.Location = new System.Drawing.Point(77, 48);
            this.X0Box.Name = "X0Box";
            this.X0Box.ShortcutsEnabled = false;
            this.X0Box.Size = new System.Drawing.Size(130, 29);
            this.X0Box.TabIndex = 7;
            this.X0Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.X0Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(10, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 30);
            this.label8.TabIndex = 6;
            this.label8.Text = "X =";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "1";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "X   =";
            // 
            // limpiar
            // 
            this.limpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.limpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.limpiar.Location = new System.Drawing.Point(586, 142);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(99, 33);
            this.limpiar.TabIndex = 18;
            this.limpiar.Text = "LIMPIAR";
            this.limpiar.UseVisualStyleBackColor = false;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // calcular
            // 
            this.calcular.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calcular.Location = new System.Drawing.Point(586, 61);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(99, 33);
            this.calcular.TabIndex = 19;
            this.calcular.Text = "CALCULAR";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.limpiar);
            this.groupBox1.Controls.Add(this.calcular);
            this.groupBox1.Controls.Add(this.valoresBox);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(0, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 228);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(24, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 40);
            this.button4.TabIndex = 15;
            this.button4.Text = "<---SALIR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbDisplay
            // 
            this.tbDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDisplay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbDisplay.Location = new System.Drawing.Point(16, 29);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.ReadOnly = true;
            this.tbDisplay.ShortcutsEnabled = false;
            this.tbDisplay.Size = new System.Drawing.Size(654, 52);
            this.tbDisplay.TabIndex = 17;
            this.tbDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(214, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(39, 91);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(220, 25);
            this.textBox2.TabIndex = 26;
            this.textBox2.Text = "ERROR PORCENTUAL=";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDisplayError
            // 
            this.tbDisplayError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDisplayError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDisplayError.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbDisplayError.Location = new System.Drawing.Point(260, 91);
            this.tbDisplayError.Multiline = true;
            this.tbDisplayError.Name = "tbDisplayError";
            this.tbDisplayError.ReadOnly = true;
            this.tbDisplayError.ShortcutsEnabled = false;
            this.tbDisplayError.Size = new System.Drawing.Size(409, 25);
            this.tbDisplayError.TabIndex = 27;
            this.tbDisplayError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.groupBox2.Controls.Add(this.tbDisplayError);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.tbDisplay);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 154);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RESULTADOS";
            // 
            // tittle
            // 
            this.tittle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.tittle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tittle.ForeColor = System.Drawing.SystemColors.Menu;
            this.tittle.Location = new System.Drawing.Point(163, 36);
            this.tittle.MaximumSize = new System.Drawing.Size(400, 40);
            this.tittle.Name = "tittle";
            this.tittle.ReadOnly = true;
            this.tittle.ShortcutsEnabled = false;
            this.tittle.Size = new System.Drawing.Size(356, 36);
            this.tittle.TabIndex = 23;
            this.tittle.Text = "ECUACION INTERPOLACION LINEAL";
            this.tittle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 566);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tittle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(1320, 650);
            this.MinimumSize = new System.Drawing.Size(691, 605);
            this.Name = "Form8";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.valoresBox.ResumeLayout(false);
            this.valoresBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView1;
        private GroupBox valoresBox;
        private TextBox FX1Box;
        private TextBox FX0Box;
        private Label label10;
        private Label label11;
        private Label label7;
        private Label label9;
        private TextBox XBox;
        private TextBox X1Box;
        private TextBox X0Box;
        private Label label8;
        private Label label3;
        private Label label4;
        private Label label2;
        private Button limpiar;
        private Button calcular;
        private GroupBox groupBox1;
        private TextBox tbDisplay;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private TextBox tbDisplayError;
        private TextBox errorBox;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox tittle;
        private Button button4;
    }
}