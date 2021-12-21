namespace EburyPartners
{
    partial class Inicio
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
            this.bReRegistro = new System.Windows.Forms.Button();
            this.bOtras = new System.Windows.Forms.Button();
            this.bRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bReRegistro
            // 
            this.bReRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bReRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReRegistro.Location = new System.Drawing.Point(278, 199);
            this.bReRegistro.Name = "bReRegistro";
            this.bReRegistro.Size = new System.Drawing.Size(244, 60);
            this.bReRegistro.TabIndex = 2;
            this.bReRegistro.Text = "Re-registro";
            this.bReRegistro.UseVisualStyleBackColor = true;
            // 
            // bOtras
            // 
            this.bOtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bOtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOtras.Location = new System.Drawing.Point(278, 295);
            this.bOtras.Name = "bOtras";
            this.bOtras.Size = new System.Drawing.Size(244, 60);
            this.bOtras.TabIndex = 3;
            this.bOtras.Text = "Otras operaciones";
            this.bOtras.UseVisualStyleBackColor = true;
            this.bOtras.Click += new System.EventHandler(this.bOtras_Click);
            // 
            // bRegistro
            // 
            this.bRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegistro.Location = new System.Drawing.Point(278, 102);
            this.bRegistro.Name = "bRegistro";
            this.bRegistro.Size = new System.Drawing.Size(244, 60);
            this.bRegistro.TabIndex = 4;
            this.bRegistro.Text = "Registro";
            this.bRegistro.UseVisualStyleBackColor = true;
            this.bRegistro.Click += new System.EventHandler(this.bRegistro_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bRegistro);
            this.Controls.Add(this.bOtras);
            this.Controls.Add(this.bReRegistro);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bReRegistro;
        private System.Windows.Forms.Button bOtras;
        private System.Windows.Forms.Button bRegistro;
    }
}