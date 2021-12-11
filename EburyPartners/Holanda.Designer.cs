namespace EburyPartners
{
    partial class Holanda
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
            this.bFiltroCuenta = new System.Windows.Forms.Button();
            this.bFiltroClientes = new System.Windows.Forms.Button();
            this.bHealthCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bFiltroCuenta
            // 
            this.bFiltroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFiltroCuenta.Location = new System.Drawing.Point(300, 89);
            this.bFiltroCuenta.Name = "bFiltroCuenta";
            this.bFiltroCuenta.Size = new System.Drawing.Size(204, 54);
            this.bFiltroCuenta.TabIndex = 0;
            this.bFiltroCuenta.Text = "Filtro por cuenta bancaria";
            this.bFiltroCuenta.UseVisualStyleBackColor = true;
            this.bFiltroCuenta.Click += new System.EventHandler(this.bFiltroCuenta_Click);
            // 
            // bFiltroClientes
            // 
            this.bFiltroClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFiltroClientes.Location = new System.Drawing.Point(300, 181);
            this.bFiltroClientes.Name = "bFiltroClientes";
            this.bFiltroClientes.Size = new System.Drawing.Size(204, 54);
            this.bFiltroClientes.TabIndex = 1;
            this.bFiltroClientes.Text = "Filtro por clientes";
            this.bFiltroClientes.UseVisualStyleBackColor = true;
            this.bFiltroClientes.Click += new System.EventHandler(this.bFiltroClientes_Click);
            // 
            // bHealthCheck
            // 
            this.bHealthCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHealthCheck.Location = new System.Drawing.Point(300, 275);
            this.bHealthCheck.Name = "bHealthCheck";
            this.bHealthCheck.Size = new System.Drawing.Size(204, 54);
            this.bHealthCheck.TabIndex = 2;
            this.bHealthCheck.Text = "Health Check";
            this.bHealthCheck.UseVisualStyleBackColor = true;
            this.bHealthCheck.Click += new System.EventHandler(this.button3_Click);
            // 
            // Holanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bHealthCheck);
            this.Controls.Add(this.bFiltroClientes);
            this.Controls.Add(this.bFiltroCuenta);
            this.Name = "Holanda";
            this.Text = "Holanda";
            this.Load += new System.EventHandler(this.Holanda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bFiltroCuenta;
        private System.Windows.Forms.Button bFiltroClientes;
        private System.Windows.Forms.Button bHealthCheck;
    }
}