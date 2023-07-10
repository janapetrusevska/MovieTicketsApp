using Eshop.Web.Data;
using Eshop.Web.Models.Domain;
using Eshop.Web.Models.DTO;
using Eshop.Web.Service.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Web.Service
{
    public class TicketService : ITicketService
    {
        private readonly IRepository<Ticket> _ticketRepository;
        private readonly IRepository<TicketInShoppingCart> _ticketInShoppingCartRepository;
        private readonly IUserRepository _userRepository;
        private readonly ILogger<TicketService> _logger;


        public TicketService(IRepository<Ticket> ticketRepository, ILogger<TicketService> logger, IUserRepository userRepository, IRepository<TicketInShoppingCart> ticketInShoppingCartRepository)
        {
            _ticketRepository = ticketRepository;
            _userRepository = userRepository;
            _ticketInShoppingCartRepository = ticketInShoppingCartRepository;
            _logger = logger;
        }


        public bool AddToShoppingCart(AddToShoppingCartDto item, string userID)
        {
            var user = this._userRepository.Get(userID);

            var userShoppingCart = user.UserCart;

            var ticket = this.GetDetailsForProduct(item.SelectedTicketId);

            if (ticket != null && userShoppingCart != null)
            {
                TicketInShoppingCart itemToAdd = new TicketInShoppingCart
                {
                    Id = Guid.NewGuid(),
                    TicketId = ticket.Id,
                    ShoppingCartId = userShoppingCart.Id,
                    Ticket = ticket,
                    ShoppingCart = userShoppingCart,
                    Quantity = item.Quantity
                };
                this._ticketInShoppingCartRepository.Insert(itemToAdd);
                _logger.LogInformation("Ticket was successfully added into Shopping Cart!");

                return true;

            }
            _logger.LogInformation("Something was wrong. TicketId or UserShoppingCart may be unavaliable!");
            return false;
        }

        public void CreateNewProduct(Ticket t)
        {
            this._ticketRepository.Insert(t);
        }

        public void DeleteProduct(Guid id)
        {
            var product = this.GetDetailsForProduct(id);
            this._ticketRepository.Delete(product);
        }

        public List<Ticket> GetAllProducts()
        {
            _logger.LogInformation("Get all products was called!");

            return this._ticketRepository.GetAll().ToList();

        }

        public Ticket GetDetailsForProduct(Guid? id)
        {
            return _ticketRepository.Get(id);
        }

        public AddToShoppingCartDto GetShoppingCartInfo(Guid? id)
        {
            var ticket = this.GetDetailsForProduct(id);

            AddToShoppingCartDto model = new AddToShoppingCartDto
            {
                SelectedTicket = ticket,
                SelectedTicketId = ticket.Id,
                Quantity = 1
            };
            return model;
        }

        public void UpdeteExistingProduct(Ticket t)
        {
            this._ticketRepository.Update(t);
        }
    }
}
