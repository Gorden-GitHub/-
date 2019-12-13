using hotelmgt.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelmgt.BLL
{
    public class TicketSellManager
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
        public static bool AddTicketSell(string Time, string RNumber, string Type, string Price, string TNumber, string Total)
        {
            int flag = TicketSellService.AddTicketSell(Time, RNumber, Type, Price, TNumber, Total);
            if (flag == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
