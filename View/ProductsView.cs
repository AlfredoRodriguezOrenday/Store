﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CRUDSTORE.Control;
using CRUDSTORE.Model;

namespace CRUDSTORE.View
{
    /// <summary>
    /// This class is used to see the products view.
    /// </summary>
    public partial class ProductsView : Form
    {
        /// <value>The property ProductC is used to access his methods from ProductControl. </value>
        ProductControl ProductC = new ProductControl();
        /// <value>The property ImageByte is used to save an array kind byte. </value>
        byte[] ImageByte;
        /// <value>The property Id is used to save the Product Id. </value>
        int Id;
        public ProductsView()
        {
            InitializeComponent();
            RefreshGrid();
            RefreshDelivery();
        }
        /// <summary>
        /// This method redirect to the main view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHome_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();
        }
        /// <summary>
        /// This method clean the TextBoxs and parameters.
        /// </summary>
        private void CleanText()
        {
            TxtID.Text = "";
            TxtName.Text = "";
            TxtDescription.Text = "";
            TxtSize.Text = "";
            TxtPrice.Text = "";
            TxtAvailable.Text = "";
            PicFoto.Image = null;
            ImageByte.Initialize(); 
            CBDelivery.SelectedIndex = 0;
            Id = 0;
        }
        /// <summary>
        /// This method is used when the user click in the button and call the function CleanText.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            CleanText();
        }
        /// <summary>
        /// This method is called when the user click in the button and search a picture in the files of the computer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog SelectorImage = new OpenFileDialog();
            SelectorImage.Title = "Select a picture";
            if (SelectorImage.ShowDialog() == DialogResult.OK)
            {
                PicFoto.Image = Image.FromStream(SelectorImage.OpenFile());
                MemoryStream memoria = new MemoryStream();
                PicFoto.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);
                PicFoto.SizeMode = PictureBoxSizeMode.StretchImage; 
                ImageByte = memoria.ToArray();
            }
        }
        /// <summary>
        /// This method get the data from the TextBoxs, return an object kind Product and check if all parameters are ready and do the operation.
        /// </summary>
        /// <param name="Action">It's a boolean parameter if the action is add the parameter will be false.</param>
        /// <returns></returns>
        private Product GetInfo(bool Action)
        {
            Product DeliveryModel = new Product();
            Id = 1;
            double Size = 0;
            double Price = 0;
            double Available = 0;
            int IdDelivery = 0;
            int.TryParse(TxtID.Text, out Id);
            double.TryParse(TxtSize.Text, out Size);
            double.TryParse(TxtPrice.Text, out Price);
            double.TryParse(TxtAvailable.Text, out Available);
            int.TryParse(CBDelivery.SelectedValue.ToString(), out IdDelivery);
            try
            {
                if (Action && Id == 0)
                {
                    throw new Exception("Select one row");
                }
                if (TxtName.Text != "" && TxtDescription.Text != "" && TxtSize.Text != "" && TxtPrice.Text != "" && TxtAvailable.Text != "" && PicFoto.Image != null && CBDelivery.SelectedIndex >= 0 && IdDelivery >= 0 )
                {
                    DeliveryModel.Name = TxtName.Text;
                    DeliveryModel.Description = TxtDescription.Text;
                    DeliveryModel.Size = Size;
                    DeliveryModel.Price = Price;
                    DeliveryModel.Available = Available;
                    DeliveryModel.Photo = ImageByte;
                    DeliveryModel.IdDelivery = IdDelivery;
                }
                else
                {
                    throw new Exception("Complete the fields");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DeliveryModel.ID = Id;
            return DeliveryModel;
        }
        /// <summary>
        /// This method is used when the user click in the button and add a register in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ProductC.SaveProduct(GetInfo(false));
            RefreshGrid();
            CleanText();
        }
        /// <summary>
        /// This method refresh the DataGridView register from database.
        /// </summary>
        private void RefreshGrid()
        {
            try
            {
                DGVProducts.DataSource = ProductC.ShowProducts("Exec SP_ShowProducts").Tables[0];
                DGVProducts.Columns[0].HeaderText = "Id";
                DGVProducts.Columns[1].HeaderText = "Name";
                DGVProducts.Columns[2].HeaderText = "Description";
                DGVProducts.Columns[3].HeaderText = "Cant";
                DGVProducts.Columns[4].HeaderText = "Price";
                DGVProducts.Columns[5].HeaderText = "Abadible";
                DGVProducts.Columns[6].HeaderText = "Delivery Name";
                DGVProducts.Columns[7].HeaderText = "Id Delivery";
                DGVProducts.Columns[8].HeaderText = "Photo";
                DataGridViewColumn column = DGVProducts.Columns[8];
                column.Width = 250;
                DGVProducts.RowTemplate.Height = 120;
                DGVProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch(Exception e)
            {
                MessageBox.Show("It was ocurred an error " + e.Message);
            }
        }
        /// <summary>
        /// This method refresh the ComboBox register from database.
        /// </summary>
        private void RefreshDelivery()
        {
            CBDelivery.DataSource = ProductC.ShowProducts("Select Id, DeliveryName From DeliveryProducts").Tables[0];
            CBDelivery.DisplayMember = "DeliveryName";
            CBDelivery.ValueMember = "Id";
        }
        /// <summary>
        /// This method is used when the user click in the button and update a register in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            ProductC.UpdateProduct(GetInfo(true));
            RefreshGrid();
            CleanText();
        }
        /// <summary>
        /// This method is used when the user click in the button and delete a register in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ProductC.DeleteProduct(GetInfo(true));
            RefreshGrid();
            CleanText();
        }
        /// <summary>
        /// This method filled the data to the TextBoxs, PictureBox and ComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectProduct(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Indice = e.RowIndex;
            DGVProducts.ClearSelection();
            if(Indice >= 0)
            {
                TxtID.Text = DGVProducts.Rows[Indice].Cells[0].Value.ToString();
                TxtName.Text = DGVProducts.Rows[Indice].Cells[1].Value.ToString();
                TxtDescription.Text = DGVProducts.Rows[Indice].Cells[2].Value.ToString();
                TxtSize.Text = DGVProducts.Rows[Indice].Cells[3].Value.ToString();
                TxtPrice.Text = DGVProducts.Rows[Indice].Cells[4].Value.ToString();
                TxtAvailable.Text = DGVProducts.Rows[Indice].Cells[5].Value.ToString();
                CBDelivery.SelectedValue = DGVProducts.Rows[Indice].Cells[7].Value.ToString();
                ImageByte = (byte[])DGVProducts.Rows[Indice].Cells[8].Value;
                MemoryStream MS = new MemoryStream(ImageByte);
                PicFoto.Image = Image.FromStream(MS);
                PicFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
