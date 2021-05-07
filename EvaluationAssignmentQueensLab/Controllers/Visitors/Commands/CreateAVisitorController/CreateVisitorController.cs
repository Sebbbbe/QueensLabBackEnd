using EvaluationAssignmentQueensLab.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EvaluationAssignmentQueensLab.Controllers.Visitors.Commands.CreateAVisitorController
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreateVisitorController
    {
        private readonly ShopDBContext _shopDBContext;
        public CreateVisitorController(ShopDBContext shopDBContext)
        {
            _shopDBContext = shopDBContext;
        }


        [HttpPost]
        public void CreateVisitor(CreateVisitorCommand createVisitorCommand)
        {
            var addAVisitor = new Visitor()
            {
                VisitorName = createVisitorCommand.VisitorName,
                VisitorID = new Guid()
            };

            _shopDBContext.visitors.Add(addAVisitor);
            _shopDBContext.SaveChanges();

        }
    }

}