using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Interfaces;
using Web.Models;

namespace Web.Services
{
    public class HomeViewModelService : IHomeViewModelService
    {
        private readonly IRepository<Product> _productRepository;

        public HomeViewModelService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<HomeViewModel> GetHomeViewModelAsync()
        {
            var list = (await _productRepository.ListAllAsync()).Select(p => new ProductViewModel() 
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                PictureUri = p.PictureUri,
                Price = p.Price
            }).ToList();

            var vm = new HomeViewModel()
            {
                Products = list
            };
            return vm;

        }
    }
}
