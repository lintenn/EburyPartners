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
            this.bGenerarInformeInicial = new System.Windows.Forms.Button();
            this.bGenerarInformeSemanal = new System.Windows.Forms.Button();
            this.tMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bGenerarInformeInicial
            // 
            this.bGenerarInformeInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGenerarInformeInicial.Location = new System.Drawing.Point(276, 102);
            this.bGenerarInformeInicial.Name = "bGenerarInformeInicial";
            this.bGenerarInformeInicial.Size = new System.Drawing.Size(244, 60);
            this.bGenerarInformeInicial.TabIndex = 0;
            this.bGenerarInformeInicial.Text = "Generar informe inicial";
            this.bGenerarInformeInicial.UseVisualStyleBackColor = true;
            this.bGenerarInformeInicial.Click += new System.EventHandler(this.bGenerarInformeInicial_Click);
            // 
            // bGenerarInformeSemanal
            // 
            this.bGenerarInformeSemanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGenerarInformeSemanal.Location = new System.Drawing.Point(276, 225);
            this.bGenerarInformeSemanal.Name = "bGenerarInformeSemanal";
            this.bGenerarInformeSemanal.Size = new System.Drawing.Size(244, 60);
            this.bGenerarInformeSemanal.TabIndex = 1;
            this.bGenerarInformeSemanal.Text = "Generar informe semanal";
            this.bGenerarInformeSemanal.UseVisualStyleBackColor = true;
            this.bGenerarInformeSemanal.Click += new System.EventHandler(this.bGenerarInformeSemanal_Click);
            // 
            // tMessage
            // 
            this.tMessage.BackColor = System.Drawing.SystemColors.Control;
            this.tMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tMessage.Enabled = false;
            this.tMessage.Location = new System.Drawing.Point(276, 379);
            this.tMessage.Multiline = true;
            this.tMessage.Name = "tMessage";
            this.tMessage.Size = new System.Drawing.Size(244, 20);
            this.tMessage.TabIndex = 2;
            // 
            // Alemania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tMessage);
            this.Controls.Add(this.bGenerarInformeSemanal);
            this.Controls.Add(this.bGenerarInformeInicial);
            this.Name = "Alemania";
            this.Text = "Alemania";
            this.Load += new System.EventHandler(this.Alemania_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bGenerarInformeInicial;
        private System.Windows.Forms.Button bGenerarInformeSemanal;
        private System.Windows.Forms.TextBox tMessage;
    }
}