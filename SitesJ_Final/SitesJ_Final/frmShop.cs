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

namespace SitesJ_Final
{
    public partial class frmShop : Form
    {
        int selectedQuantity = 0;
        decimal selectedPrice = 0m;
        string selectedUpc = "";
        public frmShop()
        {
            InitializeComponent();
        }

        private void frmShop_Load(object sender, EventArgs e)
        {
            loadGames();
        }

        private void dgvGames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvGames.CurrentCell.RowIndex;
            string selectedImagePath = dgvGames.Rows[rowIndex].Cells[5].Value.ToString();

            selectedQuantity = Int32.Parse(dgvGames.Rows[rowIndex].Cells[4].Value.ToString());
            selectedPrice = Decimal.Parse(dgvGames.Rows[rowIndex].Cells[3].Value.ToString());
            selectedUpc = dgvGames.Rows[rowIndex].Cells[0].Value.ToString();
            pbxGame.BackgroundImage = Image.FromFile(@selectedImagePath + ".jpeg");

            if (selectedQuantity != 0)
            {
                cbxQuantity.Items.Clear();
                cbxQuantity.ResetText();

                for (int x = 0; x < selectedQuantity + 1; x++)
                {
                    cbxQuantity.Items.Add(x);
                    cbxQuantity.SelectedItem = 0;
                }
            }
            else
            {
                cbxQuantity.Items.Clear();
                cbxQuantity.ResetText();
                cbxQuantity.Items.Add(0);
                cbxQuantity.SelectedItem = 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int quantityAdded = cbxQuantity.SelectedIndex;

            if (cbxQuantity.SelectedIndex > 0 && (selectedQuantity - quantityAdded) > -1)
            {
                int copiesReplaced = 0;

                for (int x = 0; x < ProgOps._dtOrdersTable.Rows.Count; x++)
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

                ProgOps.DatabaseCommandUpdate("UPDATE Games SET Video_QuantityOnHand = Video_QuantityOnHand -"
                    + quantityAdded + "WHERE Video_Game_UPC = '" + selectedUpc + "';");
                loadGames();

                cbxQuantity.Items.Clear();
                cbxQuantity.ResetText();

                for (int x = 0; x < (selectedQuantity - quantityAdded) + 1; x++)
                {
                    cbxQuantity.Items.Add(x);
                    cbxQuantity.SelectedItem = 0;
                }

                selectedQuantity = selectedQuantity - quantityAdded;

                decimal totalCost = quantityAdded * selectedPrice;

                ProgOps.DatabaseCommandCustomerOrders(selectedUpc, quantityAdded, totalCost);
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            ProgOps.DatabaseCommandBuildOrder();
            frmCart cart = new frmCart(this);
            cart.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadGames()
        {
            ProgOps.DatabaseCommand("SELECT * FROM Games;", dgvGames);
        }
    }
}
