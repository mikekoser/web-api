using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPISandbox.Models;

namespace WebAPISandbox.Controllers
{
    public class ContactsController : ApiController
    {
		Contact[] contacts = new Contact[]
		{
			new Contact { Id = 1, FirstName = "John", LastName = "Doe", EmailAddress = "johndoe@email.com", Street1 = "123 A St", Street2 = "", City = "Doeville", State = "Kansas", PostalCode = "12345", Country = "United States", Phone = "777-999-2222"},
			new Contact { Id = 2, FirstName = "Jane", LastName = "Doe", EmailAddress = "janedoe@email.com", Street1 = "123 A St", Street2 = "", City = "Doeville", State = "Kansas", PostalCode = "12345", Country = "United States", Phone = "222-333-6666"},
			new Contact { Id = 3, FirstName = "Sally", LastName = "Doe", EmailAddress = "salydoe@email.com", Street1 = "123 A St", Street2 = "", City = "Doeville", State = "Kansas", PostalCode = "12345", Country = "United States", Phone = "444-222-7777"}
		};

		public IEnumerable<Contact> GetAll() 
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
