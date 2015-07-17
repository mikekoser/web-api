using System;
using System.Collections.Generic;
using WebAPISandbox.Models;

namespace WebAPISandbox.DAL
{
	public class WebApiDataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<WebAPIDataContext>
	{
		protected override void Seed(WebAPIDataContext context)
		{
			var customers = new List<Customer>
            {
				new Customer{Id = 1, FirstName = "John", LastName = "Doe", EmailAddress = "johndoe@email.com", Phone = "555-444-5555" },
				new Customer{Id = 2, FirstName = "Jane", LastName = "Doe", EmailAddress = "janedoe@email.com", Phone = "222-333-4444" },
				new Customer{Id = 3, FirstName = "Sally", LastName = "Doe", EmailAddress = "sallydoe@email.com", Phone = "444-666-7777" }
            };

			customers.ForEach(c => context.Customers.Add(c));
			context.SaveChanges();
			var addresses = new List<Address>
            {
				new Address{Id = 1, CustomerId = 1, Street1 = "123 A St", City = "Lancaster", State = "PA", PostalCode = "17603", Country = "US" },
				new Address{Id = 2, CustomerId = 1, Street1 = "456 B St", City = "Landisville", State = "PA", PostalCode = "17538", Country = "US" },
				new Address{Id = 3, CustomerId = 2, Street1 = "21 Elk Neck Ln", City = "Kansas City", State = "KS", PostalCode = "44673", Country = "US" },
				new Address{Id = 4, CustomerId = 3, Street1 = "21 High St", Street2 = "Apt 3B", City = "Lancaster", State = "PA", PostalCode = "17601", Country = "US" }            };
			addresses.ForEach(a => context.Addresses.Add(a));
			context.SaveChanges();
			var orders = new List<Order>
            {
				new Order{Id = 1, CustomerId = 1, BillingAddressId = 1, ShippingAddressId = 2, OrderNumber = "0000001", CreatedDate = DateTime.Parse("2014-03-07")},
				new Order{Id = 2, CustomerId = 1, BillingAddressId = 2, ShippingAddressId = 2, OrderNumber = "0000002", CreatedDate = DateTime.Parse("2015-01-25")},
				new Order{Id = 3, CustomerId = 2, BillingAddressId = 3, ShippingAddressId = 3, OrderNumber = "0000003", CreatedDate = DateTime.Parse("2015-07-07")},
				new Order{Id = 4, CustomerId = 3, BillingAddressId = 4, ShippingAddressId = 4, OrderNumber = "0000004", CreatedDate = DateTime.Parse("1998-11-10")}
            };
			orders.ForEach(o => context.Orders.Add(o));
			context.SaveChanges();

			var items = new List<Item>
            {
				new Item{Id = 1, OrderId = 1, ItemNumber = "AAA", Quantity = 2, UnitPrice = 12.75M},
				new Item{Id = 2, OrderId = 1, ItemNumber = "BBB", Quantity = 5, UnitPrice = 3.65M},
				new Item{Id = 3, OrderId = 2, ItemNumber = "AAA", Quantity = 1, UnitPrice = 12.75M},
				new Item{Id = 4, OrderId = 3, ItemNumber = "BBB", Quantity = 2, UnitPrice = 3.65M},
            };
			items.ForEach(i => context.Items.Add(i));
			context.SaveChanges();
		}
	}
}