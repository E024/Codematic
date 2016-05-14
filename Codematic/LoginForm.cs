using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using WiB.Pinkie.Controls;
using Codematic.Properties;
using Maticsoft.CmConfig;
using Maticsoft.IDBO;
using Maticsoft.DBFactory;
namespace Codematic
{
	/// <summary>
	/// LoginForm ��ժҪ˵����
	/// </summary>
	public class LoginForm : System.Windows.Forms.Form
    {
        #region 
        public Label label1;
        public GroupBox groupBox1;
        public Label label2;
        public Label label3;
        private ToolTip toolTip1;
        public TextBox txtUser;
        public TextBox txtPass;
        private IContainer components;
        private ButtonXP btn_Ok;
        private ButtonXP btn_Cancel;
        private Label label4;
        private ButtonXP btn_ConTest;
        public ComboBox cmbDBlist;

       
        public ComboBox cmboxTabLoadtype;
        public TextBox txtTabLoadKeyword;
        #endregion

        Maticsoft.CmConfig.DbSettings dbobj=new Maticsoft.CmConfig.DbSettings();
		public string constr;
        public ComboBox comboBoxServer;
        public Label label5;
        public ComboBox comboBoxServerVer;
        public Label label6;
        public ComboBox comboBox_Verified;
        public CheckBox chk_Simple;
        private PictureBox pictureBox1;
		public string dbname="master";
      
		

