using myshop.Entities.Models;

namespace myshop.Entities.ViewModels;
public class ShoppingCartVM
{
    public IEnumerable<ShoppingCart> CartsList { get; set; } = null!;
    public OrderHeader OrderHeader { get; set; } = null!;
}
