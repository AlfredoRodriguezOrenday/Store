using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDSTORE.View;

namespace CRUDSTORE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnProviders_Click(object sender, EventArgs e)
        {
            DeliveryView DV = new DeliveryView();
            DV.Show();
            this.Hide();
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            ProductsView PV = new ProductsView();
            PV.Show(); 
            this.Hide();
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            ClientView CV = new ClientView();
            CV.Show();
            this.Hide();
        }
    }
}
