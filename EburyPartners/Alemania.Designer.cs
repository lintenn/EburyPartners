namespace EburyPartners
{
    partial class Alemania
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
            this.bGenerarInformeIncial = new System.Windows.Forms.Button();
            this.bGenerarInformeSemanal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bGenerarInformeIncial
            // 
            this.bGenerarInformeIncial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGenerarInformeIncial.Location = new System.Drawing.Point(449, 198);
            this.bGenerarInformeIncial.Name = "bGenerarInformeIncial";
            this.bGenerarInformeIncial.Size = new System.Drawing.Size(307, 90);
            this.bGenerarInformeIncial.TabIndex = 0;
            this.bGenerarInformeIncial.Text = "Generar informe inicial";
            this.bGenerarInformeIncial.UseVisualStyleBackColor = true;
            // 
            // bGenerarInformeSemanal
            // 
            this.bGenerarInformeSemanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGenerarInformeSemanal.Location = new System.Drawing.Point(449, 394);
            this.bGenerarInformeSemanal.Name = "bGenerarInformeSemanal";
            this.bGenerarInformeSemanal.Size = new System.Drawing.Size(307, 90);
            this.bGenerarInformeSemanal.TabIndex = 1;
            this.bGenerarInformeSemanal.Text = "Generar informe semanal";
            this.bGenerarInformeSemanal.UseVisualStyleBackColor = true;
            // 
            // Alemania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 790);
            this.Controls.Add(this.bGenerarInformeSemanal);
            this.Controls.Add(this.bGenerarInformeIncial);
            this.Name = "Alemania";
            this.Text = "Alemania";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bGenerarInformeIncial;
        private System.Windows.Forms.Button bGenerarInformeSemanal;
    }
}