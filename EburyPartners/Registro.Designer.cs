
namespace EburyPartners
{
    partial class Registro
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
            this.label1 = new System.Windows.Forms.Label();
            this.bPersona = new System.Windows.Forms.Button();
            this.bEmpresa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = " Seleccione si quiere crear una cuenta para ";
            // 
            // bPersona
            // 
            this.bPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPersona.Location = new System.Drawing.Point(179, 283);
            this.bPersona.Name = "bPersona";
            this.bPersona.Size = new System.Drawing.Size(120, 56);
            this.bPersona.TabIndex = 1;
            this.bPersona.Text = "Persona física";
            this.bPersona.UseVisualStyleBackColor = true;
            this.bPersona.Click += new System.EventHandler(this.bPersona_Click);
            // 
            // bEmpresa
            // 
            this.bEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEmpresa.Location = new System.Drawing.Point(489, 283);
            this.bEmpresa.Name = "bEmpresa";
            this.bEmpresa.Size = new System.Drawing.Size(120, 56);
            this.bEmpresa.TabIndex = 2;
            this.bEmpresa.Text = "Empresa";
            this.bEmpresa.UseVisualStyleBackColor = true;
            this.bEmpresa.Click += new System.EventHandler(this.bEmpresa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "una persona física o para una empresa";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bEmpresa);
            this.Controls.Add(this.bPersona);
            this.Controls.Add(this.label1);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bPersona;
        private System.Windows.Forms.Button bEmpresa;
        private System.Windows.Forms.Label label2;
    }
}