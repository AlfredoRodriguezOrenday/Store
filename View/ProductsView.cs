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
            CBDelivery.SelectedIndex = 1;
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
    }
}
