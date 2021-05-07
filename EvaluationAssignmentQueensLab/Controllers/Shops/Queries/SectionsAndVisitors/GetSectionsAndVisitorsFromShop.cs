using EvaluationAssignmentQueensLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace EvaluationAssignmentQueensLab.Controllers.Shops.Queries.SectionsAndVisitors
{
    [ApiController]
    [Route("api/[controller]")]

    public class GetSectionsAndVisitorsFromShop
    {
        private readonly ShopDBContext _shopDBContext;

        public GetSectionsAndVisitorsFromShop(ShopDBContext shopDBContext)
        {
            _shopDBContext = shopDBContext;
        }



        [HttpGet]

        public List<Shop> GetSectionsAndVisitors([FromQuery] GetSectionsAndVisitorsFromShopCommand getSectionsAndVisitorsCommand)

        {

            var GetShopByName =
               _shopDBContext.Shops.Include(shop => shop.Sections)
              .Where(shop => shop.ShopName == getSectionsAndVisitorsCommand.ShopName).ToList();

            return GetShopByName;

        }


    }
}
