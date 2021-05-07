using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EvaluationAssignmentQueensLab.Controllers.Sections.Commands.DeleteVisitors
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeleteVisitorsFromASection
    {
        private readonly ShopDBContext _shopDBContext;
        public DeleteVisitorsFromASection(ShopDBContext shopDBContext)
        {
            _shopDBContext = shopDBContext;
        }

        [HttpDelete]
        // nollställer en zone
        public void DeleteVisitorsInSection(DeleteVisitorsFromASectionCommand deleteVisitorsFromASectionCommand)
        {
            //   _shopDBContext.sections.Find(deleteVisitorsFromASectionCommand.SectionID);
            _shopDBContext.Remove(_shopDBContext.visitors.Single(visitor => visitor.SectionID == deleteVisitorsFromASectionCommand.SectionID));
            _shopDBContext.SaveChanges();


        }
    }
}
