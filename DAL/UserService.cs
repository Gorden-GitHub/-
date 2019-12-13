using hotelmgt.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelmgt.DAL
{
    public class UserService
    {
        #region 根据登录名称查询员工信息
        /// <summary>
        /// 根据登录名称查询员工信息
        /// </summary>
        /// <param name="Username"></param>
        /// <returns></returns>
        public static User SelectUserInfoByUsername(string Username)
        {
            User u = null;
            string sql = "select * from system_user_information where Username='" + Username + "'";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                u = new User();
                u.Username = (string)dr["Username"];
                u.Password = (string)dr["Password"];
            }
            dr.Close();
            DBHelper.Closecon();
            return u;
        }
        #endregion

        #region 根据登录名称、密码查询员工信息
        /// <summary>
        /// 根据登录名称、密码查询员工信息
        /// </summary>
        /// <param name="Username"></param>
        /// 登录名称
        /// <param name="Password"></param>
        /// 登录密码
        /// <returns></returns>
        public static User SelectUserInfoByUsernameAndPassword(string Username, string Password)
        {
            User u = null;
            string sql = "select * from system_user_information where  Username='{0}' and Password='{1}'";
            sql = string.Format(sql, Username, Password);
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                u = new User();
                u.Username = (string)dr["Username"];
                u.Password = (string)dr["Password"];
            }
            dr.Close();
            DBHelper.Closecon();
            return u;
        }
        #endregion
    }
}
