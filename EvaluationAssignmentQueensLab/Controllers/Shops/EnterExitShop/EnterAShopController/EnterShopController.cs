using EvaluationAssignmentQueensLab.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace EvaluationAssignmentQueensLab.Controllers.Shops.Commands.EnterExitShop
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnterShopController : ControllerBase
    {



        private readonly ShopDBContext _shopDBContext;

        public EnterShopController(ShopDBContext shopDBContext)
        {
            _shopDBContext = shopDBContext;
        }


        [HttpPut]

        public void EnterShop(EnterShopCommand enterShopCommand)
        {

            var findVisitor = _shopDBContext.visitors.Find(enterShopCommand.VisitorID);
            var getShop = _shopDBContext.Shops.FirstOrDefault(shop => shop.ShopName == enterShopCommand.ShopName);
            var getSection = _shopDBContext.sections.FirstOrDefault(section => section.SectionName == enterShopCommand.SectionName);

            findVisitor.ShopID = getShop.ShopID;
            findVisitor.SectionID = getSection.SectionID;



            //  findVisitor.ShopID = enterShopCommand.ShopID;
            //  findVisitor.SectionID = enterShopCommand.SectionID;
            findVisitor.VisitorEntered = DateTime.Now;


            var addVisitorAmount = _shopDBContext.sections.Find(getSection.SectionID);



            addVisitorAmount.VisitorAmount = addVisitorAmount.VisitorAmount + 1;


            var enterExit = new EnterExit()
            {
                VisitorID = findVisitor.VisitorID,
                Status = "Entered",
                EnterExitID = new Guid(),
                Time = DateTime.Now


            };


            _shopDBContext.Update(findVisitor);
            _shopDBContext.Update(addVisitorAmount);
            _shopDBContext.Update(enterExit);


            _shopDBContext.SaveChanges();
        }
    }
}