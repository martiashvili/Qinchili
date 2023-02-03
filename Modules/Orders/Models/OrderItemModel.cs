namespace Modules.Orders
{
    public class OrderItemModel
    {
        public int OrderItemId { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public long Price { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
