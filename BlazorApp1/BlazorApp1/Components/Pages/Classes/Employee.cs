using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Components.Pages.Classes
{
	[Table("Employee")]
	public class Employee
	{

		[Key, Required, Column("EMPLOYEE_ID")]
		public string EmployeeId { get; set; }
		
		[Column("EMPLOYEE_LEVEL")]
		public string Level { get; set; }
		
		[Column("EMPLOYEE_FN")]
		public string FName { get; set; }
		
		[Column("EMPLOYEE_LN")]
		public string LName { get; set; }
		
		//[ForeignKey("LOCATION_ID"), Column("LOCATION_ID")]
		[Column("LOCATION_ID")]
		public string E_Location_Id { get; set; }
		//public Location LocationId { get; set; }
		
		[Column("EMPLOYEE_PASSWORD")]
		private string Password { get; set; }

		[Column("EMPLOYEE_EMAIL")] 
		private string Employee_Email { get; set; }
		
		[Column("SALT")]
		private string Salt { get; set; }
		
		
		/*public Employee(string fname, string lname, uint id, string permission, Location location, string password) 
		{ 
			FName = fname;
			LName = lname;
			Permission = permission;
			Location = location;
			EmployeeId = id;
			Password = HashPwd(password);
		}
		public string HashPwd(string pwd)
		{
			return null;
		}*/

	}
}
