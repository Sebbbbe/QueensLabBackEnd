using System;

namespace EvaluationAssignmentQueensLab.Controllers.Shops.Commands.EnterExitShop
{
    public class EnterShopCommand
    {
        public Guid VisitorID { get; set; }


        public string SectionName { get; set; }

        public string ShopName { get; set; }

    }
}
