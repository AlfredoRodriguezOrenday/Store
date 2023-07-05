namespace CRUDSTORE.View
{
    partial class DeliveryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryView));
            this.BtnHome = new System.Windows.Forms.Button();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCompany = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.BtnAdding = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDeliveryDays = new System.Windows.Forms.TextBox();
            this.DGVDelivery = new System.Windows.Forms.DataGridView();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnEliminate = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnHome.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.BtnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.Location = new System.Drawing.Point(713, 12);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(75, 65);
            this.BtnHome.TabIndex = 0;
            this.BtnHome.Text = "Home";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(31, 41);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(65, 20);
            this.TxtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(117, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(121, 41);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(84, 20);
            this.TxtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(226, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Company";
            // 
            // TxtCompany
            // 
            this.TxtCompany.Location = new System.Drawing.Point(230, 41);
            this.TxtCompany.Name = "TxtCompany";
            this.TxtCompany.Size = new System.Drawing.Size(98, 20);
            this.TxtCompany.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(335, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone Number";
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Location = new System.Drawing.Point(355, 41);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(98, 20);
            this.TxtPhoneNumber.TabIndex = 7;
            // 
            // BtnAdding
            // 
            this.BtnAdding.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdding.Image")));
            this.BtnAdding.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdding.Location = new System.Drawing.Point(31, 84);
            this.BtnAdding.Name = "BtnAdding";
            this.BtnAdding.Size = new System.Drawing.Size(75, 34);
            this.BtnAdding.TabIndex = 9;
            this.BtnAdding.Text = "Adding";
            this.BtnAdding.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdding.UseVisualStyleBackColor = true;
            this.BtnAdding.Click += new System.EventHandler(this.BtnAdding_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(479, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Delivery Days";
            // 
            // TxtDeliveryDays
            // 
            this.TxtDeliveryDays.Location = new System.Drawing.Point(499, 41);
            this.TxtDeliveryDays.Name = "TxtDeliveryDays";
            this.TxtDeliveryDays.Size = new System.Drawing.Size(98, 20);
            this.TxtDeliveryDays.TabIndex = 10;
            // 
            // DGVDelivery
            // 
            this.DGVDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDelivery.Location = new System.Drawing.Point(-1, 159);
            this.DGVDelivery.Name = "DGVDelivery";
            this.DGVDelivery.Size = new System.Drawing.Size(803, 291);
            this.DGVDelivery.TabIndex = 12;
            this.DGVDelivery.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectDelivery);
            // 
            // BtnModify
            // 
            this.BtnModify.Image = ((System.Drawing.Image)(resources.GetObject("BtnModify.Image")));
            this.BtnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModify.Location = new System.Drawing.Point(130, 84);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(75, 34);
            this.BtnModify.TabIndex = 13;
            this.BtnModify.Text = "Modify";
            this.BtnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnEliminate
            // 
            this.BtnEliminate.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminate.Image")));
            this.BtnEliminate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminate.Location = new System.Drawing.Point(230, 84);
            this.BtnEliminate.Name = "BtnEliminate";
            this.BtnEliminate.Size = new System.Drawing.Size(75, 34);
            this.BtnEliminate.TabIndex = 14;
            this.BtnEliminate.Text = "Eliminate";
            this.BtnEliminate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminate.UseVisualStyleBackColor = true;
            this.BtnEliminate.Click += new System.EventHandler(this.BtnEliminate_Click);
            // 
            // BtnClean
            // 
            this.BtnClean.Image = ((System.Drawing.Image)(resources.GetObject("BtnClean.Image")));
            this.BtnClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClean.Location = new System.Drawing.Point(330, 84);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(75, 34);
            this.BtnClean.TabIndex = 15;
            this.BtnClean.Text = "Clean";
            this.BtnClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // DeliveryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.BtnEliminate);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.DGVDelivery);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDeliveryDays);
            this.Controls.Add(this.BtnAdding);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPhoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.BtnHome);
            this.Name = "DeliveryView";
            this.Text = "DeliveryView";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDelivery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPhoneNumber;
        private System.Windows.Forms.Button BtnAdding;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDeliveryDays;
        private System.Windows.Forms.DataGridView DGVDelivery;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnEliminate;
        private System.Windows.Forms.Button BtnClean;
    }
}