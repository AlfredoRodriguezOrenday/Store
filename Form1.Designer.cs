namespace CRUDSTORE
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnProviders = new System.Windows.Forms.Button();
            this.BtnProducts = new System.Windows.Forms.Button();
            this.BtnClients = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProviders
            // 
            this.BtnProviders.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProviders.Image = ((System.Drawing.Image)(resources.GetObject("BtnProviders.Image")));
            this.BtnProviders.Location = new System.Drawing.Point(12, 30);
            this.BtnProviders.Name = "BtnProviders";
            this.BtnProviders.Size = new System.Drawing.Size(116, 106);
            this.BtnProviders.TabIndex = 0;
            this.BtnProviders.Text = "Providers";
            this.BtnProviders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnProviders.UseVisualStyleBackColor = true;
            // 
            // BtnProducts
            // 
            this.BtnProducts.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.BtnProducts.Image = ((System.Drawing.Image)(resources.GetObject("BtnProducts.Image")));
            this.BtnProducts.Location = new System.Drawing.Point(154, 30);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Size = new System.Drawing.Size(116, 106);
            this.BtnProducts.TabIndex = 1;
            this.BtnProducts.Text = "Products";
            this.BtnProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnProducts.UseVisualStyleBackColor = true;
            // 
            // BtnClients
            // 
            this.BtnClients.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.BtnClients.Image = ((System.Drawing.Image)(resources.GetObject("BtnClients.Image")));
            this.BtnClients.Location = new System.Drawing.Point(300, 30);
            this.BtnClients.Name = "BtnClients";
            this.BtnClients.Size = new System.Drawing.Size(116, 106);
            this.BtnClients.TabIndex = 2;
            this.BtnClients.Text = "Clients";
            this.BtnClients.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnClients.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 190);
            this.Controls.Add(this.BtnClients);
            this.Controls.Add(this.BtnProducts);
            this.Controls.Add(this.BtnProviders);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProviders;
        private System.Windows.Forms.Button BtnProducts;
        private System.Windows.Forms.Button BtnClients;
    }
}

