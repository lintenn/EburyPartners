namespace EburyPartners
{
    partial class FiltroClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltroClientes));
            this.t1Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bBuscar = new System.Windows.Forms.Button();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.t2Nombre = new System.Windows.Forms.TextBox();
            this.tCiudad = new System.Windows.Forms.TextBox();
            this.tCalle = new System.Windows.Forms.TextBox();
            this.tNumero = new System.Windows.Forms.TextBox();
            this.tCodPostal = new System.Windows.Forms.TextBox();
            this.bBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // t1Nombre
            // 
            this.t1Nombre.ForeColor = System.Drawing.Color.Silver;
            this.t1Nombre.Location = new System.Drawing.Point(72, 74);
            this.t1Nombre.Name = "t1Nombre";
            this.t1Nombre.Size = new System.Drawing.Size(166, 20);
            this.t1Nombre.TabIndex = 8;
            this.t1Nombre.Text = "Primer nombre";
            this.t1Nombre.Enter += new System.EventHandler(this.t1Nombre_Enter);
            this.t1Nombre.Leave += new System.EventHandler(this.t1Nombre_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(69, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(635, 85);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(91, 34);
            this.bBuscar.TabIndex = 6;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(72, 137);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.Size = new System.Drawing.Size(654, 241);
            this.dataGridClientes.TabIndex = 5;
            // 
            // t2Nombre
            // 
            this.t2Nombre.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.t2Nombre.Location = new System.Drawing.Point(259, 75);
            this.t2Nombre.Name = "t2Nombre";
            this.t2Nombre.Size = new System.Drawing.Size(166, 20);
            this.t2Nombre.TabIndex = 9;
            this.t2Nombre.Text = "Segundo nombre";
            this.t2Nombre.Enter += new System.EventHandler(this.t2Nombre_Enter);
            this.t2Nombre.Leave += new System.EventHandler(this.t2Nombre_Leave);
            // 
            // tCiudad
            // 
            this.tCiudad.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tCiudad.Location = new System.Drawing.Point(447, 75);
            this.tCiudad.Name = "tCiudad";
            this.tCiudad.Size = new System.Drawing.Size(166, 20);
            this.tCiudad.TabIndex = 10;
            this.tCiudad.Text = "Ciudad";
            this.tCiudad.Enter += new System.EventHandler(this.tCiudad_Enter);
            this.tCiudad.Leave += new System.EventHandler(this.tCiudad_Leave);
            // 
            // tCalle
            // 
            this.tCalle.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tCalle.Location = new System.Drawing.Point(72, 106);
            this.tCalle.Name = "tCalle";
            this.tCalle.Size = new System.Drawing.Size(166, 20);
            this.tCalle.TabIndex = 11;
            this.tCalle.Text = "Calle";
            this.tCalle.Enter += new System.EventHandler(this.tCalle_Enter);
            this.tCalle.Leave += new System.EventHandler(this.tCalle_Leave);
            // 
            // tNumero
            // 
            this.tNumero.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tNumero.Location = new System.Drawing.Point(259, 106);
            this.tNumero.Name = "tNumero";
            this.tNumero.Size = new System.Drawing.Size(166, 20);
            this.tNumero.TabIndex = 12;
            this.tNumero.Text = "Número";
            this.tNumero.Enter += new System.EventHandler(this.tNumero_Enter);
            this.tNumero.Leave += new System.EventHandler(this.tNumero_Leave);
            // 
            // tCodPostal
            // 
            this.tCodPostal.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tCodPostal.Location = new System.Drawing.Point(447, 106);
            this.tCodPostal.Name = "tCodPostal";
            this.tCodPostal.Size = new System.Drawing.Size(166, 20);
            this.tCodPostal.TabIndex = 13;
            this.tCodPostal.Text = "Código postal";
            this.tCodPostal.Enter += new System.EventHandler(this.tCodPostal_Enter);
            this.tCodPostal.Leave += new System.EventHandler(this.tCodPostal_Leave);
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.bBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.bBack.FlatAppearance.BorderSize = 10;
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack.ForeColor = System.Drawing.Color.Transparent;
            this.bBack.Image = ((System.Drawing.Image)(resources.GetObject("bBack.Image")));
            this.bBack.Location = new System.Drawing.Point(707, 384);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(81, 60);
            this.bBack.TabIndex = 14;
            this.bBack.UseMnemonic = false;
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // FiltroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.tCodPostal);
            this.Controls.Add(this.tNumero);
            this.Controls.Add(this.tCalle);
            this.Controls.Add(this.tCiudad);
            this.Controls.Add(this.t2Nombre);
            this.Controls.Add(this.t1Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.dataGridClientes);
            this.Name = "FiltroClientes";
            this.Text = "FiltroClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox t1Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.TextBox t2Nombre;
        private System.Windows.Forms.TextBox tCiudad;
        private System.Windows.Forms.TextBox tCalle;
        private System.Windows.Forms.TextBox tNumero;
        private System.Windows.Forms.TextBox tCodPostal;
        private System.Windows.Forms.Button bBack;
    }
}