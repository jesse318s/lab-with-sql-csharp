using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SitesJ_Final
{
    public partial class frmCart : Form
    {
        frmShop handleFrmShop;
        int currentCustomerId = ProgOps.currentCustomerId;
        int currentOrderId = ProgOps.currentOrderId;
        decimal subtotal = 0m;
        string selectedUpc = "";
        public frmCart(frmShop shop)
        {
            InitializeComponent();
            handleFrmShop = shop;
        }
        public frmCart()
        {
            InitializeComponent();
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            dgvCart.DataSource = ProgOps._dtOrdersTable;
            dgvCart.Columns["OrderID"].Visible = false;
            dgvCart.Columns["CustomerID"].Visible = false;
            dgvCart.Columns["Video_Game_UPC"].Visible = false;

            subtotal = 0m;

            for (int x = 0; x < ProgOps._dtOrdersTable.Rows.Count; x++)
            {
                DataRow index = ProgOps._dtOrdersTable.Rows[x];
                subtotal += Decimal.Parse(index["Total_Line_Cost"].ToString());
            }

            lblSubtotalOutput.Text = subtotal.ToString();
            lblTaxAmountOutput.Text = (subtotal * 0.08m).ToString();
            lblNetTotalOutput.Text = (subtotal + subtotal * 0.08m).ToString();
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = 0;
            rowIndex = dgvCart.CurrentCell.RowIndex;
            selectedUpc = dgvCart.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int copiesReplaced = 0;

            for (int x = ProgOps._dtOrdersTable.Rows.Count - 1; x >= 0; x--)
            {
                DataRow index = ProgOps._dtOrdersTable.Rows[x];
                if (index["Video_Game_UPC"].ToString() == selectedUpc)
                {
                    copiesReplaced = Int32.Parse(index["Order_Quantity"].ToString());
                    index.Delete();
                }
            }

            ProgOps.DatabaseCommandUpdate("UPDATE Games SET Video_QuantityOnHand = Video_QuantityOnHand +"
            + copiesReplaced + "WHERE Video_Game_UPC = '" + selectedUpc + "';");

            subtotal = 0m;

            for (int x = 0; x < ProgOps._dtOrdersTable.Rows.Count; x++)
            {
                DataRow index = ProgOps._dtOrdersTable.Rows[x];
                subtotal += Decimal.Parse(index["Total_Line_Cost"].ToString());
            }

            lblSubtotalOutput.Text = subtotal.ToString();
            lblTaxAmountOutput.Text = (subtotal * 0.08m).ToString();
            lblNetTotalOutput.Text = (subtotal + subtotal * 0.08m).ToString();

            handleFrmShop.loadGames();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            int copiesReplaced = 0;
            string replacedUpc = "";

            for (int x = ProgOps._dtOrdersTable.Rows.Count - 1; x >= 0; x--)
            {
                DataRow index = ProgOps._dtOrdersTable.Rows[x];
                copiesReplaced = Int32.Parse(index["Order_Quantity"].ToString());
                replacedUpc = index["Video_Game_UPC"].ToString();
                index.Delete();
                ProgOps.DatabaseCommandUpdate("UPDATE Games SET Video_QuantityOnHand = Video_QuantityOnHand +"
                + copiesReplaced + "WHERE Video_Game_UPC = '" + replacedUpc + "';");
            }

            subtotal = 0m;

            for (int x = 0; x < ProgOps._dtOrdersTable.Rows.Count; x++)
            {
                DataRow index2 = ProgOps._dtOrdersTable.Rows[x];
                subtotal += Decimal.Parse(index2["Total_Line_Cost"].ToString());
            }

            lblSubtotalOutput.Text = subtotal.ToString();
            lblTaxAmountOutput.Text = (subtotal * 0.08m).ToString();
            lblNetTotalOutput.Text = (subtotal + subtotal * 0.08m).ToString();

            handleFrmShop.loadGames();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (tbxFName.Text.Length < 26 && tbxFName.Text.Length < 26)
            {
                if (ProgOps._dtOrdersTable.Rows.Count > 0)
                {
                    ProgOps.DatabaseCommandUpdate("INSERT INTO Customers (Cust_FName, Cust_LName) VALUES" +
                        " ('" + tbxFName.Text + "', '" + tbxLName.Text + "');");
                    ProgOps.currentCustomerId = ProgOps.DatabaseCommandId("SELECT MAX(CustomerID) FROM Customers;");
                    ProgOps.currentOrderId = ProgOps.DatabaseCommandId("SELECT MAX(OrderID) FROM Orders;") + 1;
                    ProgOps.DatabaseCommandCreateOrderRecord();

                    subtotal = 0m;

                    for (int x = 0; x < ProgOps._dtOrdersTable.Rows.Count; x++)
                    {
                        DataRow index2 = ProgOps._dtOrdersTable.Rows[x];
                        subtotal += Decimal.Parse(index2["Total_Line_Cost"].ToString());
                    }

                    lblSubtotalOutput.Text = subtotal.ToString();
                    lblTaxAmountOutput.Text = (subtotal * 0.08m).ToString();
                    lblNetTotalOutput.Text = (subtotal + subtotal * 0.08m).ToString();
                    tbxFName.Text = "";
                    tbxLName.Text = "";

                    //print crystal report
                    CrystalReports.crptOrder order = new CrystalReports.crptOrder();
                    order.SetDatabaseLogon("jsitessp222353", "1234567");
                    frmViewer viewer = new frmViewer();
                    viewer.crvViewer.ReportSource = null;
                    viewer.crvViewer.ReportSource = order;
                    viewer.Show();
                }
                else
                {
                    MessageBox.Show("No order items.", "Order",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Customer name is too long, please try again.", "Customer Name",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxFName.Text = "";
                tbxLName.Text = "";
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
