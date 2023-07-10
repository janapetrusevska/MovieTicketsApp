using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eshop.Web.Models.Domain
{
    public class Ticket : BaseEntity
    {
        [Required]
        public int Price { get; set; }
        [Required]
        public string MovieName { get; set; }
        [Required]
        public DateTime DateValid { get; set; }

        public string Description { get; set; }

        public virtual ICollection<TicketInShoppingCart> TicketInShoppingCarts { get; set; }

        public virtual ICollection<TicketInOrder> Orders { get; set; }


    }
}
