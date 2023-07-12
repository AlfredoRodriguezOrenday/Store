namespace CRUDSTORE.View
{
    partial class ClientView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientView));
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.PicFoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblSize = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblAbadible = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.BtnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtSearch.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.TxtSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtSearch.Location = new System.Drawing.Point(29, 26);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(170, 24);
            this.TxtSearch.TabIndex = 0;
            this.TxtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Search);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnSearch.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
            this.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearch.Location = new System.Drawing.Point(236, 26);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(102, 33);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // PicFoto
            // 
            this.PicFoto.Location = new System.Drawing.Point(236, 84);
            this.PicFoto.Name = "PicFoto";
            this.PicFoto.Size = new System.Drawing.Size(160, 187);
            this.PicFoto.TabIndex = 2;
            this.PicFoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(29, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.LblName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblName.Location = new System.Drawing.Point(29, 101);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(22, 22);
            this.LblName.TabIndex = 4;
            this.LblName.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(29, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price:";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.LblPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblPrice.Location = new System.Drawing.Point(29, 170);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(22, 22);
            this.LblPrice.TabIndex = 6;
            this.LblPrice.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(29, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Size:";
            // 
            // LblSize
            // 
            this.LblSize.AutoSize = true;
            this.LblSize.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.LblSize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblSize.Location = new System.Drawing.Point(29, 238);
            this.LblSize.Name = "LblSize";
            this.LblSize.Size = new System.Drawing.Size(22, 22);
            this.LblSize.TabIndex = 8;
            this.LblSize.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(29, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Abadible:";
            // 
            // LblAbadible
            // 
            this.LblAbadible.AutoSize = true;
            this.LblAbadible.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.LblAbadible.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblAbadible.Location = new System.Drawing.Point(29, 309);
            this.LblAbadible.Name = "LblAbadible";
            this.LblAbadible.Size = new System.Drawing.Size(22, 22);
            this.LblAbadible.TabIndex = 10;
            this.LblAbadible.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(29, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "Description:";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.LblDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblDescription.Location = new System.Drawing.Point(29, 378);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(22, 22);
            this.LblDescription.TabIndex = 12;
            this.LblDescription.Text = "...";
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnHome.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.BtnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.Location = new System.Drawing.Point(358, 3);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(75, 65);
            this.BtnHome.TabIndex = 13;
            this.BtnHome.Text = "Home";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblAbadible);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicFoto);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Name = "ClientView";
            this.Text = "ClientView";
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.PictureBox PicFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblAbadible;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Button BtnHome;
    }
}