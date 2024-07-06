namespace PShop.COTLOI.Models
{
    public interface IDichVuOrder
    {
        bool ValidateCreateOrder(Order order);
        bool ValidateCustomerInformation(string name, string sdt, string diachi);
        bool ValidateProcessOrder(Order order);
        bool ValidateUpdateOrder(Order order);
    }
}