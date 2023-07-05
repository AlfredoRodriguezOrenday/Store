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
            DeliveryC.AddDeliveryProduct(GetData());
            CleanTxt();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            if(TxtID.Text != null)
            {
                DeliveryC.UpdateDeliveryProduct(GetData());
                CleanTxt();
            }
        }

        private void BtnEliminate_Click(object sender, EventArgs e)
        {
            if(TxtID.Text != null)
            {
                DeliveryC.DeleteDeliveryProduct(GetData());
                CleanTxt();
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
        }

        private DeliveryProduct GetData()
        {
            DeliveryProduct DeliveryModel = new DeliveryProduct();
            int.TryParse(TxtID.Text, out Id);
            int PhoneNumber = 0;
            int.TryParse(TxtPhoneNumber.Text, out PhoneNumber);

            DeliveryModel.ID = Id;
            DeliveryModel.Name = TxtName.Text;
            DeliveryModel.Company = TxtCompany.Text;
            DeliveryModel.PhoneNumber = PhoneNumber;
            DeliveryModel.DeliveryDays = TxtDeliveryDays.Text;
            return DeliveryModel;
        }

        private void RefreshGrid()
        {
            try
            {
                DGVDelivery.DataSource = DeliveryC.ShowDelivery("EXEC SP_ShowDeliveryProducts");
                DGVDelivery.Columns[0].HeaderText = "Id";
                DGVDelivery.Columns[1].HeaderText = "Name";
                DGVDelivery.Columns[2].HeaderText = "Company";
                DGVDelivery.Columns[3].HeaderText = "Phone Number";
                //DGVDelivery.Columns[4].HeaderText = "Delivery Days";
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
