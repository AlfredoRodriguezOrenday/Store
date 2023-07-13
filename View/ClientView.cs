using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace CRUDSTORE.View
{
    /// <summary>
    /// This class is used to see the client view.
    /// </summary>
    public partial class ClientView : Form
    {
        /// <value>The property ImageByte is used to save an array kind byte. </value>
        byte[] ImageByte;
        /// <value>The property StringConnection is used to save the path of the database. </value>
        private string StringConnection = "server= LAPTOP-3989L6UR; database= StoreMini; integrated security = true";
        /// <value> The property ConnectionDB will be used to create a Connection with Sql.</value>
        SqlConnection ConnectionDB;

        public ClientView()
        {
            InitializeComponent();
            SetData("Select Top(1) * From Products");
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
            LblName.Text = "";
            LblPrice.Text = "";
            LblSize.Text = "";
            LblDescription.Text = "";
            LblAbadible.Text = "";
            PicFoto.Image = null;
            ImageByte.Initialize();
        }
        /// <summary>
        /// This method is used when the user click in the button and call the function SetData and search products in the databse.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            CleanText();
            SetData("Select Top(1) * From Products Where ProductName Like '%" + TxtSearch.Text + "%'");
        }
        /// <summary>
        /// This method filled the data to the Labels and PictureBox.
        /// </summary>
        /// <param name="Query">It's a string that will be have a Query</param>
        private void SetData(string Query)
        {
            SqlDataReader Reader;
            try
            {
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
                    Reader.Close();
                }
                else
                {
                    MessageBox.Show("This product don't exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("It was ocurred an error" + ex.Message);
            }
            ConnectionDB.Close();
        }
        /// <summary>
        /// This method do a connection with the database.
        /// </summary>
        /// <returns>An object SqlConnection with the path of the database.</returns>
        public SqlConnection SetConnection()
        {
            return ConnectionDB = new SqlConnection(StringConnection);
        }
        /// <summary>
        /// This method filled the data to the Labels and PictureBox when the user type Enter in the TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CleanText();
                SetData("Select Top(1) * From Products Where ProductName Like '%" + TxtSearch.Text + "%'");
            }
        }
    }
}
