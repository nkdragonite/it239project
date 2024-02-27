using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Components.Pages.Classes
{
	[Table("Employee")]
	public class Employee
	{

		[Key, Required, Column("EMPLOYEE_ID")]
		public uint EmployeeId { get; set; }
		[Required, Column("EMP_FNAME")]
		public string FName { get; set; }
		[Required, Column("EMP_LNAME")]
		public string LName { get; set; }
		[Required, Column("EMP_PERMISSION")]
		public string Permission { get; set; }
		[Required, Column("LOCATION_ID")]
		public Location Location { get; set; }
		[Required, Column("EMP_PASSWORD")]
		private string Password { get; set; }
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
