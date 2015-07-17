
using System.Collections.Generic;
namespace WebAPISandbox.Models
{
	public class Customer
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EmailAddress { get; set; }
		public string Phone { get; set; }

		public virtual ICollection<Address> Addresses { get; set; }
		public virtual ICollection<Order> Orders { get; set; }
	}
}