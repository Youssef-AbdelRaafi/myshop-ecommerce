using myshop.Entities.Models;

namespace myshop.Entities.ViewModels;
public class OrderVM
{
    public OrderHeader OrderHeader { get; set; } = null!;

    public IEnumerable<OrderDetail> OrderDetails { get; set; } = null!;
}
