using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationEntityFramework
{
    class Program
    {
        public static void Main(string[] args)
        {
            People people = new People();
            people.LoadWithPeopleID(10);
            Console.WriteLine(people.ToString());
            people.FullName = "John";
            people.UpdatePeople();
            people.LoadWithPeopleID(10);
            Console.WriteLine(people.ToString());
            Console.ReadKey();

            CustomerCategories customerCategories = new CustomerCategories();
            customerCategories.LoadWithCustomerCategoryID(8);
            Console.WriteLine(customerCategories.ToString());
            customerCategories.CustomerCategoryName = "Retailer";
            customerCategories.UpdatecustomerCategories();
            customerCategories.LoadWithCustomerCategoryID(10);
            Console.WriteLine(customerCategories.ToString());
            Console.ReadKey();
        }
    }
}

//modification apportes sur l'id = 11 dans la table Application.People
//
//string Query = string.Format("select * from Application.People where PersonID = 11");
//SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(Query, myConnection);
//DataSet myDataSet = new DataSet();
//DataRow myDataRow;
//SqlCommandBuilder mySqlCommandBuilder = new SqlCommandBuilder(mySqlDataAdapter);
//
//mySqlDataAdapter.Fill(myDataSet, "Application.People");
//myDataRow = myDataSet.Tables["Application.People"].Rows[0];
//myDataRow["FullName"] = "Michel Henri";
//myDataRow["PreferredName"] = "Michel";
//myDataRow["PhoneNumber"] = "(420) 666-0608";
//myDataRow["FaxNumber"] = "(420) 666-0507";
//myDataRow["EmailAddress"] = "michel@wideworldimporters.com";
//mySqlDataAdapter.Update(myDataSet, "Application.People");

//modification apportés sur l'id = 8 dans la table Sales.CustomerCategories
//
//string Query2 = string.Format("select * from Sales.CustomerCategories where CustomerCategoryID = 8");
//SqlDataAdapter mySqlDataAdapter2 = new SqlDataAdapter(Query2, myConnection);
//DataSet myDataSet2 = new DataSet();
//DataRow myDataRow2;
//SqlCommandBuilder mySqlCommandBuilder2 = new SqlCommandBuilder(mySqlDataAdapter2);
//
//mySqlDataAdapter2.Fill(myDataSet2, "Sales.CustomerCategories");
//myDataRow2 = myDataSet2.Tables["Sales.CustomerCategories"].Rows[0];
//myDataRow2["CustomerCategoryName"] = "General Retailer";
//mySqlDataAdapter2.Update(myDataSet2, "Sales.CustomerCategories");

//affichage de la ligne id = 10 dans la table Sales.InvoiceLines
//
//string Query3 = string.Format("select * from Sales.InvoiceLines where InvoiceLineID = 10");
//SqlDataAdapter mySqlDataAdapter3 = new SqlDataAdapter(Query3, myConnection);
//DataSet myDataSet3 = new DataSet();
//DataRow myDataRow3;
//SqlCommandBuilder mySqlCommandBuilder3 = new SqlCommandBuilder(mySqlDataAdapter3);
//
//mySqlDataAdapter3.Fill(myDataSet3, "Sales.InvoiceLines");
//myDataRow3 = myDataSet3.Tables["Sales.InvoiceLines"].Rows[0];
//Console.WriteLine("Description : " + myDataRow3["Description"]);
//Console.WriteLine("Quantity : " + myDataRow3["Quantity"]);
//Console.WriteLine("UnitPrice : " + myDataRow3["UnitPrice"]);
//Console.WriteLine("TaxRate : " + myDataRow3["TaxRate"]);
//Console.WriteLine("TaxAmount : " + myDataRow3["TaxAmount"]);
//Console.WriteLine("LineProfit : " + myDataRow3["LineProfit"]);
//Console.WriteLine("ExtendedPrice : " + myDataRow3["ExtendedPrice"]);
//Console.Read();

//myConnection.Dispose();
