using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EvaluationAssignmentQueensLab.Controllers.Sections.Queries.VisitorCountQuery
{
    [ApiController]
    [Route("api/[controller]")]
    public class VisitorCountInSectionQuery
    {



        private readonly ShopDBContext _shopDBContext;
        public VisitorCountInSectionQuery(ShopDBContext shopDBContext)
        {
            _shopDBContext = shopDBContext;
        }
        [HttpGet]


        public int VisitorCountInSection([FromQuery] VisitorCountInSectionCommand getVisitorCountInSectionCommand)
        {

            var count = _shopDBContext.visitors.Count(visitor => visitor.SectionID == getVisitorCountInSectionCommand.SectionID);

            return count;

        }
    }
}
