namespace EburyPartners
{
    partial class ModificarAutorizados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarAutorizados));
            this.bBack = new System.Windows.Forms.Button();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.lCuentas = new System.Windows.Forms.Label();
            this.dgvNoAutorizados = new System.Windows.Forms.DataGridView();
            this.dgvAutorizados = new System.Windows.Forms.DataGridView();
            this.lNoAutorizados = new System.Windows.Forms.Label();
            this.lAutorizados = new System.Windows.Forms.Label();
            this.bAutorizar = new System.Windows.Forms.Button();
            this.bDesautorizar = new System.Windows.Forms.Button();
            this.lStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoAutorizados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutorizados)).BeginInit();
            this.SuspendLayout();
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
            this.bBack.Location = new System.Drawing.Point(707, 378);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(81, 60);
            this.bBack.TabIndex = 17;
            this.bBack.UseMnemonic = false;
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AllowUserToAddRows = false;
            this.dgvCuentas.AllowUserToDeleteRows = false;
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Location = new System.Drawing.Point(12, 51);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.ReadOnly = true;
            this.dgvCuentas.Size = new System.Drawing.Size(776, 128);
            this.dgvCuentas.TabIndex = 18;
            this.dgvCuentas.SelectionChanged += new System.EventHandler(this.dgvCuentas_SelectionChanged);
            // 
            // lCuentas
            // 
            this.lCuentas.AutoSize = true;
            this.lCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lCuentas.Location = new System.Drawing.Point(12, 24);
            this.lCuentas.Name = "lCuentas";
            this.lCuentas.Size = new System.Drawing.Size(165, 24);
            this.lCuentas.TabIndex = 19;
            this.lCuentas.Text = "Cuentas bancarias";
            // 
            // dgvNoAutorizados
            // 
            this.dgvNoAutorizados.AllowUserToAddRows = false;
            this.dgvNoAutorizados.AllowUserToDeleteRows = false;
            this.dgvNoAutorizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoAutorizados.Location = new System.Drawing.Point(12, 222);
            this.dgvNoAutorizados.Name = "dgvNoAutorizados";
            this.dgvNoAutorizados.ReadOnly = true;
            this.dgvNoAutorizados.Size = new System.Drawing.Size(372, 108);
            this.dgvNoAutorizados.TabIndex = 20;
            // 
            // dgvAutorizados
            // 
            this.dgvAutorizados.AllowUserToAddRows = false;
            this.dgvAutorizados.AllowUserToDeleteRows = false;
            this.dgvAutorizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutorizados.Location = new System.Drawing.Point(416, 222);
            this.dgvAutorizados.Name = "dgvAutorizados";
            this.dgvAutorizados.ReadOnly = true;
            this.dgvAutorizados.Size = new System.Drawing.Size(372, 108);
            this.dgvAutorizados.TabIndex = 21;
            // 
            // lNoAutorizados
            // 
            this.lNoAutorizados.AutoSize = true;
            this.lNoAutorizados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lNoAutorizados.Location = new System.Drawing.Point(12, 195);
            this.lNoAutorizados.Name = "lNoAutorizados";
            this.lNoAutorizados.Size = new System.Drawing.Size(136, 24);
            this.lNoAutorizados.TabIndex = 22;
            this.lNoAutorizados.Text = "No autorizados";
            // 
            // lAutorizados
            // 
            this.lAutorizados.AutoSize = true;
            this.lAutorizados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lAutorizados.Location = new System.Drawing.Point(421, 195);
            this.lAutorizados.Name = "lAutorizados";
            this.lAutorizados.Size = new System.Drawing.Size(109, 24);
            this.lAutorizados.TabIndex = 23;
            this.lAutorizados.Text = "Autorizados";
            // 
            // bAutorizar
            // 
            this.bAutorizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.bAutorizar.Location = new System.Drawing.Point(259, 345);
            this.bAutorizar.Name = "bAutorizar";
            this.bAutorizar.Size = new System.Drawing.Size(125, 42);
            this.bAutorizar.TabIndex = 24;
            this.bAutorizar.Text = "Autorizar";
            this.bAutorizar.UseVisualStyleBackColor = true;
            this.bAutorizar.Click += new System.EventHandler(this.bAutorizar_Click);
            // 
            // bDesautorizar
            // 
            this.bDesautorizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.bDesautorizar.Location = new System.Drawing.Point(416, 345);
            this.bDesautorizar.Name = "bDesautorizar";
            this.bDesautorizar.Size = new System.Drawing.Size(125, 42);
            this.bDesautorizar.TabIndex = 25;
            this.bDesautorizar.Text = "Desautorizar";
            this.bDesautorizar.UseVisualStyleBackColor = true;
            this.bDesautorizar.Click += new System.EventHandler(this.bDesautorizar_Click);
            // 
            // lStatus
            // 
            this.lStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lStatus.Location = new System.Drawing.Point(131, 402);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(538, 22);
            this.lStatus.TabIndex = 98;
            this.lStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ModificarAutorizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.bDesautorizar);
            this.Controls.Add(this.bAutorizar);
            this.Controls.Add(this.lAutorizados);
            this.Controls.Add(this.lNoAutorizados);
            this.Controls.Add(this.dgvAutorizados);
            this.Controls.Add(this.dgvNoAutorizados);
            this.Controls.Add(this.lCuentas);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.bBack);
            this.Name = "ModificarAutorizados";
            this.Text = "Modificar autorizados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoAutorizados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutorizados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.Label lCuentas;
        private System.Windows.Forms.DataGridView dgvNoAutorizados;
        private System.Windows.Forms.DataGridView dgvAutorizados;
        private System.Windows.Forms.Label lNoAutorizados;
        private System.Windows.Forms.Label lAutorizados;
        private System.Windows.Forms.Button bAutorizar;
        private System.Windows.Forms.Button bDesautorizar;
        private System.Windows.Forms.Label lStatus;
    }
}