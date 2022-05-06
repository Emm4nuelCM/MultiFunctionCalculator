namespace CALCULADORA_2._0
{
    partial class noLinealFalsaPosicion
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
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.valoresBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hastaBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.desdeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FXBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.paroBox = new System.Windows.Forms.TextBox();
            this.salir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tittle = new System.Windows.Forms.TextBox();
            this.iter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.valoresBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iter,
            this.xr,
            this.FX,
            this.paro});
            this.dgvResults.Location = new System.Drawing.Point(144, 85);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowTemplate.Height = 25;
            this.dgvResults.Size = new System.Drawing.Size(411, 205);
            this.dgvResults.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.valoresBox);
            this.groupBox1.Controls.Add(this.salir);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(0, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 267);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(598, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 33);
            this.button2.TabIndex = 18;
            this.button2.Text = "LIMPIAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // valoresBox
            // 
            this.valoresBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.valoresBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.valoresBox.Controls.Add(this.groupBox2);
            this.valoresBox.Controls.Add(this.label1);
            this.valoresBox.Controls.Add(this.FXBox);
            this.valoresBox.Controls.Add(this.label9);
            this.valoresBox.Controls.Add(this.paroBox);
            this.valoresBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.valoresBox.ForeColor = System.Drawing.Color.White;
            this.valoresBox.Location = new System.Drawing.Point(104, 22);
            this.valoresBox.Name = "valoresBox";
            this.valoresBox.Size = new System.Drawing.Size(487, 233);
            this.valoresBox.TabIndex = 17;
            this.valoresBox.TabStop = false;
            this.valoresBox.Text = "VALORES";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.groupBox2.Controls.Add(this.hastaBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.desdeBox);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(8, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 84);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UBICACION DE RAIZ";
            // 
            // hastaBox
            // 
            this.hastaBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hastaBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hastaBox.Location = new System.Drawing.Point(309, 36);
            this.hastaBox.Multiline = true;
            this.hastaBox.Name = "hastaBox";
            this.hastaBox.ShortcutsEnabled = false;
            this.hastaBox.Size = new System.Drawing.Size(129, 30);
            this.hastaBox.TabIndex = 26;
            this.hastaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hastaBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(260, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 30);
            this.label12.TabIndex = 24;
            this.label12.Text = "Xu:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(34, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 30);
            this.label11.TabIndex = 13;
            this.label11.Text = "Xi:";
            // 
            // desdeBox
            // 
            this.desdeBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.desdeBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.desdeBox.Location = new System.Drawing.Point(76, 36);
            this.desdeBox.Multiline = true;
            this.desdeBox.Name = "desdeBox";
            this.desdeBox.ShortcutsEnabled = false;
            this.desdeBox.Size = new System.Drawing.Size(129, 30);
            this.desdeBox.TabIndex = 16;
            this.desdeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.desdeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Factor De Paro:";
            // 
            // FXBox
            // 
            this.FXBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FXBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FXBox.Location = new System.Drawing.Point(79, 43);
            this.FXBox.Multiline = true;
            this.FXBox.Name = "FXBox";
            this.FXBox.ShortcutsEnabled = false;
            this.FXBox.Size = new System.Drawing.Size(388, 30);
            this.FXBox.TabIndex = 15;
            this.FXBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FXBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box2_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(8, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 30);
            this.label9.TabIndex = 11;
            this.label9.Text = "f(X)=";
            // 
            // paroBox
            // 
            this.paroBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.paroBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paroBox.Location = new System.Drawing.Point(176, 95);
            this.paroBox.Name = "paroBox";
            this.paroBox.ShortcutsEnabled = false;
            this.paroBox.Size = new System.Drawing.Size(43, 29);
            this.paroBox.TabIndex = 7;
            this.paroBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.paroBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // salir
            // 
            this.salir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.salir.Location = new System.Drawing.Point(24, 124);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(72, 40);
            this.salir.TabIndex = 15;
            this.salir.Text = "<---SALIR";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(597, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 33);
            this.button3.TabIndex = 19;
            this.button3.Text = "CALCULAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tittle
            // 
            this.tittle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.tittle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tittle.ForeColor = System.Drawing.SystemColors.Menu;
            this.tittle.Location = new System.Drawing.Point(151, 36);
            this.tittle.Name = "tittle";
            this.tittle.ReadOnly = true;
            this.tittle.ShortcutsEnabled = false;
            this.tittle.Size = new System.Drawing.Size(403, 36);
            this.tittle.TabIndex = 40;
            this.tittle.Text = "ECUACION NO LINEAL FALSA POSICION";
            this.tittle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iter
            // 
            this.iter.HeaderText = "ITERACION";
            this.iter.Name = "iter";
            this.iter.ReadOnly = true;
            this.iter.Width = 70;
            // 
            // xr
            // 
            this.xr.HeaderText = "Xr";
            this.xr.Name = "xr";
            this.xr.ReadOnly = true;
            // 
            // FX
            // 
            this.FX.HeaderText = "F(Xr)";
            this.FX.Name = "FX";
            this.FX.ReadOnly = true;
            // 
            // paro
            // 
            this.paro.HeaderText = "Ɛa";
            this.paro.Name = "paro";
            this.paro.ReadOnly = true;
            // 
            // noLinealFalsaPosicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(708, 604);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tittle);
            this.Name = "noLinealFalsaPosicion";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.valoresBox.ResumeLayout(false);
            this.valoresBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvResults;
        private GroupBox groupBox1;
        private Button salir;
        private Button button2;
        private GroupBox valoresBox;
        private GroupBox groupBox2;
        private TextBox hastaBox;
        private Label label12;
        private Label label11;
        private TextBox desdeBox;
        private Label label1;
        private TextBox FXBox;
        private Label label9;
        private TextBox paroBox;
        private Button button3;
        private TextBox tittle;
        private DataGridViewTextBoxColumn iter;
        private DataGridViewTextBoxColumn xr;
        private DataGridViewTextBoxColumn FX;
        private DataGridViewTextBoxColumn paro;
    }
}