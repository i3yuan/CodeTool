using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeModelTool
{
   public class SqlHelper
    {
        /// <summary>
        /// 获取所有数据库
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static List<DbTable> GetAllDataBaseName(string connection)
        {
            List<DbTable> dic = new List<DbTable>();
            string ConnString = "select name from Master.sys.SysDatabases order by name  ";
            SqlConnection connect = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(ConnString, connect);
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    dic.Clear();
                    while (dr.Read())
                    {
                        dic.Add(new DbTable { value = dr["name"].ToString(), key = dr["name"].ToString() });
                    }
                    dr.Close();

                }
            }
            catch (Exception ex)
            {
                 throw new AggregateException("获得数据库连接居然不传数据库类型，你想上天吗？");
            }
            finally
            {
                if (connect != null && connect.State == ConnectionState.Open)
                {
                    connect.Dispose();
                }
            }
            return dic;
        }

        /// <summary>
        /// 获取数据库表
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static Dictionary<string,string> GetAllTableName(string connection)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            string ConnString = "select * from sysobjects where xtype='u' order by name";
            SqlConnection connect = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(ConnString, connect);
            try
            {
                if(connect.State==ConnectionState.Closed)
                {
                    connect.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    dic.Clear();
                    while(dr.Read())
                    {
                        dic.Add(dr["name"].ToString(), dr["name"].ToString());
                    }
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                if(connect!=null&&connect.State==ConnectionState.Open)
                {
                    connect.Dispose();
                }
            }
            return dic;
        }
        /// <summary>
        /// 获取表信息
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public static List<CompleteField> GetColumnCompleteField(string connection, string TableName)
        {
            List<CompleteField> list = new List<CompleteField>();
            SqlConnection objConnetion = new SqlConnection(connection);
            try
            {
                if (objConnetion.State == ConnectionState.Closed)
                {
                    objConnetion.Open();
                }
                string sqlStr = "SELECT "
                                + "  c.name,"
                                + "  c.user_type_id,"
                                + "  c.max_length,"
                                + "  c.is_nullable,"
                                + "  remark = ex.value"
                                + "  FROM  "
                                + "     sys.columns c  "
                                + "  LEFT OUTER JOIN  "
                                + "     sys.extended_properties ex  "
                                + "  ON  "
                                + "     ex.major_id = c.object_id "
                                + "     AND ex.minor_id = c.column_id  "
                                + "     AND ex.name = 'MS_Description'  "
                                + "  WHERE  "
                                + "     OBJECTPROPERTY(c.object_id, 'IsMsShipped')=0  "
                                + "      AND OBJECT_NAME(c.object_id) = '" + TableName + "' "
                                + "  ORDER  "
                                + "     BY OBJECT_NAME(c.object_id), c.column_id";
                SqlCommand cmd = new SqlCommand(sqlStr, objConnetion);
                SqlDataReader objReader = cmd.ExecuteReader();
                while (objReader.Read())
                {
                    list.Add(new CompleteField() { name = objReader[0].ToString(), xType = objReader[1].ToString(), length = objReader[2].ToString(), isNullAble = objReader[3].ToString(), remark = (objReader[4] == null ? "" : objReader[4].ToString()) });
                }
            }
            catch (Exception)
            {

            }
            objConnetion.Close();
            return list;

        }

        public static string GetType(string xtype)
        {
            switch (xtype)
            {
                case "34": return "image";
                case "35": return "string";
                case "36": return "uniqueidentifier";
                case "48": return "tinyint";
                case "52": return "smallint";
                case "56": return "int";
                case "58": return "smalldatetime";
                case "59": return "real";
                case "60": return "money";
                case "61": return "DateTime";
                case "62": return "float";
                case "98": return "sql_variant";
                case "99": return "ntext";
                case "104": return "bool";
                case "106": return "decimal";
                case "108": return " numeric";
                case "122": return "smallmoney";
                case "127": return "bigint";
                case "165": return "varbinary";
                case "167": return "string";
                case "173": return "binary";
                case "175": return "char";
                case "189": return "timestamp";
                case "231": return "string";
                case "239": return "nchar";
                default: return "";
            }

        }
    }
    public class CompleteField
    {
        /// <summary>
        /// 字段名
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 字段类型
        /// </summary>
        public string xType { get; set; }
        /// <summary>
        /// 字段长度
        /// </summary>
        public string length { get; set; }
        /// <summary>
        /// 是否可为空
        /// </summary>
        public string isNullAble { get; set; }
        /// <summary>
        /// 字段说明备注
        /// </summary>
        public string remark { get; set; }
    }
}
