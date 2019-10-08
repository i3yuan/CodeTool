namespace CodeModelTool
{
    partial class CodeTool
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txt_prefix = new System.Windows.Forms.TextBox();
            this.lb_Tables = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Model = new System.Windows.Forms.TabPage();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.radioAllTables = new System.Windows.Forms.RadioButton();
            this.radioPartTables = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textPlace = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SelectPlaceButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.localhostBox = new System.Windows.Forms.Label();
            this.LocalName = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.Label();
            this.PassWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataBaseBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tp_Model.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 655);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "命名空间：";
            // 
            // txt_prefix
            // 
            this.txt_prefix.Location = new System.Drawing.Point(402, 646);
            this.txt_prefix.Name = "txt_prefix";
            this.txt_prefix.Size = new System.Drawing.Size(154, 21);
            this.txt_prefix.TabIndex = 4;
            // 
            // lb_Tables
            // 
            this.lb_Tables.FormattingEnabled = true;
            this.lb_Tables.ItemHeight = 12;
            this.lb_Tables.Location = new System.Drawing.Point(23, 31);
            this.lb_Tables.Name = "lb_Tables";
            this.lb_Tables.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_Tables.Size = new System.Drawing.Size(250, 724);
            this.lb_Tables.TabIndex = 6;
            this.lb_Tables.SelectedIndexChanged += new System.EventHandler(this.lb_Tables_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_Model);
            this.tabControl1.Location = new System.Drawing.Point(297, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(697, 496);
            this.tabControl1.TabIndex = 7;
            // 
            // tp_Model
            // 
            this.tp_Model.Controls.Add(this.txt_Model);
            this.tp_Model.Location = new System.Drawing.Point(4, 22);
            this.tp_Model.Name = "tp_Model";
            this.tp_Model.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Model.Size = new System.Drawing.Size(689, 470);
            this.tp_Model.TabIndex = 0;
            this.tp_Model.Text = "Model实体类";
            this.tp_Model.UseVisualStyleBackColor = true;
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(-4, -3);
            this.txt_Model.Multiline = true;
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(697, 477);
            this.txt_Model.TabIndex = 0;
            // 
            // radioAllTables
            // 
            this.radioAllTables.AutoSize = true;
            this.radioAllTables.Checked = true;
            this.radioAllTables.Location = new System.Drawing.Point(633, 604);
            this.radioAllTables.Name = "radioAllTables";
            this.radioAllTables.Size = new System.Drawing.Size(59, 16);
            this.radioAllTables.TabIndex = 9;
            this.radioAllTables.TabStop = true;
            this.radioAllTables.Text = "所有表";
            this.radioAllTables.UseVisualStyleBackColor = true;
            // 
            // radioPartTables
            // 
            this.radioPartTables.AutoSize = true;
            this.radioPartTables.Location = new System.Drawing.Point(829, 604);
            this.radioPartTables.Name = "radioPartTables";
            this.radioPartTables.Size = new System.Drawing.Size(59, 16);
            this.radioPartTables.TabIndex = 10;
            this.radioPartTables.Text = "部分表";
            this.radioPartTables.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 702);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "文件存放位置：";
            // 
            // textPlace
            // 
            this.textPlace.Location = new System.Drawing.Point(402, 699);
            this.textPlace.Name = "textPlace";
            this.textPlace.Size = new System.Drawing.Size(476, 21);
            this.textPlace.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SelectPlaceButton
            // 
            this.SelectPlaceButton.Location = new System.Drawing.Point(897, 696);
            this.SelectPlaceButton.Name = "SelectPlaceButton";
            this.SelectPlaceButton.Size = new System.Drawing.Size(97, 24);
            this.SelectPlaceButton.TabIndex = 13;
            this.SelectPlaceButton.Text = "选择位置";
            this.SelectPlaceButton.UseVisualStyleBackColor = true;
            this.SelectPlaceButton.Click += new System.EventHandler(this.SelectPlaceButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Location = new System.Drawing.Point(733, 748);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "一 键 生 成";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(919, 563);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "连接";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // localhostBox
            // 
            this.localhostBox.AutoSize = true;
            this.localhostBox.Location = new System.Drawing.Point(295, 566);
            this.localhostBox.Name = "localhostBox";
            this.localhostBox.Size = new System.Drawing.Size(29, 12);
            this.localhostBox.TabIndex = 16;
            this.localhostBox.Text = "IP：";
            // 
            // LocalName
            // 
            this.LocalName.Location = new System.Drawing.Point(333, 563);
            this.LocalName.Name = "LocalName";
            this.LocalName.Size = new System.Drawing.Size(100, 21);
            this.LocalName.TabIndex = 17;
            this.LocalName.Text = "localhost";
            // 
            // UserNameBox
            // 
            this.UserNameBox.AutoSize = true;
            this.UserNameBox.Location = new System.Drawing.Point(470, 568);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(53, 12);
            this.UserNameBox.TabIndex = 18;
            this.UserNameBox.Text = "登录名：";
            this.UserNameBox.Click += new System.EventHandler(this.UserNameBox_Click);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(553, 565);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(100, 21);
            this.UserName.TabIndex = 19;
            this.UserName.Text = "sa";
            // 
            // PasswordBox
            // 
            this.PasswordBox.AutoSize = true;
            this.PasswordBox.Location = new System.Drawing.Point(691, 568);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(41, 12);
            this.PasswordBox.TabIndex = 20;
            this.PasswordBox.Text = "密码：";
            // 
            // PassWord
            // 
            this.PassWord.Location = new System.Drawing.Point(766, 563);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(100, 21);
            this.PassWord.TabIndex = 21;
            this.PassWord.Text = "123456";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "数据库列表";
            // 
            // DataBaseBox
            // 
            this.DataBaseBox.FormattingEnabled = true;
            this.DataBaseBox.Location = new System.Drawing.Point(402, 598);
            this.DataBaseBox.Name = "DataBaseBox";
            this.DataBaseBox.Size = new System.Drawing.Size(121, 20);
            this.DataBaseBox.TabIndex = 23;
            this.DataBaseBox.SelectedIndexChanged += new System.EventHandler(this.DataBaseBox_SelectedIndexChanged);
            // 
            // CodeTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 813);
            this.Controls.Add(this.DataBaseBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.LocalName);
            this.Controls.Add(this.localhostBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SelectPlaceButton);
            this.Controls.Add(this.textPlace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioPartTables);
            this.Controls.Add(this.radioAllTables);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lb_Tables);
            this.Controls.Add(this.txt_prefix);
            this.Controls.Add(this.label2);
            this.Name = "CodeTool";
            this.Text = "实体类生成工具(i3yuan.cnblogs.com)";
            this.Load += new System.EventHandler(this.CodeTool_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp_Model.ResumeLayout(false);
            this.tp_Model.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_prefix;
        private System.Windows.Forms.ListBox lb_Tables;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Model;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.RadioButton radioAllTables;
        private System.Windows.Forms.RadioButton radioPartTables;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPlace;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SelectPlaceButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label localhostBox;
        private System.Windows.Forms.TextBox LocalName;
        private System.Windows.Forms.Label UserNameBox;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label PasswordBox;
        private System.Windows.Forms.TextBox PassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DataBaseBox;
    }
}

