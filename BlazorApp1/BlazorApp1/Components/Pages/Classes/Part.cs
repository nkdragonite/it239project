namespace BlazorApp1.Components.Pages.Classes
{
	public class Part
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Vendor { get; set; }
		public int VendorID { get; set; }
		public int Quantity { get; set; }
		public Part(int id, string name, string description, int vendorid, int quantity)
		{
			Id = id;
			Name = name;
			Description = description;
			VendorID = vendorid;
			Quantity = quantity;
		}
		public void GetVendor()
		{
			//Gets Vendor name from vendor ID
		}
	}
}
