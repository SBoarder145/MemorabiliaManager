using MemorabiliaManager.Data;
using MemorabiliaManager.Domain;

namespace MemorabiliaManager.UI.Maintenance
{
	public partial class FrmMaintenance : Form
	{
		private static readonly MemorabiliaManagerContext _context = new();
		private static EntertainmentCategory? selectedEC = null;
		private static int prevRowIndex = 0;
		private readonly DataGridViewTextBoxColumn isModifiedColumn = new()
		{
			DataPropertyName = "IsModified",
			DefaultCellStyle = new DataGridViewCellStyle
			{
				Alignment = DataGridViewContentAlignment.MiddleCenter,
				Font = new Font("Segoe UI", 16F, FontStyle.Bold),
				ForeColor = Color.Red
			},
			Resizable = DataGridViewTriState.False,
			Width = 38
		};

		public FrmMaintenance()
		{
			InitializeComponent();
			InitializeGrid();
		}

		private void tcMaintenance_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				InitializeGrid();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		private void InitializeGrid()
		{
			var selectedTabPageName = tcMaintenance.TabPages[tcMaintenance.SelectedIndex].Name.ToLower();

			if (selectedTabPageName.Equals(tpgAuthenticationService.Name.ToLower()))
			{

			}
			else if (selectedTabPageName.Equals(tpgAuthentication.Name.ToLower()))
			{

			}
			else if (selectedTabPageName.Equals(tpgEntertainmentCategory.Name.ToLower()))
			{
				InitializeEntertainmentCategoryGrid();
			}
			else if (selectedTabPageName.Equals(tpgEntertainment.Name.ToLower()))
			{

			}
			else if (selectedTabPageName.Equals(tpgItemCategory.Name.ToLower()))
			{

			}
			else if (selectedTabPageName.Equals(tpgSignature.Name.ToLower()))
			{

			}
			else if (selectedTabPageName.Equals(tpgSubject.Name.ToLower()))
			{

			}
		}

		#region InitializeGrids
		private void InitializeEntertainmentCategoryGrid()
		{
			if (dgvEntertainmentCategory.DataSource == null)
			{
				dgvEntertainmentCategory.DataSource = _context.EntertainmentCategories.ToList();
				dgvEntertainmentCategory.Columns[0].Visible = false;
				dgvEntertainmentCategory.Columns[2].HeaderText = "Sport";

				dgvEntertainmentCategory.Columns.Insert(0, isModifiedColumn);
			}
		}
		#endregion

		private void dgvEntertainmentCategory_SelectionChanged(object sender, EventArgs e)
		{
			try
			{
				if (dgvEntertainmentCategory.SelectedRows.Count > 0)
				{
					if (selectedEC == null)
					{
						selectedEC = (EntertainmentCategory)dgvEntertainmentCategory.SelectedRows[0].DataBoundItem;
						txtEntertainmentCategoryName.Text = selectedEC.Name;
						chkEntertainmentCategoryIsSport.Checked = selectedEC.IsSport;
						prevRowIndex = 0;
					}
					else if (!selectedEC.Equals((EntertainmentCategory)dgvEntertainmentCategory.SelectedRows[0].DataBoundItem))
					{
						var name = txtEntertainmentCategoryName.Text;
						var isModded = false;

						// update object
						if (!string.IsNullOrWhiteSpace(name) && !selectedEC.Name.Equals(name))
						{
							selectedEC.Name = name;
							isModded = true;
						}

						if (selectedEC.IsSport != chkEntertainmentCategoryIsSport.Checked)
						{
							selectedEC.IsSport = chkEntertainmentCategoryIsSport.Checked;
							isModded = true;
						}

						if (isModded)
						{
							dgvEntertainmentCategory.Rows[prevRowIndex].Cells[0].Value = "*";
						}

						// load new selected row
						selectedEC = (EntertainmentCategory)dgvEntertainmentCategory.SelectedRows[0].DataBoundItem;
						txtEntertainmentCategoryName.Text = selectedEC.Name;
						chkEntertainmentCategoryIsSport.Checked = selectedEC.IsSport;
						prevRowIndex = dgvEntertainmentCategory.SelectedRows[0].Index;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}