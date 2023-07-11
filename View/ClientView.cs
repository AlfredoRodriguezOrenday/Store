using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDSTORE.Control;
using System.Data.SqlClient;
using System.IO;

namespace CRUDSTORE.View
{
    public partial class ClientView : Form
    {
        private ProductControl ProductC = new ProductControl();
        byte[] ImageByte;
        private string StringConnection = "server= LAPTOP-3989L6UR; database= StoreMini; integrated security = true";
        SqlConnection ConnectionDB;

        public ClientView()
        {
            InitializeComponent();
            SetData("Select Top(1) * From Products");
        }
        private void SetData(string Query)
        {
            //SqlDataReader Reader =  ProductC.ShowProductsToClient(Query);
            try
            {
                SqlDataReader Reader;
                SqlCommand ExecuteQuery = new SqlCommand(Query);
                ExecuteQuery.Connection = SetConnection();
                ConnectionDB.Open();
                Reader = ExecuteQuery.ExecuteReader();
                if (Reader.Read())
                {
                    LblName.Text = Reader["ProductName"].ToString();
                    LblDescription.Text = Reader["Desription"].ToString();
                    LblSize.Text = Reader["Cant"].ToString();
                    LblPrice.Text = Reader["Price"].ToString();
                    LblAbadible.Text = Reader["Abadible"].ToString();
                    ImageByte = (byte[])Reader["Photo"];
                    MemoryStream MS = new MemoryStream(ImageByte);
                    PicFoto.Image = Image.FromStream(MS);
                    PicFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("It was ocurred an error" + ex.Message);
            }
                ConnectionDB.Close();
        }

        public SqlConnection SetConnection()
        {
            return ConnectionDB = new SqlConnection(StringConnection);
        }
    }
}
