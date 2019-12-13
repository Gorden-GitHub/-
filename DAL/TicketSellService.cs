using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelmgt.DAL
{
    public class TicketSellService
    {
        #region 添加餐票销售信息
        /// <summary>
        /// 添加餐票销售信息
        /// </summary>
        /// <param name="Time"></param>
        /// <param name="RNumber"></param>
        /// <param name="Type"></param>
        /// <param name="Price"></param>
        /// <param name="TNumber"></param>
        /// <param name="Total"></param>
        /// <returns></returns>
        public static int AddTicketSell(string Time, string RNumber, string Type, string Price, string TNumber, string Total)
        {
            string sql = "INSERT INTO ticket_sell_information";
            sql += " values('" + Time + "','" + RNumber + "','" + Type + "','" + Price + "','" + TNumber + "','" + Total + "') ";
            MySqlConnection con = DBHelper.GetConnection();
            con.Open();
            int flag = DBHelper.ExecuteNonQuery(sql);
            DBHelper.Closecon();
            return flag;
        }
        #endregion
    }
}
