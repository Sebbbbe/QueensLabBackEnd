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
            var findSection = _shopDBContext.sections.FirstOrDefault(Sections => Sections.SectionID == deleteVisitorsFromASectionCommand.SectionID);
            _shopDBContext.Remove(_shopDBContext.visitors.Single(visitor => visitor.SectionID == deleteVisitorsFromASectionCommand.SectionID));
            findSection.VisitorAmount = 0;
            _shopDBContext.SaveChanges();


        }
    }
}
