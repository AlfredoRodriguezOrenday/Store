using System;
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
    public partial class DeliveryView : Form
    {
        int Id = 0;
        DeliveryControl DeliveryC = new DeliveryControl();

        public DeliveryView()
        {
            InitializeComponent();
            RefreshGrid();
        }


        private void BtnHome_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();
        }

        private void BtnAdding_Click(object sender, EventArgs e)
        {
            DeliveryC.AddDeliveryProduct(GetData(false));
            CleanTxt();
            RefreshGrid();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            if(TxtID.Text != null)
            {
                DeliveryC.UpdateDeliveryProduct(GetData(true));
                CleanTxt();
                RefreshGrid();
            }
        }

        private void BtnEliminate_Click(object sender, EventArgs e)
        {
            if(TxtID.Text != null)
            {
                DeliveryC.DeleteDeliveryProduct(GetData(true));
                CleanTxt();
                RefreshGrid();
            }
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            CleanTxt();
        }

        private void CleanTxt()
        {
            TxtID.Text = "";
            TxtName.Text = "";
            TxtCompany.Text = "";
            TxtPhoneNumber.Text = "";
            TxtDeliveryDays.Text = "";
            Id = 0;
        }

        private DeliveryProduct GetData(bool Action)
        {
            DeliveryProduct DeliveryModel = new DeliveryProduct();
            int.TryParse(TxtID.Text, out Id);
            int PhoneNumbers = 0;
            int.TryParse(TxtPhoneNumber.Text, out PhoneNumbers);
            if (Action && Id == 0)
            {
                MessageBox.Show("Select one row");
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
                MessageBox.Show("Complete the fields");
            }
            DeliveryModel.ID = Id;
            return DeliveryModel;
        }

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
