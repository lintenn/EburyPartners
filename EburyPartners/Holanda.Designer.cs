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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Holanda));
            this.bFiltroCuenta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bHealthCheck = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(300, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Filtro por clientes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.bBack.Location = new System.Drawing.Point(696, 369);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(81, 60);
            this.bBack.TabIndex = 6;
            this.bBack.UseMnemonic = false;
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // Holanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bHealthCheck);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bFiltroCuenta);
            this.Name = "Holanda";
            this.Text = "Holanda";
            this.Load += new System.EventHandler(this.Holanda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bFiltroCuenta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bHealthCheck;
        private System.Windows.Forms.Button bBack;
    }
}