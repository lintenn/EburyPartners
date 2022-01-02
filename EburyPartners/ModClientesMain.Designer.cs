namespace EburyPartners
{
    partial class ModClientesMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModClientesMain));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bMostrar = new System.Windows.Forms.Button();
            this.bSociosAutorizados = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.lStatus = new System.Windows.Forms.Label();
            this.bBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // bMostrar
            // 
            this.bMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bMostrar.Location = new System.Drawing.Point(91, 350);
            this.bMostrar.Name = "bMostrar";
            this.bMostrar.Size = new System.Drawing.Size(100, 30);
            this.bMostrar.TabIndex = 1;
            this.bMostrar.Text = "Mostrar todo";
            this.bMostrar.UseVisualStyleBackColor = true;
            this.bMostrar.Click += new System.EventHandler(this.bMostrar_Click);
            // 
            // bSociosAutorizados
            // 
            this.bSociosAutorizados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bSociosAutorizados.Location = new System.Drawing.Point(303, 349);
            this.bSociosAutorizados.Name = "bSociosAutorizados";
            this.bSociosAutorizados.Size = new System.Drawing.Size(197, 31);
            this.bSociosAutorizados.TabIndex = 2;
            this.bSociosAutorizados.Text = "Mostrar socios y autorizados";
            this.bSociosAutorizados.UseVisualStyleBackColor = true;
            this.bSociosAutorizados.Click += new System.EventHandler(this.bSociosAutorizados_Click);
            // 
            // bModificar
            // 
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bModificar.Location = new System.Drawing.Point(598, 350);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(121, 30);
            this.bModificar.TabIndex = 3;
            this.bModificar.Text = "Modificar datos";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lStatus.ForeColor = System.Drawing.Color.Black;
            this.lStatus.Location = new System.Drawing.Point(282, 405);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(0, 17);
            this.lStatus.TabIndex = 4;
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
            this.bBack.Location = new System.Drawing.Point(707, 384);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(81, 60);
            this.bBack.TabIndex = 16;
            this.bBack.UseMnemonic = false;
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // ModClientesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bSociosAutorizados);
            this.Controls.Add(this.bMostrar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ModClientesMain";
            this.Text = "Modificar datos de clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bMostrar;
        private System.Windows.Forms.Button bSociosAutorizados;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Button bBack;
    }
}