namespace BlazorApp1.Components.Pages.Classes
{
	public enum Permission
	{
		CLevel,
		Manager,
		Floor
	}
	public class Employee
	{
		public string FName { get; set; }
		public int EmployeeId { get; set; }
		public string LName { get; set; }
		public Permission Permission { get; set; }
		public Location Location { get; set; }
		private string Password { get; set; }
		public Employee(string fname, string lname, int id, Permission permission, Location location, string password) 
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
		}

	}
}
