using hotelmgt.DAL;
using hotelmgt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelmgt.BLL
{
    public class MemberManager
    {
        public static List<Member> SelectMemberAll()
        {
            return MemberService.SelectMemberAll();
        }

        #region 根据会员姓名查询会员信息
        /// <summary>
        /// 根据会员姓名查询会员信息
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static Member SelectMemberByName(string Name)
        {
            return MemberService.SelectMemberByName(Name);
        }
        #endregion
        #region 根据会员手机号码查询会员信息
        /// <summary>
        /// 根据会员手机号码查询会员信息
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static Member SelectMemberByPhone(string Phone)
        {
            return MemberService.SelectMemberByPhone(Phone);
        }
        #endregion
        #region 根据会员姓名删除会员信息
        /// <summary>
        /// 根据会员姓名删除会员信息
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static bool DeleteMemberByName(string Name)
        {
            int flag = MemberService.DeleteMemberByName(Name);
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
        #region 添加会员信息
        /// <summary>
        /// 添加会员信息
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Phone"></param>
        /// <returns></returns>
        public static bool AddMember(string Name, string Phone)
        {
            int flag = MemberService.AddMember(Name, Phone);
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
