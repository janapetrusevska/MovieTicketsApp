using Eshop.Web.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Web.Models.DTO
{
    public class TicketsFilteredByDateDto
    {
        public List<Ticket> AllTickets { get; set; }
        public DateTime CurrentDate { get; set; }
    }
}
