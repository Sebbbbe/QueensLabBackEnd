using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace EvaluationAssignmentQueensLab.Controllers.Shops.Queries.VisitorsInShop
{
    [ApiController]
    [Route("api/[controller]")]

    public class ShowVisitorsInShop
    {
        private readonly ShopDBContext _shopDBContext;

        public ShowVisitorsInShop(ShopDBContext shopDBContext)
        {
            _shopDBContext = shopDBContext;
        }



        [HttpGet]

        public int ShowAllVisitorsInShop([FromQuery] ShowVisitorInShopCommand showVisitorInShopCommand)

        {

            var GetShop = _shopDBContext.Shops.FirstOrDefault(shop => shop.ShopName == showVisitorInShopCommand.ShopName);

            return _shopDBContext.visitors.Count(visitor => visitor.ShopID == GetShop.ShopID);


        }


    }
}
