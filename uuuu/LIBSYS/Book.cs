using System;
using System.Data;


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace LIBSYS
{
    class Book
    {
        private int book_id;
        private string title;
        private string isbn;
        private string author;
        private string genre;
        private char status;
        public Book()
         {
            book_id = 0;
            title = " ";
            author = " ";
            isbn = " ";
            genre = " ";
            status = ' ';
        }

        public Book(int Book_id, string Title , string Author ,string Isbn , string Genre)
        {
            book_id = Book_id;
            title = Title;
            isbn = Isbn;
            author = Author;
            genre = Genre;
            status = 'A';
        }
        public string getTitle()
        {
            return this.title;
        }
        public string getAuthor()
        {
            return this.author;
        }
        public string getGenre()
        {
            return this.genre;
        }
        public int getBook_id()
        {
            return this.book_id;
        }
        public string getIsbn()
        {
            return this.isbn;
        }
        public DataSet getBook(System.Data.DataSet ds)
        {
            OracleConnection conn = new OracleConnection(DBconnect.oradb);
            conn.Open();

            //Define sql Query

            String strSQL = "SELECT title, author From BOOKS";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "Pat");

            conn.Close();
            return ds;
        }
        public static DataSet getBook(System.Data.DataSet ds, String srhString)
        {

            //Create database connection string

            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);


            //Define SQL query
            String strSQL = "SELECT * FROM BOOKS WHERE Title LIKE '" + srhString + "%'";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //create OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "BOOKS");

            //Close DB
            myConn.Close();

            return ds;
        }
        public void getBook(int book_id)
        {
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();


            String strSQL = "SELECT * FROM BOOKS WHERE book_id = " + book_id;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //instantiate object instance variables
                this.book_id = dr.GetInt32(0);
                this.title = dr.GetString(2);
                this.author = dr.GetString(1);
                this.genre = dr.GetString(3);
                this.isbn = dr.GetString(4);

                myConn.Close();
            }


        }
        public static int nextBookId()
        {
            int nextBookId;

            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

            //Define the SQL query to get MAX book_id used
            String strSQL = "SELECT MAX(BOOK_ID) from BOOKS";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextBookId = 1;
            else
                nextBookId = Convert.ToInt32(dr.GetValue(0)) + 1;

            myConn.Close();

            //return next StockNo
            return nextBookId;
        }
        public void regBook()
        {
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

            String strSQL = "INSERT INTO BOOKS VALUES(" + this.book_id + ",'" + this.title + "','" + this.author + "','" + this.isbn + "','" + this.genre + "','" + this.status + "')";
          

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //Close DB
            myConn.Close();
        }


    }

}
