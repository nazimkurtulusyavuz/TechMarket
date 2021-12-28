using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Interfaces
{
    public interface IBasketViewModelService
    {
        Task<Basket> GetBasketAsync();
        Task<Basket> AddBasketItemAsync(int productId, int quantity = 1);
        Task<int> BasketItemsCountAsync();
    }
}
