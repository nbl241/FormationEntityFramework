using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationEntityFramework
{
    public class CustomerCategories
    {
        private SqlConnection OpenConnection()
        {
            SqlConnection myConnection = new SqlConnection("Data Source=UTILISA-PFCSKJJ\\SQLEXPRESS;" +
            "Initial Catalog=WideWorldImporters;" +
            "Integrated Security=True");

            return myConnection;
        }

        public int CustomerCategoryID { get; set; }
        public string CustomerCategoryName { get; set; }

        public CustomerCategories(int customerCategoryID, string customerCategoryNAme)
        {
            CustomerCategoryID = customerCategoryID;
            CustomerCategoryName = customerCategoryNAme;
        }

        public CustomerCategories() { }

        public void LoadWithCustomerCategoryID(int id)
        {
            SqlConnection connection = OpenConnection();
            string Query = string.Format("select * from Sales.CustomerCategories where CustomerCategoryID = {0}", id);
            SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(Query, connection);
            DataSet CustomerCategoriesSet = new DataSet();
            DataRow CustomerCategoriesRow;

            mySqlDataAdapter.Fill(CustomerCategoriesSet, "Sales.CustomerCategories");
            CustomerCategoriesRow = CustomerCategoriesSet.Tables["Sales.CustomerCategories"].Rows[0];

            CustomerCategoryID = (int)CustomerCategoriesRow["CustomerCategoryID"];
            CustomerCategoryName = (string)CustomerCategoriesRow["CustomerCategoryName"];

            connection.Dispose();
        }

        public void UpdatecustomerCategories()
        {
            SqlConnection connection = OpenConnection();
            string Query = string.Format("select * from Sales.CustomerCategories where CustomerCategoryID = {0}", id);
            SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(Query, connection);
            DataSet CustomerCategoriesSet = new DataSet();
            DataRow CustomerCategoriesRow;
            SqlCommandBuilder mySqlCommandBuilder = new SqlCommandBuilder(mySqlDataAdapter);

            mySqlDataAdapter.Fill(CustomerCategoriesSet, "Sales.CustomerCategories");
            CustomerCategoriesRow = CustomerCategoriesSet.Tables["Sales.CustomerCategories"].Rows[0];

            CustomerCategoryID = (int)CustomerCategoriesRow["CustomerCategoryID"];
            CustomerCategoryName = (string)CustomerCategoriesRow["CustomerCategoryName"];

            connection.Dispose();
        }

        public override string ToString()
        {
            return string.Format("{0}; {1}", CustomerCategoryID, CustomerCategoryName);
        }
    }
}
