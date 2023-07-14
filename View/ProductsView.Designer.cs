namespace CRUDSTORE.View
{
    partial class ProductsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsView));
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAvailable = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CBDelivery = new System.Windows.Forms.ComboBox();
            this.PicFoto = new System.Windows.Forms.PictureBox();
            this.BtnExaminar = new System.Windows.Forms.Button();
            this.DGVProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnHome.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.BtnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.Location = new System.Drawing.Point(821, 3);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(75, 65);
            this.BtnHome.TabIndex = 1;
            this.BtnHome.Text = "Home";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnLimpiar.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(786, 139);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 34);
            this.BtnLimpiar.TabIndex = 29;
            this.BtnLimpiar.Text = "Clean";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnEliminar.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(653, 139);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(102, 34);
            this.BtnEliminar.TabIndex = 28;
            this.BtnEliminar.Text = "Eliminate";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnEditar.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(542, 139);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(82, 34);
            this.BtnEditar.TabIndex = 27;
            this.BtnEditar.Text = "Modify";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(346, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Price";
            // 
            // TxtPrice
            // 
            this.TxtPrice.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtPrice.Location = new System.Drawing.Point(350, 48);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(98, 20);
            this.TxtPrice.TabIndex = 25;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnAgregar.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(443, 139);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 34);
            this.BtnAgregar.TabIndex = 24;
            this.BtnAgregar.Text = "Add";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(219, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Size";
            // 
            // TxtSize
            // 
            this.TxtSize.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtSize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtSize.Location = new System.Drawing.Point(223, 48);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.Size = new System.Drawing.Size(98, 20);
            this.TxtSize.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(611, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Description";
            // 
            // TxtDescription
            // 
            this.TxtDescription.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtDescription.Location = new System.Drawing.Point(611, 48);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(186, 62);
            this.TxtDescription.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(104, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtName.Location = new System.Drawing.Point(108, 48);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(84, 20);
            this.TxtName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID";
            // 
            // TxtID
            // 
            this.TxtID.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtID.Location = new System.Drawing.Point(18, 48);
            this.TxtID.Name = "TxtID";
            this.TxtID.ReadOnly = true;
            this.TxtID.Size = new System.Drawing.Size(65, 20);
            this.TxtID.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(478, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 31;
            this.label6.Text = "Available";
            // 
            // TxtAvailable
            // 
            this.TxtAvailable.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtAvailable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtAvailable.Location = new System.Drawing.Point(482, 48);
            this.TxtAvailable.Name = "TxtAvailable";
            this.TxtAvailable.Size = new System.Drawing.Size(98, 20);
            this.TxtAvailable.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(14, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "Photo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(145, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 22);
            this.label8.TabIndex = 35;
            this.label8.Text = "Delivery";
            // 
            // CBDelivery
            // 
            this.CBDelivery.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CBDelivery.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CBDelivery.FormattingEnabled = true;
            this.CBDelivery.Location = new System.Drawing.Point(149, 111);
            this.CBDelivery.Name = "CBDelivery";
            this.CBDelivery.Size = new System.Drawing.Size(121, 21);
            this.CBDelivery.TabIndex = 36;
            // 
            // PicFoto
            // 
            this.PicFoto.Location = new System.Drawing.Point(12, 113);
            this.PicFoto.Name = "PicFoto";
            this.PicFoto.Size = new System.Drawing.Size(106, 85);
            this.PicFoto.TabIndex = 37;
            this.PicFoto.TabStop = false;
            // 
            // BtnExaminar
            // 
            this.BtnExaminar.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnExaminar.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.BtnExaminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnExaminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnExaminar.Image")));
            this.BtnExaminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExaminar.Location = new System.Drawing.Point(311, 139);
            this.BtnExaminar.Name = "BtnExaminar";
            this.BtnExaminar.Size = new System.Drawing.Size(106, 34);
            this.BtnExaminar.TabIndex = 38;
            this.BtnExaminar.Text = "Examinate";
            this.BtnExaminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExaminar.UseVisualStyleBackColor = false;
            this.BtnExaminar.Click += new System.EventHandler(this.BtnExaminar_Click);
            // 
            // DGVProducts
            // 
            this.DGVProducts.AllowUserToAddRows = false;
            this.DGVProducts.AllowUserToDeleteRows = false;
            this.DGVProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProducts.Location = new System.Drawing.Point(2, 201);
            this.DGVProducts.Name = "DGVProducts";
            this.DGVProducts.ReadOnly = true;
            this.DGVProducts.Size = new System.Drawing.Size(894, 248);
            this.DGVProducts.TabIndex = 39;
            this.DGVProducts.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectProduct);
            // 
            // ProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.DGVProducts);
            this.Controls.Add(this.BtnExaminar);
            this.Controls.Add(this.PicFoto);
            this.Controls.Add(this.CBDelivery);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtAvailable);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.BtnHome);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(915, 489);
            this.Name = "ProductsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsView";
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAvailable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CBDelivery;
        private System.Windows.Forms.PictureBox PicFoto;
        private System.Windows.Forms.Button BtnExaminar;
        private System.Windows.Forms.DataGridView DGVProducts;
    }
}