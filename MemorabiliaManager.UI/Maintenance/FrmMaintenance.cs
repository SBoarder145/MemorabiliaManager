using System.Data;

namespace MemorabiliaManager.UI.Maintenance
{
	public partial class FrmMaintenance : Form
	{
		public FrmMaintenance()
		{
			InitializeComponent();
			var editableEntities = new DataTable();
			editableEntities.Rows.Add("authentication", "Authentications");
			//{
			//	{ "authentication", "Authentications" },
			//	{ "entertainment", "Entertainment" },
			//	{ "image", "Images" },
			//	{ "item", "Items" },
			//	{ "itemCategory", "Item Categories" },
			//	{ "itemImage", "Item/Image Relationships" },
			//	{ "itemSignature", "Item/Signature Relationships" },
			//	{ "itemSubject", "Item/Subject Relationships" },
			//	{ "signature", "Signatures" },
			//	{ "subject", "Subject/Characters" }
			//};

			/*
			 * TODO:
			 * Load combo with table names
			 * Load dgvRecords when table name is selected
			 *		Save deep copy of records in case of reload
			 * [check how to CUD on dgv]
			 * Update DB with changes when Apply/Submit clicked
			 * Reload dgv on Undo Changes click
			 */
		}
	}

	class Entities
	{
		public string id { get; set; }
		public string value { get; set; }
	}
}
