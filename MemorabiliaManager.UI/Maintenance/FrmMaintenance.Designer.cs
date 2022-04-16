namespace MemorabiliaManager.UI.Maintenance
{
	partial class FrmMaintenance
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaintenance));
			this.tcMaintenance = new System.Windows.Forms.TabControl();
			this.tpgAuthentication = new System.Windows.Forms.TabPage();
			this.tpgEntertainment = new System.Windows.Forms.TabPage();
			this.tpgItemCategory = new System.Windows.Forms.TabPage();
			this.tpgSignature = new System.Windows.Forms.TabPage();
			this.tpgSubject = new System.Windows.Forms.TabPage();
			this.dgvAuthentication = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cboAuthenticationService = new System.Windows.Forms.ComboBox();
			this.txtAuthenticationCode = new System.Windows.Forms.TextBox();
			this.cboAuthenticationItem = new System.Windows.Forms.ComboBox();
			this.cboAuthenticationSignature = new System.Windows.Forms.ComboBox();
			this.btnApply = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnCopy = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.dgvEntertainment = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtEntertainmentName = new System.Windows.Forms.TextBox();
			this.cboEntertainmentCategory = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.dgvItemCategory = new System.Windows.Forms.DataGridView();
			this.label11 = new System.Windows.Forms.Label();
			this.txtItemCategoryName = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.clbItemCategoryItems = new System.Windows.Forms.CheckedListBox();
			this.dgvSignature = new System.Windows.Forms.DataGridView();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.lblJerseyNumber = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.clbEntertainmentSignatures = new System.Windows.Forms.CheckedListBox();
			this.clbEntertainmentSubjects = new System.Windows.Forms.CheckedListBox();
			this.chkIsSportTeam = new System.Windows.Forms.CheckBox();
			this.txtSignatureFirstName = new System.Windows.Forms.TextBox();
			this.txtSignatureLastName = new System.Windows.Forms.TextBox();
			this.txtSignatureJerseyNumber = new System.Windows.Forms.TextBox();
			this.cboSignatureEntertainment = new System.Windows.Forms.ComboBox();
			this.clbSignatureItems = new System.Windows.Forms.CheckedListBox();
			this.dgvSubject = new System.Windows.Forms.DataGridView();
			this.label15 = new System.Windows.Forms.Label();
			this.clbEntertainmentItems = new System.Windows.Forms.CheckedListBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.txtSubjectName = new System.Windows.Forms.TextBox();
			this.cboSubjectEntertainment = new System.Windows.Forms.ComboBox();
			this.clbSubjectItem = new System.Windows.Forms.CheckedListBox();
			this.tcMaintenance.SuspendLayout();
			this.tpgAuthentication.SuspendLayout();
			this.tpgEntertainment.SuspendLayout();
			this.tpgItemCategory.SuspendLayout();
			this.tpgSignature.SuspendLayout();
			this.tpgSubject.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAuthentication)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEntertainment)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvItemCategory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSignature)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
			this.SuspendLayout();
			// 
			// tcMaintenance
			// 
			this.tcMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tcMaintenance.Controls.Add(this.tpgAuthentication);
			this.tcMaintenance.Controls.Add(this.tpgEntertainment);
			this.tcMaintenance.Controls.Add(this.tpgItemCategory);
			this.tcMaintenance.Controls.Add(this.tpgSignature);
			this.tcMaintenance.Controls.Add(this.tpgSubject);
			this.tcMaintenance.Location = new System.Drawing.Point(1, 0);
			this.tcMaintenance.Name = "tcMaintenance";
			this.tcMaintenance.SelectedIndex = 0;
			this.tcMaintenance.Size = new System.Drawing.Size(851, 518);
			this.tcMaintenance.TabIndex = 0;
			// 
			// tpgAuthentication
			// 
			this.tpgAuthentication.BackColor = System.Drawing.SystemColors.Control;
			this.tpgAuthentication.Controls.Add(this.cboAuthenticationSignature);
			this.tpgAuthentication.Controls.Add(this.cboAuthenticationItem);
			this.tpgAuthentication.Controls.Add(this.txtAuthenticationCode);
			this.tpgAuthentication.Controls.Add(this.cboAuthenticationService);
			this.tpgAuthentication.Controls.Add(this.label4);
			this.tpgAuthentication.Controls.Add(this.label3);
			this.tpgAuthentication.Controls.Add(this.label2);
			this.tpgAuthentication.Controls.Add(this.label1);
			this.tpgAuthentication.Controls.Add(this.dgvAuthentication);
			this.tpgAuthentication.Location = new System.Drawing.Point(4, 29);
			this.tpgAuthentication.Name = "tpgAuthentication";
			this.tpgAuthentication.Padding = new System.Windows.Forms.Padding(3);
			this.tpgAuthentication.Size = new System.Drawing.Size(843, 485);
			this.tpgAuthentication.TabIndex = 0;
			this.tpgAuthentication.Text = "Authentication";
			// 
			// tpgEntertainment
			// 
			this.tpgEntertainment.BackColor = System.Drawing.SystemColors.Control;
			this.tpgEntertainment.Controls.Add(this.chkIsSportTeam);
			this.tpgEntertainment.Controls.Add(this.label10);
			this.tpgEntertainment.Controls.Add(this.clbEntertainmentSignatures);
			this.tpgEntertainment.Controls.Add(this.label9);
			this.tpgEntertainment.Controls.Add(this.clbEntertainmentSubjects);
			this.tpgEntertainment.Controls.Add(this.label8);
			this.tpgEntertainment.Controls.Add(this.label7);
			this.tpgEntertainment.Controls.Add(this.clbEntertainmentItems);
			this.tpgEntertainment.Controls.Add(this.cboEntertainmentCategory);
			this.tpgEntertainment.Controls.Add(this.txtEntertainmentName);
			this.tpgEntertainment.Controls.Add(this.label6);
			this.tpgEntertainment.Controls.Add(this.label5);
			this.tpgEntertainment.Controls.Add(this.dgvEntertainment);
			this.tpgEntertainment.Location = new System.Drawing.Point(4, 29);
			this.tpgEntertainment.Name = "tpgEntertainment";
			this.tpgEntertainment.Size = new System.Drawing.Size(843, 485);
			this.tpgEntertainment.TabIndex = 1;
			this.tpgEntertainment.Text = "Entertainment";
			// 
			// tpgItemCategory
			// 
			this.tpgItemCategory.BackColor = System.Drawing.SystemColors.Control;
			this.tpgItemCategory.Controls.Add(this.clbItemCategoryItems);
			this.tpgItemCategory.Controls.Add(this.label12);
			this.tpgItemCategory.Controls.Add(this.txtItemCategoryName);
			this.tpgItemCategory.Controls.Add(this.label11);
			this.tpgItemCategory.Controls.Add(this.dgvItemCategory);
			this.tpgItemCategory.Location = new System.Drawing.Point(4, 29);
			this.tpgItemCategory.Name = "tpgItemCategory";
			this.tpgItemCategory.Size = new System.Drawing.Size(843, 485);
			this.tpgItemCategory.TabIndex = 2;
			this.tpgItemCategory.Text = "Item Categories";
			// 
			// tpgSignature
			// 
			this.tpgSignature.BackColor = System.Drawing.SystemColors.Control;
			this.tpgSignature.Controls.Add(this.clbSignatureItems);
			this.tpgSignature.Controls.Add(this.cboSignatureEntertainment);
			this.tpgSignature.Controls.Add(this.txtSignatureJerseyNumber);
			this.tpgSignature.Controls.Add(this.txtSignatureLastName);
			this.tpgSignature.Controls.Add(this.txtSignatureFirstName);
			this.tpgSignature.Controls.Add(this.label17);
			this.tpgSignature.Controls.Add(this.label16);
			this.tpgSignature.Controls.Add(this.lblJerseyNumber);
			this.tpgSignature.Controls.Add(this.label14);
			this.tpgSignature.Controls.Add(this.label13);
			this.tpgSignature.Controls.Add(this.dgvSignature);
			this.tpgSignature.Location = new System.Drawing.Point(4, 29);
			this.tpgSignature.Name = "tpgSignature";
			this.tpgSignature.Size = new System.Drawing.Size(843, 485);
			this.tpgSignature.TabIndex = 3;
			this.tpgSignature.Text = "Signatures";
			// 
			// tpgSubject
			// 
			this.tpgSubject.BackColor = System.Drawing.SystemColors.Control;
			this.tpgSubject.Controls.Add(this.clbSubjectItem);
			this.tpgSubject.Controls.Add(this.cboSubjectEntertainment);
			this.tpgSubject.Controls.Add(this.txtSubjectName);
			this.tpgSubject.Controls.Add(this.label20);
			this.tpgSubject.Controls.Add(this.label19);
			this.tpgSubject.Controls.Add(this.label18);
			this.tpgSubject.Controls.Add(this.label15);
			this.tpgSubject.Controls.Add(this.dgvSubject);
			this.tpgSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.tpgSubject.Location = new System.Drawing.Point(4, 29);
			this.tpgSubject.Name = "tpgSubject";
			this.tpgSubject.Size = new System.Drawing.Size(843, 485);
			this.tpgSubject.TabIndex = 4;
			this.tpgSubject.Text = "Subjects";
			// 
			// dgvAuthentication
			// 
			this.dgvAuthentication.AllowUserToAddRows = false;
			this.dgvAuthentication.AllowUserToDeleteRows = false;
			this.dgvAuthentication.AllowUserToOrderColumns = true;
			this.dgvAuthentication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvAuthentication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAuthentication.Location = new System.Drawing.Point(0, 0);
			this.dgvAuthentication.Name = "dgvAuthentication";
			this.dgvAuthentication.ReadOnly = true;
			this.dgvAuthentication.RowHeadersWidth = 51;
			this.dgvAuthentication.RowTemplate.Height = 29;
			this.dgvAuthentication.Size = new System.Drawing.Size(843, 384);
			this.dgvAuthentication.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(7, 405);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Authentication Service:";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(7, 448);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(157, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Authentication Code:";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(398, 405);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Item:";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(398, 448);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "Signature:";
			// 
			// cboAuthenticationService
			// 
			this.cboAuthenticationService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cboAuthenticationService.FormattingEnabled = true;
			this.cboAuthenticationService.Location = new System.Drawing.Point(185, 402);
			this.cboAuthenticationService.Name = "cboAuthenticationService";
			this.cboAuthenticationService.Size = new System.Drawing.Size(196, 28);
			this.cboAuthenticationService.TabIndex = 5;
			// 
			// txtAuthenticationCode
			// 
			this.txtAuthenticationCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtAuthenticationCode.Location = new System.Drawing.Point(185, 445);
			this.txtAuthenticationCode.MaxLength = 20;
			this.txtAuthenticationCode.Name = "txtAuthenticationCode";
			this.txtAuthenticationCode.Size = new System.Drawing.Size(196, 27);
			this.txtAuthenticationCode.TabIndex = 6;
			// 
			// cboAuthenticationItem
			// 
			this.cboAuthenticationItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cboAuthenticationItem.FormattingEnabled = true;
			this.cboAuthenticationItem.Location = new System.Drawing.Point(484, 402);
			this.cboAuthenticationItem.Name = "cboAuthenticationItem";
			this.cboAuthenticationItem.Size = new System.Drawing.Size(211, 28);
			this.cboAuthenticationItem.TabIndex = 7;
			// 
			// cboAuthenticationSignature
			// 
			this.cboAuthenticationSignature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cboAuthenticationSignature.FormattingEnabled = true;
			this.cboAuthenticationSignature.Location = new System.Drawing.Point(484, 444);
			this.cboAuthenticationSignature.Name = "cboAuthenticationSignature";
			this.cboAuthenticationSignature.Size = new System.Drawing.Size(211, 28);
			this.cboAuthenticationSignature.TabIndex = 8;
			// 
			// btnApply
			// 
			this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnApply.Location = new System.Drawing.Point(654, 524);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(94, 29);
			this.btnApply.TabIndex = 16;
			this.btnApply.Text = "Apply";
			this.btnApply.UseVisualStyleBackColor = true;
			// 
			// btnReset
			// 
			this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReset.Location = new System.Drawing.Point(554, 524);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(94, 29);
			this.btnReset.TabIndex = 15;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			// 
			// btnCopy
			// 
			this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCopy.Location = new System.Drawing.Point(454, 524);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(94, 29);
			this.btnCopy.TabIndex = 14;
			this.btnCopy.Text = "Copy";
			this.btnCopy.UseVisualStyleBackColor = true;
			// 
			// btnNew
			// 
			this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNew.Location = new System.Drawing.Point(354, 524);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(94, 29);
			this.btnNew.TabIndex = 13;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnDelete.ForeColor = System.Drawing.Color.Red;
			this.btnDelete.Location = new System.Drawing.Point(754, 524);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(94, 29);
			this.btnDelete.TabIndex = 17;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// dgvEntertainment
			// 
			this.dgvEntertainment.AllowUserToAddRows = false;
			this.dgvEntertainment.AllowUserToDeleteRows = false;
			this.dgvEntertainment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvEntertainment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEntertainment.Location = new System.Drawing.Point(0, 0);
			this.dgvEntertainment.Name = "dgvEntertainment";
			this.dgvEntertainment.ReadOnly = true;
			this.dgvEntertainment.RowHeadersWidth = 51;
			this.dgvEntertainment.RowTemplate.Height = 29;
			this.dgvEntertainment.Size = new System.Drawing.Size(843, 188);
			this.dgvEntertainment.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(7, 231);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 20);
			this.label5.TabIndex = 1;
			this.label5.Text = "Name:";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(371, 231);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 20);
			this.label6.TabIndex = 2;
			this.label6.Text = "Category:";
			// 
			// txtEntertainmentName
			// 
			this.txtEntertainmentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtEntertainmentName.Location = new System.Drawing.Point(68, 228);
			this.txtEntertainmentName.MaxLength = 100;
			this.txtEntertainmentName.Name = "txtEntertainmentName";
			this.txtEntertainmentName.Size = new System.Drawing.Size(297, 27);
			this.txtEntertainmentName.TabIndex = 3;
			// 
			// cboEntertainmentCategory
			// 
			this.cboEntertainmentCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cboEntertainmentCategory.FormattingEnabled = true;
			this.cboEntertainmentCategory.Location = new System.Drawing.Point(454, 228);
			this.cboEntertainmentCategory.Name = "cboEntertainmentCategory";
			this.cboEntertainmentCategory.Size = new System.Drawing.Size(202, 28);
			this.cboEntertainmentCategory.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label7.Location = new System.Drawing.Point(9, 279);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 20);
			this.label7.TabIndex = 6;
			this.label7.Text = "Items:";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label8.Location = new System.Drawing.Point(266, 279);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(71, 20);
			this.label8.TabIndex = 7;
			this.label8.Text = "Subjects:";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label9.Location = new System.Drawing.Point(541, 279);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 20);
			this.label9.TabIndex = 9;
			this.label9.Text = "Signatures:";
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label10.Location = new System.Drawing.Point(7, 191);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(550, 20);
			this.label10.TabIndex = 11;
			this.label10.Text = "Entertainment entries are groups for subjects, such as team names, movie names, e" +
    "tc.";
			// 
			// dgvItemCategory
			// 
			this.dgvItemCategory.AllowUserToAddRows = false;
			this.dgvItemCategory.AllowUserToDeleteRows = false;
			this.dgvItemCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvItemCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvItemCategory.Location = new System.Drawing.Point(0, 3);
			this.dgvItemCategory.Name = "dgvItemCategory";
			this.dgvItemCategory.ReadOnly = true;
			this.dgvItemCategory.RowHeadersWidth = 51;
			this.dgvItemCategory.RowTemplate.Height = 29;
			this.dgvItemCategory.Size = new System.Drawing.Size(843, 269);
			this.dgvItemCategory.TabIndex = 0;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label11.Location = new System.Drawing.Point(7, 295);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(55, 20);
			this.label11.TabIndex = 1;
			this.label11.Text = "Name:";
			// 
			// txtItemCategoryName
			// 
			this.txtItemCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtItemCategoryName.Location = new System.Drawing.Point(68, 292);
			this.txtItemCategoryName.MaxLength = 20;
			this.txtItemCategoryName.Name = "txtItemCategoryName";
			this.txtItemCategoryName.Size = new System.Drawing.Size(225, 27);
			this.txtItemCategoryName.TabIndex = 2;
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label12.Location = new System.Drawing.Point(315, 295);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(53, 20);
			this.label12.TabIndex = 3;
			this.label12.Text = "Items:";
			// 
			// clbItemCategoryItems
			// 
			this.clbItemCategoryItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.clbItemCategoryItems.FormattingEnabled = true;
			this.clbItemCategoryItems.Location = new System.Drawing.Point(374, 292);
			this.clbItemCategoryItems.Name = "clbItemCategoryItems";
			this.clbItemCategoryItems.ScrollAlwaysVisible = true;
			this.clbItemCategoryItems.Size = new System.Drawing.Size(192, 180);
			this.clbItemCategoryItems.TabIndex = 11;
			// 
			// dgvSignature
			// 
			this.dgvSignature.AllowUserToAddRows = false;
			this.dgvSignature.AllowUserToDeleteRows = false;
			this.dgvSignature.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSignature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSignature.Location = new System.Drawing.Point(0, 0);
			this.dgvSignature.Name = "dgvSignature";
			this.dgvSignature.ReadOnly = true;
			this.dgvSignature.RowHeadersWidth = 51;
			this.dgvSignature.RowTemplate.Height = 29;
			this.dgvSignature.Size = new System.Drawing.Size(843, 253);
			this.dgvSignature.TabIndex = 0;
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label13.Location = new System.Drawing.Point(7, 262);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(90, 20);
			this.label13.TabIndex = 1;
			this.label13.Text = "First Name:";
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label14.Location = new System.Drawing.Point(7, 295);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(88, 20);
			this.label14.TabIndex = 2;
			this.label14.Text = "Last Name:";
			// 
			// lblJerseyNumber
			// 
			this.lblJerseyNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblJerseyNumber.AutoSize = true;
			this.lblJerseyNumber.Location = new System.Drawing.Point(7, 328);
			this.lblJerseyNumber.Name = "lblJerseyNumber";
			this.lblJerseyNumber.Size = new System.Drawing.Size(109, 20);
			this.lblJerseyNumber.TabIndex = 3;
			this.lblJerseyNumber.Text = "Jersey Number:";
			this.lblJerseyNumber.Visible = false;
			// 
			// label16
			// 
			this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label16.Location = new System.Drawing.Point(294, 262);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(114, 20);
			this.label16.TabIndex = 4;
			this.label16.Text = "Entertainment:";
			// 
			// label17
			// 
			this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label17.Location = new System.Drawing.Point(294, 295);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(53, 20);
			this.label17.TabIndex = 5;
			this.label17.Text = "Items:";
			// 
			// clbEntertainmentSignatures
			// 
			this.clbEntertainmentSignatures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.clbEntertainmentSignatures.FormattingEnabled = true;
			this.clbEntertainmentSignatures.Location = new System.Drawing.Point(628, 279);
			this.clbEntertainmentSignatures.Name = "clbEntertainmentSignatures";
			this.clbEntertainmentSignatures.ScrollAlwaysVisible = true;
			this.clbEntertainmentSignatures.Size = new System.Drawing.Size(192, 180);
			this.clbEntertainmentSignatures.TabIndex = 10;
			// 
			// clbEntertainmentSubjects
			// 
			this.clbEntertainmentSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.clbEntertainmentSubjects.FormattingEnabled = true;
			this.clbEntertainmentSubjects.Location = new System.Drawing.Point(343, 279);
			this.clbEntertainmentSubjects.Name = "clbEntertainmentSubjects";
			this.clbEntertainmentSubjects.ScrollAlwaysVisible = true;
			this.clbEntertainmentSubjects.Size = new System.Drawing.Size(192, 180);
			this.clbEntertainmentSubjects.TabIndex = 8;
			// 
			// chkIsSportTeam
			// 
			this.chkIsSportTeam.AutoSize = true;
			this.chkIsSportTeam.Location = new System.Drawing.Point(682, 230);
			this.chkIsSportTeam.Name = "chkIsSportTeam";
			this.chkIsSportTeam.Size = new System.Drawing.Size(107, 24);
			this.chkIsSportTeam.TabIndex = 12;
			this.chkIsSportTeam.Text = "Sport Team";
			this.chkIsSportTeam.UseVisualStyleBackColor = true;
			// 
			// txtSignatureFirstName
			// 
			this.txtSignatureFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtSignatureFirstName.Location = new System.Drawing.Point(122, 259);
			this.txtSignatureFirstName.MaxLength = 15;
			this.txtSignatureFirstName.Name = "txtSignatureFirstName";
			this.txtSignatureFirstName.Size = new System.Drawing.Size(149, 27);
			this.txtSignatureFirstName.TabIndex = 6;
			// 
			// txtSignatureLastName
			// 
			this.txtSignatureLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtSignatureLastName.Location = new System.Drawing.Point(122, 292);
			this.txtSignatureLastName.MaxLength = 20;
			this.txtSignatureLastName.Name = "txtSignatureLastName";
			this.txtSignatureLastName.Size = new System.Drawing.Size(149, 27);
			this.txtSignatureLastName.TabIndex = 7;
			// 
			// txtSignatureJerseyNumber
			// 
			this.txtSignatureJerseyNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtSignatureJerseyNumber.Location = new System.Drawing.Point(122, 325);
			this.txtSignatureJerseyNumber.MaxLength = 2;
			this.txtSignatureJerseyNumber.Name = "txtSignatureJerseyNumber";
			this.txtSignatureJerseyNumber.Size = new System.Drawing.Size(38, 27);
			this.txtSignatureJerseyNumber.TabIndex = 8;
			this.txtSignatureJerseyNumber.Visible = false;
			// 
			// cboSignatureEntertainment
			// 
			this.cboSignatureEntertainment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cboSignatureEntertainment.FormattingEnabled = true;
			this.cboSignatureEntertainment.Location = new System.Drawing.Point(414, 259);
			this.cboSignatureEntertainment.Name = "cboSignatureEntertainment";
			this.cboSignatureEntertainment.Size = new System.Drawing.Size(192, 28);
			this.cboSignatureEntertainment.TabIndex = 9;
			// 
			// clbSignatureItems
			// 
			this.clbSignatureItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.clbSignatureItems.FormattingEnabled = true;
			this.clbSignatureItems.Location = new System.Drawing.Point(414, 292);
			this.clbSignatureItems.Name = "clbSignatureItems";
			this.clbSignatureItems.ScrollAlwaysVisible = true;
			this.clbSignatureItems.Size = new System.Drawing.Size(192, 180);
			this.clbSignatureItems.TabIndex = 12;
			// 
			// dgvSubject
			// 
			this.dgvSubject.AllowUserToAddRows = false;
			this.dgvSubject.AllowUserToDeleteRows = false;
			this.dgvSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSubject.Location = new System.Drawing.Point(0, 0);
			this.dgvSubject.Name = "dgvSubject";
			this.dgvSubject.ReadOnly = true;
			this.dgvSubject.RowHeadersWidth = 51;
			this.dgvSubject.RowTemplate.Height = 29;
			this.dgvSubject.Size = new System.Drawing.Size(843, 225);
			this.dgvSubject.TabIndex = 0;
			// 
			// label15
			// 
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label15.Location = new System.Drawing.Point(6, 228);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(724, 40);
			this.label15.TabIndex = 12;
			this.label15.Text = "Subjects are a person/character related to a specific item such as a character in" +
    " a group of movie characters, etc. Subjects are not directly related to signatur" +
    "es.";
			// 
			// clbEntertainmentItems
			// 
			this.clbEntertainmentItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.clbEntertainmentItems.FormattingEnabled = true;
			this.clbEntertainmentItems.Location = new System.Drawing.Point(68, 279);
			this.clbEntertainmentItems.Name = "clbEntertainmentItems";
			this.clbEntertainmentItems.ScrollAlwaysVisible = true;
			this.clbEntertainmentItems.Size = new System.Drawing.Size(192, 180);
			this.clbEntertainmentItems.TabIndex = 5;
			// 
			// label18
			// 
			this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label18.Location = new System.Drawing.Point(7, 294);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(55, 20);
			this.label18.TabIndex = 13;
			this.label18.Text = "Name:";
			// 
			// label19
			// 
			this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label19.Location = new System.Drawing.Point(7, 329);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(114, 20);
			this.label19.TabIndex = 14;
			this.label19.Text = "Entertainment:";
			// 
			// label20
			// 
			this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label20.Location = new System.Drawing.Point(332, 294);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(53, 20);
			this.label20.TabIndex = 15;
			this.label20.Text = "Items:";
			// 
			// txtSubjectName
			// 
			this.txtSubjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtSubjectName.Location = new System.Drawing.Point(127, 291);
			this.txtSubjectName.MaxLength = 50;
			this.txtSubjectName.Name = "txtSubjectName";
			this.txtSubjectName.Size = new System.Drawing.Size(187, 27);
			this.txtSubjectName.TabIndex = 16;
			// 
			// cboSubjectEntertainment
			// 
			this.cboSubjectEntertainment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cboSubjectEntertainment.FormattingEnabled = true;
			this.cboSubjectEntertainment.Location = new System.Drawing.Point(127, 326);
			this.cboSubjectEntertainment.Name = "cboSubjectEntertainment";
			this.cboSubjectEntertainment.Size = new System.Drawing.Size(187, 28);
			this.cboSubjectEntertainment.TabIndex = 17;
			// 
			// clbSubjectItem
			// 
			this.clbSubjectItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.clbSubjectItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.clbSubjectItem.FormattingEnabled = true;
			this.clbSubjectItem.Location = new System.Drawing.Point(391, 294);
			this.clbSubjectItem.Name = "clbSubjectItem";
			this.clbSubjectItem.ScrollAlwaysVisible = true;
			this.clbSubjectItem.Size = new System.Drawing.Size(192, 180);
			this.clbSubjectItem.TabIndex = 18;
			// 
			// FrmMaintenance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(853, 565);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnApply);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnCopy);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.tcMaintenance);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmMaintenance";
			this.Text = "Maintenance";
			this.tcMaintenance.ResumeLayout(false);
			this.tpgAuthentication.ResumeLayout(false);
			this.tpgAuthentication.PerformLayout();
			this.tpgEntertainment.ResumeLayout(false);
			this.tpgEntertainment.PerformLayout();
			this.tpgItemCategory.ResumeLayout(false);
			this.tpgItemCategory.PerformLayout();
			this.tpgSignature.ResumeLayout(false);
			this.tpgSignature.PerformLayout();
			this.tpgSubject.ResumeLayout(false);
			this.tpgSubject.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAuthentication)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEntertainment)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvItemCategory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSignature)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private TabControl tcMaintenance;
		private TabPage tpgAuthentication;
		private TabPage tpgEntertainment;
		private TabPage tpgItemCategory;
		private TabPage tpgSignature;
		private TabPage tpgSubject;
		private ComboBox cboAuthenticationSignature;
		private ComboBox cboAuthenticationItem;
		private TextBox txtAuthenticationCode;
		private ComboBox cboAuthenticationService;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private DataGridView dgvAuthentication;
		private Button btnApply;
		private Button btnReset;
		private Button btnCopy;
		private Button btnNew;
		private TextBox txtEntertainmentName;
		private Label label6;
		private Label label5;
		private DataGridView dgvEntertainment;
		private Button btnDelete;
		private Label label10;
		private Label label9;
		private Label label8;
		private Label label7;
		private ComboBox cboEntertainmentCategory;
		private DataGridView dgvItemCategory;
		private TextBox txtItemCategoryName;
		private Label label11;
		private CheckedListBox clbItemCategoryItems;
		private Label label12;
		private DataGridView dgvSignature;
		private Label lblJerseyNumber;
		private Label label14;
		private Label label13;
		private Label label17;
		private Label label16;
		private CheckBox chkIsSportTeam;
		private CheckedListBox clbEntertainmentSignatures;
		private CheckedListBox clbEntertainmentSubjects;
		private TextBox txtSignatureJerseyNumber;
		private TextBox txtSignatureLastName;
		private TextBox txtSignatureFirstName;
		private ComboBox cboSignatureEntertainment;
		private CheckedListBox clbSignatureItems;
		private Label label15;
		private DataGridView dgvSubject;
		private CheckedListBox clbEntertainmentItems;
		private ComboBox cboSubjectEntertainment;
		private TextBox txtSubjectName;
		private Label label20;
		private Label label19;
		private Label label18;
		private CheckedListBox clbSubjectItem;
	}
}