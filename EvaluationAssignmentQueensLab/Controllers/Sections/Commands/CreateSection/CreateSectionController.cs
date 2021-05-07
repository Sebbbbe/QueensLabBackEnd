using EvaluationAssignmentQueensLab.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EvaluationAssignmentQueensLab.Controllers.Sections.Commands.CreateSection
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreateSectionController
    {
        private readonly ShopDBContext _shopDBContext;
        public CreateSectionController(ShopDBContext shopDBContext)
        {
            _shopDBContext = shopDBContext;
        }

        [HttpPost]

        public void CreateSection(CreateSectionCommand createSectionCommand)
        {
            var addASection = new Section()
            {
                ShopID = createSectionCommand.ShopID,
                SectionName = createSectionCommand.SectionName,
                SectionID = new Guid(),
                VisitorAmount = 0

            };


            _shopDBContext.sections.Add(addASection);
            _shopDBContext.SaveChanges();
        }

    }
}
