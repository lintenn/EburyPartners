namespace EburyPartners
{
    partial class EburyPartners
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
            this.bAlemania = new System.Windows.Forms.Button();
            this.bHolanda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAlemania
            // 
            this.bAlemania.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAlemania.Location = new System.Drawing.Point(443, 188);
            this.bAlemania.Name = "bAlemania";
            this.bAlemania.Size = new System.Drawing.Size(162, 64);
            this.bAlemania.TabIndex = 0;
            this.bAlemania.Text = "Informe Alemania";
            this.bAlemania.UseVisualStyleBackColor = true;
            this.bAlemania.Click += new System.EventHandler(this.bAlemania_Click);
            // 
            // bHolanda
            // 
            this.bHolanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHolanda.Location = new System.Drawing.Point(162, 188);
            this.bHolanda.Name = "bHolanda";
            this.bHolanda.Size = new System.Drawing.Size(162, 64);
            this.bHolanda.TabIndex = 1;
            this.bHolanda.Text = "Informe Holanda";
            this.bHolanda.UseVisualStyleBackColor = true;
            this.bHolanda.Click += new System.EventHandler(this.bHolanda_Click);
            // 
            // EburyPartners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bHolanda);
            this.Controls.Add(this.bAlemania);
            this.Name = "EburyPartners";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAlemania;
        private System.Windows.Forms.Button bHolanda;
    }
}

