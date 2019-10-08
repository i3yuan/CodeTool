using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeModelTool
{
    public partial class CodeTool : Form
    {
        static string conn = "";
        public CodeTool()
        {
            InitializeComponent();
        }

        private void init()
        {
            string strXmlPath = "Config.xml";
           // txt_SQL.Text = XmlHelper.GetXmlFileValue(strXmlPath, "DataBase");
          //  conn = txt_SQL.Text;
            Dictionary<string, string> tables = SqlHelper.GetAllTableName(conn);
            lb_Tables.DataSource = new BindingSource(tables, null);
            lb_Tables.DisplayMember = "key";
            lb_Tables.DisplayMember = "value";

        }

        private void btn_SqlCon_Click(object sender, EventArgs e)
        {
            string strXmlPath = "Config.xml";
         //   XmlHelper.SetXmlFileValue(strXmlPath, "DataBase", txt_SQL.Text);
            MessageBox.Show("修改成功，重新载入");

        }

        private void CodeTool_Load(object sender, EventArgs e)
        {
           // init();
        }

        private void lb_Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var li = DataBaseBox.SelectedItem;
                DbTable list = li as DbTable;
                string key = list.key;
                string value = list.value;
                if (key != "0" && key != "")
                {
                    string conn = string.Format("Integrated Security=false;Data Source={0};User ID={1};Password={2};Initial Catalog={3};Connect Timeout=30", LocalName.Text.Trim(), UserName.Text.Trim(), PassWord.Text.Trim(), value);
                    OutputCode(conn);
                }
            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// 输出代码
        /// </summary>
        private void OutputCode(string conn)
        {
            string tableName = lb_Tables.Text;
            ///获取model
            txt_Model.Text = GetModel(conn,tableName);
        }

        private void OutputTabels()
        {
            var li = DataBaseBox.SelectedItem;
            DbTable list=li as  DbTable;
            string key = list.key;
            string value = list.value;
            if(key != "0"&& key != "")
            {
                string conn = string.Format("Integrated Security=false;Data Source={0};User ID={1};Password={2};Initial Catalog={3};Connect Timeout=30", LocalName.Text.Trim(), UserName.Text.Trim(), PassWord.Text.Trim(), value);
                Dictionary<string, string> tables = SqlHelper.GetAllTableName(conn);
                lb_Tables.DataSource = new BindingSource(tables, null);
                lb_Tables.DisplayMember = "key";
                lb_Tables.DisplayMember = "value";
            }
        }

        /// <summary>
        /// 获取实体类
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public string GetModel(string conn,string tableName)
        {
           // string leftStr = GetLeftStr(tableName);
            List<CompleteField> fields = SqlHelper.GetColumnCompleteField(conn, tableName);
            StringBuilder sb = new StringBuilder();
            sb.Append("using System;\r\n");
            sb.Append("using SysTem.CommponentModel.DataAnnotations;\r\n");
            sb.Append("using " + txt_prefix.Text + ".Models;\r\n");
            sb.Append("namespace " + txt_prefix.Text + ".Models\r\n");
            sb.Append("{\r\n");
            sb.Append("    public partial class " + tableName + "Model\r\n");
            sb.Append("    {\r\n");
            foreach (CompleteField field in fields)
            {
                sb.Append("        /// <summary>\r\n");
                sb.Append("        ///  " + field.remark + "\r\n");
                sb.Append("        /// <summary>\r\n");
                sb.Append("        public " + SqlHelper.GetType(field.xType) + " " + field.name + " { get; set; }\r\n");
                sb.Append("\r\n");
            }
            sb.Append("     }\r\n");
            sb.Append("}\r\n");
            return sb.ToString();
        }
        /// <summary>
        /// 获取表明前缀
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public string GetLeftStr(string tableName)
        {
            string nameSpace = "";
            if (tableName.IndexOf("_") > 0)
            {
                nameSpace = tableName.Substring(0, tableName.IndexOf("_"));
            }
            else
            {
                // nameSpace = "Sys";
                nameSpace = tableName;
            }
            return nameSpace;
        }

        private void SelectPlaceButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "浏览文件夹";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK || folderBrowserDialog.ShowDialog() == DialogResult.Yes)
            {
                textPlace.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private readonly string Delimiter = "\\";//分隔符，默认为windows下的\\分隔符
        private void button1_Click(object sender, EventArgs e)
        {
            if(lb_Tables.Items.Count==0)
            {
                MessageBox.Show("请先连接数据库或选择数据库!");
                return;
            }
            if(txt_prefix.Text.Trim()=="")
            {
                MessageBox.Show("命名空间不能为空!");
                return;
            }
            if (textPlace.Text != "")
            {
                Regex regex = new Regex(@"^([a-zA-Z]:\\)?[^\/\:\*\?\""\<\>\|\,]*$");
                Match m = regex.Match(textPlace.Text);
                if (!m.Success)
                {
                    MessageBox.Show("非法的文件保存路径，请重新选择或输入！");
                    return;
                }
            }
            else
            {
                MessageBox.Show("不指定生成路径，你咋不上天呢!");
                return;
            }

            if (radioAllTables.Checked)
            {
                // string strXmlPath = "Config.xml";
                //   txt_SQL.Text = XmlHelper.GetXmlFileValue(strXmlPath, "DataBase");
                //   conn = txt_SQL.Text;
                var li = DataBaseBox.SelectedItem;
                DbTable list = li as DbTable;
                string key = list.key;
                string value = list.value;
                if (key != "0" && key != "")
                {
                    string conn = string.Format("Integrated Security=false;Data Source={0};User ID={1};Password={2};Initial Catalog={3};Connect Timeout=30", LocalName.Text.Trim(), UserName.Text.Trim(), PassWord.Text.Trim(), value);

                    Dictionary<string, string> tables = SqlHelper.GetAllTableName(conn);
                    if (tables != null && tables.Any())
                    {
                        foreach (var tablename in tables)
                        {
                            GenerateEntity(conn,tablename.Value, textPlace.Text);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选择数据库！");
                }
            }
            else if(radioPartTables.Checked)
            {
                var li = DataBaseBox.SelectedItem;
                DbTable list = li as DbTable;
                string key = list.key;
                string value = list.value;
                if (key != "0" && key != "")
                {
                    string conn = string.Format("Integrated Security=false;Data Source={0};User ID={1};Password={2};Initial Catalog={3};Connect Timeout=30", LocalName.Text.Trim(), UserName.Text.Trim(), PassWord.Text.Trim(), value);
                    var tables = lb_Tables.SelectedItems;
                    if (tables != null)
                    {
                        foreach (var tablename in tables)
                        {
                            GenerateEntity(conn, lb_Tables.GetItemText(tablename), textPlace.Text);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选择数据库！");
                }
                
            }
            else
            {
                MessageBox.Show("你咋不上天呢!");
                return;
            }
            MessageBox.Show("生成成功!");
            return;
        }


        /// <summary>
        /// 生成实体代码
        /// </summary>
        /// <param name="table">表名</param>
        private void GenerateEntity(string conn,string tableName, string OutputPath)
        {
            GenerateModelpath(tableName, OutputPath, out string path);
            WriteAndSave(path, GetModel(conn,tableName));
        } 

        /// <summary>
        /// 根据表格信息生成实体路径
        /// </summary>
        /// <param name="table">表信息</param>
        /// <param name="path">实体路径</param>
        private void GenerateModelpath(string tableName, string OutputPath, out string path)
        {
            var modelPath = OutputPath + Delimiter + "Models"; ;
            if (!Directory.Exists(modelPath))
            {
                Directory.CreateDirectory(modelPath);
            }
            StringBuilder fullPath = new StringBuilder();
            fullPath.Append(modelPath);
            fullPath.Append(Delimiter);
            fullPath.Append(tableName);
            fullPath.Append(".cs");
            path = fullPath.ToString();
        }

        /// <summary>
        /// 写文件
        /// </summary>
        /// <param name="fileName">文件完整路径</param>
        /// <param name="content">内容</param>
        private static void WriteAndSave(string fileName, string content)
        {
            //实例化一个文件流--->与写入文件相关联
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                //实例化一个StreamWriter-->与fs相关联
                using (var sw = new StreamWriter(fs))
                {
                    //开始写入
                    sw.Write(content);
                    //清空缓冲区
                    sw.Flush();
                    //关闭流
                    sw.Close();
                    fs.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (LocalName.Text.Trim() == "")
            {
                MessageBox.Show("IP地址不能为空!");
                return;
            }
            if (UserName.Text.Trim() == "")
            {
                MessageBox.Show("登录名不能为空!");
                return;
            }
            if (PassWord.Text.Trim() == "")
            {
                MessageBox.Show("密码不能为空!");
                return;
            }
            string conn = string.Format("Integrated Security=false;Data Source={0};User ID={1};Password={2};Connect Timeout=30", LocalName.Text.Trim(), UserName.Text.Trim(), PassWord.Text.Trim());
            List<DbTable> tables = SqlHelper.GetAllDataBaseName(conn) as List<DbTable>;

            tables.Insert(0, new DbTable { key = "0", value = "-请选择数据库-" });//如果实体对象有多个属性，可以在实例化该对象后，只为用到的两个属性赋值
            DataBaseBox.DataSource = tables;
            DataBaseBox.DisplayMember = "Value";
            DataBaseBox.ValueMember = "Key";
           
        }

        private void UserNameBox_Click(object sender, EventArgs e)
        {

        }

        private void DataBaseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OutputTabels();
            }
            catch (Exception)
            {

            }
        }
    }
}
