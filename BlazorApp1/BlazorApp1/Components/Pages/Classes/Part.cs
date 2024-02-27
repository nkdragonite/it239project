using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Components.Pages.Classes
{
	[Table("Part")]
	public class Part
	{
		[Key, Required, Column("Part_Id")]
		public int Id { get; set; }
		[Required, Column("Part_Name")]
		public string Name { get; set; }
		[Required, Column("Part_Desc")]
		public string Description { get; set; }
		[Required, Column("Vendor_Id")]
		public int VendorID { get; set; }
		[Required, Column("Part_Quantity")]
		public int Quantity { get; set; }
		[Required, Column("Part_Cost")]
		public decimal Cost { get; set; }
		[Required, Column("Location_Id")]
		public int LocationID { get; set; }
		public Part(int id, string name, string description, int vendorid, int quantity)
		{
			Id = id;
			Name = name;
			Description = description;
			VendorID = vendorid;
			Quantity = quantity;
		}
	}
}
