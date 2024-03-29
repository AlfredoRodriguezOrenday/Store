﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDSTORE.Model;
using CRUDSTORE.Control;

namespace CRUDSTORE.View
{
    /// <summary>
    /// This class is used to see the delivery view.
    /// </summary>
    public partial class DeliveryView : Form
    {
        /// <value>The property Id is used to save the Delivery Id. </value>
        int Id = 0;
        /// <value>The property DeliveryC is used to access the methods from DeliveryControl. </value>
        DeliveryControl DeliveryC = new DeliveryControl();

        public DeliveryView()
        {
            InitializeComponent();
            RefreshGrid();
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
        /// This method is used when the user click in the button and add a register in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdding_Click(object sender, EventArgs e)
        {
            DeliveryC.AddDeliveryProduct(GetData(false));
            CleanTxt();
            RefreshGrid();
        }
        /// <summary>
        /// This method is used when the user click in the button and modify a register in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModify_Click(object sender, EventArgs e)
        {
            if(TxtID.Text != null)
            {
                DeliveryC.UpdateDeliveryProduct(GetData(true));
                CleanTxt();
                RefreshGrid();
            }
        }
        /// <summary>
        /// This method is used when the user click in the button and delete a register in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEliminate_Click(object sender, EventArgs e)
        {
            if(TxtID.Text != null)
            {
                DeliveryC.DeleteDeliveryProduct(GetData(true));
                CleanTxt();
                RefreshGrid();
            }
        }
        /// <summary>
        /// This method is used when the user click in the button and call the function CleanTxt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClean_Click(object sender, EventArgs e)
        {
            CleanTxt();
        }
        /// <summary>
        /// This method clean the TextBoxs and parameters.
        /// </summary>
        private void CleanTxt()
        {
            TxtID.Text = "";
            TxtName.Text = "";
            TxtCompany.Text = "";
            TxtPhoneNumber.Text = "";
            TxtDeliveryDays.Text = "";
            Id = 0;
        }
        /// <summary>
        /// This method get the data from the TextBoxs, return an object kind DeliveryProduct and check if all parameters are ready and do the operation.
        /// </summary>
        /// <param name="Action">It's a boolean parameter if the action is add the parameter will be false.</param>
        /// <returns></returns>
        private DeliveryProduct GetData(bool Action)
        {
            DeliveryProduct DeliveryModel = new DeliveryProduct();
            int.TryParse(TxtID.Text, out Id);
            int PhoneNumbers = 0;
            int.TryParse(TxtPhoneNumber.Text, out PhoneNumbers);
            try
            {
                if (Action && Id == 0)
                {
                    throw new Exception("Select one row");
                }
                if (TxtName.Text != "" && TxtCompany.Text != "" && PhoneNumbers != 0 && TxtDeliveryDays.Text != "")
                {
                    DeliveryModel.Name = TxtName.Text;
                    DeliveryModel.Company = TxtCompany.Text;
                    DeliveryModel.PhoneNumber = PhoneNumbers;
                    DeliveryModel.DeliveryDays = TxtDeliveryDays.Text;
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
        /// This method refresh the DataGridView register from database.
        /// </summary>
        private void RefreshGrid()
        {
            try
            {
                DGVDelivery.DataSource = DeliveryC.ShowDelivery("Exec SP_ShowDeliveryProducts").Tables[0];
                DGVDelivery.Columns[0].HeaderText = "Id";
                DGVDelivery.Columns[1].HeaderText = "Name";
                DGVDelivery.Columns[2].HeaderText = "Company";
                DGVDelivery.Columns[3].HeaderText = "Phone Number";
                DGVDelivery.Columns[4].HeaderText = "Delivery Days";
            }catch (Exception e)
            {
                MessageBox.Show("It was ocurred an error " + e.Message);
            }
        }
        /// <summary>
        /// This method filled the data to the TextBoxs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDelivery(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Indice =  e.RowIndex;
            DGVDelivery.ClearSelection();
            if (Indice >= 0)
            {
                TxtID.Text = DGVDelivery.Rows[Indice].Cells[0].Value.ToString();
                TxtName.Text = DGVDelivery.Rows[Indice].Cells[1].Value.ToString();
                TxtCompany.Text = DGVDelivery.Rows[Indice].Cells[2].Value.ToString();
                TxtPhoneNumber.Text = DGVDelivery.Rows[Indice].Cells[3].Value.ToString();
                TxtDeliveryDays.Text = DGVDelivery.Rows[Indice].Cells[4].Value.ToString();
            }
        }
    }
}
