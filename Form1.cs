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
    /// <summary>
    /// This class is used to see the main view.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method redirect to the Delivery view when the user click in the button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnProviders_Click(object sender, EventArgs e)
        {
            DeliveryView DV = new DeliveryView();
            DV.Show();
            this.Hide();
        }
        /// <summary>
        /// This method redirect to the Products view when the user click in the button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnProducts_Click(object sender, EventArgs e)
        {
            ProductsView PV = new ProductsView();
            PV.Show(); 
            this.Hide();
        }
        /// <summary>
        /// This method redirect to the Clients view when the user click in the button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClients_Click(object sender, EventArgs e)
        {
            ClientView CV = new ClientView();
            CV.Show();
            this.Hide();
        }
    }
}
