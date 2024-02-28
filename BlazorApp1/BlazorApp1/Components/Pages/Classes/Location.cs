using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Components.Pages.Classes
{
	[Table("Locations")]
	public class Location
	{
		[Key, Required, Column("Location_Id")]
		public string LocationID { get; set; }
		
		[Column("Location_Name")]
		public string LocationName { get; set; }
		
		//[Required, ForeignKey("EMPLOYEE_ID"), Column("Employee_Id")]
		//public Employee Manager { get; set; }
		
		//[InverseProperty("Location")]
		public List<Part> Parts { get; set; }
		
		
	}
}
