using EvaluationAssignmentQueensLab.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EvaluationAssignmentQueensLab.Controllers.Shops.Commands.CreateShop
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreateShopController : ControllerBase
    {
        private readonly ShopDBContext _shopDBContext;

        public CreateShopController(ShopDBContext shopDBContext)
        {
            _shopDBContext = shopDBContext;
        }

        [HttpPost]
        public void CreateShop(CreateShopCommand createShopCommand)
        {

            var addAShop = new Shop()
            {
                ShopName = createShopCommand.ShopName,
                ShopID = new Guid()
            };

            _shopDBContext.Shops.Add(addAShop);
            _shopDBContext.SaveChanges();

        }
    }
}