		public LoginForm()
		{			
			InitializeComponent();			
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		public void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDBlist = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chk_Simple = new System.Windows.Forms.CheckBox();
            this.btn_Ok = new WiB.Pinkie.Controls.ButtonXP();
            this.btn_Cancel = new WiB.Pinkie.Controls.ButtonXP();
            this.btn_ConTest = new WiB.Pinkie.Controls.ButtonXP();
            this.comboBoxServer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxServerVer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Verified = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmboxTabLoadtype = new System.Windows.Forms.ComboBox();
            this.txtTabLoadKeyword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "����������(&S)��";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(32, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 5);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cmbDBlist
            // 
            this.cmbDBlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDBlist.Enabled = false;
            this.cmbDBlist.Location = new System.Drawing.Point(144, 219);
            this.cmbDBlist.Name = "cmbDBlist";
            this.cmbDBlist.Size = new System.Drawing.Size(232, 20);
            this.cmbDBlist.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "���ݿ�(&D)��";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(144, 169);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(232, 21);
            this.txtUser.TabIndex = 3;
            this.txtUser.Text = "sa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "��¼��(&L)��";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(144, 194);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(232, 21);
            this.txtPass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "����(&P)��";
            // 
            // chk_Simple
            // 
            this.chk_Simple.AutoSize = true;
            this.chk_Simple.Checked = true;
            this.chk_Simple.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Simple.Location = new System.Drawing.Point(144, 244);
            this.chk_Simple.Name = "chk_Simple";
            this.chk_Simple.Size = new System.Drawing.Size(96, 16);
            this.chk_Simple.TabIndex = 22;
            this.chk_Simple.Text = "��Ч����ģʽ";
            this.toolTip1.SetToolTip(this.chk_Simple, "�ڱ�ǳ��������£����ø�ģʽ��������ٶ�");
            this.chk_Simple.UseVisualStyleBackColor = true;
            // 
            // btn_Ok
            // 
            this.btn_Ok._Image = null;
            this.btn_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_Ok.DefaultScheme = false;
            this.btn_Ok.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Ok.Image = null;
            this.btn_Ok.Location = new System.Drawing.Point(163, 306);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Scheme = WiB.Pinkie.Controls.ButtonXP.Schemes.Blue;
            this.btn_Ok.Size = new System.Drawing.Size(73, 28);
            this.btn_Ok.TabIndex = 19;
            this.btn_Ok.Text = "ȷ��(&O):";
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel._Image = null;
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_Cancel.DefaultScheme = false;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Image = null;
            this.btn_Cancel.Location = new System.Drawing.Point(270, 306);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Scheme = WiB.Pinkie.Controls.ButtonXP.Schemes.Blue;
            this.btn_Cancel.Size = new System.Drawing.Size(73, 28);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Text = "ȡ��(&C):";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_ConTest
            // 
            this.btn_ConTest._Image = null;
            this.btn_ConTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ConTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_ConTest.DefaultScheme = false;
            this.btn_ConTest.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ConTest.Image = null;
            this.btn_ConTest.Location = new System.Drawing.Point(56, 306);
            this.btn_ConTest.Name = "btn_ConTest";
            this.btn_ConTest.Scheme = WiB.Pinkie.Controls.ButtonXP.Schemes.Blue;
            this.btn_ConTest.Size = new System.Drawing.Size(73, 28);
            this.btn_ConTest.TabIndex = 19;
            this.btn_ConTest.Text = "����/����";
            this.btn_ConTest.Click += new System.EventHandler(this.btn_ConTest_Click);
            // 
            // comboBoxServer
            // 
            this.comboBoxServer.FormattingEnabled = true;
            this.comboBoxServer.Location = new System.Drawing.Point(144, 97);
            this.comboBoxServer.Name = "comboBoxServer";
            this.comboBoxServer.Size = new System.Drawing.Size(232, 20);
            this.comboBoxServer.TabIndex = 21;
            this.comboBoxServer.Text = "127.0.0.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "����������(&T)��";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxServerVer
            // 
            this.comboBoxServerVer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServerVer.FormattingEnabled = true;
            this.comboBoxServerVer.Items.AddRange(new object[] {
            "SQL Server2012",
            "SQL Server2008",
            "SQL Server2005",
            "SQL Server2000"});
            this.comboBoxServerVer.Location = new System.Drawing.Point(144, 121);
            this.comboBoxServerVer.Name = "comboBoxServerVer";
            this.comboBoxServerVer.Size = new System.Drawing.Size(232, 20);
            this.comboBoxServerVer.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "�����֤(&A)��";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_Verified
            // 
            this.comboBox_Verified.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Verified.FormattingEnabled = true;
            this.comboBox_Verified.Items.AddRange(new object[] {
            "SQL Server �����֤",
            "Windows �����֤"});
            this.comboBox_Verified.Location = new System.Drawing.Point(144, 145);
            this.comboBox_Verified.Name = "comboBox_Verified";
            this.comboBox_Verified.Size = new System.Drawing.Size(232, 20);
            this.comboBox_Verified.TabIndex = 21;
            this.comboBox_Verified.SelectedIndexChanged += new System.EventHandler(this.comboBox_Verified_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Codematic.Properties.Resources.loginsql;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // cmboxTabLoadtype
            // 
            this.cmboxTabLoadtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxTabLoadtype.FormattingEnabled = true;
            this.cmboxTabLoadtype.Items.AddRange(new object[] {
            "����ȫ����",
            "ֻ���ر����к��У�",
            "�����ر����к��У�"});
            this.cmboxTabLoadtype.Location = new System.Drawing.Point(144, 261);
            this.cmboxTabLoadtype.Name = "cmboxTabLoadtype";
            this.cmboxTabLoadtype.Size = new System.Drawing.Size(128, 20);
            this.cmboxTabLoadtype.TabIndex = 24;
            this.cmboxTabLoadtype.SelectedIndexChanged += new System.EventHandler(this.cmboxTabLoadtype_SelectedIndexChanged);
            // 
            // txtTabLoadKeyword
            // 
            this.txtTabLoadKeyword.Location = new System.Drawing.Point(276, 261);
            this.txtTabLoadKeyword.Name = "txtTabLoadKeyword";
            this.txtTabLoadKeyword.Size = new System.Drawing.Size(100, 21);
            this.txtTabLoadKeyword.TabIndex = 25;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btn_Ok;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(451, 357);
            this.Controls.Add(this.txtTabLoadKeyword);
            this.Controls.Add(this.cmboxTabLoadtype);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chk_Simple);
            this.Controls.Add(this.comboBox_Verified);
            this.Controls.Add(this.comboBoxServerVer);
            this.Controls.Add(this.comboBoxServer);
            this.Controls.Add(this.cmbDBlist);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btn_ConTest);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "���ӵ�������";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

//		protected override void OnClosing(CancelEventArgs e)
//		{				
//			if(this.DialogResult==DialogResult.Cancel)
//			{					
//				this.Close();
//			}	
//			else
//			{
//				e.Cancel = true;
//			}
//			// otherwise, let the framework close the app
//		}


		#endregion

		private void LoginForm_Load(object sender, System.EventArgs e)
		{
            this.toolTip1.SetToolTip(this.txtUser, "�뱣֤���û�����ÿ�����ݿ�ķ���Ȩ��");
            this.comboBoxServerVer.SelectedIndex = 0;
            this.comboBox_Verified.SelectedIndex = 0;
            this.cmboxTabLoadtype.SelectedIndex = 0;
            this.txtTabLoadKeyword.Visible = false;
        }

