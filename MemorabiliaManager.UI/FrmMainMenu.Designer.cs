namespace MemorabiliaManager
{
    partial class FrmMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAddSignature = new System.Windows.Forms.Button();
			this.btnAddSignatureUploadImage = new System.Windows.Forms.Button();
			this.btnAddItem = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnViewSignatures = new System.Windows.Forms.Button();
			this.btnMaintenance = new System.Windows.Forms.Button();
			this.btnViewItems = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAddSignature);
			this.groupBox1.Controls.Add(this.btnAddSignatureUploadImage);
			this.groupBox1.Controls.Add(this.btnAddItem);
			this.groupBox1.Location = new System.Drawing.Point(217, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(258, 202);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Quick Actions";
			// 
			// btnAddSignature
			// 
			this.btnAddSignature.Location = new System.Drawing.Point(16, 83);
			this.btnAddSignature.Name = "btnAddSignature";
			this.btnAddSignature.Size = new System.Drawing.Size(227, 51);
			this.btnAddSignature.TabIndex = 3;
			this.btnAddSignature.Text = "Add Signature";
			this.btnAddSignature.UseVisualStyleBackColor = true;
			this.btnAddSignature.Click += new System.EventHandler(this.btnAddSignature_Click);
			// 
			// btnAddSignatureUploadImage
			// 
			this.btnAddSignatureUploadImage.Location = new System.Drawing.Point(16, 140);
			this.btnAddSignatureUploadImage.Name = "btnAddSignatureUploadImage";
			this.btnAddSignatureUploadImage.Size = new System.Drawing.Size(227, 51);
			this.btnAddSignatureUploadImage.TabIndex = 2;
			this.btnAddSignatureUploadImage.Text = "Add Signature && Upload Image";
			this.btnAddSignatureUploadImage.UseVisualStyleBackColor = true;
			this.btnAddSignatureUploadImage.Click += new System.EventHandler(this.btnAddSignatureUploadImage_Click);
			// 
			// btnAddItem
			// 
			this.btnAddItem.Location = new System.Drawing.Point(16, 26);
			this.btnAddItem.Name = "btnAddItem";
			this.btnAddItem.Size = new System.Drawing.Size(227, 51);
			this.btnAddItem.TabIndex = 1;
			this.btnAddItem.Text = "Add Item";
			this.btnAddItem.UseVisualStyleBackColor = true;
			this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnViewSignatures);
			this.groupBox2.Controls.Add(this.btnMaintenance);
			this.groupBox2.Controls.Add(this.btnViewItems);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(199, 202);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Primary Functions";
			// 
			// btnViewSignatures
			// 
			this.btnViewSignatures.Location = new System.Drawing.Point(16, 83);
			this.btnViewSignatures.Name = "btnViewSignatures";
			this.btnViewSignatures.Size = new System.Drawing.Size(167, 51);
			this.btnViewSignatures.TabIndex = 3;
			this.btnViewSignatures.Text = "View Signatures";
			this.btnViewSignatures.UseVisualStyleBackColor = true;
			this.btnViewSignatures.Click += new System.EventHandler(this.btnViewSignatures_Click);
			// 
			// btnMaintenance
			// 
			this.btnMaintenance.Location = new System.Drawing.Point(16, 140);
			this.btnMaintenance.Name = "btnMaintenance";
			this.btnMaintenance.Size = new System.Drawing.Size(167, 51);
			this.btnMaintenance.TabIndex = 2;
			this.btnMaintenance.Text = "Maintenance";
			this.btnMaintenance.UseVisualStyleBackColor = true;
			this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
			// 
			// btnViewItems
			// 
			this.btnViewItems.Location = new System.Drawing.Point(16, 26);
			this.btnViewItems.Name = "btnViewItems";
			this.btnViewItems.Size = new System.Drawing.Size(167, 51);
			this.btnViewItems.TabIndex = 1;
			this.btnViewItems.Text = "View && Maintain Items";
			this.btnViewItems.UseVisualStyleBackColor = true;
			this.btnViewItems.Click += new System.EventHandler(this.btnViewItems_Click);
			// 
			// FrmMainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 226);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmMainMenu";
			this.Text = "Memorabilia Manager";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private GroupBox groupBox1;
		private Button btnAddSignature;
		private Button btnAddSignatureUploadImage;
		private Button btnAddItem;
		private GroupBox groupBox2;
		private Button btnViewSignatures;
		private Button btnMaintenance;
		private Button btnViewItems;
	}
}