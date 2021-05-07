using EvaluationAssignmentQueensLab.Controllers.Sections.Queries.VisitorsInSections;
using EvaluationAssignmentQueensLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EvaluationAssignmentQueensLab.Controllers.Sections.Queries.VisitorsInSection
{
    [ApiController]
    [Route("api/[controller]")]
    public class GetVisitorsInASection : ControllerBase
    {

        private readonly ShopDBContext _shopDBContext;
        public GetVisitorsInASection(ShopDBContext shopDBContext)
        {
            _shopDBContext = shopDBContext;


        }
        [HttpGet]

        public List<Section> GetVisitorsInOneSection([FromQuery] GetVisitorsInASectionCommand visitorsInSectionListCommand)
        {




            return _shopDBContext.sections.Include(section => section.Visitors).Where(section => section.SectionID == visitorsInSectionListCommand.SectionID).ToList();



        }
    }
}
