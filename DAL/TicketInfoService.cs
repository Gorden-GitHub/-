using hotelmgt.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelmgt.DAL
{
    public class TicketInfoService
    {
        public static List<TicketInfo> SelectTicketAll()
        {
            List<TicketInfo> tickets = new List<TicketInfo>();
            string sql = "select * from ticket_information";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                TicketInfo ticket = new TicketInfo();
                ticket.Ticket_Type = (string)dr["Ticket_Type"];
                ticket.Ticket_Price = (string)dr["Ticket_Price"];
                tickets.Add(ticket);
            }
            dr.Close();
            DBHelper.Closecon();
            return tickets;
        }
        #region 根据餐票类型删除餐费信息
        /// <summary>
        /// 根据餐票类型删除餐费信息
        /// </summary>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static int DeleteTicketByType(string Type)
        {
            MySqlConnection con = DBHelper.GetConnection();
            con.Open();
            int flag = DBHelper.ExecuteNonQuery("delete from ticket_information where Ticket_Type='" + Type + "'");
            DBHelper.Closecon();
            return flag;
        }
        #endregion
        #region 添加餐费信息
        /// <summary>
        /// 添加餐费信息
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Price"></param>
        /// <returns></returns>
        public static int AddTicket(string Type, string Price)
        {
            string sql = "INSERT INTO ticket_information";
            sql += " values('" + Type + "','" + Price + "') ";
            MySqlConnection con = DBHelper.GetConnection();
            con.Open();
            int flag = DBHelper.ExecuteNonQuery(sql);
            DBHelper.Closecon();
            return flag;
        }
        #endregion
    }
}
