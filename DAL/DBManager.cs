using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DAL
{
    public class DBManager
    {
        SqlConnection sqlCn;
        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable Dt;

        public DBManager()
        {
            try
            {
                sqlCn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString());


                sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Connection = sqlCn;

                DA = new SqlDataAdapter(sqlCmd);

                Dt = new DataTable();
            }
            catch
            {
                Debug.WriteLine(" Error Constractor : DBManager : ERROR ConnectionStrings");
            }
        }
           

        

        public int ExecuteNonQuery(string SpName)
        {
            int R = -1;
            try
            {
                if (sqlCn?.State == ConnectionState.Closed)
                {
                    sqlCn.Open();

                    sqlCmd.CommandText = SpName;
                    sqlCmd.Parameters.Clear();

                    R = sqlCmd.ExecuteNonQuery();

                    sqlCn.Close();
                }
            }
            catch
            {
                Debug.WriteLine(" Error 35 : DBManager");
            }
            return R;
        }

        public object ExecuteScaler(string SpName)
        {
            object R = new object();
            try
            {
                if (sqlCn?.State == ConnectionState.Closed)
                {
                    sqlCn.Open();

                    sqlCmd.CommandText = SpName;
                    sqlCmd.Parameters.Clear();

                    R = sqlCmd.ExecuteScalar();

                    sqlCn.Close();
                }
            }
            catch
            {
                Debug.WriteLine(" Error 59 : DBManager");
            }
            return R;
        }

        public DataTable ExecuteDataTable(string SpName)
        {
            Dt.Clear();
            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = SpName;

                DA.Fill(Dt);
            }
            catch
            {
                Debug.WriteLine(" Error 83 : DBManager");
            }
            return Dt;
        }

        public int ExecuteNonQuery(string SpName, Dictionary<string, Object> ParamLst)
        {
            int R = -1;
            try
            {
                if ((sqlCn?.State == ConnectionState.Closed) && (ParamLst?.Count > 0))
                {
                    sqlCn.Open();

                    sqlCmd.CommandText = SpName;
                    sqlCmd.Parameters.Clear();
                    foreach (KeyValuePair<string, object> item in ParamLst)
                    {
                        sqlCmd.Parameters.AddWithValue(item.Key, item.Value);
                    }

                    R = sqlCmd.ExecuteNonQuery();

                    sqlCn.Close();
                }
            }
            catch
            {
                Debug.WriteLine(" Error 100 : DBManager");
            }
            return R;
        }

        public object ExecuteScaler(string SpName, Dictionary<string, Object> ParamLst)
        {
            object R = new object();
            try
            {
                if ((sqlCn?.State == ConnectionState.Closed) && (ParamLst?.Count > 0))
                {
                    sqlCn.Open();

                    sqlCmd.CommandText = SpName;
                    sqlCmd.Parameters.Clear();
                    foreach (KeyValuePair<string, object> item in ParamLst)
                    {
                        sqlCmd.Parameters.AddWithValue(item.Key, item.Value);
                    }

                    R = sqlCmd.ExecuteNonQuery();

                    sqlCn.Close();
                }
            }
            catch
            {
                Debug.WriteLine(" Error 128 : DBManager");
            }
            return R;
        }

        public DataTable ExecuteDataTable(string SpName, Dictionary<string, Object> ParamLst)
        {
            Dt.Clear();
            try
            {
                sqlCmd.Parameters.Clear();
                foreach (KeyValuePair<string, object> item in ParamLst)
                {
                    sqlCmd.Parameters.AddWithValue(item.Key, item.Value);
                }

                DA.Fill(Dt);
            }
            catch
            {
                Debug.WriteLine(" Error 156 : DBManager");
            }
            return Dt;
        }
    }
}
