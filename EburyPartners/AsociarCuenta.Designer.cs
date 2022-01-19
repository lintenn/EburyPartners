
namespace EburyPartners
{
    partial class AsociarCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsociarCuenta));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lTipo = new System.Windows.Forms.ListBox();
            this.bBack = new System.Windows.Forms.Button();
            this.bAsociar = new System.Windows.Forms.Button();
            this.lEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(12, 32);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.Size = new System.Drawing.Size(776, 284);
            this.dataGridViewClientes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipos de cuenta bancaria";
            // 
            // lTipo
            // 
            this.lTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTipo.FormattingEnabled = true;
            this.lTipo.ItemHeight = 20;
            this.lTipo.Items.AddRange(new object[] {
            "Pooled",
            "Segregada",
            "Dedicada"});
            this.lTipo.Location = new System.Drawing.Point(205, 334);
            this.lTipo.Name = "lTipo";
            this.lTipo.Size = new System.Drawing.Size(120, 64);
            this.lTipo.TabIndex = 3;
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
            this.bBack.Location = new System.Drawing.Point(707, 378);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(81, 60);
            this.bBack.TabIndex = 7;
            this.bBack.UseMnemonic = false;
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bAsociar
            // 
            this.bAsociar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAsociar.Location = new System.Drawing.Point(415, 334);
            this.bAsociar.Name = "bAsociar";
            this.bAsociar.Size = new System.Drawing.Size(219, 64);
            this.bAsociar.TabIndex = 8;
            this.bAsociar.Text = "Asociar cuenta bancaria";
            this.bAsociar.UseVisualStyleBackColor = true;
            this.bAsociar.Click += new System.EventHandler(this.bAsociar_Click);
            // 
            // lEstado
            // 
            this.lEstado.AutoSize = true;
            this.lEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEstado.ForeColor = System.Drawing.Color.Red;
            this.lEstado.Location = new System.Drawing.Point(202, 412);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(57, 16);
            this.lEstado.TabIndex = 9;
            this.lEstado.Text = "ejemplo";
            // 
            // AsociarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lEstado);
            this.Controls.Add(this.bAsociar);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.lTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.label1);
            this.Name = "AsociarCuenta";
            this.Text = "Asociar cuentas bancarias";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lTipo;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bAsociar;
        private System.Windows.Forms.Label lEstado;
    }
}