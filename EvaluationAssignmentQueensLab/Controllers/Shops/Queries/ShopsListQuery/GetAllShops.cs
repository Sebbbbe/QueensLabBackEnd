using EvaluationAssignmentQueensLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EvaluationAssignmentQueensLab.Controllers.Shops.Queries.ShopsListQuery
{
    [ApiController]
    [Route("api/[controller]")]
    public class GetAllShops : ControllerBase
    {


        private readonly ShopDBContext _shopDBContext;

        public GetAllShops(ShopDBContext shopDBContext)
        {
            _shopDBContext = shopDBContext;
        }

        [HttpGet]
        public List<Shop> ShowAllShops()
        {
            return _shopDBContext.Shops.Include(shop => shop.Sections).ToList();

        }
    }
}
