using Eshop.Web.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Web.Data
{
    public interface IOrderRepository
    {
        public List<Order> GetAllOrders();

        public Order GetOrderDetails(BaseEntity model);
    }
}
