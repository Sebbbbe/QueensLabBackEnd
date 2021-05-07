using EvaluationAssignmentQueensLab.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace EvaluationAssignmentQueensLab.Controllers.Shops.Commands.EnterExitShop
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExitShopController : ControllerBase

    {
        private readonly ShopDBContext _shopDBContext;

        public ExitShopController(ShopDBContext shopDBContext)
        {
            _shopDBContext = shopDBContext;
        }

        [HttpPut]

        public void ExitShop(ExitShopCommand exitShopCommand)
        {

            var findVisitor = _shopDBContext.visitors.Find(exitShopCommand.VisitorID);

            var lowerVisitorAmount = _shopDBContext.sections.FirstOrDefault(section => section.SectionID == findVisitor.SectionID);

            findVisitor.ShopID = null;
            findVisitor.SectionID = null;
            findVisitor.VisitorEntered = DateTime.Now;



            lowerVisitorAmount.VisitorAmount -= 1;

            var enterExit = new EnterExit()
            {
                VisitorID = findVisitor.VisitorID,
                Status = "Exit",
                EnterExitID = new Guid(),
                Time = DateTime.Now

            };

            _shopDBContext.Update(findVisitor);
            _shopDBContext.Update(lowerVisitorAmount);

            _shopDBContext.Update(enterExit);
            _shopDBContext.SaveChanges();

        }
    }
}
