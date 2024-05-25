namespace LaboratorioFinCurso
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.Consolasleer = new System.Windows.Forms.DataGridView();
            this.bttonCargar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCompania = new System.Windows.Forms.ComboBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AnioLanzamiento = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textGenercion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Consolasleer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnombre.Location = new System.Drawing.Point(12, 20);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(430, 25);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Mario Fernando Cerna Najea 0905-23-5025";
            // 
            // Consolasleer
            // 
            this.Consolasleer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Consolasleer.Location = new System.Drawing.Point(686, 30);
            this.Consolasleer.Name = "Consolasleer";
            this.Consolasleer.RowHeadersWidth = 82;
            this.Consolasleer.RowTemplate.Height = 33;
            this.Consolasleer.Size = new System.Drawing.Size(1380, 452);
            this.Consolasleer.TabIndex = 2;
            // 
            // bttonCargar
            // 
            this.bttonCargar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.bttonCargar.Location = new System.Drawing.Point(1649, 556);
            this.bttonCargar.Name = "bttonCargar";
            this.bttonCargar.Size = new System.Drawing.Size(161, 98);
            this.bttonCargar.TabIndex = 3;
            this.bttonCargar.Text = "Cargar";
            this.bttonCargar.UseVisualStyleBackColor = true;
            this.bttonCargar.Click += new System.EventHandler(this.bttonCargar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Compañias";
            // 
            // cmbCompania
            // 
            this.cmbCompania.FormattingEnabled = true;
            this.cmbCompania.Location = new System.Drawing.Point(222, 224);
            this.cmbCompania.Name = "cmbCompania";
            this.cmbCompania.Size = new System.Drawing.Size(295, 33);
            this.cmbCompania.TabIndex = 7;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(222, 95);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(295, 31);
            this.textID.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 31);
            this.textBox1.TabIndex = 9;
            // 
            // AnioLanzamiento
            // 
            this.AnioLanzamiento.AutoSize = true;
            this.AnioLanzamiento.Location = new System.Drawing.Point(28, 307);
            this.AnioLanzamiento.Name = "AnioLanzamiento";
            this.AnioLanzamiento.Size = new System.Drawing.Size(179, 25);
            this.AnioLanzamiento.TabIndex = 10;
            this.AnioLanzamiento.Text = "Año Lanzamiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(222, 302);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(422, 31);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Generacion";
            // 
            // textGenercion
            // 
            this.textGenercion.Location = new System.Drawing.Point(227, 369);
            this.textGenercion.Name = "textGenercion";
            this.textGenercion.Size = new System.Drawing.Size(289, 31);
            this.textGenercion.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(2257, 854);
            this.Controls.Add(this.textGenercion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.AnioLanzamiento);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.cmbCompania);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttonCargar);
            this.Controls.Add(this.Consolasleer);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Consolasleer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.DataGridView Consolasleer;
        private System.Windows.Forms.Button bttonCargar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCompania;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label AnioLanzamiento;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textGenercion;
    }
}

