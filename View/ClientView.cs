﻿using System;
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
    public partial class ClientView : Form
    {
        byte[] ImageByte;
        private string StringConnection = "server= LAPTOP-3989L6UR; database= StoreMini; integrated security = true";
        SqlConnection ConnectionDB;

        public ClientView()
        {
            InitializeComponent();
            SetData("Select Top(1) * From Products");
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();
        }

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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            CleanText();
            SetData("Select Top(1) * From Products Where ProductName Like '%" + TxtSearch.Text + "%'");
        }

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
