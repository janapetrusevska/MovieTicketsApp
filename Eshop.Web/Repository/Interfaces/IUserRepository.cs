using Eshop.Web.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Web.Data
{
    public interface IUserRepository
    {
        IEnumerable<EShopAppUser> GetAll();

        EShopAppUser Get(string id);

        void Insert(EShopAppUser entity);

        void Update(EShopAppUser entity);

        void Delete(EShopAppUser entity);
    }
}
