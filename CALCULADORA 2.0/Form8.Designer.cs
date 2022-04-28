namespace CALCULADORA_2._0
{
    partial class Form8
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
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.valoresBox = new System.Windows.Forms.GroupBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.calcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.valoresBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(12, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 40);
            this.button4.TabIndex = 15;
            this.button4.Text = "<---SALIR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(751, 561);
            this.dataGridView1.TabIndex = 11;
            // 
            // valoresBox
            // 
            this.valoresBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.valoresBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
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
            this.valoresBox.Location = new System.Drawing.Point(99, 22);
            this.valoresBox.Name = "valoresBox";
            this.valoresBox.Size = new System.Drawing.Size(452, 197);
            this.valoresBox.TabIndex = 17;
            this.valoresBox.TabStop = false;
            this.valoresBox.Text = "VALORES";
            // 
            // FX1Box
            // 
            this.FX1Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FX1Box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FX1Box.Location = new System.Drawing.Point(311, 101);
            this.FX1Box.Multiline = true;
            this.FX1Box.Name = "FX1Box";
            this.FX1Box.Size = new System.Drawing.Size(130, 30);
            this.FX1Box.TabIndex = 16;
            this.FX1Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FX0Box
            // 
            this.FX0Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FX0Box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FX0Box.Location = new System.Drawing.Point(311, 49);
            this.FX0Box.Multiline = true;
            this.FX0Box.Name = "FX0Box";
            this.FX0Box.Size = new System.Drawing.Size(130, 30);
            this.FX0Box.TabIndex = 15;
            this.FX0Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.XBox.Size = new System.Drawing.Size(130, 30);
            this.XBox.TabIndex = 10;
            this.XBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // X1Box
            // 
            this.X1Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.X1Box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.X1Box.Location = new System.Drawing.Point(77, 96);
            this.X1Box.Multiline = true;
            this.X1Box.Name = "X1Box";
            this.X1Box.Size = new System.Drawing.Size(130, 30);
            this.X1Box.TabIndex = 8;
            this.X1Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // X0Box
            // 
            this.X0Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.X0Box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.X0Box.Location = new System.Drawing.Point(77, 48);
            this.X0Box.Multiline = true;
            this.X0Box.Name = "X0Box";
            this.X0Box.Size = new System.Drawing.Size(130, 30);
            this.X0Box.TabIndex = 7;
            this.X0Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // limpiar
            // 
            this.limpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.limpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.limpiar.Location = new System.Drawing.Point(597, 142);
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
            this.calcular.Location = new System.Drawing.Point(597, 61);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(99, 33);
            this.calcular.TabIndex = 19;
            this.calcular.Text = "CALCULAR";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.limpiar);
            this.groupBox1.Controls.Add(this.calcular);
            this.groupBox1.Controls.Add(this.valoresBox);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(0, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 228);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // tbDisplay
            // 
            this.tbDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDisplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbDisplay.Location = new System.Drawing.Point(99, 134);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(497, 102);
            this.tbDisplay.TabIndex = 17;
            this.tbDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 561);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.valoresBox.ResumeLayout(false);
            this.valoresBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button4;
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
    }
}