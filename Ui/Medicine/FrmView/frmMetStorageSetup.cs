using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace com.digitalwave.iCare.gui.HIS
{
	/// <summary>
	/// frmMetStorageSetup ��ժҪ˵����
	/// </summary>
	public class frmMetStorageSetup  :com.digitalwave.GUI_Base.frmMDI_Child_Base
	{
		private System.Windows.Forms.ToolBar m_tb;
		private System.Windows.Forms.ToolBarButton Find;
		private System.Windows.Forms.ToolBarButton reNew;
		private System.Windows.Forms.ToolBarButton Esc;
		private PinkieControls.ButtonXP btnClose;
		private PinkieControls.ButtonXP m_btnFind;
		internal com.digitalwave.controls.datagrid.ctlDataGrid DgdMed;
		internal System.Windows.Forms.ToolBarButton m_tbNot;
		internal System.Windows.Forms.ToolBarButton m_tbOK;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		internal System.Windows.Forms.TextBox m_txtVal;
		internal System.Windows.Forms.ComboBox m_CobSele;
		private System.Windows.Forms.Label label6;
		internal com.digitalwave.iCare.gui.HIS.exComboBox cobSelectType;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmMetStorageSetup()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú������κι��캯������
			//
		}

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

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo1 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo2 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo3 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo4 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo5 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo6 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo7 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo8 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo9 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo10 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo11 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo12 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo13 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo14 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo15 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo16 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo17 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo18 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo19 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo20 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo21 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo22 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo23 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo24 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo25 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo26 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            com.digitalwave.controls.datagrid.clsColumnInfo clsColumnInfo27 = new com.digitalwave.controls.datagrid.clsColumnInfo();
            this.m_tb = new System.Windows.Forms.ToolBar();
            this.Find = new System.Windows.Forms.ToolBarButton();
            this.m_tbNot = new System.Windows.Forms.ToolBarButton();
            this.m_tbOK = new System.Windows.Forms.ToolBarButton();
            this.reNew = new System.Windows.Forms.ToolBarButton();
            this.Esc = new System.Windows.Forms.ToolBarButton();
            this.btnClose = new PinkieControls.ButtonXP();
            this.m_btnFind = new PinkieControls.ButtonXP();
            this.m_txtVal = new System.Windows.Forms.TextBox();
            this.DgdMed = new com.digitalwave.controls.datagrid.ctlDataGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.m_CobSele = new System.Windows.Forms.ComboBox();
            this.cobSelectType = new com.digitalwave.iCare.gui.HIS.exComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgdMed)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_tb
            // 
            this.m_tb.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.m_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_tb.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.Find,
            this.m_tbNot,
            this.m_tbOK,
            this.reNew,
            this.Esc});
            this.m_tb.ButtonSize = new System.Drawing.Size(40, 38);
            this.m_tb.DropDownArrows = true;
            this.m_tb.Location = new System.Drawing.Point(0, 0);
            this.m_tb.Name = "m_tb";
            this.m_tb.ShowToolTips = true;
            this.m_tb.Size = new System.Drawing.Size(1028, 44);
            this.m_tb.TabIndex = 12;
            this.m_tb.Wrappable = false;
            this.m_tb.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.m_tb_ButtonClick);
            // 
            // Find
            // 
            this.Find.Name = "Find";
            this.Find.Text = "����";
            this.Find.ToolTipText = "����";
            // 
            // m_tbNot
            // 
            this.m_tbNot.Name = "m_tbNot";
            this.m_tbNot.Text = "ȱҩ";
            // 
            // m_tbOK
            // 
            this.m_tbOK.Name = "m_tbOK";
            this.m_tbOK.Text = "��ҩ";
            // 
            // reNew
            // 
            this.reNew.Name = "reNew";
            this.reNew.Text = "ˢ��";
            this.reNew.ToolTipText = "ˢ��";
            // 
            // Esc
            // 
            this.Esc.Name = "Esc";
            this.Esc.Text = "�ر�";
            this.Esc.ToolTipText = "�ر�";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.btnClose.DefaultScheme = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Hint = "";
            this.btnClose.Location = new System.Drawing.Point(476, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Scheme = PinkieControls.ButtonXP.Schemes.Blue;
            this.btnClose.Size = new System.Drawing.Size(64, 24);
            this.btnClose.TabIndex = 100;
            this.btnClose.Text = "����(&R)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // m_btnFind
            // 
            this.m_btnFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.m_btnFind.DefaultScheme = true;
            this.m_btnFind.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_btnFind.Hint = "";
            this.m_btnFind.Location = new System.Drawing.Point(404, 2);
            this.m_btnFind.Name = "m_btnFind";
            this.m_btnFind.Scheme = PinkieControls.ButtonXP.Schemes.Blue;
            this.m_btnFind.Size = new System.Drawing.Size(64, 24);
            this.m_btnFind.TabIndex = 99;
            this.m_btnFind.Text = "����(&F)";
            this.m_btnFind.Click += new System.EventHandler(this.m_btnFind_Click);
            // 
            // m_txtVal
            // 
            this.m_txtVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_txtVal.Location = new System.Drawing.Point(224, 3);
            this.m_txtVal.MaxLength = 20;
            this.m_txtVal.Name = "m_txtVal";
            this.m_txtVal.Size = new System.Drawing.Size(152, 23);
            this.m_txtVal.TabIndex = 5;
            this.m_txtVal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_txtVal_KeyDown);
            // 
            // DgdMed
            // 
            this.DgdMed.AllowAddNew = false;
            this.DgdMed.AllowDelete = false;
            this.DgdMed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DgdMed.AutoAppendRow = false;
            this.DgdMed.AutoScroll = true;
            this.DgdMed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgdMed.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DgdMed.CaptionText = "";
            this.DgdMed.CaptionVisible = false;
            this.DgdMed.CausesValidation = false;
            this.DgdMed.ColumnHeadersVisible = true;
            clsColumnInfo1.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo1.BackColor = System.Drawing.Color.White;
            clsColumnInfo1.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo1.ColumnIndex = 0;
            clsColumnInfo1.ColumnName = "������";
            clsColumnInfo1.ColumnWidth = 75;
            clsColumnInfo1.Enabled = false;
            clsColumnInfo1.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo1.HeadText = "������";
            clsColumnInfo1.ReadOnly = true;
            clsColumnInfo1.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo2.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo2.BackColor = System.Drawing.Color.White;
            clsColumnInfo2.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo2.ColumnIndex = 1;
            clsColumnInfo2.ColumnName = "ҩƷ����";
            clsColumnInfo2.ColumnWidth = 140;
            clsColumnInfo2.Enabled = false;
            clsColumnInfo2.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo2.HeadText = "ҩƷ����";
            clsColumnInfo2.ReadOnly = true;
            clsColumnInfo2.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo3.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo3.BackColor = System.Drawing.Color.White;
            clsColumnInfo3.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo3.ColumnIndex = 2;
            clsColumnInfo3.ColumnName = "ҩƷͨ����";
            clsColumnInfo3.ColumnWidth = 80;
            clsColumnInfo3.Enabled = false;
            clsColumnInfo3.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo3.HeadText = "ҩƷͨ����";
            clsColumnInfo3.ReadOnly = true;
            clsColumnInfo3.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo4.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo4.BackColor = System.Drawing.Color.White;
            clsColumnInfo4.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo4.ColumnIndex = 3;
            clsColumnInfo4.ColumnName = "Ӣ����";
            clsColumnInfo4.ColumnWidth = 75;
            clsColumnInfo4.Enabled = false;
            clsColumnInfo4.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo4.HeadText = "Ӣ����";
            clsColumnInfo4.ReadOnly = true;
            clsColumnInfo4.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo5.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo5.BackColor = System.Drawing.Color.White;
            clsColumnInfo5.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo5.ColumnIndex = 4;
            clsColumnInfo5.ColumnName = "���";
            clsColumnInfo5.ColumnWidth = 50;
            clsColumnInfo5.Enabled = false;
            clsColumnInfo5.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo5.HeadText = "���";
            clsColumnInfo5.ReadOnly = true;
            clsColumnInfo5.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo6.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo6.BackColor = System.Drawing.Color.White;
            clsColumnInfo6.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo6.ColumnIndex = 5;
            clsColumnInfo6.ColumnName = "�Ƽ�";
            clsColumnInfo6.ColumnWidth = 40;
            clsColumnInfo6.Enabled = false;
            clsColumnInfo6.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo6.HeadText = "�Ƽ�";
            clsColumnInfo6.ReadOnly = true;
            clsColumnInfo6.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo7.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo7.BackColor = System.Drawing.Color.White;
            clsColumnInfo7.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo7.ColumnIndex = 6;
            clsColumnInfo7.ColumnName = "���";
            clsColumnInfo7.ColumnWidth = 120;
            clsColumnInfo7.Enabled = false;
            clsColumnInfo7.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo7.HeadText = "���";
            clsColumnInfo7.ReadOnly = true;
            clsColumnInfo7.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo8.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            clsColumnInfo8.BackColor = System.Drawing.Color.White;
            clsColumnInfo8.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo8.ColumnIndex = 7;
            clsColumnInfo8.ColumnName = "������";
            clsColumnInfo8.ColumnWidth = 60;
            clsColumnInfo8.Enabled = false;
            clsColumnInfo8.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo8.HeadText = "������";
            clsColumnInfo8.ReadOnly = true;
            clsColumnInfo8.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo9.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            clsColumnInfo9.BackColor = System.Drawing.Color.White;
            clsColumnInfo9.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo9.ColumnIndex = 8;
            clsColumnInfo9.ColumnName = "����";
            clsColumnInfo9.ColumnWidth = 50;
            clsColumnInfo9.Enabled = false;
            clsColumnInfo9.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo9.HeadText = "����";
            clsColumnInfo9.ReadOnly = true;
            clsColumnInfo9.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo10.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo10.BackColor = System.Drawing.Color.White;
            clsColumnInfo10.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo10.ColumnIndex = 9;
            clsColumnInfo10.ColumnName = "��������";
            clsColumnInfo10.ColumnWidth = 80;
            clsColumnInfo10.Enabled = false;
            clsColumnInfo10.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo10.HeadText = "��������";
            clsColumnInfo10.ReadOnly = true;
            clsColumnInfo10.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo11.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo11.BackColor = System.Drawing.Color.White;
            clsColumnInfo11.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo11.ColumnIndex = 10;
            clsColumnInfo11.ColumnName = "����";
            clsColumnInfo11.ColumnWidth = 40;
            clsColumnInfo11.Enabled = false;
            clsColumnInfo11.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo11.HeadText = "����";
            clsColumnInfo11.ReadOnly = true;
            clsColumnInfo11.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo12.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo12.BackColor = System.Drawing.Color.White;
            clsColumnInfo12.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo12.ColumnIndex = 11;
            clsColumnInfo12.ColumnName = "������λ";
            clsColumnInfo12.ColumnWidth = 60;
            clsColumnInfo12.Enabled = false;
            clsColumnInfo12.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo12.HeadText = "������λ";
            clsColumnInfo12.ReadOnly = true;
            clsColumnInfo12.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo13.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo13.BackColor = System.Drawing.Color.White;
            clsColumnInfo13.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo13.ColumnIndex = 12;
            clsColumnInfo13.ColumnName = "���ﵥλ";
            clsColumnInfo13.ColumnWidth = 60;
            clsColumnInfo13.Enabled = false;
            clsColumnInfo13.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo13.HeadText = "���ﵥλ";
            clsColumnInfo13.ReadOnly = true;
            clsColumnInfo13.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo14.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            clsColumnInfo14.BackColor = System.Drawing.Color.White;
            clsColumnInfo14.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo14.ColumnIndex = 13;
            clsColumnInfo14.ColumnName = "���ﵥ��";
            clsColumnInfo14.ColumnWidth = 75;
            clsColumnInfo14.Enabled = false;
            clsColumnInfo14.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo14.HeadText = "���ﵥ��";
            clsColumnInfo14.ReadOnly = true;
            clsColumnInfo14.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo15.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo15.BackColor = System.Drawing.Color.White;
            clsColumnInfo15.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo15.ColumnIndex = 14;
            clsColumnInfo15.ColumnName = "סԺ��λ";
            clsColumnInfo15.ColumnWidth = 60;
            clsColumnInfo15.Enabled = false;
            clsColumnInfo15.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo15.HeadText = "סԺ��λ";
            clsColumnInfo15.ReadOnly = true;
            clsColumnInfo15.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo16.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            clsColumnInfo16.BackColor = System.Drawing.Color.White;
            clsColumnInfo16.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo16.ColumnIndex = 15;
            clsColumnInfo16.ColumnName = "סԺ����";
            clsColumnInfo16.ColumnWidth = 75;
            clsColumnInfo16.Enabled = false;
            clsColumnInfo16.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo16.HeadText = "סԺ����";
            clsColumnInfo16.ReadOnly = true;
            clsColumnInfo16.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo17.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo17.BackColor = System.Drawing.Color.White;
            clsColumnInfo17.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo17.ColumnIndex = 16;
            clsColumnInfo17.ColumnName = "��װ��";
            clsColumnInfo17.ColumnWidth = 50;
            clsColumnInfo17.Enabled = false;
            clsColumnInfo17.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo17.HeadText = "��װ��";
            clsColumnInfo17.ReadOnly = true;
            clsColumnInfo17.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo18.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo18.BackColor = System.Drawing.Color.White;
            clsColumnInfo18.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo18.ColumnIndex = 17;
            clsColumnInfo18.ColumnName = "ȱҩ";
            clsColumnInfo18.ColumnWidth = 40;
            clsColumnInfo18.Enabled = false;
            clsColumnInfo18.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo18.HeadText = "ȱҩ";
            clsColumnInfo18.ReadOnly = true;
            clsColumnInfo18.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo19.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo19.BackColor = System.Drawing.Color.White;
            clsColumnInfo19.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo19.ColumnIndex = 18;
            clsColumnInfo19.ColumnName = "����ҩƷ";
            clsColumnInfo19.ColumnWidth = 0;
            clsColumnInfo19.Enabled = false;
            clsColumnInfo19.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo19.HeadText = "����ҩƷ";
            clsColumnInfo19.ReadOnly = true;
            clsColumnInfo19.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo20.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo20.BackColor = System.Drawing.Color.White;
            clsColumnInfo20.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo20.ColumnIndex = 19;
            clsColumnInfo20.ColumnName = "����ҩƷ";
            clsColumnInfo20.ColumnWidth = 0;
            clsColumnInfo20.Enabled = false;
            clsColumnInfo20.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo20.HeadText = "����ҩƷ";
            clsColumnInfo20.ReadOnly = true;
            clsColumnInfo20.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo21.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo21.BackColor = System.Drawing.Color.White;
            clsColumnInfo21.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo21.ColumnIndex = 20;
            clsColumnInfo21.ColumnName = "����ҩƷ";
            clsColumnInfo21.ColumnWidth = 0;
            clsColumnInfo21.Enabled = false;
            clsColumnInfo21.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo21.HeadText = "����ҩƷ";
            clsColumnInfo21.ReadOnly = true;
            clsColumnInfo21.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo22.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo22.BackColor = System.Drawing.Color.White;
            clsColumnInfo22.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo22.ColumnIndex = 21;
            clsColumnInfo22.ColumnName = "Ժ���Ƽ�";
            clsColumnInfo22.ColumnWidth = 0;
            clsColumnInfo22.Enabled = false;
            clsColumnInfo22.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo22.HeadText = "Ժ���Ƽ�";
            clsColumnInfo22.ReadOnly = true;
            clsColumnInfo22.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo23.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo23.BackColor = System.Drawing.Color.White;
            clsColumnInfo23.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo23.ColumnIndex = 22;
            clsColumnInfo23.ColumnName = "����ҩƷ";
            clsColumnInfo23.ColumnWidth = 0;
            clsColumnInfo23.Enabled = false;
            clsColumnInfo23.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo23.HeadText = "����ҩƷ";
            clsColumnInfo23.ReadOnly = true;
            clsColumnInfo23.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo24.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo24.BackColor = System.Drawing.Color.White;
            clsColumnInfo24.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo24.ColumnIndex = 23;
            clsColumnInfo24.ColumnName = "�Է�ҩƷ";
            clsColumnInfo24.ColumnWidth = 0;
            clsColumnInfo24.Enabled = false;
            clsColumnInfo24.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo24.HeadText = "�Է�ҩƷ";
            clsColumnInfo24.ReadOnly = true;
            clsColumnInfo24.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo25.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo25.BackColor = System.Drawing.Color.White;
            clsColumnInfo25.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo25.ColumnIndex = 24;
            clsColumnInfo25.ColumnName = "�����";
            clsColumnInfo25.ColumnWidth = 0;
            clsColumnInfo25.Enabled = true;
            clsColumnInfo25.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo25.HeadText = "�����";
            clsColumnInfo25.ReadOnly = false;
            clsColumnInfo25.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo26.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo26.BackColor = System.Drawing.Color.White;
            clsColumnInfo26.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo26.ColumnIndex = 25;
            clsColumnInfo26.ColumnName = "ƴ����";
            clsColumnInfo26.ColumnWidth = 0;
            clsColumnInfo26.Enabled = true;
            clsColumnInfo26.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo26.HeadText = "ƴ����";
            clsColumnInfo26.ReadOnly = false;
            clsColumnInfo26.TextFont = new System.Drawing.Font("����", 10F);
            clsColumnInfo27.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            clsColumnInfo27.BackColor = System.Drawing.Color.White;
            clsColumnInfo27.Column_Type = com.digitalwave.controls.datagrid.enum_DataType.System_String;
            clsColumnInfo27.ColumnIndex = 26;
            clsColumnInfo27.ColumnName = "MEDICINEID_CHR";
            clsColumnInfo27.ColumnWidth = 0;
            clsColumnInfo27.Enabled = false;
            clsColumnInfo27.ForeColor = System.Drawing.Color.Black;
            clsColumnInfo27.HeadText = "MEDICINEID_CHR";
            clsColumnInfo27.ReadOnly = true;
            clsColumnInfo27.TextFont = new System.Drawing.Font("����", 10F);
            this.DgdMed.Columns.Add(clsColumnInfo1);
            this.DgdMed.Columns.Add(clsColumnInfo2);
            this.DgdMed.Columns.Add(clsColumnInfo3);
            this.DgdMed.Columns.Add(clsColumnInfo4);
            this.DgdMed.Columns.Add(clsColumnInfo5);
            this.DgdMed.Columns.Add(clsColumnInfo6);
            this.DgdMed.Columns.Add(clsColumnInfo7);
            this.DgdMed.Columns.Add(clsColumnInfo8);
            this.DgdMed.Columns.Add(clsColumnInfo9);
            this.DgdMed.Columns.Add(clsColumnInfo10);
            this.DgdMed.Columns.Add(clsColumnInfo11);
            this.DgdMed.Columns.Add(clsColumnInfo12);
            this.DgdMed.Columns.Add(clsColumnInfo13);
            this.DgdMed.Columns.Add(clsColumnInfo14);
            this.DgdMed.Columns.Add(clsColumnInfo15);
            this.DgdMed.Columns.Add(clsColumnInfo16);
            this.DgdMed.Columns.Add(clsColumnInfo17);
            this.DgdMed.Columns.Add(clsColumnInfo18);
            this.DgdMed.Columns.Add(clsColumnInfo19);
            this.DgdMed.Columns.Add(clsColumnInfo20);
            this.DgdMed.Columns.Add(clsColumnInfo21);
            this.DgdMed.Columns.Add(clsColumnInfo22);
            this.DgdMed.Columns.Add(clsColumnInfo23);
            this.DgdMed.Columns.Add(clsColumnInfo24);
            this.DgdMed.Columns.Add(clsColumnInfo25);
            this.DgdMed.Columns.Add(clsColumnInfo26);
            this.DgdMed.Columns.Add(clsColumnInfo27);
            this.DgdMed.FullRowSelect = false;
            this.DgdMed.Location = new System.Drawing.Point(0, 50);
            this.DgdMed.MultiSelect = false;
            this.DgdMed.Name = "DgdMed";
            this.DgdMed.ReadOnly = true;
            this.DgdMed.RowHeadersVisible = true;
            this.DgdMed.RowHeaderWidth = 35;
            this.DgdMed.SelectedRowBackColor = System.Drawing.Color.Purple;
            this.DgdMed.SelectedRowForeColor = System.Drawing.Color.White;
            this.DgdMed.Size = new System.Drawing.Size(1028, 619);
            this.DgdMed.TabIndex = 16;
            this.DgdMed.m_evtCurrentCellChanged += new System.EventHandler(this.DgdMed_m_evtCurrentCellChanged);
            this.DgdMed.m_evtMouseUpCell += new com.digitalwave.controls.datagrid.clsDGTextMousePressEventHandler(this.DgdMed_m_evtMouseUpCell);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(824, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 101;
            this.label4.Text = "ҩƷ����";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("����", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(832, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 102;
            this.label5.Text = "ҩƷ����";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.m_CobSele);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.m_btnFind);
            this.panel1.Controls.Add(this.m_txtVal);
            this.panel1.Location = new System.Drawing.Point(216, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 32);
            this.panel1.TabIndex = 103;
            this.panel1.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("����", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(16, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 102;
            this.label6.Text = "���ҷ�ʽ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_CobSele
            // 
            this.m_CobSele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_CobSele.Items.AddRange(new object[] {
            "ҩƷ������",
            "ҩƷ����",
            "ҩƷͨ����",
            "ƴ����",
            "�����",
            "Ӣ������"});
            this.m_CobSele.Location = new System.Drawing.Point(96, 3);
            this.m_CobSele.Name = "m_CobSele";
            this.m_CobSele.Size = new System.Drawing.Size(121, 22);
            this.m_CobSele.TabIndex = 101;
            this.m_CobSele.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_CobSele_KeyDown);
            // 
            // cobSelectType
            // 
            this.cobSelectType.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cobSelectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobSelectType.Location = new System.Drawing.Point(904, 13);
            this.cobSelectType.Name = "cobSelectType";
            this.cobSelectType.Size = new System.Drawing.Size(88, 22);
            this.cobSelectType.TabIndex = 104;
            this.cobSelectType.SelectedIndexChanged += new System.EventHandler(this.cobSelectType_SelectedIndexChanged_1);
            // 
            // frmMetStorageSetup
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
            this.ClientSize = new System.Drawing.Size(1028, 669);
            this.Controls.Add(this.cobSelectType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DgdMed);
            this.Controls.Add(this.m_tb);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("����", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmMetStorageSetup";
            this.Text = "ҩ��ȱҩ�趨";
            this.Load += new System.EventHandler(this.frmMetStorageSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgdMed)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void frmMetStorageSetup_Load(object sender, System.EventArgs e)
		{
			((clsControlMetStorageSetup)this.objController).m_mthFromLoad(m_strMedType);
		}
		public override void CreateController()
		{
			this.objController=new com.digitalwave.iCare.gui.HIS.clsControlMetStorageSetup();
			objController.Set_GUI_Apperance(this);
		}
		public string  m_strMedType;

        public  bool isReadOnly = false;
		public void m_mthShowMe(string strMedType,string strReadOnly)
		{
			m_strMedType=strMedType;
            if (strReadOnly == "0")
            {
                m_tb.Buttons[1].Enabled = false;
                m_tb.Buttons[2].Enabled = false;
                isReadOnly = true;
            }
			this.Show();
		}

		private void DgdMed_Navigate(object sender, System.Windows.Forms.NavigateEventArgs ne)
		{
		}

		private void DgdMed_DoubleClick(object sender, System.EventArgs e)
		{
			((clsControlMetStorageSetup)this.objController).DoubleCleck();
		}

		private void DgdMed_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{

		}

		private void m_btChang_Click(object sender, System.EventArgs e)
		{
		}

		private void m_tb_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch(this.m_tb.Buttons.IndexOf(e.Button))
			{
				case 0:
				{
					panel1.Visible=true;
					m_CobSele.Focus();
					break;
				}
				case 1:
				{
					((clsControlMetStorageSetup)this.objController).m_btCheck(1);
					this.m_tbNot.Enabled=false;
					this.m_tbOK.Enabled=true;
					break;
				}
				case 2:
				{
					((clsControlMetStorageSetup)this.objController).m_btCheck(0);
					this.m_tbNot.Enabled=true;
					this.m_tbOK.Enabled=false;
					break;
				}
				case 3:
				{
//					((clsControlMetStorageSetup)this.objController).m_lngFillDataGrid();
					break;
				}
				case 4:
				{
					this.Close();
					break;
				}
			}
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			
			panel1.Visible=false;
			((clsControlMetStorageSetup)this.objController).m_lngReture();
			m_CobSele.Text="";
			m_txtVal.Text="";
		}

		private void m_btnFind_Click(object sender, System.EventArgs e)
		{
			((clsControlMetStorageSetup)this.objController).m_lngFind();
		}



		private void DgdMed_m_evtMouseUpCell(object sender, com.digitalwave.controls.datagrid.clsDGTextMousePressEventArgs e)
		{
        }

		private void DgdMed_m_evtDoubleClickCell(object sender, com.digitalwave.controls.datagrid.clsDGTextMouseClickEventArgs e)
		{
		((clsControlMetStorageSetup)this.objController).DoubleCleck();
		}

		private void DgdMed_m_evtCurrentCellChanged(object sender, System.EventArgs e)
		{
			((clsControlMetStorageSetup)this.objController).m_lngCellChang();
		}

		private void cobSelectType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
//			((clsControlMetStorageSetup)this.objController).m_cobSelect();
		}

		private void cobSelectType_SelectedIndexChanged_1(object sender, System.EventArgs e)
		{
			((clsControlMetStorageSetup)this.objController).m_mthCboSele();
		}

		private void m_CobSele_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
				m_txtVal.Focus();
		}

		private void m_txtVal_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			((clsControlMetStorageSetup)this.objController).m_lngFind();
		}

	}
}