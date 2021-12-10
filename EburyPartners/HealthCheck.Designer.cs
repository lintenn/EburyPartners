
namespace EburyPartners
{
    partial class HealthCheck
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
            this.bEjecutar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tMessage = new System.Windows.Forms.TextBox();
            this.bFinalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bEjecutar
            // 
            this.bEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEjecutar.Location = new System.Drawing.Point(300, 49);
            this.bEjecutar.Name = "bEjecutar";
            this.bEjecutar.Size = new System.Drawing.Size(213, 51);
            this.bEjecutar.TabIndex = 0;
            this.bEjecutar.Text = "Ejecutar Health Check";
            this.bEjecutar.UseVisualStyleBackColor = true;
            this.bEjecutar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estado de la conexión:";
            // 
            // tMessage
            // 
            this.tMessage.BackColor = System.Drawing.SystemColors.Control;
            this.tMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tMessage.Enabled = false;
            this.tMessage.Location = new System.Drawing.Point(300, 179);
            this.tMessage.Multiline = true;
            this.tMessage.Name = "tMessage";
            this.tMessage.Size = new System.Drawing.Size(213, 62);
            this.tMessage.TabIndex = 3;
            // 
            // bFinalizar
            // 
            this.bFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFinalizar.Location = new System.Drawing.Point(300, 306);
            this.bFinalizar.Name = "bFinalizar";
            this.bFinalizar.Size = new System.Drawing.Size(213, 57);
            this.bFinalizar.TabIndex = 4;
            this.bFinalizar.Text = "Finalizar Health Check";
            this.bFinalizar.UseVisualStyleBackColor = true;
            this.bFinalizar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // HealthCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bFinalizar);
            this.Controls.Add(this.tMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bEjecutar);
            this.Name = "HealthCheck";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HealthCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEjecutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tMessage;
        private System.Windows.Forms.Button bFinalizar;
    }
}