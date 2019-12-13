using hotelmgt.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelmgt.DAL
{
    public class MemberService
    {
        public static List<Member> SelectMemberAll()
        {
            List<Member> members = new List<Member>();
            string sql = "select * from member_information";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Member member = new Member();
                member.Member_Name = (string)dr["Name"];
                member.Member_Phone = (string)dr["Phone_Number"];
                member.Member_RTime = Convert.ToDateTime(dr["RTime"]).ToString("yyyy.MM.dd");
                members.Add(member);
            }
            dr.Close();
            DBHelper.Closecon();
            return members;
        }
        #region 根据会员姓名查询会员信息
        /// <summary>
        /// 根据会员姓名查询会员信息
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static Member SelectMemberByName(string Name)
        {
            Member member = null;
            MySqlConnection con = DBHelper.GetConnection();
            con.Open();
            MySqlDataReader dr = DBHelper.ExecuteReader("select * from member_information where Name='" + Name + "'");
            if (dr.Read())
            {
                member = new Member();
                member.Member_Name = (String)dr["Name"];
                member.Member_Phone = (String)dr["Phone_Number"];
                member.Member_RTime = Convert.ToDateTime(dr["RTime"]).ToString("yyyy.MM.dd");
            }
            dr.Close();
            DBHelper.Closecon();
            return member;
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
            Member member = null;
            MySqlConnection con = DBHelper.GetConnection();
            con.Open();
            MySqlDataReader dr = DBHelper.ExecuteReader("select * from member_information where Phone_Number='" + Phone + "'");
            if (dr.Read())
            {
                member = new Member();
                member.Member_Name = (String)dr["Name"];
                member.Member_Phone = (String)dr["Phone_Number"];
                member.Member_RTime = Convert.ToDateTime(dr["RTime"]).ToString("yyyy.MM.dd");
            }
            dr.Close();
            DBHelper.Closecon();
            return member;
        }
        #endregion
        #region 根据会员姓名删除会员信息
        /// <summary>
        /// 根据会员姓名删除会员信息
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static int DeleteMemberByName(string Name)
        {
            MySqlConnection con = DBHelper.GetConnection();
            con.Open();
            int flag = DBHelper.ExecuteNonQuery("delete from member_information where Name='" + Name + "'");
            DBHelper.Closecon();
            return flag;
        }
        #endregion
        #region 添加会员信息
        /// <summary>
        /// 添加会员信息
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Phone"></param>
        /// <returns></returns>
        public static int AddMember(string Name, string Phone)
        {
            string sql = "INSERT INTO member_information";
            sql += " values('" + Phone + "','" + Name + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "') ";
            MySqlConnection con = DBHelper.GetConnection();
            con.Open();
            int flag = DBHelper.ExecuteNonQuery(sql);
            DBHelper.Closecon();
            return flag;
        }
        #endregion
    }
}
