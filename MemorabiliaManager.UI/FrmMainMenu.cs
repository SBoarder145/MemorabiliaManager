using MemorabiliaManager.UI.Maintenance;

namespace MemorabiliaManager
{
	public partial class FrmMainMenu : Form
	{
		public FrmMainMenu()
		{
			InitializeComponent();
		}

		private void btnViewItems_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Not implemented yet", "Pending", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void btnViewSignatures_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Not implemented yet", "Pending", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void btnMaintenance_Click(object sender, EventArgs e)
		{
			var form = new FrmMaintenance();
			form.Show();
		}

		private void btnAddItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Not implemented yet", "Pending", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void btnAddSignature_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Not implemented yet", "Pending", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void btnAddSignatureUploadImage_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Not implemented yet", "Pending", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}