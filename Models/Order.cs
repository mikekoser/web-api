using System;
using System.Collections.Generic;

namespace WebAPISandbox.Models
{
	public class Order
	{
		public int Id { get; set; }
		public string OrderNumber { get; set; }
		public DateTime CreatedDate { get; set; }
		public int CustomerId { get; set; }
		public int BillingAddressId { get; set; }
		public int ShippingAddressId { get; set; }
		public virtual Customer Customer { get; set; }
		public virtual Address BillingAddress { get; set; }
		public virtual Address ShippingAddress { get; set; }
		public virtual ICollection<Item> Items { get; set; }
	}
}