        #region ��������
        //�õ�ѡ��İ汾
        public string GetSelVer()
        {
            string text;
            string result;
            if ((text = this.comboBoxServerVer.Text) != null)
            {
                if (text == "SQL Server2000")
                {
                    result = "SQL2000";
                    return result;
                }
                if (text == "SQL Server2005")
                {
                    result = "SQL2005";
                    return result;
                }
                if (text == "SQL Server2008")
                {
                    result = "SQL2008";
                    return result;
                }
                if (text == "SQL Server2012")
                {
                    result = "SQL2012";
                    return result;
                }
            }
            result = "SQL2005";
            return result;
        }
        //�õ�ѡ��İ汾
        public string GetSelVerified()
        {
            if (this.comboBox_Verified.SelectedItem.ToString() == "Windows �����֤")
            {
                return "Windows";
            }
            return "SQL";

        }
        //�ж�sql�İ汾
        private string GetSQLVer(string connectionString)
        {
            string cmdText = "select serverproperty('productversion')";
            string result;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        object obj = sqlCommand.ExecuteScalar();
                        if (object.Equals(obj, null) || object.Equals(obj, DBNull.Value))
                        {
                            result = "";
                        }
                        else
                        {
                            string text = obj.ToString().Trim();
                            if (text.Length > 1)
                            {
                                int num = text.IndexOf(".");
                                if (num > 0)
                                {
                                    result = text.Substring(0, num);
                                }
                                else
                                {
                                    result = text.Substring(0, 1);
                                }
                            }
                            else
                            {
                                result = "";
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        sqlConnection.Close();
                        LogInfo.WriteLog(ex);
                        throw ex;
                    }
                    finally
                    {
                        sqlCommand.Dispose();
                        sqlConnection.Close();
                    }
                }
            }
            return result;
        }
        #endregion

