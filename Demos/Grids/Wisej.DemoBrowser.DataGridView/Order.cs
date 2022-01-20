namespace Wisej.DemoBrowser.DataGridView
{
	public class Order
	{
		public int OrderId { get; set; }
		public string Item { get; set; }
		public int Quantity { get; set; }
		public decimal UnitPrice { get; set; }
		public int? LotNumber { get; set; }
		public decimal? TotalPrice => (decimal) UnitPrice * Quantity;
	}
}