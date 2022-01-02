namespace EburyPartners
{
    partial class ModificarEstadoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarEstadoCliente));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bPasarInactivo = new System.Windows.Forms.Button();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.bBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(89, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(877, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 42);
            this.label1.TabIndex = 17;
            this.label1.Text = "Clientes";
            // 
            // bPasarInactivo
            // 
            this.bPasarInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bPasarInactivo.Location = new System.Drawing.Point(459, 440);
            this.bPasarInactivo.Name = "bPasarInactivo";
            this.bPasarInactivo.Size = new System.Drawing.Size(159, 49);
            this.bPasarInactivo.TabIndex = 50;
            this.bPasarInactivo.Text = "Pasar a inactivo";
            this.bPasarInactivo.UseVisualStyleBackColor = true;
            this.bPasarInactivo.Click += new System.EventHandler(this.bPasarInactivo_Click);
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelMensaje.ForeColor = System.Drawing.Color.Black;
            this.labelMensaje.Location = new System.Drawing.Point(86, 507);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(94, 18);
            this.labelMensaje.TabIndex = 51;
            this.labelMensaje.Text = "labelMensaje";
            this.labelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bBack
            // 
            this.bBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bBack.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.bBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.bBack.FlatAppearance.BorderSize = 10;
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack.ForeColor = System.Drawing.Color.Transparent;
            this.bBack.Image = ((System.Drawing.Image)(resources.GetObject("bBack.Image")));
            this.bBack.Location = new System.Drawing.Point(946, 467);
            this.bBack.Margin = new System.Windows.Forms.Padding(4);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(108, 74);
            this.bBack.TabIndex = 52;
            this.bBack.UseMnemonic = false;
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // ModificarEstadoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.bPasarInactivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ModificarEstadoCliente";
            this.Text = "Modificar el estado de un cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bPasarInactivo;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.Button bBack;
    }
}