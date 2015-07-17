
namespace WebAPISandbox.Models
{
	public class Item
	{
		public int Id { get; set; }
		public string ItemNumber { get; set; }
		public decimal UnitPrice { get; set; }
		public int Quantity { get; set; }
		public int OrderId { get; set; }
		public virtual Order Order { get; set; }
	}
}