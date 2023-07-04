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
    public partial class ProductsView : Form
    {
        ProductControl ProductC = new ProductControl();
        byte[] ImageByte;
        int Id;
        public ProductsView()
        {
            InitializeComponent();
            RefreshGrid();
            RefreshDelivery();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();
        }

        private void CleanText()
        {
            TxtID.Text = "";
            TxtName.Text = "";
            TxtDescription.Text = "";
            TxtSize.Text = "";
            PicFoto.Hide();
            CBDelivery.SelectedIndex = 1; //Aqui hay un erros que hay que solucionar
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            CleanText();
        }

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog SelectorImage = new OpenFileDialog();
            SelectorImage.Title = "Select a picture";
            if (SelectorImage.ShowDialog() == DialogResult.OK)
            {
                PicFoto.Image = Image.FromStream(SelectorImage.OpenFile());
                MemoryStream memoria = new MemoryStream();
                PicFoto.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);

                ImageByte = memoria.ToArray();
            }
        }

        private Product GetInfo()
        {
            Product DeliveryModel = new Product();
            Id = 1;
            double Size = 0;
            double Price = 0;
            int IdDelivery = 0;
            int.TryParse(TxtID.Text, out Id);
            DeliveryModel.ID = Id;
            DeliveryModel.Name = TxtName.Text;
            DeliveryModel.Description = TxtDescription.Text;
            double.TryParse(TxtSize.Text, out Size);
            DeliveryModel.Size = Size;
            double.TryParse(TxtPrice.Text, out Price);
            DeliveryModel.Price = Price;
            DeliveryModel.Photo = ImageByte;
            int.TryParse(CBDelivery.SelectedValue.ToString(), out IdDelivery);
            DeliveryModel.IdDelivery = IdDelivery;
            return DeliveryModel;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ProductC.SaveProduct(GetInfo());
            RefreshGrid();
            CleanText();

        }

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
            }catch(Exception e)
            {
                MessageBox.Show("It was ocurred an error " + e.Message);
            }
        }

        private void RefreshDelivery()
        {
            CBDelivery.DataSource = ProductC.ShowProducts("Select Id, DeliveryName From DeliveryProducts").Tables[0];
            CBDelivery.DisplayMember = "DeliveryName";
            CBDelivery.ValueMember = "Id";
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            ProductC.UpdateProduct(GetInfo());
            RefreshGrid();
            CleanText();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ProductC.DeleteProduct(GetInfo());
            RefreshGrid();
            CleanText();
        }

        private void SelectProduct(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Indice = e.RowIndex;
            DGVProducts.ClearSelection();
            if(Indice > 0)
            {
                TxtID.Text = DGVProducts.Rows[Indice].Cells[0].Value.ToString();
                TxtName.Text = DGVProducts.Rows[Indice].Cells[1].Value.ToString();
                TxtDescription.Text = DGVProducts.Rows[Indice].Cells[2].Value.ToString();
                TxtSize.Text = DGVProducts.Rows[Indice].Cells[3].Value.ToString();
                TxtPrice.Text = DGVProducts.Rows[Indice].Cells[4].Value.ToString();
                TxtAvailable.Text = DGVProducts.Rows[Indice].Cells[5].Value.ToString();
                CBDelivery.SelectedItem = DGVProducts.Rows[Indice].Cells[7].Value.ToString();
                ImageByte = (byte[])DGVProducts.Rows[Indice].Cells[8].Value;
                MemoryStream MS = new MemoryStream(ImageByte);
                PicFoto.Image = Image.FromStream(MS);
            }
        }
    }
}
