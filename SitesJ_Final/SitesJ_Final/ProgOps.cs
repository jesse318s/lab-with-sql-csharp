using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SitesJ_Final
{
    class ProgOps
    {
        private static SqlConnection dbConnection;

        public static SqlCommand _sqlOrdersCmd = null;
        public static SqlDataAdapter _daOrders = new SqlDataAdapter();
        public static DataTable _dtOrdersTable = new DataTable();

        public static int currentCustomerId = 0;
        public static int currentOrderId = 0;

        public static void OpenDatabase()
        {
            //connect to db
            dbConnection = new SqlConnection("Server=cstnt.tstc.edu;" +
            "Database=GameCastle_JS_2353SP22;User Id=jsitessp222353;" +
            "password=1234567");
            dbConnection.Open();
        }

        public static void CloseDatabase()
        {
            //close and dispose db
            dbConnection.Close();
            dbConnection.Dispose();
        }


        public static void DatabaseCommand(string sqlStatement, DataGridView dgvTable)
        {
            SqlCommand resultsCmd = null;
            SqlDataAdapter resultsAdapter = new SqlDataAdapter();
            DataTable resultsTable = new DataTable();

            //est cmd obj and da
            resultsCmd = new SqlCommand(sqlStatement, dbConnection);
            resultsAdapter.SelectCommand = resultsCmd;
            resultsAdapter.Fill(resultsTable);
            //bind grid to table
            dgvTable.DataSource = resultsTable;
            resultsCmd.Dispose();
            resultsAdapter.Dispose();
            resultsTable.Dispose();
        }

        public static void DatabaseCommandUpdate(string sqlStatement)
        {
            SqlDataAdapter resultsAdapter = new SqlDataAdapter();
            SqlCommand resultsCmd = null;

            resultsCmd = new SqlCommand(sqlStatement, dbConnection);
            resultsAdapter.UpdateCommand = new SqlCommand(sqlStatement, dbConnection);
            //execute sql
            resultsAdapter.UpdateCommand.ExecuteNonQuery();
            resultsCmd.Dispose();
            resultsAdapter.Dispose();
        }

        public static int DatabaseCommandId(string sqlStatement)
        {
            int newId = 0;
            SqlCommand resultsCmd = null;
            SqlDataReader reader = null;

            resultsCmd = new SqlCommand(sqlStatement, dbConnection);
            reader = resultsCmd.ExecuteReader();
            reader.Read();
            newId = reader.GetInt32(0);
            reader.Close();

            resultsCmd.Dispose();
            reader.Dispose();

            return newId;
        }

        public static int DatabaseCommandCopies(string sqlStatement)
        {
            int copies = 0;
            SqlCommand resultsCmd = null;
            SqlDataReader reader = null;

            resultsCmd = new SqlCommand(sqlStatement, dbConnection);
            reader = resultsCmd.ExecuteReader();
            if (reader.Read())
            {
                copies = reader.GetInt32(0);
            }
            reader.Close();

            resultsCmd.Dispose();
            reader.Dispose();

            return copies;
        }

        public static void DatabaseCommandBuildOrder()
        {
            if (_dtOrdersTable.Columns.Count < 7)
            {
                _dtOrdersTable.Columns.Add("Video_Title");
                _dtOrdersTable.Columns.Add("Video_PricePerUnit");
                _dtOrdersTable.Columns.Add("OrderID");
                _dtOrdersTable.Columns.Add("Video_Game_UPC");
                _dtOrdersTable.Columns.Add("CustomerID");
                _dtOrdersTable.Columns.Add("Order_Quantity");
                _dtOrdersTable.Columns.Add("Total_Line_Cost");
            }
        }

        public static void DatabaseCommandCustomerOrders(string selectedUpc, int selectedQuantity, decimal totalCost)
        {
            string sqlStatement = "SELECT Video_Title FROM Games WHERE Video_Game_UPC = " + selectedUpc + ";";
            string sqlStatement2 = "SELECT Video_PricePerUnit FROM Games WHERE Video_Game_UPC = " + selectedUpc + ";";
            string newTitle = "";
            decimal newPrice = 0;
            SqlCommand resultsCmd = null;
            SqlCommand resultsCmd2 = null;
            SqlDataReader reader = null;
            SqlDataReader reader2 = null;

            resultsCmd = new SqlCommand(sqlStatement, dbConnection);
            reader = resultsCmd.ExecuteReader();
            reader.Read();
            newTitle = reader.GetString(0);
            reader.Close();
            resultsCmd2 = new SqlCommand(sqlStatement2, dbConnection);
            reader2 = resultsCmd2.ExecuteReader();
            reader2.Read();
            newPrice = reader2.GetDecimal(0);
            reader2.Close();

            DatabaseCommandBuildOrder();

            DataRow newOrder;
            newOrder = _dtOrdersTable.NewRow();
            newOrder[0] = newTitle;
            newOrder[1] = newPrice;
            newOrder[2] = currentOrderId;
            newOrder[3] = selectedUpc;
            newOrder[4] = currentCustomerId;
            newOrder[5] = selectedQuantity;
            newOrder[6] = totalCost;
            _dtOrdersTable.Rows.Add(newOrder);

            resultsCmd.Dispose();
            reader.Dispose();
            resultsCmd2.Dispose();
            reader2.Dispose();
        }

        public static void DatabaseCommandCreateOrderRecord()
        {
            //copy data table
            DataTable _dtOrdersTableDBCopy = new DataTable();
            _dtOrdersTableDBCopy = _dtOrdersTable.Copy();
            DataRow updateRow;

            _dtOrdersTable.Clear();
            _dtOrdersTableDBCopy.Columns.Remove("Video_Title");
            _dtOrdersTableDBCopy.Columns.Remove("Video_PricePerUnit");

            for (int x = 0; x < _dtOrdersTableDBCopy.Rows.Count; x++)
            {
                updateRow = _dtOrdersTableDBCopy.Rows[x];
                updateRow["OrderID"] = currentOrderId;
                updateRow["CustomerID"] = currentCustomerId;
            }

            //statement for the command string
            string sqlStatement = "Select * From Orders;";
            //establish command object
            _sqlOrdersCmd = new SqlCommand(sqlStatement, dbConnection);
            _daOrders.SelectCommand = _sqlOrdersCmd;
            SqlCommandBuilder ordersAdapterCommands = new SqlCommandBuilder(_daOrders);
            _daOrders.Update(_dtOrdersTableDBCopy);

            ordersAdapterCommands.Dispose();
            _dtOrdersTableDBCopy.Dispose();
        }
    }
}