        #region ѡ���������
        private void comboBox_Verified_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.GetSelVerified() == "Windows")
			{
				this.label2.Enabled = false;
				this.label3.Enabled = false;
				this.txtUser.Enabled = false;
				this.txtPass.Enabled = false;
				return;
			}
			this.label2.Enabled = true;
			this.label3.Enabled = true;
			this.txtUser.Enabled = true;
			this.txtPass.Enabled = true;
           
        }
		#endregion


		#region ��֤��¼��Ϣ

		private void btn_Ok_Click(object sender, System.EventArgs e)
		{
            try
            {
                string text = this.comboBoxServer.Text.Trim();
                string text2 = this.txtUser.Text.Trim();
                string text3 = this.txtPass.Text.Trim();
                if (text2 == "" || text == "")
                {
                    MessageBox.Show(this, "���������û�������Ϊ�գ�", "����", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (this.cmbDBlist.SelectedIndex > 0)
                    {
                        this.dbname = this.cmbDBlist.Text;
                    }
                    else
                    {
                        this.dbname = "master";
                    }
                    if (this.GetSelVerified() == "Windows")
                    {
                        this.constr = "Integrated Security=SSPI;Data Source=" + text + ";Initial Catalog=" + this.dbname;
                    }
                    else
                    {
                        if (text3 == "")
                        {
                            this.constr = string.Concat(new string[]
							{
								"User Id=",
								text2,
								";Database=",
								this.dbname,
								";Server=",
								text
							});
                        }
                        else
                        {
                            this.constr = string.Concat(new string[]
							{
								"User Id=",
								text2,
								";Password=",
								text3,
								";Database=",
								this.dbname,
								";Server=",
								text
							});
                        }
                    }
                    string selVer = this.GetSelVer();
                    try
                    {
                        string sQLVer = this.GetSQLVer(this.constr);
                        if (sQLVer != "11" && selVer == "SQL2012")
                        {
                            DialogResult dialogResult = MessageBox.Show(this, "�����ݿ�������汾����SQLServer 2008���Ƿ��������ѡ��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                            if (dialogResult == DialogResult.OK)
                            {
                                this.SelectServerVer(sQLVer);
                                return;
                            }
                        }
                        if (sQLVer != "10" && selVer == "SQL2008")
                        {
                            DialogResult dialogResult2 = MessageBox.Show(this, "�����ݿ�������汾����SQLServer 2008���Ƿ��������ѡ��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                            if (dialogResult2 == DialogResult.OK)
                            {
                                this.SelectServerVer(sQLVer);
                                return;
                            }
                        }
                        if (sQLVer != "9" && selVer == "SQL2005")
                        {
                            DialogResult dialogResult3 = MessageBox.Show(this, "�����ݿ�������汾����SQLServer 2005���Ƿ��������ѡ��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                            if (dialogResult3 == DialogResult.OK)
                            {
                                this.SelectServerVer(sQLVer);
                                return;
                            }
                        }
                        if (sQLVer != "8" && selVer == "SQL2000")
                        {
                            DialogResult dialogResult4 = MessageBox.Show(this, "�����ݿ�������汾����SQLServer 2000���Ƿ��������ѡ��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                            if (dialogResult4 == DialogResult.OK)
                            {
                                this.SelectServerVer(sQLVer);
                                return;
                            }
                        }
                    }
                    catch
                    {
                    }
                    SqlConnection sqlConnection = new SqlConnection(this.constr);
                    try
                    {
                        this.Text = "�������ӷ����������Ժ�...";
                        sqlConnection.Open();
                    }
                    catch (Exception ex)
                    {
                        this.Text = "���ӷ�����ʧ�ܣ�";
                        LogInfo.WriteLog(ex);
                        string text4 = "���ӷ��������ȡ������Ϣʧ�ܣ�\r\n";
                        text4 += "1.�����������ַ���û��������Ƿ���ȷ��\r\n";
                        text4 += "2.��ȷ����SQLServer��ʽ�棬����SQLEXPRESS�棡\r\n";
                        text4 += "3.�������ʧ�ܣ������������Գ����á�������������IP������ ��(local)�����ǡ�.����һ�£�\r\n";
                        text4 += "4.�����Ҫ�鿴�����ļ��԰�����������⣬��㡰ȷ����������㡰ȡ����";
                        MessageBox.Show(this, text4, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                    this.Text = "���ӷ������ɹ���";
                    if (this.dbobj == null)
                    {
                        this.dbobj = new DbSettings();
                    }
                    this.dbobj.DbType = selVer;
                    this.dbobj.Server = text;
                    this.dbobj.ConnectStr = this.constr;
                    this.dbobj.DbName = this.dbname;
                    this.dbobj.DbHelperName = "DbHelperSQL";
                    this.dbobj.ConnectSimple = this.chk_Simple.Checked;
                    if (this.cmboxTabLoadtype.SelectedIndex > 0)
                    {
                        if (this.txtTabLoadKeyword.Text.Trim().Length == 0)
                        {
                            MessageBox.Show(this, "������������˵Ĺؼ��֣�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return;
                        }
                        this.dbobj.TabLoadtype = this.cmboxTabLoadtype.SelectedIndex;
                        this.dbobj.TabLoadKeyword = this.txtTabLoadKeyword.Text.Trim();
                    }
                    switch (DbConfig.AddSettings(this.dbobj))
                    {
                        case 0:
                            MessageBox.Show(this, "��ӷ���������ʧ�ܣ������Ƿ���д��Ȩ�޻��ļ��Ƿ���ڣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        case 2:
                            {
                                DialogResult dialogResult5 = MessageBox.Show(this, "�÷�������Ϣ�Ѿ����ڣ���ȷ���Ƿ񸲸ǵ�ǰ���ݿ����ã�", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                                if (dialogResult5 != DialogResult.Yes)
                                {
                                    return;
                                }
                                DbConfig.DelSetting(this.dbobj.DbType, this.dbobj.Server, this.dbobj.DbName);
                                int num = DbConfig.AddSettings(this.dbobj);
                                if (num != 1)
                                {
                                    MessageBox.Show(this, "����ж�ص�ǰ�汾����ɾ����װĿ¼�����°�װ���°汾��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    return;
                                }
                                break;
                            }
                    }
                    base.DialogResult = DialogResult.OK;
                    base.Close();
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show(this, ex2.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LogInfo.WriteLog(ex2);
            }
		}
		
		#endregion
		
		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
        }

        #region ��������
        private void SelectServerVer(string ver)
        {
            if (ver != null)
            {
                if (ver == "11")
                {
                    this.comboBoxServerVer.SelectedIndex = 0;
                    return;
                }
                if (ver == "10")
                {
                    this.comboBoxServerVer.SelectedIndex = 1;
                    return;
                }
                if (ver == "9")
                {
                    this.comboBoxServerVer.SelectedIndex = 2;
                    return;
                }
                if (ver == "8")
                {
                    this.comboBoxServerVer.SelectedIndex = 3;
                    return;
                }
            }
            this.comboBoxServerVer.SelectedIndex = 1;
        }
        private void btn_ConTest_Click(object sender, EventArgs e)
        {
            try
            {
                string text = this.comboBoxServer.Text.Trim();
                string text2 = this.txtUser.Text.Trim();
                string text3 = this.txtPass.Text.Trim();
                if (text2 == "" || text == "")
                {
                    MessageBox.Show(this, "���������û�������Ϊ�գ�", "����", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (this.GetSelVerified() == "Windows")
                    {
                        this.constr = "Integrated Security=SSPI;Data Source=" + text + ";Initial Catalog=master";
                    }
                    else
                    {
                        if (text3 == "")
                        {
                            this.constr = "User Id=" + text2 + ";Database=master; Server=" + text;
                        }
                        else
                        {
                            this.constr = string.Concat(new string[]
							{
								"User Id=",
								text2,
								";Password=",
								text3,
								";Database=master; Server=",
								text
							});
                        }
                    }
                    string selVer = this.GetSelVer();
                    try
                    {
                        string sQLVer = this.GetSQLVer(this.constr);
                        if (sQLVer != "11" && selVer == "SQL2012")
                        {
                            DialogResult dialogResult = MessageBox.Show(this, "�����ݿ�������汾����SQLServer 2012���Ƿ��������ѡ�񣿵㡰�񡱿ɼ�����", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                            if (dialogResult == DialogResult.OK)
                            {
                                return;
                            }
                        }
                        if (sQLVer != "10" && selVer == "SQL2008")
                        {
                            DialogResult dialogResult2 = MessageBox.Show(this, "�����ݿ�������汾����SQLServer 2008���Ƿ��������ѡ�񣿵㡰�񡱿ɼ�����", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                            if (dialogResult2 == DialogResult.OK)
                            {
                                return;
                            }
                        }
                        if (sQLVer != "9" && selVer == "SQL2005")
                        {
                            DialogResult dialogResult3 = MessageBox.Show(this, "�����ݿ�������汾����SQLServer 2005���Ƿ��������ѡ�񣿵㡰�񡱿ɼ�����", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                            if (dialogResult3 == DialogResult.OK)
                            {
                                return;
                            }
                        }
                        if (sQLVer != "8" && selVer == "SQL2000")
                        {
                            DialogResult dialogResult4 = MessageBox.Show(this, "�����ݿ�������汾����SQLServer 2000���Ƿ��������ѡ�񣿵㡰�񡱿ɼ�����", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                            if (dialogResult4 == DialogResult.OK)
                            {
                                return;
                            }
                        }
                    }
                    catch
                    {
                    }
                    try
                    {
                        this.Text = "�������ӷ����������Ժ�...";
                        IDbObject dbObject = DBOMaker.CreateDbObj(selVer);
                        if (dbObject == null)
                        {
                            LogInfo.WriteLog("�������ݿ����ʧ��:" + selVer);
                            MessageBox.Show(this, "�������ݿ����ʧ��:" + selVer, "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            dbObject.DbConnectStr = this.constr;
                            List<string> dBList = dbObject.GetDBList();
                            dBList.Sort();
                            this.cmbDBlist.Enabled = true;
                            this.cmbDBlist.Items.Clear();
                            this.cmbDBlist.Items.Add("ȫ����");
                            if (dBList != null && dBList.Count > 0)
                            {
                                foreach (string current in dBList)
                                {
                                    this.cmbDBlist.Items.Add(current);
                                }
                            }
                            this.cmbDBlist.SelectedIndex = 0;
                            this.Text = "���ӷ������ɹ���";
                        }
                    }
                    catch (Exception ex)
                    {
                        LogInfo.WriteLog(ex);
                        this.Text = "���ӷ��������ȡ������Ϣʧ�ܣ�";
                        string text4 = "���ӷ��������ȡ������Ϣʧ�ܣ�\r\n";
                        text4 += "1.�����������ַ���û��������Ƿ���ȷ��\r\n";
                        text4 += "2.��ȷ����SQLServer��ʽ�棬����SQLEXPRESS�棡\r\n";
                        text4 += "3.�������ʧ�ܣ������������Գ����á�������������IP������ ��(local)�����ǡ�.����һ�£�\r\n";
                        text4 += "4.�����Ҫ�鿴�����ļ��԰�����������⣬��㡰ȷ����������㡰ȡ����";
                        DialogResult dialogResult5 = MessageBox.Show(this, text4, "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                        if (dialogResult5 == DialogResult.OK)
                        {
                            try
                            {
                                new Process();
                                Process.Start("IExplore.exe", "http://help.maticsoft.com");
                            }
                            catch
                            {
                                MessageBox.Show("����ʣ�http://www.maticsoft.com", "���", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                    }
                }
            }
            catch (Exception ex2)
            {
                LogInfo.WriteLog(ex2);
                MessageBox.Show(this, ex2.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void cmboxTabLoadtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmboxTabLoadtype.SelectedIndex > 0)
            {
                this.txtTabLoadKeyword.Visible = true;
                return;
            }
            this.txtTabLoadKeyword.Visible = false;
        }
        #endregion

        
   
        

    }
}
