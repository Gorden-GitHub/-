using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelmgr
{
    public class MySQLHelper
    {
        private static MySQLHelper mInstance = null;

        private static String mConnStr = null;

        private MySQLHelper()
        { 
        }

        public static MySQLHelper GetInstance()
        {
            if (mInstance == null)
            {
                mInstance = new MySQLHelper();
            }
            mConnStr = "server=" + "localhost" + ";port=" + "3306" +
                ";user=" + "root" + ";password=" + "gorden51" +
                ";database=" + "hotelmgr" + ";CharSet=utf8";
            return mInstance;
        }

        /// <summary>
        /// 查询返回DataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(String sql)
        {
            try
            {
                //创建一个MySqlConnection对象
                using (MySqlConnection connection = new MySqlConnection(mConnStr))
                {
                    connection.Open();
                    MySqlTransaction transaction = connection.BeginTransaction();

                    //创建一个MySqlCommand对象
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        try
                        {
                            PrepareCommand(cmd, connection, transaction, CommandType.Text, sql, null);

                            MySqlDataAdapter adapter = new MySqlDataAdapter();
                            adapter.SelectCommand = cmd;
                            DataTable dt = new DataTable();

                            adapter.Fill(dt);

                            transaction.Commit();

                            //清除参数
                            cmd.Parameters.Clear();
                            return dt;

                        }
                        catch (MySqlException e1)
                        {
                            try
                            {
                                transaction.Rollback();
                            }
                            catch (Exception e2)
                            {
                                throw e2;
                            }

                            throw e1;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 准备执行一个命令
        /// </summary>
        /// <param name="cmd">sql命令</param>
        /// <param name="conn">OleDb连接</param>
        /// <param name="trans">OleDb事务</param>
        /// <param name="cmdType">命令类型例如 存储过程或者文本</param>
        /// <param name="cmdText">命令文本,例如:Select * from Products</param>
        /// <param name="cmdParms">执行命令的参数</param>
        private void PrepareCommand(MySqlCommand cmd, MySqlConnection conn, MySqlTransaction trans, CommandType cmdType, string cmdText, MySqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            if (trans != null)
                cmd.Transaction = trans;

            cmd.CommandType = cmdType;

            if (cmdParms != null)
            {
                foreach (MySqlParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }
    }


}
