using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPISandbox.Models;

namespace WebAPISandbox.Controllers
{
    public class AddressesController : ApiController
    {
		Address[] contacts = new Address[]
		{
			new Address { Id = 1, Street1 = "123 A St", Street2 = "", City = "Doeville", State = "Kansas", PostalCode = "12345", Country = "United States"},
			new Address { Id = 2, Street1 = "123 A St", Street2 = "", City = "Doeville", State = "Kansas", PostalCode = "12345", Country = "United States"},
			new Address { Id = 3, Street1 = "123 A St", Street2 = "", City = "Doeville", State = "Kansas", PostalCode = "12345", Country = "United States"}
		};

		public IEnumerable<Address> GetAll() 
		{
			return contacts;
		}

		public IHttpActionResult Get(int id)
		{
			var contact = (from c in contacts where c.Id == id select c).FirstOrDefault();
			if (contact == null)
			{
				return NotFound();
			}
			return Ok(contact);
		}
    }
}
