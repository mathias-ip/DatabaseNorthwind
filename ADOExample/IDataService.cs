using System.Collections.Generic;

namespace ADOExample
{
    public interface IDataService
    {
        IList<Category> GetCategories();
        Category GetCategory(int id);
        IList<Orders> GetOrders();
    }
}