using Eshop.Web.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Web.Models.DTO
{
    public class AllTicketsFromGenreDto
    {
        public List<Ticket> Tickets { get; set; }
        public string Genre { get; set; }
    }
}
