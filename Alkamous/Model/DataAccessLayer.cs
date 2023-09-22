using Alkamous.Controller;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Alkamous.Model
{
    public class DataAccessLayer
    {
        #region Declare variables ( SqlConnection, SqlCommand,DataTable)
        SqlConnection sqlcon = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        private readonly string _serverName = Properties.Settings.Default.ServerName;
        private readonly string _database = Properties.Settings.Default.Database;
        private readonly string _userId = Properties.Settings.Default.Userid;
        private readonly string _password = Properties.Settings.Default.password;

        #endregion

        #region Connection String this constructor initialize the connection object
        // this constructor initialize the connection object
        public DataAccessLayer()
        {
            SqlConnectionStringBuilder sqlConnectionString = new SqlConnectionStringBuilder
            {
                DataSource = _serverName,
                InitialCatalog = _database,
                UserID = _userId,
                Password = _password
            };

            sqlcon = new SqlConnection(sqlConnectionString.ConnectionString);

            cmd.Connection = sqlcon;
            cmd.CommandType = CommandType.StoredProcedure;


        }
        #endregion

        #region method to Open connection 
        private void OpenCN()
        {
            if (sqlcon.State != ConnectionState.Open)
                sqlcon.Open();
        }
        #endregion

        #region method to Close connection 
        private void CloseCN()
        {
            if (sqlcon.State == ConnectionState.Open)
                sqlcon.Close();

        }

        #endregion

        #region Method To Method To ADD Delelte Update By StordProseder
        public int RunProcedure(string StoredProcedureName, SortedList ParVal)
        {
            try
            {
                cmd.CommandText = StoredProcedureName;
                cmd.Parameters.Clear();

                for (int I = 0; I < ParVal.Count; I++)
                    cmd.Parameters.AddWithValue(ParVal.GetKey(I).ToString(), ParVal.GetByIndex(I));

                OpenCN();
                int rRusult = cmd.ExecuteNonQuery();
                CloseCN();
                return rRusult;


            }
            catch (SqlException ex)
            {
                CloseCN();

                Chelp.WriteErrorLog("Error in RunProcedure: " + ex.Message);
                return ex.Number;
            }

        }
        #endregion

        #region Method To Method To ADD Delelte Update List<SortedList> By StordProseder
        public int RunProcedureBulk(string StoredProcedureName, List<SortedList> parameterValues)
        {
            try
            {

                int totalRowsAffected = 0;
                cmd.CommandText = StoredProcedureName;

                OpenCN();

                foreach (SortedList parameterList in parameterValues)
                {
                    cmd.Parameters.Clear();
                    for (int i = 0; i < parameterList.Count; i++)
                    {
                        cmd.Parameters.AddWithValue(parameterList.GetKey(i).ToString(), parameterList.GetByIndex(i));
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();
                    totalRowsAffected += rowsAffected;
                }

                CloseCN();
                return totalRowsAffected;
            }
            catch (SqlException ex)
            {
                CloseCN();
                Chelp.WriteErrorLog("Error in RunProcedure Bulk: " + ex.Message);
                return ex.Number;
            }
            finally
            {
                CloseCN();
            }
        }
        #endregion

        #region SelectDB and Read Data By StordProseder
        public DataTable SelectDB(string StoredProcedureName, SortedList ParVal)
        {
            try
            {

                cmd.CommandText = StoredProcedureName;
                cmd.Parameters.Clear();
                for (int I = 0; I < ParVal.Count; I++)
                    cmd.Parameters.AddWithValue(ParVal.GetKey(I).ToString(), ParVal.GetByIndex(I));
                OpenCN();
                using (var dt = new DataTable())
                {
                    using (var reader = cmd.ExecuteReader())
                        dt.Load(reader);

                    CloseCN();
                    return dt;
                }


            }
            catch (SqlException ex)
            {
                CloseCN();
                Chelp.WriteErrorLog("Error in SelectDB: " + ex.Message);
                return null;
            }
        }
        #endregion
    }
}
