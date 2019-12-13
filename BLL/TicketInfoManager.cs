using hotelmgt.DAL;
using hotelmgt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelmgt.BLL
{
    public class TicketInfoManager
    {
        public static List<TicketInfo> SelectTicketAll()
        {
            return TicketInfoService.SelectTicketAll();
        }
        #region 根据餐票类型删除餐费信息
        /// <summary>
        /// 根据餐票类型删除餐费信息
        /// </summary>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool DeleteMemberByName(string Type)
        {
            int flag = TicketInfoService.DeleteTicketByType(Type);
            if (flag == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region 添加餐费信息
        /// <summary>
        /// 添加餐费信息
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Price"></param>
        /// <returns></returns>
        public static bool AddTicket(string Type, string Price)
        {
            int flag = TicketInfoService.AddTicket(Type, Price);
            if (flag == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
