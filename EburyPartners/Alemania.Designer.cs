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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alemania));
            this.bGenerarInformeInicial = new System.Windows.Forms.Button();
            this.bGenerarInformeSemanal = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.tMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bGenerarInformeInicial
            // 
            this.bGenerarInformeInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGenerarInformeInicial.Location = new System.Drawing.Point(414, 158);
            this.bGenerarInformeInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bGenerarInformeInicial.Name = "bGenerarInformeInicial";
            this.bGenerarInformeInicial.Size = new System.Drawing.Size(366, 92);
            this.bGenerarInformeInicial.TabIndex = 0;
            this.bGenerarInformeInicial.Text = "Generar informe inicial";
            this.bGenerarInformeInicial.UseVisualStyleBackColor = true;
            this.bGenerarInformeInicial.Click += new System.EventHandler(this.bGenerarInformeInicial_Click);
            // 
            // bGenerarInformeSemanal
            // 
            this.bGenerarInformeSemanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGenerarInformeSemanal.Location = new System.Drawing.Point(414, 346);
            this.bGenerarInformeSemanal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bGenerarInformeSemanal.Name = "bGenerarInformeSemanal";
            this.bGenerarInformeSemanal.Size = new System.Drawing.Size(366, 92);
            this.bGenerarInformeSemanal.TabIndex = 1;
            this.bGenerarInformeSemanal.Text = "Generar informe semanal";
            this.bGenerarInformeSemanal.UseVisualStyleBackColor = true;
            this.bGenerarInformeSemanal.Click += new System.EventHandler(this.bGenerarInformeSemanal_Click);
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.bBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.bBack.FlatAppearance.BorderSize = 10;
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack.ForeColor = System.Drawing.Color.Transparent;
            this.bBack.Image = ((System.Drawing.Image)(resources.GetObject("bBack.Image")));
            this.bBack.Location = new System.Drawing.Point(989, 584);
            this.bBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(122, 92);
            this.bBack.TabIndex = 7;
            this.bBack.UseMnemonic = false;
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click_1);
            // 
            // tMessage
            // 
            this.tMessage.AutoSize = true;
            this.tMessage.Location = new System.Drawing.Point(414, 552);
            this.tMessage.Name = "tMessage";
            this.tMessage.Size = new System.Drawing.Size(0, 20);
            this.tMessage.TabIndex = 8;
            // 
            // Alemania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tMessage);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bGenerarInformeSemanal);
            this.Controls.Add(this.bGenerarInformeInicial);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Alemania";
            this.Text = "Alemania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bGenerarInformeInicial;
        private System.Windows.Forms.Button bGenerarInformeSemanal;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Label tMessage;
    }
}