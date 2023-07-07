using System;
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
            TxtPrice.Text = "";
            TxtAvailable.Text = "";
            PicFoto.Hide();
            ImageByte.Initialize(); // Maybe in the future I will change this line
            CBDelivery.SelectedIndex = -1;
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
                PicFoto.SizeMode = PictureBoxSizeMode.StretchImage; 
                ImageByte = memoria.ToArray();
            }
        }

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
                if (TxtName.Text != "" && TxtDescription.Text != "" && TxtSize.Text != "" && TxtPrice.Text != "" && TxtAvailable.Text != "" && IdDelivery != 0)
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ProductC.SaveProduct(GetInfo(false));
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
            ProductC.UpdateProduct(GetInfo(true));
            RefreshGrid();
            CleanText();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ProductC.DeleteProduct(GetInfo(true));
            RefreshGrid();
            CleanText();
        }

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
                CBDelivery.SelectedItem = DGVProducts.Rows[Indice].Cells[7].Value.ToString();
                ImageByte = (byte[])DGVProducts.Rows[Indice].Cells[8].Value;
                MemoryStream MS = new MemoryStream(ImageByte);
                PicFoto.Image = Image.FromStream(MS);
                PicFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
