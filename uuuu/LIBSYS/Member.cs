using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;



namespace LIBSYS
{
    class Member
    //instance variables
    {
        private int member_id;
        private string foreName;
        private string surName;
        private string dateOfBirth;
        private string street;
        private string town;
        private string county;
        private string email;
        private string phone_No;
        private char member_Status;
    
    public Member()
    {
        member_id = 0;
        surName = " ";
        foreName = " ";
        dateOfBirth = " ";
        street = " ";
        town = " ";
        county = " ";
        email = " ";
        phone_No = " ";
    }
    public Member(int Member_id, string SurName, string ForeName, string DateOfBirth, string Street, string Town, string County, string Email, string Phone_No)
    {
        member_id = Member_id;
        surName = SurName;
        foreName = ForeName;
        dateOfBirth = DateOfBirth;
        street = Street;
        town = Town;
        county = County;
        email = Email;
        phone_No = Phone_No;

    }
        public int getMember_id()
        {
            return this.member_id;
        }
        public string getSurname()
        {
            return this.surName;
        }
        public string getForeName()
        {
            return this.foreName;
        }
        public string getDateOfBirth()
        {
            return this.dateOfBirth;
        }
        public string getStreet()
        {
            return this.street;
        }
        public string getTown()
        {
            return this.town;
        }
        public string getCounty()
        {
            return this.county;
        }
        public string getEmail()
        {
            return this.email;
        }
        public string getPhoneNo()
        {
            return this.phone_No;
        }
        public DataSet getMember(DataSet ds)
        {
            // Connect to DB
            OracleConnection conn = new OracleConnection(DBconnect.oradb);
            conn.Open();

            //Def sql Query

            String strSQL = "SELECT member_id, surname ,forename From Member Order BY member_id";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Ex Query

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "Pat");


            conn.Close();
            return ds;
        }
        public static DataSet getMember(DataSet ds, String srhString)
        {

            //Create database connection string

            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);


            //Define SQL query
            String strSQL = "SELECT * FROM Member WHERE surName LIKE '" + srhString + "%'";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //create OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "Member");

            //Close DB
            myConn.Close();

            return ds;
        }
        public void getMember(int book_id)
        {

            // get data for selected stock

            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Member WHERE member_id = " + book_id;

            //Execute SQL Query 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            OracleDataReader dr = cmd.ExecuteReader();

            //if there are rows in the datareader
            if (dr.Read())
            {
                //instantiate object instance variables
                this.member_id = dr.GetInt32(0);
                this.surName = dr.GetString(1);
                this.foreName = dr.GetString(2);
                this.dateOfBirth = dr.GetString(3);
                this.street = dr.GetString(4);
                this.town = dr.GetString(5);
                this.county = dr.GetString(6);
                this.email = dr.GetString(7);
                this.phone_No = dr.GetString(8);

                myConn.Close();
            }

        }
        public static int nextMemberId()
        {
            //variables to hold value to be returned
            int nextMemberId;

            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

            //Define the SQL query to get MAX stock_No used
            String strSQL = "SELECT MAX(STOCK_NO) from MEMBER";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //read the first(only) value returned by query
            //If first stockNo, assignm value 1, otherwise add 1 to MAX value
            dr.Read();

            if (dr.IsDBNull(0))
                nextMemberId = 1;
            else
                nextMemberId = Convert.ToInt32(dr.GetValue(0)) + 1;

            //close DB Connection
            myConn.Close();

            //return next StockNo
            return nextMemberId;
        }
        public void regMem()
        {
            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

            //Define SQL Query
            String strSQL = "INSERT INTO STOCK VALUES(" + this.member_id + ",'" + this.surName + "'," + this.foreName + ",'" + this.dateOfBirth + "'," + this.street + ",'" + this.town + "')";

            //Execute SQL Query 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //Close DB
            myConn.Close();
        }


    }
}






