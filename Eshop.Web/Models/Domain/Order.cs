using Eshop.Web.Models.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Web.Models.Domain
{
    public class Order : BaseEntity
    {
        public string UserId { get; set; }
        public EShopAppUser User { get; set; }
        public IEnumerable<TicketInOrder> TicketInOrders { get; set; }
    }
}
