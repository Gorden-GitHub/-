using hotelmgt.DAL;
using hotelmgt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelmgt.BLL
{
    public class UserManager
    {
        #region 根据登录名称查询员工信息
        /// <summary>
        /// 根据登录名称查询员工信息
        /// </summary>
        /// <param name="Username"></param>
        /// <returns></returns>
        public static User SelectUserInfoByUsername(string Username)
        {
            return UserService.SelectUserInfoByUsername(Username);
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
            return UserService.SelectUserInfoByUsernameAndPassword(Username, Password);
        }
        #endregion
    }
}

