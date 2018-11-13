using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationEntityFramework
{
    public class People
    {
        private SqlConnection OpenConnection()
        {
            SqlConnection myConnection = new SqlConnection("Data Source=UTILISA-PFCSKJJ\\SQLEXPRESS;" +
            "Initial Catalog=WideWorldImporters;" +
            "Integrated Security=True");

            return myConnection;
        }

        public int PersonID { get; set; }
        public string FullName { get; set; }
        public string PreferredName { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }

        public People() { }

        public People(int personID, string fullName, string preferredName, string phoneNumber, string faxNumber, string emailAddress)
        {
            PersonID = personID;
            FullName = fullName;
            PreferredName = preferredName;
            PhoneNumber = phoneNumber;
            FaxNumber = faxNumber;
            EmailAddress = emailAddress;
        }

        public void LoadWithPeopleID(int id)
        {
            SqlConnection connection = OpenConnection();
            string Query = string.Format("select * from Application.People where PersonID = {0}", id);
            SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(Query, connection);
            DataSet peopleSet = new DataSet();
            DataRow peopleRow;

            mySqlDataAdapter.Fill(peopleSet, "Application.People");
            peopleRow = peopleSet.Tables["Application.People"].Rows[0];

            PersonID = (int)peopleRow["PersonID"];
            FullName = (string)peopleRow["fullName"];
            PreferredName = (string)peopleRow["preferredName"];
            PhoneNumber = (string)peopleRow["phoneNumber"];
            FaxNumber = (string)peopleRow["faxNumber"];
            EmailAddress = (string)peopleRow["emailAddress"];

            connection.Dispose();
        }

        public void UpdatePeople()
        {
            SqlConnection connection = OpenConnection();
            string Query = string.Format("select * from Application.People where PersonID = {0}", PersonID);
            SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(Query, connection);
            DataSet peopleSet = new DataSet();
            DataRow peopleRow;
            SqlCommandBuilder mySqlCommandBuilder = new SqlCommandBuilder(mySqlDataAdapter);

            mySqlDataAdapter.Fill(peopleSet, "Application.People");
            peopleRow = peopleSet.Tables["Application.People"].Rows[0];

            peopleRow["PersonID"] = PersonID;
            peopleRow["fullName"] = FullName;
            peopleRow["preferredName"] = PreferredName;
            peopleRow["phoneNumber"] = PhoneNumber;
            peopleRow["faxNumber"] = FaxNumber;
            peopleRow["emailAddress"] = EmailAddress;
            mySqlDataAdapter.Update(peopleSet, "Application.People");

            connection.Dispose();
        }

        public override string ToString()
        {
            return string.Format("{0}; {1}; {2}; {3}; {4}; {5}", PersonID, FullName, PreferredName, PhoneNumber, FaxNumber, EmailAddress);
        }
    }
}
