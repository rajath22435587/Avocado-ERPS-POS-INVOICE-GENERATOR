using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Avocado_ERPS_POS_INVOICE_GENERATOR
{
    class DBclient
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string sslmode;

        //Constructor
        public DBclient()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "avacado";
            uid = "root";
            password = "";
            sslmode = "none";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "SslMode=" + sslmode + ";";
            connection = new MySqlConnection(connectionString);
        }

        public bool CheckConnection()
        {
            return OpenConnection();
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert()
        {
            string query = "INSERT INTO login_credentials (Username, Password, RemeberMe, JobAssigned_1, JobAssigned_1, JobAssigned_1,Admin, LastLogin, uid) VALUES('John Smith', '33')";
            ///Values yet to be done!!!

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
        }

        //Count statement
        public int Count()
        {
            return 1;
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }

        public bool DoLogin(string username, String Password)
        {
            if (OpenConnection())
            {
                int i = 0;
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from login_credentials Where Username = '"+username +"' and Password = '"+Password+"'";
                cmd.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dtbl);
                i = Convert.ToInt32(dtbl.Rows.Count.ToString());
                  
                if (i == 0)
                {
                    MessageBox.Show("Incorrect Password and Username");
                    CloseConnection();
                    return false;
                }
                else
                {
                    CloseConnection();
                    return true;
                }
                
                
            }
            return false;

        }
    }

}

