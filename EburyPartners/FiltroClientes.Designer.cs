namespace EburyPartners
{
    partial class FiltroClientes
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
            this.cbActivas = new System.Windows.Forms.ComboBox();
            this.tCuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbActivas
            // 
            this.cbActivas.FormattingEnabled = true;
            this.cbActivas.Items.AddRange(new object[] {
            "Activa",
            "Inactiva",
            "Todas"});
            this.cbActivas.Location = new System.Drawing.Point(493, 73);
            this.cbActivas.Name = "cbActivas";
            this.cbActivas.Size = new System.Drawing.Size(121, 21);
            this.cbActivas.TabIndex = 9;
            // 
            // tCuenta
            // 
            this.tCuenta.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tCuenta.Location = new System.Drawing.Point(72, 74);
            this.tCuenta.Name = "tCuenta";
            this.tCuenta.Size = new System.Drawing.Size(404, 20);
            this.tCuenta.TabIndex = 8;
            this.tCuenta.Text = "Cuenta bancaria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(69, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(635, 74);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(91, 20);
            this.bBuscar.TabIndex = 6;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 241);
            this.dataGridView1.TabIndex = 5;
            // 
            // FiltroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbActivas);
            this.Controls.Add(this.tCuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FiltroClientes";
            this.Text = "FiltroClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbActivas;
        private System.Windows.Forms.TextBox tCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}