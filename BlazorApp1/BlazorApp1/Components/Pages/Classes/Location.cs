using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Components.Pages.Classes
{
	[Table("Location")]
	public class Location
	{
		[Key, Required, Column("Location_Id")]
		public int LocationID { get; set; }
		[Required, Column("Location_Name")]
		public string LocationName { get; set; }
		[Required, Column("Employee_Id")]
		public Employee Manager { get; set; }
	}
}
