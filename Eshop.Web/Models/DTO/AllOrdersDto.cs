using Eshop.Web.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Web.Models.DTO
{
    public class AllOrdersDto
    {
        public List<Order> Orders { get; set; }
        public string userId { get; set; }
    }
}
